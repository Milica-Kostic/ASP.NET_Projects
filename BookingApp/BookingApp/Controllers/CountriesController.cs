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
    public class CountriesController : Controller
    {
        ApplicationDbContext _context = new ApplicationDbContext();

        public CountriesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Countries
        public ActionResult Index()
        {
            var countries = _context.Countries;

            if (User.IsInRole("Admin"))
            {
                return View("Index", countries.ToList());
            }

            return View("Index", "Bookings");
        }

        public ViewResult CreateCountry()
        {
            return View();
        }


        //CREATE: Country
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCountry(Country country)
        {
            var countryDb = _context.Countries.Any(c => c.CountryName == country.CountryName);

            if(countryDb == true)
            {
                ModelState.AddModelError("CountryName", "Zemlja vec postoji");
                return View("CreateCountry", country);
            }

            if (ModelState.IsValid)
            {
                if (country.Id == 0)
                {
                    _context.Countries.Add(country);
                }
                else
                {
                    var countryInDb = _context.Countries.FirstOrDefault(c => c.Id == country.Id);
                    countryInDb.CountryName = country.CountryName;
                }

                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Countries");
        }


        //EDIT: Country
        public ActionResult EditCountry(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Country country = _context.Countries.Find(id);

            if (country == null)
            {
                return HttpNotFound();
            }

            return View(country);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCountry([Bind(Include = "Id,CountryName")] Country country)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(country).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(country);
        }

        public ActionResult DeleteCountry(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Country country = _context.Countries.Find(id);

            var countryInDb = _context.Countries.FirstOrDefault(c => c.Id == country.Id);
            countryInDb.CountryName = country.CountryName;

            if (country == null)
            {
                return HttpNotFound();
            }

            return View(country);
        }

        [HttpPost, ActionName("DeleteCountry")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                Country country = _context.Countries.Find(id);
                _context.Countries.Remove(country);
                _context.SaveChanges();  
            }

            return RedirectToAction("Index");
        }

        public ActionResult CountryInfo(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Country country = _context.Countries.Find(id);

            if (country == null)
            {
                return HttpNotFound();
            }

            return View(country);
        }
    }
}