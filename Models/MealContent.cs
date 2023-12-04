namespace lesson_16_demo.Models;

public class MealContent
{
    public List<Ingredient> Ingredients { get; set; } = new();

    public override string ToString()
    {
        return string.Join(", ", Ingredients);
    }
}
