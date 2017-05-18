using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using RecipesApp.DAL.Entities;
using RecipesApp.DAL.Repository.Interfaces;

namespace RecipesApp.Web.Api
{
    public class RecipeVersionsController : ApiController
    {
        private readonly IRecipeVersionsRepository _repository;

        public RecipeVersionsController(IRecipeVersionsRepository repository)
        {
            _repository = repository;
        }

        // GET: api/RecipeVersions
        [HttpGet]
        public IHttpActionResult GetRecipeVersions(int id)
        {
            var result = _repository.GetRecipeVersions(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/GetRecipeVersion/5
        [HttpGet]
        public IHttpActionResult GetRecipeVersion(int id)
        {
            var result = _repository.GetRecipeVersion(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // POST: api/RecipeVersions
        [ResponseType(typeof(RecipeVersion))]
        [HttpPost]
        [Route("api/RecipeVersions/PostRecipeVersion/{recipeId}")]
        public async Task<IHttpActionResult> PostRecipeVersion(int recipeId, RecipeVersion recipeVersion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _repository.PostRecipeVersion(recipeId, recipeVersion);

            return CreatedAtRoute("DefaultApi", new {id = recipeVersion.VersionId}, recipeVersion);
        }

        // DELETE: api/RecipeVersions/5
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteRecipeVersion(int id)
        {
            await _repository.DeleteRecipeVersion(id);

            return Ok();
        }

        // DELETE: api/RecipeVersions/5
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteAllRecipeVersions(int id)
        {
            await _repository.DeleteAllRecipeVersions(id);

            return Ok();
        }
    }
}