using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOrderingSystemApp.Models.Orders
{
    public class CreateOrderModel
    {
        public OrderModel Order { get; set; }
        public List<SelectListItem> FoodItems { get; set; } = new List<SelectListItem>();
    }
}
