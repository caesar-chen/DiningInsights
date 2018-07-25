using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DiningInsights.Pages
{
    public class SearchModel : PageModel
    {
        private readonly AppDbContext _db;

        public SearchModel(AppDbContext db)
        {
            _db = db;
        }

        public IList<Restaurant> restaurant { get; set; }

        public async Task<IActionResult> OnGetAsync(string searchString)
        {
            var restaurantList = from r in _db.Restaurants
                            select r;
          
            if (!String.IsNullOrEmpty(searchString))
            {
                restaurantList = restaurantList.Where(s => s.FoodType.IndexOf(searchString, StringComparison.CurrentCultureIgnoreCase) > -1);
            }

            restaurant = await restaurantList.ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnPostUpdateAsync(string name)
        {
            var currRes = await _db.Restaurants.FindAsync(name);

            if (currRes != null)
            {
                currRes.isFavorite = true;
                await _db.SaveChangesAsync();
            }

            //return Page();
            return RedirectToPage();
        }
    }
}
