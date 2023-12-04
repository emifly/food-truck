namespace lesson_16_demo.Models;

public class Cheese : Ingredient, IGrateable
{
    public void Grate()
    {
        Status = "grated";
    }
}
