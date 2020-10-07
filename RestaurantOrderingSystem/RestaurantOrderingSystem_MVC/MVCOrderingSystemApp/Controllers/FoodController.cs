using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCOrderingSystemApp.Models.Food;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace MVCOrderingSystemApp.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodData _foodData;
        private readonly IRestaurantData _restaurantData;

        public FoodController(IFoodData foodData, IRestaurantData restaurantData)
        {
            _foodData = foodData;
            _restaurantData = restaurantData;
        }
        public async Task<IActionResult> Index()
        {
            var food = await _foodData.GetFood();
            return View(food);
        }
        public async Task<IActionResult> Create()
        {
            var restaurants = await _restaurantData.GetRestaurants();

            CreateFoodModel model = new CreateFoodModel();

            restaurants.ForEach(x =>
            {
                model.RestItems.Add(new SelectListItem { Value = x.Id.ToString(), Text = x.RestName });
            });

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(FoodModel food)
        {
            if(ModelState.IsValid == false)
            {
                return View();
            }

            var id = await _foodData.CreateFood(food);
            return RedirectToAction("Display", new { id });
        }
        public async Task<IActionResult> Display(int id)
        {
            DisplayFoodModel displayFood = new DisplayFoodModel();
            displayFood.Food = await _foodData.GetFoodById(id);

            if (displayFood.Food != null)
            {
                var restaurant = await _restaurantData.GetRestaurants();
                displayFood.ItemPurchased = restaurant.Where(f => f.Id == displayFood.Food.RestaurantId).FirstOrDefault()?.RestName;
            }

            return View(displayFood);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, string foodName, string foodDesc, decimal price)
        {

            await _foodData.UpdateFood(id, foodName, foodDesc, price);

            return RedirectToAction("Display", new { id });
        }
        public async Task<IActionResult> Delete(int id)
        {
            var food = await _foodData.GetFoodById(id);
            return View(food);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(FoodModel foodModel)
        {
            await _foodData.DeleteFood(foodModel.Id);

            return RedirectToAction("Index");
        }
    }

}
