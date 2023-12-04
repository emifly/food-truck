namespace lesson_16_demo.Models;

public class Tomato : Ingredient, IChoppable
{
    public void Chop()
    {
        Status = "chopped";
    }
}
