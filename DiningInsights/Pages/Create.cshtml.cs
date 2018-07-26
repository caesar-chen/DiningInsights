using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DiningInsights.Pages
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _db;

        [BindProperty]
        public Restaurant restaurant { get; set; }

        public CreateModel(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            restaurant.FoodType = "Others";
            restaurant.isFavorite = false;
            restaurant.Cafe = Cafes.Cafe109;
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();

            restaurant.Name = "Ding Tai Feng";
            restaurant.FoodType = "Chinese";
            restaurant.Cafe = Cafes.Cafe25;
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();

            restaurant.Name = "Oto Sushi";
            restaurant.FoodType = "Japanese";
            restaurant.Cafe = Cafes.CafeAdvantaA;
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();
            
            restaurant.Name = "Bamboo Garden";
            restaurant.FoodType = "Indian, Chinese";
            restaurant.Cafe = Cafes.CafeRedwF;
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();
            
            restaurant.Name = "Burger King";
            restaurant.FoodType = "American";
            restaurant.Cafe = Cafes.Cafe99;
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();
            
            restaurant.Name = "Yummy Pho";
            restaurant.FoodType = "Vietnamese";
            restaurant.Cafe = Cafes.CafeBravern2;
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();
            
            restaurant.Name = "Bai Tong";
            restaurant.FoodType = "Thai";
            restaurant.Cafe = Cafes.CafeCCP;
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();
            
            restaurant.Name = "Stone Korean";
            restaurant.FoodType = "Korean";
            restaurant.Cafe = Cafes.Cafe36;
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();

            return RedirectToPage("Display");
        }
    }
}
