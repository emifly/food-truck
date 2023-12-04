namespace lesson_16_demo.Models;

public abstract class Ingredient
{
    public int Id { get; set; }
    public string Status { get; set; } = "whole";

    public override string ToString()
    {
        return $"{GetType().Name.ToLower()} ({Status})";
    }
}
