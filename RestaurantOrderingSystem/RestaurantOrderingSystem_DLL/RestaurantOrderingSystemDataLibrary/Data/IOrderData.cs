using RestaurantDataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantDataLibrary.Data
{
    public interface IOrderData
    {
        Task<int> CreateOrder(OrderModel order);
        Task<int> DeleteOrder(int orderId);
        Task<OrderModel> GetOrderById(int orderId);
        Task<List<OrderModel>> GetOrders();
        Task<int> UpdateOrder(int orderId, string orderName, int foodId, int quantity, decimal total);
        Task<int> UpdateOrderSP(int orderId, string orderName, int quantity, decimal total);
    }
}