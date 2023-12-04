using lesson_16_demo.Models;
using lesson_16_demo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace lesson_16_demo.Controllers;

public class PizzaController : Controller
{
    private readonly FridgeRepo _fridge;
    private readonly CupboardRepo _cupboard;

    public PizzaController(FridgeRepo fridge, CupboardRepo cupboard)
    {
        _fridge = fridge;
        _cupboard = cupboard;
    }

    public IActionResult Margherita()
    {
        var tomato = _fridge.RetrieveTomato();
        var cheese = _fridge.RetrieveCheese();
        tomato.Chop();
        cheese.Grate();
        var mealContent = new MealContent
        {
            Ingredients = new List<Ingredient>
            {
                tomato,
                cheese,
            }
        };
        return View(mealContent);
    }

    public IActionResult Pepperoni()
    {
        var tomato = _fridge.RetrieveTomato();
        var cheese = _fridge.RetrieveCheese();
        var sausage = _fridge.RetrieveSausage();
        tomato.Chop();
        cheese.Grate();
        sausage.Chop();
        var mealContent = new MealContent
        {
            Ingredients = new List<Ingredient>
            {
                tomato,
                cheese,
                sausage,
            }
        };
        return View(mealContent);
    }

    public IActionResult GarlicMushroom()
    {
        var cheese = _fridge.RetrieveCheese();
        var mushroom = _fridge.RetrieveMushroom();
        var garlic = _cupboard.RetrieveGarlic();
        cheese.Grate();
        mushroom.Chop();
        garlic.Chop();
        var mealContent = new MealContent
        {
            Ingredients = new List<Ingredient>
            {
                cheese,
                mushroom,
                garlic,
            }
        };
        return View(mealContent);
    }
}
