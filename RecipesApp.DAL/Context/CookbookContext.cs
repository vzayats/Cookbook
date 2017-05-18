using System.Data.Entity;
using RecipesApp.DAL.Entities;

namespace RecipesApp.DAL.Context
{
    public class CookbookContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeVersion> RecipeVersions { get; set; }
    }
}