using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DiningInsights;

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
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();

            restaurant.Name = "Ding Tai Feng";
            restaurant.FoodType = "Chinese";
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();

            restaurant.Name = "Oto Sushi";
            restaurant.FoodType = "Japanese";
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();
            
            restaurant.Name = "Bamboo Garden";
            restaurant.FoodType = "Indian, Chinese";
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();
            
            restaurant.Name = "Burger King";
            restaurant.FoodType = "American";
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();
            
            restaurant.Name = "Yummy Pho";
            restaurant.FoodType = "Vietnamese";
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();
            
            restaurant.Name = "Bai Tong";
            restaurant.FoodType = "Thai";
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();
            
            restaurant.Name = "Stone Korean";
            restaurant.FoodType = "Korean";
            _db.Restaurants.Add(restaurant);
            await _db.SaveChangesAsync();

            return RedirectToPage("Display");
        }
    }
}
