using Microsoft.EntityFrameworkCore;

namespace finalproject.Models
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext (DbContextOptions<RestaurantContext> options)
            : base(options)
            {
            }
            public DbSet<Restaurant> Restaurant {get; set;}
            public DbSet<Review> Review {get; set;}
    }

}