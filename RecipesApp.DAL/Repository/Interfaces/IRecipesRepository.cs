using System.Linq;
using System.Threading.Tasks;
using RecipesApp.DAL.Entities;

namespace RecipesApp.DAL.Repository.Interfaces
{
    public interface IRecipesRepository
    {
        IQueryable<Recipe> GetRecipes();
        Task<Recipe> GetRecipe(int id);
        Task PutRecipe(Recipe recipe);
        Task PostRecipe(Recipe recipe);
        Task DeleteRecipe(int id);
    }
}