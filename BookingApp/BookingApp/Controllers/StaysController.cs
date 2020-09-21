using BookingApp.Models;
using BookingApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net.Http;

namespace BookingApp.Controllers
{
    [Authorize]
    public class StaysController : Controller
    {
        private ApplicationDbContext _context;
        public StaysController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET
        [AllowAnonymous]
        public ViewResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View("IndexNotAuthorized");
            }
            if (User.IsInRole("Admin"))
            {
                return View("Index");
            }
            else
            {
                return View("IndexUser");
            }
        }

        //CREATE
        public ActionResult CreateStay()
        {
            var cities = _context.Cities.ToList();
            var countries = _context.Countries.ToList();
            var types = _context.PropertyTypes.ToList();
            var viewModel = new StaysViewModel
            {
                Stays = new Stay(),
                Cities = cities,
                Countries = countries,
                PropertyTypes = types

            };
            return View(viewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateStay(StaysViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new StaysViewModel
                {
                    Stays = new Stay(),
                    Cities = _context.Cities.ToList(),
                    Countries = _context.Countries.ToList(),
                    PropertyTypes = _context.PropertyTypes.ToList()

                };

                return View(viewModel);
            }

            if (vm.Stays.Id == 0)
            {
                _context.Stays.Add(vm.Stays);
            }
            else
            {
                var staysInDb = _context.Stays.Single(c => c.Id == vm.Stays.Id);
                staysInDb.StayName = vm.Stays.StayName;
                staysInDb.Address = vm.Stays.Address;
                staysInDb.Price = vm.Stays.Price;
                staysInDb.CityId = vm.Stays.CityId;
                staysInDb.CountryId = vm.Stays.CountryId;
                staysInDb.PropertyTypeId = vm.Stays.PropertyTypeId;
                staysInDb.Description = vm.Stays.Description;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Stays");
        }

        //EDIT
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var stays = _context.Stays.Find(id);

            var viewModel = new StaysViewModel
            {
                Stays = stays,
                Cities = _context.Cities.ToList(),
                Countries = _context.Countries.ToList(),
                PropertyTypes = _context.PropertyTypes.ToList()
            };

            if (stays == null)
            {
                return HttpNotFound();
            }

            
            return View("CreateStay", viewModel);

        }
        
        //DELETE
        public ActionResult DeleteStay(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            var stays = _context.Stays.Find(id);

            if (stays == null)
            {
                return HttpNotFound();
            }
            return View(stays);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
               Stay stays = _context.Stays.Find(id);

                var viewModel = new StaysViewModel
                {
                    Stays = stays,
                    Cities = _context.Cities.ToList(),
                    Countries = _context.Countries.ToList(),
                    PropertyTypes = _context.PropertyTypes.ToList()
                };
                
                _context.Stays.Remove(stays);
                _context.SaveChanges();
            }
            catch
            {
                return RedirectToAction("DeleteStay", new { saveChangesError = true });
            }
            return RedirectToAction("Index", "Stays");
        }

        //DETAILS
        [AllowAnonymous]
        public ActionResult StaysInfo(int id)
        {
            Stay stay = _context.Stays.Include(s => s.City)
                .Include(s => s.Country)
                .Include(s => s.PropertyType)
                .SingleOrDefault(c => c.Id == id);

            if (stay == null)
                return HttpNotFound();
            //Stay stay = StaysInfo(id);
            return View(stay);
        }
        public ActionResult UpdateStay()
        {
            return View();
        }
    }
}