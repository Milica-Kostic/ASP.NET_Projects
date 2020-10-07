using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace RazorOrderingSystemApp.Pages.Restaurants
{
    public class DeleteRestaurantModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public RestaurantModel Restaurant { get; set; }

        public DeleteRestaurantModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        public async Task OnGet()
        {
            Restaurant = await _restaurantData.GetRestaurantById(Id);
        }
        public async Task<IActionResult> OnPost()
        {
            await _restaurantData.DeleteRestaurant(Id);

            return RedirectToPage("./ListRestaurants");
        }
    }
}
