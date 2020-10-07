using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace RazorOrderingSystemApp.Pages.Food
{
    public class DeleteFoodModel : PageModel
    {
        private readonly IFoodData _foodData;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public FoodModel Food { get; set; }
        public DeleteFoodModel(IFoodData foodData)
        {
            _foodData = foodData;
        }
        public async Task OnGet()
        {
            Food = await _foodData.GetFoodById(Id);
        }
        public async Task<IActionResult> OnPost()
        {
            await _foodData.DeleteFood(Id);

            return RedirectToPage("./ListFood");
        }
    }
}
