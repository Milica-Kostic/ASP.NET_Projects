using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookingApp.Hubs;
using BookingApp.Models;
using BookingApp.ViewModels;


namespace BookingApp.Controllers
{
    [Authorize]
    public class BookingsController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //GET
        public ActionResult Index()
        {
            return View();
        }

        //GET DATA
        public ActionResult GetBookingData()
        {
            var bookings = _context.Bookings.Include(b => b.Consumer).Include(b => b.Stay);
            return PartialView("_BookingsData", bookings.ToList());
        }

        //DETAILS
        public ActionResult Details(int? id, int? id2, int? id3)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var booking = _context.Bookings.Find(id);

            var viewModel = new BookingsViewModel
            {
                Booking = booking,
                Stay = _context.Stays.Find(id2),
                Consumer = _context.Consumers.Find(id3),
                Cities = _context.Cities.ToList(),
                Countries = _context.Countries.ToList(),
                PropertyTypes = _context.PropertyTypes.ToList()
            };

            if (booking == null)
            {
                return HttpNotFound();
            }

            return View("Details", viewModel);
        }

        //CREATE
        public ActionResult CreateBooking()
        {
            ViewBag.ConsumerId = new SelectList(_context.Consumers, "Id", "Name");
            ViewBag.StayId = new SelectList(_context.Stays, "Id", "StayName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBooking([Bind(Include = "Id,ConsumerId,StayId,CheckIn,CheckOut")] Booking booking)
        {
            var checkIn = _context.Bookings.Any(b => b.CheckIn == booking.CheckIn);
            var checkOut = _context.Bookings.Any(b => b.CheckOut == booking.CheckOut);
            var stayDb = _context.Bookings.Any(b => b.StayId == booking.StayId);

            if (checkIn == true && stayDb == true)
            {
                ModelState.AddModelError("CheckIn", "Datum je vec rezervisan");
                ViewBag.ConsumerId = new SelectList(_context.Consumers, "Id", "Name", booking.ConsumerId);
                ViewBag.StayId = new SelectList(_context.Stays, "Id", "StayName", booking.StayId);
                
                return View(booking);
            }

            if (checkOut == true && stayDb == true)
            {
                ModelState.AddModelError("CheckOut", "Datum je vec rezervisan");
                ViewBag.ConsumerId = new SelectList(_context.Consumers, "Id", "Name", booking.ConsumerId);
                ViewBag.StayId = new SelectList(_context.Stays, "Id", "StayName", booking.StayId);

                return View(booking);
            }

            if (booking.CheckIn < DateTime.Today)
            {
                ModelState.AddModelError("CheckIn", "Datum mora biti veci od danasnjeg.");
            }

            if (booking.CheckOut < booking.CheckIn)
            {
                ModelState.AddModelError("CheckOut", "CheckOut mora biti veci od CheckIn-a");
            }

            if (ModelState.IsValid)
            {
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                BookingHub.RefreshBookings(booking);
                return RedirectToAction("Index");
            }
            
            ViewBag.ConsumerId = new SelectList(_context.Consumers, "Id", "Name", booking.ConsumerId);
            ViewBag.StayId = new SelectList(_context.Stays, "Id", "StayName", booking.StayId);
            
            return View(booking);
        }

        //EDIT
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = _context.Bookings.Find(id);

            if (booking == null)
            {
                return HttpNotFound();
            }

            ViewBag.ConsumerId = new SelectList(_context.Consumers, "Id", "Name", booking.ConsumerId);
            ViewBag.StayId = new SelectList(_context.Stays, "Id", "StayName", booking.StayId);
            
            return View(booking);
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Booking booking, int id)
        {
            if (booking.CheckIn < DateTime.Today)
            {
                ModelState.AddModelError("CheckIn", "Datum mora biti veci od danasnjeg.");
            }

            if (booking.CheckOut < booking.CheckIn)
            {
                ModelState.AddModelError("CheckOut", "CheckOut mora biti veci od CheckIn-a");
            }

            if (ModelState.IsValid)
            {
                _context.Entry(booking).State = EntityState.Modified;
                _context.SaveChanges();
                BookingHub.RefreshBookings(booking);
                return RedirectToAction("Index");
            }
            
            ViewBag.ConsumerId = new SelectList(_context.Consumers, "Id", "Name", booking.ConsumerId);
            ViewBag.StayId = new SelectList(_context.Stays, "Id", "StayName", booking.StayId);
            
            return View(booking);
            
        }

        //DELETE
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Booking booking = _context.Bookings.Find(id);
            
            if (booking == null)
            {
                return HttpNotFound();
            }
            
            return View(booking);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Booking booking = _context.Bookings.Find(id);
            _context.Bookings.Remove(booking);
            _context.SaveChanges();
            BookingHub.RefreshBookings(booking);

            return RedirectToAction("Index");
        } 
    }
}
