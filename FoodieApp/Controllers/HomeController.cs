using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FoodieApp.Models;

namespace FoodieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> RestaurantList = new List<string>();

            foreach (FavoriteRestaurants r in FavoriteRestaurants.GetFavRestaurants())
            {
                string favdish = r.FavDish ?? "It's all tasty";
                RestaurantList.Add(string.Format("#{0}: {1} -- Favorite Dish: {2} -- Address: {3} -- Phone: {4} -- Website: {5}", r.Rank, r.Name, favdish, r.Address, r.Phone, r.Website));
            }
            return View(RestaurantList);
        }

        [HttpGet]
        public IActionResult SuggestedForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SuggestedForm(SuggestedRestaurants restaurant)
        {
            if (ModelState.IsValid)
            {
                TempSugg.AddRestaurant(restaurant);
                return View("SuggestedList", TempSugg.SuggestedRestaurants);
            }
            else { return View(); }
        }

        public IActionResult SuggestedList()
        {
            return View(TempSugg.SuggestedRestaurants);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
