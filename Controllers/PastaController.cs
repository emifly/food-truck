using lesson_16_demo.Models;
using lesson_16_demo.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace lesson_16_demo.Controllers;

public class PastaController : Controller
{
    private readonly FridgeRepo _fridge;

    public PastaController(FridgeRepo fridge)
    {
        _fridge = fridge;
    }

    public IActionResult Arrabiata()
    {
        var tomato = _fridge.RetrieveTomato();
        var chilli = _fridge.RetrieveChilli();
        tomato.Chop();
        chilli.Chop();
        var mealContent = new MealContent
        {
            Ingredients = new List<Ingredient>
            {
                tomato,
                chilli,
            }
        };
        return View(mealContent);
    }

    public IActionResult Bolognese()
    {
        var tomato = _fridge.RetrieveTomato();
        var beef = _fridge.RetrieveBeef();
        tomato.Chop();
        beef.Mince();
        var mealContent = new MealContent
        {
            Ingredients = new List<Ingredient>
            {
                tomato,
                beef,
            }
        };
        return View(mealContent);
    }

    public IActionResult Carbonara()
    {
        var egg = _fridge.RetrieveEgg();
        var ham = _fridge.RetrieveHam();
        egg.Beat();
        ham.Chop();
        var mealContent = new MealContent
        {
            Ingredients = new List<Ingredient>
            {
                egg,
                ham,
            }
        };
        return View(mealContent);
    }
}
