namespace lesson_16_demo.Models;

public class Beef : Ingredient, IMinceable
{
    public void Mince()
    {
        Status = "minced";
    }
}
