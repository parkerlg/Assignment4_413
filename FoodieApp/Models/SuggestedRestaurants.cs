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

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Enter a Valid Phone Number (xxx)-xxx-xxxx")]
        public string Phone { get; set; }
    }

}
