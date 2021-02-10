using System;
using System.ComponentModel.DataAnnotations;

namespace FoodieApp.Models
{
    public class SuggestedRestaurants
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string RestaurantName { get; set; }


        public string FavDish { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Enter a Valid Phone # (Example ###-###-####)")]
        public string Phone { get; set; }
    }

}

