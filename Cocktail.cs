namespace CocktailProject
{
    public class Cocktail
    {
        public string Name { get; set; }
        public string Glass { get; set; }
        public string Category { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string Preparation { get; set; }
    }

    public class Ingredient
    {
        public string Unit { get; set; }
        public float? Amount { get; set; }
        public string IngredientName { get; set; }
        public string Label { get; set; }
        public string Special { get; set; }
    }
}
