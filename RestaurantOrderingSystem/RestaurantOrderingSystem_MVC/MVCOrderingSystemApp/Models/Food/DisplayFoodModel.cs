using RestaurantDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCOrderingSystemApp.Models.Food
{
    public class DisplayFoodModel
    {
        public FoodModel Food { get; set; }
        public string ItemPurchased { get; set; }
    }
}
