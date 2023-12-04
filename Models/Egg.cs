namespace lesson_16_demo.Models;

public class Egg : Ingredient, IBeatable
{
    public void Beat()
    {
        Status = "beaten";
    }
}
