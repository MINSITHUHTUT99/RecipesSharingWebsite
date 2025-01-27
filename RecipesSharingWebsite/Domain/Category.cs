namespace RecipesSharingWebsite.Domain
{
    public class Category 
    {
        public int CategoryID { get; set; } // Primary Key
        public string? Name { get; set; } // Category name (e.g., "Desserts")
        public ICollection<Recipe>? Recipes { get; set; } // Relationship with Recipes
        


    }
}
