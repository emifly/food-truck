namespace lesson_16_demo.Models;

public class Ham : Ingredient, IChoppable
{
    public void Chop()
    {
        Status = "chopped";
    }
}
