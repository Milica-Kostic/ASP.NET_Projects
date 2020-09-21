using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
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
            var bookings = _context.Bookings.Include(b => b.Consumer).Include(b => b.Stay);
            
            if (!User.Identity.IsAuthenticated)
            {
                return View("IndexNotAuthorized", bookings.ToList());
            }
            if (User.IsInRole("Admin"))
            {
                return View("Index", bookings.ToList());
            }
            return View("IndexUser", bookings.ToList());
        }

        //DETAILS
        public ActionResult Details(int? id, int? id2 )
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var booking = _context.Bookings.Find(id, id2);
            var viewModel = new BookingsViewModel
            {
                Booking = booking,
                Consumer = _context.Consumers.Find(id),
                Stay = _context.Stays.Find(id2),
                City = _context.Cities.ToList(),
                Country = _context.Countries.ToList(),
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
        public ActionResult CreateBooking([Bind(Include = "ConsumerId,StayId,CheckIn,CheckOut")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ConsumerId = new SelectList(_context.Consumers, "Id", "Name", booking.ConsumerId);
            ViewBag.StayId = new SelectList(_context.Stays, "Id", "StayName", booking.StayId);
            return View(booking);
        }

        //EDIT
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id, int? id2)
        {
            
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Booking booking = _context.Bookings.Find(id, id2);

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
        public ActionResult Edit([Bind(Include = "ConsumerId,StayId,CheckIn,CheckOut")] Booking booking)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", "Bookings");
            }
            if (ModelState.IsValid)
            {
                _context.Entry(booking).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ConsumerId = new SelectList(_context.Consumers, "Id", "Name", booking.ConsumerId);
            ViewBag.StayId = new SelectList(_context.Stays, "Id", "StayName", booking.StayId);
            return View(booking);
            
        }

        //DELETE
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id, int? id2)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = _context.Bookings.Find(id, id2);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id, int id2)
        {
            Booking booking = _context.Bookings.Find(id, id2);
            _context.Bookings.Remove(booking);
            _context.SaveChanges();
            return RedirectToAction("Index");
        } 
    }
}
