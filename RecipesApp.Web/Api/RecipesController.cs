using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using RecipesApp.DAL.Entities;
using RecipesApp.DAL.Repository.Interfaces;

namespace RecipesApp.Web.Api
{
    public class RecipesController : ApiController
    {
        private readonly IRecipesRepository _repository;

        public RecipesController(IRecipesRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Recipes
        [HttpGet]
        public IHttpActionResult GetRecipes()
        {
            var result = _repository.GetRecipes();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/Recipes/5
        [HttpGet]
        public async Task<IHttpActionResult> GetRecipe(int id)
        {
            var result = await _repository.GetRecipe(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // PUT: api/Recipes/5
        [ResponseType(typeof(void))]
        [HttpPut]
        public async Task<IHttpActionResult> PutRecipe(Recipe recipe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _repository.PutRecipe(recipe);

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Recipes
        [ResponseType(typeof(Recipe))]
        [HttpPost]
        public async Task<IHttpActionResult> PostRecipe(Recipe recipe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _repository.PostRecipe(recipe);

            return CreatedAtRoute("DefaultApi", new {id = recipe.Id}, recipe);
        }

        // DELETE: api/Recipes/5
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteRecipe(int id)
        {
            await _repository.DeleteRecipe(id);

            return Ok();
        }
    }
}