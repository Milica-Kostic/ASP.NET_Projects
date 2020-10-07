using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorOrderingSystemApp.Models;
using RazorOrderingSystemApp.Pages.Food;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace RazorOrderingSystemApp.Pages.Orders
{
    public class DisplayOrderModel : PageModel
    {
        private readonly IOrderData _orderData;
        private readonly IFoodData _foodData;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public OrderModel Order { get; set; } 

        public string FoodPurchased { get; set; }

        [BindProperty]
        public OrderUpdateModel UpdateModel { get; set; }
        
        public DisplayOrderModel(IOrderData orderData, IFoodData foodData)
        {
            _orderData = orderData;
            _foodData = foodData;
        }
        public async Task<IActionResult> OnGet()
        {
            Order = await _orderData.GetOrderById(Id);

            if (Order != null)
            {
                var food = await _foodData.GetFood();

                FoodPurchased = food.Where(x => x.Id == Order.FoodId).FirstOrDefault()?.FoodName;
            }

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            

            var food = await _foodData.GetFood();
            var order = await _orderData.GetOrderById(Id);

            UpdateModel.Total = UpdateModel.Quantity * food.Where(f => f.Id == order.FoodId).First().Price;
            
            await _orderData.UpdateOrderSP(UpdateModel.Id, UpdateModel.OrderName, UpdateModel.Quantity, UpdateModel.Total);

            return RedirectToPage("./DisplayOrder", new { UpdateModel.Id });
        }
    }
}