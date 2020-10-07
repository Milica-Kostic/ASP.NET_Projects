using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RestaurantDataLibrary.Models
{
    public class RestaurantModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "You need to keep the name a max of 20 characters")]
        [MinLength(3, ErrorMessage = "You need to enter at least 3 characters for an restaurant name")]
        [DisplayName("Name of Restaurant")]
        public string RestName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "You need to keep the name a max of 30 characters")]
        public string City { get; set; }

        [DisplayName("Category of Restaurant")]
        public int CategoryId { get; set; }

        [DisplayName("Description of Restaurant")]
        public string RestDescription { get; set; }
    }
}
