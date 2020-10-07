using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace APIOrderingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryData categoryData;

        public CategoriesController(ICategoryData categoryData)
        {
            this.categoryData = categoryData;
        }

        [HttpGet]
        public async Task<List<CategoryModel>> Get()
        {
            return await categoryData.GetCategories();
        }
    }
}
