namespace lesson_16_demo.Models;

public class Sausage : Ingredient, IChoppable
{
    public void Chop()
    {
        Status = "chopped";
    }
}
