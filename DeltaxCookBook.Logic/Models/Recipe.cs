namespace DeltaxCookBook.Logic.Models;

public class Recipe
{
    public Dictionary<int, Ingredient> Ingredients { get; set; }
    public string Name { get; set; }
}