using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BookingApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CitiesController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public CitiesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var city = _context.Cities.Include(c => c.Country);
            
            return View("Index", city.ToList());
        }

        public ActionResult CreateCity()
        {
            ViewBag.CountryId = new SelectList(_context.Countries, "Id", "CountryName");
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCity(City city)
        {
            if (ModelState.IsValid)
            {
                _context.Cities.Add(city);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CountryId = new SelectList(_context.Countries, "Id", "CountryName", city.CountryId);

            return View(city);
        }

        public ActionResult EditCity(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            City city = _context.Cities.Find(id);

            var cityInDb = _context.Cities.Single(c => c.Id == city.Id);
            cityInDb.CityName = city.CityName;
            cityInDb.CountryId = city.CountryId;

            if (city == null)
            {
                return HttpNotFound();
            }

            ViewBag.CountryId = new SelectList(_context.Countries, "Id", "CountryName", city.CountryId);

            return View(city);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCity(City city)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(city).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.CountryId = new SelectList(_context.Countries, "Id", "CountryName", city.CountryId);
            
            return View(city);
        }

        public ActionResult DeleteCity(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            City city = _context.Cities.Find(id);

            if (city == null)
            {
                return HttpNotFound();
            }

            return View(city);
        }


        [HttpPost, ActionName("DeleteCity")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            City city = _context.Cities.Find(id);
            _context.Cities.Remove(city);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }


        public ActionResult CityInfo(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            City city = _context.Cities.Find(id);

            if (city == null)
            {
                return HttpNotFound();
            }
            return View(city);
        }
    }
}