using RestaurantDataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantDataLibrary.Data
{
    public interface IFoodData
    {
        Task<int> CreateFood(FoodModel food);
        Task<int> DeleteFood(int foodId);
        Task<List<FoodModel>> GetFood();
        Task<FoodModel> GetFoodById(int foodId);
        Task<int> UpdateFood(int foodId, string foodName, string description, decimal price);
    }
}