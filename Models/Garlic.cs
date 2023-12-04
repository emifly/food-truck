namespace lesson_16_demo.Models;

public class Garlic : Ingredient, IChoppable
{
    public void Chop()
    {
        Status = "chopped";
    }
}
