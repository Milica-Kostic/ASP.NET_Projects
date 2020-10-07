using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCOrderingSystemApp.Models.Orders;
using RestaurantDataLibrary.Data;
using RestaurantDataLibrary.Models;

namespace MVCOrderingSystemApp.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IFoodData _foodData;
        private readonly IOrderData _orderData;


        public OrdersController(IFoodData foodData, IOrderData orderData)
        {
            _foodData = foodData;
            _orderData = orderData;
        }
        public async Task<IActionResult> Index()
        {
            var orders = await _orderData.GetOrders();
            return View(orders);
        }
        public async Task<IActionResult> Create()
        {
            var food = await _foodData.GetFood();

            CreateOrderModel model = new CreateOrderModel();

            food.ForEach(x =>
            {
                model.FoodItems.Add(new SelectListItem { Value = x.Id.ToString(), Text = x.FoodName });
            });

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderModel order)
        {
            if(ModelState.IsValid == false)
            {
                return View();
            }
            var food = await _foodData.GetFood();

            order.Total = order.Quantity * food.Where(f => f.Id == order.FoodId).First().Price;

            int id = await _orderData.CreateOrder(order);

            return RedirectToAction("Display", new { id });

        }

        public async Task<IActionResult> Display(int id)
        {
            DisplayOrderModel displayOrder = new DisplayOrderModel
            {
                //UpdateOrderModel updateOrder = new UpdateOrderModel();

                Order = await _orderData.GetOrderById(id)
            };

            if (displayOrder.Order != null)
            {
                var food = await _foodData.GetFood();
                displayOrder.ItemPurchased = food.Where(f => f.Id == displayOrder.Order.FoodId).FirstOrDefault()?.FoodName;
            }
            //updateOrder.Id = displayOrder.Order.Id;
            //updateOrder.OrderName = displayOrder.Order.OrderName;
            //updateOrder.Quantity = displayOrder.Order.Quantity;
            //updateOrder.Total = displayOrder.Order.Total;
            //updateOrder.FoodId = displayOrder.Order.FoodId;
            
            return View(displayOrder);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateOrderModel updateOrder)
        {
            var food = await _foodData.GetFood();
            var order = await _orderData.GetOrderById(updateOrder.Id);

            updateOrder.Total = updateOrder.Quantity * food.Where(f => f.Id == order.FoodId).First().Price;

            await _orderData.UpdateOrderSP(updateOrder.Id, updateOrder.OrderName, updateOrder.Quantity, updateOrder.Total);

            return RedirectToAction("Display", new { updateOrder.Id });
        }
        public async Task<IActionResult> Delete(int id)
        {
            var order = await _orderData.GetOrderById(id);
            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(OrderModel orderModel)
        {
            await _orderData.DeleteOrder(orderModel.Id);

            return RedirectToAction("Index");
        }
    }
}
