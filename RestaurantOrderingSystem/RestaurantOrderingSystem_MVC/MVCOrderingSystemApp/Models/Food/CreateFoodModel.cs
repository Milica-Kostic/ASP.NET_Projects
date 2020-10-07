using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOrderingSystemApp.Models.Food
{
    public class CreateFoodModel
    {
        public FoodModel Food { get; set; }
        public List<SelectListItem> RestItems { get; set; } = new List<SelectListItem>();
    }
}
