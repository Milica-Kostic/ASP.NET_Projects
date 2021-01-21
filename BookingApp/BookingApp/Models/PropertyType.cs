using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class PropertyType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Unesite naziv smestaja")]
        [StringLength(128)]
        [Display(Name = "Naziv smestaja")]
        public string TypeName { get; set; }
    }
}