using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class Booking
    {
        public Consumer Consumer { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ConsumerId { get; set; }

        public Stay Stay { get; set; }

        [Key]
        [Column(Order = 2)]
        public int StayId { get; set; }

        [Required]
        public DateTime CheckIn { get; set; }

        [Required]
        public DateTime CheckOut { get; set; }



    }
}