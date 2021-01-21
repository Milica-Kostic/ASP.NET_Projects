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
using System.Data.SqlClient;
using System.Configuration;

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

        //CREATE: view
        public ActionResult CreateStay()
        {
            var types = _context.PropertyTypes.ToList();

            var cities = _context.Cities.ToList();

            var viewModel = new StaysViewModel
            {
                Stays = new Stay(),
                Cities = cities,
                PropertyTypes = types,
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
                    PropertyTypes = _context.PropertyTypes.ToList()
                };
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
                staysInDb.PropertyTypeId = vm.Stays.PropertyTypeId;
                staysInDb.Description = vm.Stays.Description;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Stays");
        }

        //FILL SELECT LIST WITH JSON
        public JsonResult CountryList(int Id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT cou.Id, cou.CountryName FROM Cities AS c INNER JOIN Countries AS cou ON c.CountryId = cou.Id WHERE c.Id = '" + Id + "'";

            SqlCommand cm = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader dataReader = cm.ExecuteReader();

            List<SelectListItem> list = new List<SelectListItem>();

            while (dataReader.Read())
            {
                list.Add(new SelectListItem { Text = dataReader[1].ToString(), Value = dataReader[0].ToString() });
            }

            connection.Close();

            return Json(list, JsonRequestBehavior.AllowGet);
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
                .Include(s => s.PropertyType)
                .Include(s => s.City.Country)
                .SingleOrDefault(c => c.Id == id);

            if (stay == null)
            {
                return HttpNotFound();
            }

            return View(stay);
        }
    }
}