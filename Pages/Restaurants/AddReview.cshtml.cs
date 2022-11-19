using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using finalproject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace finalproject.Pages
{
    public class AddReviewModel : PageModel
    {
        private readonly ILogger<AddReviewModel> _logger;
        private readonly RestaurantContext _context;
        [BindProperty]
        public Review Review {get; set;}
        public SelectList RestaurantDropDown {get; set;}

        public AddReviewModel(RestaurantContext context, ILogger<AddReviewModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            RestaurantDropDown = new SelectList(_context.Restaurant.ToList(), "RestaurantID", "Name");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Review.Add(Review);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}