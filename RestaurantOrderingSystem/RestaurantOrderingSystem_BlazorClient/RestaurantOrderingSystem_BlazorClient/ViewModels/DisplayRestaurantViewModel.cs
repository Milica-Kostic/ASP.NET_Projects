using RestaurantOrderingSystem_BlazorClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem_BlazorClient.ViewModels
{
    public class DisplayRestaurantViewModel
    {
        public RestaurantModel Restaurant { get; set; }
        public string ItemPurchased { get; set; }
    }
}
