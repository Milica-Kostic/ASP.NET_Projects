using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace RazorOrderingSystemApp.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly IFoodData _foodData;
        private readonly IOrderData _orderData;

        public List<SelectListItem> FoodItems { get; set; }

        [BindProperty]
        public OrderModel Order { get; set; }
        public CreateModel(IFoodData foodData, IOrderData orderData)
        {
           _foodData = foodData;
           _orderData = orderData;
        }
        public async Task OnGet()
        {
            var food = await _foodData.GetFood();

            FoodItems = new List<SelectListItem>();

            food.ForEach(x =>
            {
               FoodItems.Add(new SelectListItem { Value = x.Id.ToString(), Text = x.FoodName });
            });
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
           
            var food = await _foodData.GetFood();

            Order.Total = Order.Quantity * food.Where(x => x.Id == Order.FoodId).First().Price;

            int id = await _orderData.CreateOrder(Order);

            return RedirectToPage("./DisplayOrder", new { Id = id });
        }
    }
}
