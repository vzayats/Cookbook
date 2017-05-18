(function() {
    "use strict";

    angular
        .module("recipesApp")
        .factory("RecipesService", RecipesService);

    RecipesService.$inject = ["$http"];

    function RecipesService($http) {

        var service = {
            getRecipesContent: getRecipesContent,
            deleteRecipePermanently: deleteRecipePermanently,
            deleteAllRecipeVersions: deleteAllRecipeVersions
        };

        //Get recipes
        function getRecipesContent() {
            return $http.get("/api/Recipes/")
                .then(function(response) {
                    return response.data;
                })
                .catch(function() {
                    console.log("Error while retrieving recipes!");
                });
        };

        //Delete recipe
        function deleteRecipePermanently(id) {
            return $http.delete("/api/Recipes/DeleteRecipe/" + id)
                .then(function(response) {
                    return response.data;
                })
                .catch(function() {
                    console.log("Error when deleting recipe!");
                });
        };

        //Delete all recipe versions
        function deleteAllRecipeVersions(id) {
            return $http.delete("/api/RecipeVersions/DeleteAllRecipeVersions/" + id)
                .then(function(response) {
                    return response.data;
                })
                .catch(function() {
                    console.log("Error when deleting all recipe versions!");
                });
        };

        return service;
    }
})();