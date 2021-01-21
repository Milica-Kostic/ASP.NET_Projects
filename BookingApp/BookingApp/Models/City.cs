using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Unesite naziv grada")]
        [StringLength(128)]
        [Display(Name = "Naziv grada")]
        public string CityName { get; set; }

        public Country Country { get; set; }

        [Required(ErrorMessage = "Izaberite drzavu")]
        public int CountryId { get; set; }
    }
}