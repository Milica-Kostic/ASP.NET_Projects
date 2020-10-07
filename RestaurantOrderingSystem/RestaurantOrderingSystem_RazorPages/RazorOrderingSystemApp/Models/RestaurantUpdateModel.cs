using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorOrderingSystemApp.Models
{
    public class RestaurantUpdateModel
    {
        public int Id { get; set; }
        public string RestName { get; set; }
        public string RestDescription { get; set; }
        public string City { get; set; }
    }
}
