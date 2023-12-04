namespace lesson_16_demo.Models;

public class Chilli : Ingredient, IChoppable
{
    public void Chop()
    {
        Status = "chopped";
    }
}
