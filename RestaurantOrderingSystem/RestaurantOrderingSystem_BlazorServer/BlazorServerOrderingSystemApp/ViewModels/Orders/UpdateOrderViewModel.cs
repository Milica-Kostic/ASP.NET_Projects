using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerOrderingSystemApp.ViewModels.Orders
{
    public class UpdateOrderViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "You need to keep the name a max of 20 characters")]
        [MinLength(3, ErrorMessage = "You need to enter at least 3 characters for an order name")]
        [DisplayName("Name for the order")]
        public string OrderName { get; set; }
        public int FoodId { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "You can select up to 20 meals")]
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
