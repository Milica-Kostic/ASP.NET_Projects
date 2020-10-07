using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCOrderingSystemApp.Models.Restaurants;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace MVCOrderingSystemApp.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantData _restaurantData;
        private readonly ICategoryData _categoryData;

        public RestaurantsController(IRestaurantData restaurantData, ICategoryData categoryData)
        {
            _restaurantData = restaurantData;
            _categoryData = categoryData;
        }
        public async Task<IActionResult> Index()
        {
            var restaurants = await _restaurantData.GetRestaurants();
            return View(restaurants);
        }
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryData.GetCategories();

            CreateRestaurantModel model = new CreateRestaurantModel();

            categories.ForEach(x =>
            {
                model.CategoryItems.Add(new SelectListItem { Value = x.Id.ToString(), Text = x.CategoryName });
            });

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(RestaurantModel restaurant)
        {
            if (ModelState.IsValid == false)
            {
                return View();
            }

            var id = await _restaurantData.CreateRestaurant(restaurant);
            return RedirectToAction("Display", new { id });
        }

        public async Task<IActionResult> Display(int id)
        {
            DisplayRestaurantViewModel displayRestaurant = new DisplayRestaurantViewModel();
            displayRestaurant.Restaurant = await _restaurantData.GetRestaurantById(id);

            if (displayRestaurant.Restaurant != null)
            {
                var category = await _categoryData.GetCategories();
                displayRestaurant.ItemPurchased = category.Where(f => f.Id == displayRestaurant.Restaurant.CategoryId).FirstOrDefault()?.CategoryName;
            }

            return View(displayRestaurant);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, string restName, string city, string restDesc)
        {

            await _restaurantData.UpdateRestaurant(id, restName, city, restDesc);

            return RedirectToAction("Display", new { id });
        }
        public async Task<IActionResult> Delete(int id)
        {
            var restaurant = await _restaurantData.GetRestaurantById(id);
            return View(restaurant);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(RestaurantModel restaurantModel)
        {
            await _restaurantData.DeleteRestaurant(restaurantModel.Id);

            return RedirectToAction("Index");
        }
    }

    
}
