using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class Consumer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Unesite ime")]
        [StringLength(128)]
        [Display(Name = "Ime")]
        public string Name { get; set; }

        [Display(Name = "Prezime")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Unesite telefon")]
        [Display(Name = "Broj telefona")]
        public string Phone { get; set; }


        public virtual ICollection<Booking> Bookings { get; set; }
    }
}