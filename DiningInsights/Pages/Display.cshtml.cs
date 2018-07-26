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
    public class DisplayModel : PageModel
    {
        private readonly AppDbContext _db;

        public DisplayModel(AppDbContext db)
        {
            _db = db;
        }

        public IList<Restaurant> Restaurants { get; private set; }

        public async Task OnGetAsync()
        {
            Restaurants = await _db.Restaurants.ToListAsync();
        }
    }
}
