using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipesSharingWebsite.Data;

namespace RecipesSharingWebsite.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();

            builder.HasData(
                new IdentityUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@recipes.com",
                    NormalizedEmail = "ADMIN@RECIPES.COM",
                    UserName = "admin@recipes.com",
                    NormalizedUserName = "ADMIN@RECIPES.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
            );
        }
    }

}

