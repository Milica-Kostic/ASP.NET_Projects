using RestaurantDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOrderingSystemApp.Models.Restaurants
{
    public class DisplayRestaurantViewModel
    {
        public RestaurantModel Restaurant { get; set; }
        public string ItemPurchased { get; set; }
    }
}
