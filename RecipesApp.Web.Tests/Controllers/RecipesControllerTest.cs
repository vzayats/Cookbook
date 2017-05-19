using System.Linq;
using System.Net;
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
    public class RecipesControllerTest
    {
        private readonly TestData _testData = new TestData();

        [TestMethod]
        public void GetRecipes_Returns_OkNegotiatedContentResult()
        {
            // Arrange
            var mockRepository = new Mock<IRecipesRepository>();
            var controller = new RecipesController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.GetRecipes();

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<IQueryable<Recipe>>));
        }

        [TestMethod]
        public async Task GetRecipe_Returns_RecipeWithSameId()
        {
            // Arrange
            var mockRepository = new Mock<IRecipesRepository>();
            mockRepository.Setup(x => x.GetRecipe(1))
                .ReturnsAsync(_testData.RecipeData);

            var controller = new RecipesController(mockRepository.Object);

            // Act
            Task<IHttpActionResult> actionResult = controller.GetRecipe(1);
            var contentResult = await actionResult as OkNegotiatedContentResult<Recipe>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(1, contentResult.Content.Id);
        }

        [TestMethod]
        public async Task GetRecipe_Returns_RecipeWithSameContent()
        {
            // Arrange
            var mockRepository = new Mock<IRecipesRepository>();
            mockRepository.Setup(x => x.GetRecipe(1))
                .ReturnsAsync(_testData.RecipeData);

            var controller = new RecipesController(mockRepository.Object);

            // Act
            Task<IHttpActionResult> actionResult = controller.GetRecipe(1);
            var contentResult = await actionResult as OkNegotiatedContentResult<Recipe>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(_testData.RecipeData.Id, contentResult.Content.Id);
            Assert.AreEqual(_testData.RecipeData.Name, contentResult.Content.Name);
            Assert.AreEqual(_testData.RecipeData.Description, contentResult.Content.Description);
            Assert.AreEqual(_testData.RecipeData.Ingredients, contentResult.Content.Ingredients);
            Assert.AreEqual(_testData.RecipeData.Directions, contentResult.Content.Directions);
            Assert.AreEqual(_testData.RecipeData.Type, contentResult.Content.Type);
            Assert.AreEqual(_testData.RecipeData.ImageLink, contentResult.Content.ImageLink);
            Assert.AreEqual(_testData.RecipeData.DateCreated, contentResult.Content.DateCreated);
            Assert.AreEqual(_testData.RecipeData.Notes, contentResult.Content.Notes);
        }

        [TestMethod]
        public async Task PostRecipe_Sets_LocationHeader()
        {
            // Arrange
            var mockRepository = new Mock<IRecipesRepository>();
            var controller = new RecipesController(mockRepository.Object);

            // Act
            Task<IHttpActionResult> actionResult = controller.PostRecipe(_testData.RecipeData);
            var createdResult = await actionResult as CreatedAtRouteNegotiatedContentResult<Recipe>;

            // Assert
            Assert.IsNotNull(createdResult);
            Assert.AreEqual("DefaultApi", createdResult.RouteName);
            Assert.AreEqual(_testData.RecipeData.Id, createdResult.RouteValues["id"]);
        }

        [TestMethod]
        public async Task PostRecipe_Returns_CreatedResult()
        {
            // Arrange
            var mockRepository = new Mock<IRecipesRepository>();
            var controller = new RecipesController(mockRepository.Object);

            // Act
            Task<IHttpActionResult> actionResult = controller.PostRecipe(_testData.RecipeData);
            var createdResult = await actionResult as CreatedAtRouteNegotiatedContentResult<Recipe>;

            // Assert
            Assert.IsNotNull(createdResult);
            Assert.AreEqual(_testData.RecipeData.Id, createdResult.Content.Id);
            Assert.AreEqual(_testData.RecipeData.Name, createdResult.Content.Name);
            Assert.AreEqual(_testData.RecipeData.Description, createdResult.Content.Description);
            Assert.AreEqual(_testData.RecipeData.Ingredients, createdResult.Content.Ingredients);
            Assert.AreEqual(_testData.RecipeData.Directions, createdResult.Content.Directions);
            Assert.AreEqual(_testData.RecipeData.Type, createdResult.Content.Type);
            Assert.AreEqual(_testData.RecipeData.ImageLink, createdResult.Content.ImageLink);
            Assert.AreEqual(_testData.RecipeData.DateCreated, createdResult.Content.DateCreated);
            Assert.AreEqual(_testData.RecipeData.Notes, createdResult.Content.Notes);
        }

        [TestMethod]
        public async Task PutRecipe_Returns_StatusCode()
        {
            // Arrange
            var mockRepository = new Mock<IRecipesRepository>();
            var controller = new RecipesController(mockRepository.Object);

            // Act
            Task<IHttpActionResult> actionResult = controller.PutRecipe(_testData.RecipeData);
            var statusCode = await actionResult as StatusCodeResult;

            // Assert
            Assert.IsNotNull(statusCode);
            Assert.AreEqual(HttpStatusCode.NoContent, statusCode.StatusCode);
        }

        [TestMethod]
        public async Task DeleteRecipe_Returns_Ok()
        {
            // Arrange
            var mockRepository = new Mock<IRecipesRepository>();
            var controller = new RecipesController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = await controller.DeleteRecipe(10);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }
    }
}