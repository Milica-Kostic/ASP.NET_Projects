using RestaurantDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOrderingSystemApp.Models.Orders
{
    public class DisplayOrderModel
    {
        public OrderModel Order { get; set; }
        public string ItemPurchased { get; set; }
    }
}
