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
    public class PropertyTypesController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: PropertyTypes
        public ActionResult Index()
        {
            var types = _context.PropertyTypes;

            if (User.IsInRole("Admin"))
            {
                return View("Index", types.ToList());
            }

            return View("Index", "Bookings");
        }

        // CREATE: View
        public ViewResult CreatePropertyType()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePropertyType(PropertyType propertyType)
        {
            if (ModelState.IsValid)
            {
                _context.PropertyTypes.Add(propertyType);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(propertyType);
        }

        //EDIT
        public ActionResult EditPropertyType(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PropertyType propertyType = _context.PropertyTypes.Find(id);

            var propTypeInDb = _context.PropertyTypes.Single(c => c.Id == propertyType.Id);
            propTypeInDb.TypeName = propertyType.TypeName;

            if (propertyType == null)
            {
                return HttpNotFound();
            }

            return View(propertyType);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPropertyType(PropertyType propertyType)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", "PropertyTypes");
            }

            if(ModelState.IsValid)
            {
                _context.Entry(propertyType).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(propertyType);
        }


        //DELETE
        public ActionResult DeletePropertyType(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PropertyType propertyType = _context.PropertyTypes.Find(id);

            if(propertyType == null)
            {
                return HttpNotFound();
            }
            return View(propertyType);
        }


        [HttpPost, ActionName("DeletePropertyType")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            PropertyType propertyType = _context.PropertyTypes.Find(id);
            _context.PropertyTypes.Remove(propertyType);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult PropertyTypeInfo(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            PropertyType type = _context.PropertyTypes.Find(id);

            if (type == null)
            {
                return HttpNotFound();
            }
            return View(type);
        }
    }
}