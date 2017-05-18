using System.Linq;
using System.Threading.Tasks;
using RecipesApp.DAL.Entities;

namespace RecipesApp.DAL.Repository.Interfaces
{
    public interface IRecipeVersionsRepository
    {
        IQueryable<RecipeVersion> GetRecipeVersions(int id);
        IQueryable<RecipeVersion> GetRecipeVersion(int id);
        Task PostRecipeVersion(int recipeId, RecipeVersion recipeVersion);
        Task DeleteRecipeVersion(int id);
        Task DeleteAllRecipeVersions(int id);
    }
}