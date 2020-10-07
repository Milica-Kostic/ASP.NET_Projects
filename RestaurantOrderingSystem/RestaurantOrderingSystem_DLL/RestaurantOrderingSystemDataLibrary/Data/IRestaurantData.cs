using RestaurantDataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantDataLibrary.Data
{
    public interface IRestaurantData
    {
        Task<int> CreateRestaurant(RestaurantModel restaurant);
        Task<int> DeleteRestaurant(int restaurantId);
        Task<RestaurantModel> GetRestaurantById(int restaurantId);
        Task<List<RestaurantModel>> GetRestaurants();
        Task<int> UpdateRestaurant(int restaurantId, string restName, string city, string restDescription);
    }
}