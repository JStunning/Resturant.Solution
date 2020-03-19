using Microsoft.EntityFrameworkCore;

namespace Food.Models
{
  public class FoodContext : DbContext
  {
    public DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Resturant> Resturants { get; set; }
    public DbSet<Review> Reviews {get; set;}

    public FoodContext(DbContextOptions options) : base(options) { }
  }
}