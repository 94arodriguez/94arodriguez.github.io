using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using finalproject.Models;

namespace finalproject.Pages.Restaurants
{
    public class DetailsModel : PageModel
    {
        private readonly finalproject.Models.RestaurantContext _context;

        public DetailsModel(finalproject.Models.RestaurantContext context)
        {
            _context = context;
        }

        public Restaurant Restaurant { get; set; }
        [BindProperty]
        public int ReviewIDToDelete {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Restaurant = await _context.Restaurant.Include(m => m.Reviews).FirstOrDefaultAsync(m => m.RestaurantID == id);

            if (Restaurant == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPostDeleteReview(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Review Review = _context.Review.FirstOrDefault(r => r.ReviewID == ReviewIDToDelete);
            
            if (Review != null)
            {
                _context.Remove(Review);
                _context.SaveChanges();
            }

            Restaurant = _context.Restaurant.Include(m => m.Reviews).FirstOrDefault(m => m.RestaurantID == id);

            return Page();
        }        
    }
}
