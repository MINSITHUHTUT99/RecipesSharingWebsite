namespace RecipesSharingWebsite.Domain
{
    public class Rating 
    {
        public int RatingID { get; set; }
        public int RatingValue { get; set; }
        public int RecipeID { get; set; }
        public Recipe? Recipe { get; set; }
        public DateTime DateRated { get; set; }
    }
}
