﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerOrderingSystemApp.ViewModels.Food
{
    public class UpdateFoodViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "You need to keep the name a max of 20 characters")]
        [MinLength(3, ErrorMessage = "You need to enter at least 3 characters for an name of the Meal")]
        [DisplayName("Name of the Meal")]
        public string FoodName { get; set; }

        [DisplayName("Description of the Meal")]
        public string FoodDescription { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
