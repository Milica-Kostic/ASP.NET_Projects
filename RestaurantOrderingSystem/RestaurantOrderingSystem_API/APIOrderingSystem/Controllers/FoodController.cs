using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIOrderingSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace APIOrderingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IRestaurantData _restaurantData;
        private readonly IFoodData _foodData;

        public FoodController(IRestaurantData restaurantData, IFoodData foodData)
        {
            _restaurantData = restaurantData;
            _foodData = foodData;
        }

        [HttpPost]
        [ValidateModel]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(FoodModel food)
        {
            //var restaurants = await _restaurantData.GetRestaurants();
            int id = await _foodData.CreateFood(food);

            return Ok(new { Id = id });
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<List<FoodModel>> Get()
        {
            return await _foodData.GetFood();

        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var food = await _foodData.GetFoodById(id);

            if (food != null)
            {
                var restaurants = await _restaurantData.GetRestaurants();

                var output = new
                {
                    Food = food,
                    ItemPurchased = restaurants.Where(x => x.Id == food.RestaurantId).FirstOrDefault()?.RestName
                };
                return Ok(output);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put([FromBody] FoodUpdateModel data)
        {
            await _foodData.UpdateFood(data.Id, data.FoodName, data.FoodDescription, data.Price);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            await _foodData.DeleteFood(id);

            return Ok();
        }
    }
}

