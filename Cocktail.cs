using System.Text.Json.Serialization;

namespace CocktailProject
{
    public class ApiResponse
    {
        public string Status { get; set; }
        public object Error { get; set; }
        public Data Data { get; set; }
    }

    public class Data
    {
        public int Count { get; set; }
        public string FilteredOn { get; set; }
        public List<Cocktail> Cocktails { get; set; }
    }

    public class Cocktail
    {
        public string Name { get; set; }
        public string Glass { get; set; }
        public string Category { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string Preparation { get; set; }
        public string Garnish { get; set; }
    }

    public class Ingredient
    {
        public string Unit { get; set; }
        public double Amount { get; set; }
        [JsonPropertyName("ingredient")]
        public string IngredientName { get; set; }
        public string Label { get; set; }
        public string Special { get; set; }
    }
}
