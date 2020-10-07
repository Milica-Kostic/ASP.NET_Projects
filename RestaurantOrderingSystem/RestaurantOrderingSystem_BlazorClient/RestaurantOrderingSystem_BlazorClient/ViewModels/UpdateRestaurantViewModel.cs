using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem_BlazorClient.ViewModels
{
    public class UpdateRestaurantViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "You need to keep the name a max of 20 characters")]
        [MinLength(3, ErrorMessage = "You need to enter at least 3 characters for an restaurant name")]
        [DisplayName("Name of Restaurant")]
        public string RestName { get; set; }

        [DisplayName("Description of Restaurant")]
        public string RestDescription { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "You need to keep the name a max of 30 characters")]
        public string  City { get; set; }
    }
}
