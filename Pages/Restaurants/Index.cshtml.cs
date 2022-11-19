using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using finalproject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace finalproject.Pages.Restaurants
{
    public class IndexModel : PageModel
    {
        private readonly finalproject.Models.RestaurantContext _context;

        public IndexModel(finalproject.Models.RestaurantContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant {get; set;}
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 20;
        public int TotalRows {get; set;}
        public decimal MaxPage {get; set;}

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        
        public async Task OnGetAsync()
        {
            var query = _context.Restaurant.Select(m => m);

            var query2 = _context.Restaurant.Count();

            MaxPage = ((query2 + PageSize - 1) / PageSize);

            switch (CurrentSort)
            {
                case "nameAsc":
                    query = query.OrderBy(m => m.Name);
                    break;
                case "nameDesc":
                    query = query.OrderByDescending(m => m.Name);
                    break;
                case "addressAsc":
                    query = query.OrderBy(m => m.Address);
                    break;
                case "addressDesc":
                    query = query.OrderByDescending(m => m.Address);
                    break;
                case "phoneAsc":
                    query = query.OrderBy(m => m.PhoneNumber);
                    break;
                case "phoneDesc":
                    query = query.OrderByDescending(m => m.PhoneNumber);
                    break;
                case "cuisineAsc":
                    query = query.OrderBy(m => m.Cuisine);
                    break;
                case "cuisineDesc":
                    query = query.OrderByDescending(m => m.Cuisine);
                    break; 
            }

            Restaurant = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
