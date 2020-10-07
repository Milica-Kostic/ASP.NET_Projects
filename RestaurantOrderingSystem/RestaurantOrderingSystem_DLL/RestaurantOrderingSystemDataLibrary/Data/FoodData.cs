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
    public class FoodData : IFoodData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public FoodData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        //ALL FOOD
        public Task<List<FoodModel>> GetFood()
        {
            return _dataAccess.LoadData<FoodModel, dynamic>("dbo.spFood_All",
                                                            new { },
                                                            _connectionString.SqlConnectionName);
        }

        //CREATE FOOD
        public async Task<int> CreateFood(FoodModel food)
        {
            //need when ve have output parameter
            DynamicParameters p = new DynamicParameters();

            p.Add("FoodName", food.FoodName);
            p.Add("FoodDescription", food.FoodDescription);
            p.Add("Price", food.Price);
            p.Add("RestaurantId", food.RestaurantId);
            p.Add("Id", DbType.Int32, direction: ParameterDirection.Output);

            await _dataAccess.SaveData("dbo.spFood_Insert", p, _connectionString.SqlConnectionName);

            return p.Get<int>("Id");
        }
        //UPDATE FOOD
        public Task<int> UpdateFood(int foodId, string foodName, string foodDescription, decimal price)
        {
            return _dataAccess.SaveData("dbo.spFood_Update",
                                        new
                                        {
                                            Id = foodId,
                                            FoodName = foodName,
                                            FoodDescription = foodDescription,
                                            Price = price
                                        },
                                        _connectionString.SqlConnectionName);
        }

        //DELETE ORDER
        public Task<int> DeleteFood(int foodId)
        {
            return _dataAccess.SaveData("dbo.spFood_Delete",
                                        new
                                        {
                                            Id = foodId
                                        },
                                        _connectionString.SqlConnectionName);
        }

        //DISPLAY ORDER
        public async Task<FoodModel> GetFoodById(int foodId)
        {
            var record = await _dataAccess.LoadData<FoodModel, dynamic>("dbo.spFood_GetById",
                                                                         new
                                                                         {
                                                                             Id = foodId
                                                                         },
                                                                         _connectionString.SqlConnectionName);

            return record.FirstOrDefault();
        }
    }
}
