using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace RazorOrderingSystemApp.Pages.Food
{
    public class ListFoodModel : PageModel
    {
        private readonly IFoodData _foodData;
        public List<FoodModel> Food { get; set; }

        public ListFoodModel(IFoodData foodData)
        {
            _foodData = foodData;
        }
        public async Task OnGet()
        {
           Food = await _foodData.GetFood();
        }
    }
    
}
