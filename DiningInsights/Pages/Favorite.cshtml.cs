using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DiningInsights.Pages
{
    public class FavoriteModel : PageModel
    {
        private readonly AppDbContext _db;

        public FavoriteModel(AppDbContext db)
        {
            _db = db;
        }

        public IList<Restaurant> FavoriteList { get; private set; }

        public async Task OnGetAsync()
        {
            FavoriteList = await _db.Restaurants.ToListAsync();
        }

        public async Task<IActionResult> OnPostRemoveAsync(string name)
        {
            var currRes = await _db.Restaurants.FindAsync(name);

            if (currRes != null)
            {
                currRes.isFavorite = false;
                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
