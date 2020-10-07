using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorOrderingSystemApp.Models;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace RazorOrderingSystemApp.Pages.Food
{
    public class DisplayFoodModel : PageModel
    {
        private readonly IFoodData _foodData;
        private readonly IRestaurantData _restaurantData;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public FoodModel Food { get; set; }
        public string RestaurantPurchased { get; set; }

        [BindProperty]
        public FoodUpdateModel UpdateModel { get; set; }
        public DisplayFoodModel(IFoodData foodData, IRestaurantData restaurantData)
        {
            _foodData = foodData;
            _restaurantData = restaurantData;
        }
        public async Task<IActionResult> OnGet()
        {
            Food = await _foodData.GetFoodById(Id);

            if (Food != null)
            {
                var category = await _restaurantData.GetRestaurants();

                RestaurantPurchased = category.Where(x => x.Id == Food.RestaurantId).FirstOrDefault()?.RestName;
            }

            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            await _foodData.UpdateFood(UpdateModel.Id, UpdateModel.FoodName, UpdateModel.FoodDescription, UpdateModel.Price);

            return RedirectToPage("./DisplayFood", new { UpdateModel.Id });
        }
    }
}
