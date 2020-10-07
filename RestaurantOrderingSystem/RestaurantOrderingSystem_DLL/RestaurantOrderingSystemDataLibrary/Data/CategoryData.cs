using RestaurantDataLibrary.Db;
using RestaurantDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDataLibrary.Data
{
    public class CategoryData : ICategoryData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public CategoryData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        //ALL CATEGORIES
        public Task<List<CategoryModel>> GetCategories()
        {
            return _dataAccess.LoadData<CategoryModel, dynamic>("dbo.spCategory_All",
                                                                new { },
                                                                _connectionString.SqlConnectionName);
        }
    }
}
