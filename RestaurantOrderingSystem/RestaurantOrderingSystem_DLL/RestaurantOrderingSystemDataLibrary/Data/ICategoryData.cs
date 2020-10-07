using RestaurantDataLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantDataLibrary.Data
{
    public interface ICategoryData
    {
        Task<List<CategoryModel>> GetCategories();
    }
}