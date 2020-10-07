using BlazorServerOrderingSystemApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerOrderingSystemApp.ViewModels.Orders
{
    public class DisplayOrderViewModel
    {
        public OrderModel Order { get; set; }
        public string ItemPurchased { get; set; }
    }
}
