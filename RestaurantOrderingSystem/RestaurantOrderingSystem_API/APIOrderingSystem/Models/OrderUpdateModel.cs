using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIOrderingSystem.Models
{
    public class OrderUpdateModel
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public int FoodId { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
