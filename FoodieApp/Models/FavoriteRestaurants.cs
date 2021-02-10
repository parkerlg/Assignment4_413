using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodieApp.Models
{
    public class FavoriteRestaurants
    {
        
        [Required(ErrorMessage = "Rank Required")]
        [ReadOnly(true)]
        public int Rank { get; set; }
        [Required(ErrorMessage ="Restaurant Name Required")]
        public string Name { get; set; }
        #nullable enable
        public string? FavDish { get; set; }
        #nullable disable
        [Required(ErrorMessage = "Restaurant Address Required")]
        public string Address { get; set; }
        #nullable enable
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Enter a Valid Phone Number")]
        public string? Phone { get; set; }
        [Url]
        public string? Website { get; set; } = "Coming Soon!";
        #nullable disable

        public static FavoriteRestaurants[] GetFavRestaurants()
        {
            FavoriteRestaurants r1 = new FavoriteRestaurants
            {
                Rank = 1,
                Name = "R&R BBQ",
                //FavDish = null, //"2 Meat Combo w/ Brisket and Pulled Pork",
                Address = "4801 N University Ave #490, Provo, UT 84601",
                Phone = "(801) 281-5508",
                //Website = null
            };

            FavoriteRestaurants r2 = new FavoriteRestaurants
            {
                Rank = 2,
                Name = "Chick-Fil-A",
                FavDish = "Chicken Deluxe Sandwich w/ PepperJack Cheese",
                Address = "484 Bulldog Ln, Provo, UT 84604",
                Phone = "(801) 374-2697",
                Website = "chick-fil-a.com"
            };

            FavoriteRestaurants r3 = new FavoriteRestaurants
            {
                Rank = 3,
                Name = "Mooyah",
                FavDish = "The Best Quesonario",
                Address = "62 W 1230 N St Suite 105, Provo, UT",
                Phone = "(801) 705-8500",
                Website = "mooyah.com"
            };

            FavoriteRestaurants r4 = new FavoriteRestaurants
            {
                Rank = 4,
                Name = "Bumblebees KBBQ and Grill",
                FavDish = "K-Pop Fries",
                Address = "1254 N State St, Provo, UT",
                Phone = "(801) 607-2543",
                Website = "provo.bumblebeeskbbq.com"
            };

            FavoriteRestaurants r5 = new FavoriteRestaurants
            {
                Rank = 5,
                Name = "Wendy's",
                FavDish = "4 for 4 Jr. Bacon Cheeseburger",
                Address = "122 E 1230 N St, Provo, UT",
                Phone = "(801) 377-8063",
                Website = "wendys.com"
            };

            return new FavoriteRestaurants[] { r1, r2, r3, r4, r5 };
        }
    }
}
