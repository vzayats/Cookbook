using System;
using System.Linq;
using System.Threading.Tasks;
using RecipesApp.DAL.Context;
using RecipesApp.DAL.Entities;
using RecipesApp.DAL.Repository.Interfaces;

namespace RecipesApp.DAL.Repository
{
    public class RecipeVersionsRepository : IRecipeVersionsRepository
    {
        private CookbookContext db = new CookbookContext();

        public IQueryable<RecipeVersion> GetRecipeVersions(int id)
        {
            return db.RecipeVersions.Where(c => c.RecipeId == id);
        }

        public IQueryable<RecipeVersion> GetRecipeVersion(int id)
        {
            return db.RecipeVersions.Where(c => c.VersionId == id);
        }

        public async Task PostRecipeVersion(int recipeId, RecipeVersion recipeVersion)
        {
            RecipeVersion version = new RecipeVersion
            {
                RecipeId = recipeId,
                Name = recipeVersion.Name,
                Description = recipeVersion.Description,
                Ingredients = recipeVersion.Ingredients,
                Directions = recipeVersion.Directions,
                Type = recipeVersion.Type,
                ImageLink = recipeVersion.ImageLink,
                DateModified = DateTime.Now,
                DateCreated = recipeVersion.DateCreated,
                Notes = recipeVersion.Notes
            };
            db.RecipeVersions.Add(version);

            await db.SaveChangesAsync();
        }

        public async Task DeleteRecipeVersion(int id)
        {
            var remove = db.RecipeVersions.Single(d => d.VersionId == id);

            if (remove != null)
            {
                db.RecipeVersions.Remove(remove);
                await db.SaveChangesAsync();
            }
        }

        public async Task DeleteAllRecipeVersions(int id)
        {
            var remove = db.RecipeVersions.RemoveRange(db.RecipeVersions.Where(c => c.RecipeId == id));

            db.RecipeVersions.RemoveRange(remove);
            await db.SaveChangesAsync();
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            Dispose(disposing);
        }
    }
}