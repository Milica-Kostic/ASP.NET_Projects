using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace RazorOrderingSystemApp.Pages.Restaurants
{
    public class CreateRestaurantModel : PageModel
    {
        private readonly ICategoryData _categoryData;
        private readonly IRestaurantData _restaurantData;

        public List<SelectListItem> CategoryItems { get; set; }

        [BindProperty]
        public RestaurantModel Restaurant { get; set; }
        public CreateRestaurantModel(ICategoryData categoryData, IRestaurantData restaurantData)
        {
            _categoryData = categoryData;
            _restaurantData = restaurantData;
        }
        public async Task OnGet()
        {
            var categories = await _categoryData.GetCategories();

            CategoryItems = new List<SelectListItem>();

            categories.ForEach(x =>
            {
                CategoryItems.Add(new SelectListItem { Value = x.Id.ToString(), Text = x.CategoryName });
            });
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }

            int id = await _restaurantData.CreateRestaurant(Restaurant);

            return RedirectToPage("./DisplayRestaurant", new { Id = id });
        }
    }
}
