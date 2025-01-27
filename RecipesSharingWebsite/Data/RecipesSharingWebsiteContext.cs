using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RecipesSharingWebsite.Configurations.Entities;
using RecipesSharingWebsite.Data;

namespace RecipesSharingWebsite.Data
{
    public class RecipesSharingWebsiteContext(DbContextOptions<RecipesSharingWebsiteContext> options) : IdentityDbContext<RecipesSharingWebsiteUser>(options)
    {
        public DbSet<RecipesSharingWebsite.Domain.Category> Category { get; set; } = default!;
        public DbSet<RecipesSharingWebsite.Domain.Comment> Comment { get; set; } = default!;
        public DbSet<RecipesSharingWebsite.Domain.Ingredient> Ingredient { get; set; } = default!;
        public DbSet<RecipesSharingWebsite.Domain.Rating> Rating { get; set; } = default!;
        public DbSet<RecipesSharingWebsite.Domain.Recipe> Recipe { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategorySeed());
        }
    }
}
