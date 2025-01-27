namespace RecipesSharingWebsite.Domain
{ 
public class Comment 
    {
        public int CommentID { get; set; }
        public string? Content { get; set; }
        public string? AuthorName { get; set; } // Optional
        public int RecipeID { get; set; }
        public Recipe? Recipe { get; set; }
        public DateTime DatePosted { get; set; }
    }

}
