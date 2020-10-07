using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace RazorOrderingSystemApp.Pages.Orders
{
    public class DeleteOrderModel : PageModel
    {
        private readonly IOrderData _orderData;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public OrderModel Order { get; set; }
        public DeleteOrderModel(IOrderData orderData)
        {
            _orderData = orderData;
        }
        public async Task OnGet()
        {
            Order = await _orderData.GetOrderById(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            await _orderData.DeleteOrder(Id);

            return RedirectToPage("./ListOrders");
        }
    }
}
