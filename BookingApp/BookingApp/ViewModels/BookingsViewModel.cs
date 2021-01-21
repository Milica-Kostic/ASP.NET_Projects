using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingApp.ViewModels
{
    public class BookingsViewModel
    {
        public Consumer Consumer { get; set; }
        public Booking Booking { get; set; }
        public Stay Stay { get; set; }

        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<Country> Countries { get; set; }
        public IEnumerable<PropertyType> PropertyTypes { get; set; }
        public IEnumerable<Consumer> Consumers { get; set; }
        public IEnumerable<Stay> Stays { get; set; }
    }
}