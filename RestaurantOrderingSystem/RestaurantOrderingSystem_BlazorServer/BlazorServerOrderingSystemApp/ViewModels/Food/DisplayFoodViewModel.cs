using BlazorServerOrderingSystemApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerOrderingSystemApp.ViewModels.Food
{
    public class DisplayFoodViewModel
    {
        public FoodModel Food { get; set; }
        public string ItemPurchased { get; set; }
    }
}
