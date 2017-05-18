using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using RecipesApp.DAL.Context;
using RecipesApp.DAL.Entities;
using RecipesApp.DAL.Repository.Interfaces;

namespace RecipesApp.DAL.Repository
{
    public class RecipesRepository : IRecipesRepository
    {
        private CookbookContext db = new CookbookContext();

        public IQueryable<Recipe> GetRecipes()
        {
            return db.Recipes;
        }

        public async Task<Recipe> GetRecipe(int id)
        {
            return await db.Recipes.FindAsync(id);
        }

        public async Task PutRecipe(Recipe recipe)
        {
            db.Entry(recipe).State = EntityState.Modified;
            await db.SaveChangesAsync();
        }

        public async Task PostRecipe(Recipe recipe)
        {
            db.Recipes.Add(recipe);
            await db.SaveChangesAsync();
        }

        public async Task DeleteRecipe(int id)
        {
            Recipe recipe = await db.Recipes.FindAsync(id);

            if (recipe != null)
            {
                db.Recipes.Remove(recipe);
            }

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