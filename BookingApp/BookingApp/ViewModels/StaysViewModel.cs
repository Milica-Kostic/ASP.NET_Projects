using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingApp.ViewModels
{
    public class StaysViewModel
    {
        public Stay Stays { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<PropertyType> PropertyTypes { get; set; }
    }
}