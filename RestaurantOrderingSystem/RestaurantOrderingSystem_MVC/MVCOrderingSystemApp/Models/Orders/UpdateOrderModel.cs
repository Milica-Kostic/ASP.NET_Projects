using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOrderingSystemApp.Models.Orders
{
    public class UpdateOrderModel
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        //public int FoodId { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
