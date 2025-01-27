namespace RecipesSharingWebsite.Domain
{
    public class Ingredient 
    {
        public int IngredientID { get; set; }
        public string? Name { get; set; }
        public string? Quantity { get; set; }
        public int RecipeID { get; set; }
        public Recipe? Recipe { get; set; }
    }

}
