using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class Stay
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Unesite naziv smestaja")]
        [StringLength(128)]
        [Display(Name = "Naziv")]
        public string StayName { get; set; }

        [Required(ErrorMessage = "Unesite adresu")]
        [StringLength(128)]
        [Display(Name = "Adresa")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Unesite Cenu")]
        [Display(Name = "Cena")]
        public decimal Price { get; set; }

        public City City { get; set; }

        [Required(ErrorMessage = "Izaberite grad")]
        public int CityId { get; set; }

        public PropertyType PropertyType { get; set; }

        [Required(ErrorMessage = "Izaberite tip smestaja")]
        public int PropertyTypeId { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}