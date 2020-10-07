using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorOrderingSystemApp.Models;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace RazorOrderingSystemApp.Pages.Restaurants
{
    public class DisplayRestaurantModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        private readonly ICategoryData _categoryData;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public RestaurantModel Restaurant { get; set; }
        public string CategoryPurchased { get; set; }

        [BindProperty]
        public RestaurantUpdateModel UpdateModel{ get; set; }

        public DisplayRestaurantModel(IRestaurantData restaurantData, ICategoryData categoryData) 
        {
            _restaurantData = restaurantData;
            _categoryData = categoryData;
        }
        public async Task<IActionResult> OnGet()
        {
            Restaurant = await _restaurantData.GetRestaurantById(Id);

            if(Restaurant != null)
            {
                var category = await _categoryData.GetCategories();

                CategoryPurchased = category.Where(x => x.Id == Restaurant.CategoryId).FirstOrDefault()?.CategoryName;
            }

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }

            await _restaurantData.UpdateRestaurant(UpdateModel.Id, UpdateModel.RestName,UpdateModel.City,UpdateModel.RestDescription);

            return RedirectToPage("./DisplayRestaurant", new { UpdateModel.Id });
        }
    }
}
