using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace RazorOrderingSystemApp.Pages.Food
{
    public class CreateFoodModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        private readonly IFoodData _foodData;

        public List<SelectListItem> RestaurantItems { get; set; }

        [BindProperty]
        public FoodModel Food { get; set; }
        public CreateFoodModel(IRestaurantData restaurantData, IFoodData foodData)
        {
            _restaurantData = restaurantData;
            _foodData = foodData;
        }
        public async Task OnGet()
        {
            var restaurant = await _restaurantData.GetRestaurants();

            RestaurantItems = new List<SelectListItem>();

            restaurant.ForEach(x =>
            {
                RestaurantItems.Add(new SelectListItem { Value = x.Id.ToString(), Text = x.RestName });
            });
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            int id = await _foodData.CreateFood(Food);

            return RedirectToPage("./DisplayFood", new { Id = id });
        }
    }
}
