using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Unesite naziv drzave")]
        [StringLength(128)]
        [Display(Name = "Naziv drzave")]
        public string  CountryName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}