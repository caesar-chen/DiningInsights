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
    }
}
