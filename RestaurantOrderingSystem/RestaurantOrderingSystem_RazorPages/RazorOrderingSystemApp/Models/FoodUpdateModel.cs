using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorOrderingSystemApp.Models
{
    public class FoodUpdateModel
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string FoodDescription { get; set; }
        public decimal Price { get; set; }
    }
}
