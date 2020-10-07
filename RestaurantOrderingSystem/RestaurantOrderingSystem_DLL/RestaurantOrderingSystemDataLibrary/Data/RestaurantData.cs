using Dapper;
using RestaurantDataLibrary.Db;
using RestaurantDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDataLibrary.Data
{
    public class RestaurantData : IRestaurantData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;
        public RestaurantData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        //ALL RESTAURANTS
        public Task<List<RestaurantModel>> GetRestaurants()
        {
            return _dataAccess.LoadData<RestaurantModel, dynamic>("dbo.spRestaurant_All",
                                                                new { },
                                                                _connectionString.SqlConnectionName);
        }

        //CREATE ORDER
        public async Task<int> CreateRestaurant(RestaurantModel restaurant)
        {
            //need when ve have output parameter
            DynamicParameters p = new DynamicParameters();

            p.Add("RestName", restaurant.RestName);
            p.Add("City", restaurant.City);
            p.Add("CategoryId", restaurant.CategoryId);
            p.Add("RestDescription", restaurant.RestDescription);
            p.Add("Id", DbType.Int32, direction: ParameterDirection.Output);

            await _dataAccess.SaveData("dbo.spRestaurant_Insert", p, _connectionString.SqlConnectionName);

            return p.Get<int>("Id");
        }

        //UPDATE ORDER
        public Task<int> UpdateRestaurant(int restaurantId, string restName, string city, string restDescription)
        {
            return _dataAccess.SaveData("dbo.spRestaurant_Update",
                                        new
                                        {
                                            Id = restaurantId,
                                            RestName = restName,
                                            City = city,
                                            RestDescription = restDescription
                                        },
                                        _connectionString.SqlConnectionName);
        }

        //DELETE ORDER
        public Task<int> DeleteRestaurant(int restaurantId)
        {
            return _dataAccess.SaveData("dbo.spRestaurant_Delete",
                                        new
                                        {
                                            Id = restaurantId
                                        },
                                        _connectionString.SqlConnectionName);
        }

        //DISPLAY ORDER
        public async Task<RestaurantModel> GetRestaurantById(int restaurantId)
        {
            var record = await _dataAccess.LoadData<RestaurantModel, dynamic>("dbo.spRestaurant_GetById",
                                                                         new
                                                                         {
                                                                             Id = restaurantId
                                                                         },
                                                                         _connectionString.SqlConnectionName);

            return record.FirstOrDefault();
        }
    }
}
