using System.Xml.Linq;

namespace RecipesSharingWebsite.Domain
{
    public class Recipe 
    {
        public int RecipeID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? CuisineType { get; set; }
        public int PreparationTime { get; set; }
        public string? DifficultyLevel { get; set; }
        public string? AuthorName { get; set; } // Optional

        public int CategoryID { get; set; } // Foreign Key
        public Category? Category { get; set; } // Navigation Property

        public ICollection<Ingredient>? Ingredients { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Rating>? Ratings { get; set; }
    }

}
