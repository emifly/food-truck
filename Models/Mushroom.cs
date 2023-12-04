namespace lesson_16_demo.Models;

public class Mushroom : Ingredient, IChoppable
{
    public void Chop()
    {
        Status = "chopped";
    }
}
