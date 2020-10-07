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
    public class ListOrdersModel : PageModel
    {
        private readonly IOrderData _orderData;
        public List<OrderModel> Orders { get; set; }
        public ListOrdersModel(IOrderData orderData)
        {
            _orderData = orderData;
        }
        public async Task OnGet()
        {
            Orders = await _orderData.GetOrders();
        }
    }
}
