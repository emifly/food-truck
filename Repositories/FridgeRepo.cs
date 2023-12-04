using lesson_16_demo.Database;
using lesson_16_demo.Models;
using Microsoft.EntityFrameworkCore;

namespace lesson_16_demo.Repositories;

public class FridgeRepo
{
    private readonly FoodTruckContext _context;

    public FridgeRepo(FoodTruckContext context)
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

    public Beef RetrieveBeef()
    {
        if (!_context.Beef.Any())
        {
            Restock(_context.Beef);
        }
        return RetrieveFirst(_context.Beef);
    }

    public Cheese RetrieveCheese()
    {
        if (!_context.Cheese.Any())
        {
            Restock(_context.Cheese);
        }
        return RetrieveFirst(_context.Cheese);
    }

    public Chilli RetrieveChilli()
    {
        if (!_context.Chillies.Any())
        {
            Restock(_context.Chillies);
        }
        return RetrieveFirst(_context.Chillies);
    }

    public Egg RetrieveEgg()
    {
        if (!_context.Eggs.Any())
        {
            Restock(_context.Eggs);
        }
        return RetrieveFirst(_context.Eggs);
    }

    public Ham RetrieveHam()
    {
        if (!_context.Ham.Any())
        {
            Restock(_context.Ham);
        }
        return RetrieveFirst(_context.Ham);
    }

    public Mushroom RetrieveMushroom()
    {
        if (!_context.Mushrooms.Any())
        {
            Restock(_context.Mushrooms);
        }
        return RetrieveFirst(_context.Mushrooms);
    }

    public Sausage RetrieveSausage()
    {
        if (!_context.Sausages.Any())
        {
            Restock(_context.Sausages);
        }
        return RetrieveFirst(_context.Sausages);
    }

    public Tomato RetrieveTomato()
    {
        if (!_context.Tomatoes.Any())
        {
            Restock(_context.Tomatoes);
        }
        return RetrieveFirst(_context.Tomatoes);
    }
}
