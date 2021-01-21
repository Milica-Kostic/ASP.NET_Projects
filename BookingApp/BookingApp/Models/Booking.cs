using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public Consumer Consumer { get; set; }

        [Required(ErrorMessage = "Izaberite na cije ime ce glasiti rezervacija")]
        public int ConsumerId { get; set; }

        public Stay Stay { get; set; }

        [Required(ErrorMessage = "Izaberite smestaj")]
        public int StayId { get; set; }

        [Required]
        public DateTime CheckIn { get; set; }

        [Required]
        public DateTime CheckOut { get; set; }

    }
}