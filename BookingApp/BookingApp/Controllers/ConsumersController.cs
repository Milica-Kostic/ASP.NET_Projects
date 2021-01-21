using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace BookingApp.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ConsumersController : Controller
    {
        private ApplicationDbContext _context;

        public ConsumersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET
        public ActionResult Index(string sortBy, string search, string currentFilter, int? page)
        {
            ViewBag.CurrentSort = sortBy;
            ViewBag.NameSortParam = String.IsNullOrEmpty(sortBy) ? "Name desc" : "";
            ViewBag.PhoneSortParam = sortBy == "Phone" ? "phone_desc" : "Phone";
            
            var consumers = _context.Consumers.AsQueryable();

            if (search != null)
            {
                page = 1;
            }
            else
            {
                search = currentFilter;
            }

            ViewBag.CurrentFilter = search;

            if (!String.IsNullOrEmpty(search))
            {
                consumers = consumers.Where(s => s.Name.Contains(search) || s.LastName.Contains(search));
            }

            switch (sortBy)
            {
                case "Name desc":
                    consumers = consumers.OrderByDescending(s => s.Name);
                    break;
                case "Phone":
                    consumers = consumers.OrderBy(s => s.Phone);
                break;
                case "phone_desc":
                    consumers = consumers.OrderByDescending(s => s.Phone);
                break;
                default:
                    consumers = consumers.OrderBy(s => s.Name);
                    break;
            }

            int pageSize = 10;
            int pageNumer = (page ?? 1);
            
            return View(consumers.ToPagedList(pageNumer, pageSize));
        }

        //CREATE
        public ViewResult CreateConsumer()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateConsumer(Consumer consumer)
        {

            if (consumer.Id == 0)
            {
                _context.Consumers.Add(consumer);
            }
            else
            {
                var consumerInDb = _context.Consumers.Single(c => c.Id == consumer.Id);
                consumerInDb.Name = consumer.Name;
                consumerInDb.Phone = consumer.Phone;
                consumerInDb.LastName = consumer.LastName;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Consumers");
        }
        
        //EDIT VIEW
        public ActionResult Edit(int id)
        {
            Consumer consumer = _context.Consumers.Find(id);
            if (consumer == null)
            {
                return HttpNotFound();
            }

            return View("CreateConsumer", consumer);
        }

        //DELETE
        public ActionResult DeleteConsumer(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Ne mozete obrisati ovog Usera. Proverite da li imate dozvolu za brisanje";
            }
            Consumer consumer = _context.Consumers.Find(id);
            if (consumer == null)
            {
                return HttpNotFound();
            }

            return View(consumer);
        }

        //DELETE
        [HttpPost]
        public ActionResult DeleteConsumer(int id)
        {
            try
            {
                Consumer consumer = _context.Consumers.Find(id);
                _context.Consumers.Remove(consumer);
                _context.SaveChanges();
            }
            catch
            {
                return RedirectToAction("DeleteConsumer", new {saveChangesError = true });
            }

            return RedirectToAction("Index", "Consumers");
        }

        //DETAILS
        public ActionResult ConsumerProfile(int id)
        {
            Consumer consumer = _context.Consumers.Find(id);

            if (consumer == null)
                return HttpNotFound();

            return View(consumer);
        }
    }
}