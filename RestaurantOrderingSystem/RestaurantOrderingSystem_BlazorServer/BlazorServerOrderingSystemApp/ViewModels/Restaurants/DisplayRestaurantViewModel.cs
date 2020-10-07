using BlazorServerOrderingSystemApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerOrderingSystemApp.ViewModels.Restaurants
{
    public class DisplayRestaurantViewModel
    {
        public RestaurantModel Restaurant { get; set; }
        public string ItemPurchased { get; set; }
    }
}
