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
    public class RestaurantsController : ControllerBase
    {
        private readonly ICategoryData _categoryData;
        private readonly IRestaurantData _restaurantData;

        public RestaurantsController(ICategoryData categoryData, IRestaurantData restaurantData)
        {
            _categoryData = categoryData;
            _restaurantData = restaurantData;
        }

        [HttpPost]
        [ValidateModel]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(RestaurantModel restaurant)
        {
            //var categories = await _categoryData.GetCategories();
            int id = await _restaurantData.CreateRestaurant(restaurant);

            return Ok(new { Id = id });
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<List<RestaurantModel>> Get()
        {
            return await _restaurantData.GetRestaurants();

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

            var restaurant = await _restaurantData.GetRestaurantById(id);

            if (restaurant != null)
            {
                var categories = await _categoryData.GetCategories();

                var output = new
                {
                    Restaurant = restaurant,
                    ItemPurchased = categories.Where(x => x.Id == restaurant.CategoryId).FirstOrDefault()?.CategoryName
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
        public async Task<IActionResult> Put([FromBody] RestaurantUpdateModel data)
        {
            await _restaurantData.UpdateRestaurant(data.Id, data.RestName, data.City, data.RestDescription);
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            await _restaurantData.DeleteRestaurant(id);

            return Ok();
        }
    }
}
