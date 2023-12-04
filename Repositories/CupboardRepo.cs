using lesson_16_demo.Database;
using lesson_16_demo.Models;
using Microsoft.EntityFrameworkCore;

namespace lesson_16_demo.Repositories;

public class CupboardRepo
{
    private readonly FoodTruckContext _context;

    public CupboardRepo(FoodTruckContext context)
    {
        _context = context;
    }

    public TIngredient RetrieveFirst<TIngredient>(DbSet<TIngredient> stock) where TIngredient : Ingredient
    {
        var ingredient = stock.First();
        _context.Remove(ingredient);
        _context.SaveChanges();
        return ingredient;
    }

    public void Restock<TIngredient>(DbSet<TIngredient> stock) where TIngredient : Ingredient, new()
    {
        var newIngredients = Enumerable.Range(1, 10).Select(_ => new TIngredient());
        stock.AddRange(newIngredients);
        _context.SaveChanges();
    }

    public Garlic RetrieveGarlic()
    {
        if (!_context.Garlic.Any())
        {
            Restock(_context.Garlic);
        }
        return RetrieveFirst(_context.Garlic);
    }
}
