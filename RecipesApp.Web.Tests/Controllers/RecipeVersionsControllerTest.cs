using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipesApp.Web.Api;
using RecipesApp.DAL.Repository.Interfaces;
using RecipesApp.DAL.Entities;
using Moq;

namespace RecipesApp.Web.Tests.Controllers
{
    [TestClass]
    public class RecipeVersionsControllerTest
    {
        private readonly TestData _testData = new TestData();

        [TestMethod]
        public void GetRecipeVersions_Returns_OkNegotiatedContentResult()
        {
            // Arrange
            var mockRepository = new Mock<IRecipeVersionsRepository>();
            var controller = new RecipeVersionsController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.GetRecipeVersions(1);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<IQueryable<RecipeVersion>>));
        }

        [TestMethod]
        public void GetRecipeVersion_Returns_OkNegotiatedContentResult()
        {
            // Arrange
            var mockRepository = new Mock<IRecipeVersionsRepository>();
            var controller = new RecipeVersionsController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.GetRecipeVersion(1);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<IQueryable<RecipeVersion>>));
        }

        [TestMethod]
        public async Task PostRecipe_Sets_LocationHeader()
        {
            // Arrange
            var mockRepository = new Mock<IRecipeVersionsRepository>();
            var controller = new RecipeVersionsController(mockRepository.Object);

            // Act
            Task<IHttpActionResult> actionResult = controller.PostRecipeVersion(1, _testData.RecipeVersionData);
            var createdResult = await actionResult as CreatedAtRouteNegotiatedContentResult<RecipeVersion>;

            // Assert
            Assert.IsNotNull(createdResult);
            Assert.AreEqual("DefaultApi", createdResult.RouteName);
            Assert.AreEqual(_testData.RecipeData.Id, createdResult.RouteValues["id"]);
        }

        [TestMethod]
        public async Task PostRecipeVersion_Returns_CreatedResult()
        {
            // Arrange
            var mockRepository = new Mock<IRecipeVersionsRepository>();
            var controller = new RecipeVersionsController(mockRepository.Object);

            // Act
            Task<IHttpActionResult> actionResult = controller.PostRecipeVersion(1, _testData.RecipeVersionData);
            var createdResult = await actionResult as CreatedAtRouteNegotiatedContentResult<RecipeVersion>;

            // Assert
            Assert.IsNotNull(createdResult);
            Assert.AreEqual(_testData.RecipeVersionData.VersionId, createdResult.Content.VersionId);
            Assert.AreEqual(_testData.RecipeVersionData.RecipeId, createdResult.Content.RecipeId);
            Assert.AreEqual(_testData.RecipeVersionData.Name, createdResult.Content.Name);
            Assert.AreEqual(_testData.RecipeVersionData.Description, createdResult.Content.Description);
            Assert.AreEqual(_testData.RecipeVersionData.Ingredients, createdResult.Content.Ingredients);
            Assert.AreEqual(_testData.RecipeVersionData.Directions, createdResult.Content.Directions);
            Assert.AreEqual(_testData.RecipeVersionData.Type, createdResult.Content.Type);
            Assert.AreEqual(_testData.RecipeVersionData.ImageLink, createdResult.Content.ImageLink);
            Assert.AreEqual(_testData.RecipeVersionData.DateCreated, createdResult.Content.DateCreated);
            Assert.AreEqual(_testData.RecipeVersionData.DateModified, createdResult.Content.DateModified);
            Assert.AreEqual(_testData.RecipeVersionData.Notes, createdResult.Content.Notes);
        }

        [TestMethod]
        public async Task DeleteRecipeVersion_Returns_Ok()
        {
            // Arrange
            var mockRepository = new Mock<IRecipeVersionsRepository>();
            var controller = new RecipeVersionsController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = await controller.DeleteRecipeVersion(10);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }

        [TestMethod]
        public async Task DeleteAllRecipeVersions_Returns_Ok()
        {
            // Arrange
            var mockRepository = new Mock<IRecipeVersionsRepository>();
            var controller = new RecipeVersionsController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = await controller.DeleteAllRecipeVersions(1);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }
    }
}