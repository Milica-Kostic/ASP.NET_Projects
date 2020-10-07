using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace RazorOrderingSystemApp.Pages.Restaurants
{
    public class ListRestaurantsModel : PageModel
    {
        private readonly IRestaurantData _restaurantData;
        public List<RestaurantModel> Restaurants { get; set; }

        public ListRestaurantsModel(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        public async Task OnGet()
        {
            Restaurants = await _restaurantData.GetRestaurants();
        }
    }
}
