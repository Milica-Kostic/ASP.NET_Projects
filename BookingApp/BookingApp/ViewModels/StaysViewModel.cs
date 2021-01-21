using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingApp.ViewModels
{
    public class StaysViewModel
    {
        public IEnumerable<PropertyType> PropertyTypes { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public Stay Stays { get; set; }
    }
}