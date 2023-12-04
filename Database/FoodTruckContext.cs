using lesson_16_demo.Models;
using Microsoft.EntityFrameworkCore;

namespace lesson_16_demo.Database;

public class FoodTruckContext : DbContext
{
    public DbSet<Beef> Beef { get; set; } = null!;
    public DbSet<Cheese> Cheese { get; set; } = null!;
    public DbSet<Chilli> Chillies { get; set; } = null!;
    public DbSet<Egg> Eggs { get; set; } = null!;
    public DbSet<Garlic> Garlic { get; set; } = null!;
    public DbSet<Ham> Ham { get; set; } = null!;
    public DbSet<Mushroom> Mushrooms { get; set; } = null!;
    public DbSet<Sausage> Sausages { get; set; } = null!;
    public DbSet<Tomato> Tomatoes { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=food-truck.db");
    }
}
