using System;
using System.Collections.Generic;

namespace FoodieApp.Models
{
    public class TempSugg
    {
        private static List<SuggestedRestaurants> suggestions = new List<SuggestedRestaurants>();

        public static IEnumerable<SuggestedRestaurants> SuggestedRestaurants => suggestions;

        public static void AddRestaurant(SuggestedRestaurants suggested)
        {
            suggestions.Add(suggested);
        }
    }
}
