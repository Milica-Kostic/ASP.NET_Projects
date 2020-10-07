using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOrderingSystemApp.Models.Restaurants
{
    public class CreateRestaurantModel
    {
        public RestaurantModel Restaurant { get; set; }
        public List<SelectListItem> CategoryItems { get; set; } = new List<SelectListItem>();
    }
}
