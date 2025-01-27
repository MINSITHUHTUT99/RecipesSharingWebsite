using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipesSharingWebsite.Domain;

namespace RecipesSharingWebsite.Configurations.Entities
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    CategoryID = 1, // Explicitly set the primary key value
                    Name = "Appetizers"
                },
                new Category
                {
                    CategoryID = 2, // Explicitly set the primary key value
                    Name = "Main Course"
                },
                new Category
                {
                    CategoryID = 3, // Explicitly set the primary key value
                    Name = "Desserts"
                },
                new Category
                {
                    CategoryID = 4, // Explicitly set the primary key value
                    Name = "Beverages"
                }
            );
        }
    }
}
