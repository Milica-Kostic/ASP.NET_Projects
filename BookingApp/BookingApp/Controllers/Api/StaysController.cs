using AutoMapper;
using BookingApp.Dtos;
using BookingApp.Models;
using BookingApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookingApp.Controllers.Api
{
    public class StaysController : ApiController
    {
        private  ApplicationDbContext _context;
        public StaysController()
        {
            _context = new ApplicationDbContext();
        }

        // /api/stays
        public IHttpActionResult GetStays()
        {
            var staysDtos = _context.Stays
                               .Include(s => s.PropertyType)
                               .Include(c => c.City)
                               .ToList()
                               .Select(Mapper.Map<Stay, StayDto>);

            return Ok(staysDtos);
        }

        
      
        public IHttpActionResult StaysInfo(int id)
        {
            var stay = _context.Stays.Include(s => s.City)
               // .Include(s => s.Country)
                .Include(s => s.PropertyType)
                .SingleOrDefault(s => s.Id == id);

            if (stay == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Stay, StayDto>(stay));
        }

        [HttpPost]
        public IHttpActionResult CreateStay(StayDto stayDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var stay = Mapper.Map<StayDto, Stay>(stayDto);
            _context.Stays.Add(stay);
            _context.SaveChanges();

            stayDto.Id = stay.Id;
            return Created(new Uri(Request.RequestUri + "/" + stay.Id), stayDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateStay(int id, StayDto stayDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var staysInDb = _context.Stays.Find(id);

            if (staysInDb == null)
            {
                return NotFound();
            }

            Mapper.Map(stayDto, staysInDb);

            _context.SaveChanges();

            return Ok();
        }


        public IHttpActionResult DeleteStay(int id)
        {
            var staysInDb = _context.Stays.Find(id);

            if (staysInDb == null)
            {
                return NotFound();
            }

            _context.Stays.Remove(staysInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
