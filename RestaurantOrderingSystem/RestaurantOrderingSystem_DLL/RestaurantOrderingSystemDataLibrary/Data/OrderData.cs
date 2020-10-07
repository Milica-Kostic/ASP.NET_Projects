using Dapper;
using RestaurantDataLibrary.Db;
using RestaurantDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace RestaurantDataLibrary.Data
{
    public class OrderData : IOrderData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public OrderData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        //ALL ORDERS
        public Task<List<OrderModel>> GetOrders()
        {
            return _dataAccess.LoadData<OrderModel, dynamic>("dbo.spOrders_All",
                                                                new { },
                                                                _connectionString.SqlConnectionName);
        }

        //CREATE ORDER
        public async Task<int> CreateOrder(OrderModel order)
        {
            //need when ve have output parameter
            DynamicParameters p = new DynamicParameters();

            p.Add("OrderName", order.OrderName);
            p.Add("OrderDate", order.OrderDate);
            p.Add("FoodId", order.FoodId);
            p.Add("Quantity", order.Quantity);
            p.Add("Total", order.Total);
            p.Add("Id", DbType.Int32, direction: ParameterDirection.Output);

            await _dataAccess.SaveData("dbo.spOrders_Insert", p, _connectionString.SqlConnectionName);

            return p.Get<int>("Id");
        }

        //UPDATE ORDER
        public Task<int> UpdateOrder(int orderId, string orderName, int foodId, int quantity, decimal total)
        {
            return _dataAccess.SaveData("dbo.spOrders_Update",
                                        new
                                        {
                                            Id = orderId,
                                            OrderName = orderName,
                                            FoodId = foodId,
                                            Quantity = quantity,
                                            Total = total
                                        },
                                        _connectionString.SqlConnectionName);
        }

        //UPDATE ORDER
        public Task<int> UpdateOrderSP(int orderId, string orderName, int quantity, decimal total)
        {
            return _dataAccess.SaveData("dbo.spOrders_Update_Direct",
                                        new
                                        {
                                            Id = orderId,
                                            OrderName = orderName,
                                            Quantity = quantity,
                                            Total = total
                                        },
                                        _connectionString.SqlConnectionName);
        }

        //DELETE ORDER
        public Task<int> DeleteOrder(int orderId)
        {
            return _dataAccess.SaveData("dbo.spOrders_Delete",
                                        new
                                        {
                                            Id = orderId
                                        },
                                        _connectionString.SqlConnectionName);
        }

        //DISPLAY ORDER
        public async Task<OrderModel> GetOrderById(int orderId)
        {
            var record = await _dataAccess.LoadData<OrderModel, dynamic>("dbo.spOrders_GetById",
                                                                         new
                                                                         {
                                                                             Id = orderId
                                                                         },
                                                                         _connectionString.SqlConnectionName);

            return record.FirstOrDefault();
        }

    }
}
