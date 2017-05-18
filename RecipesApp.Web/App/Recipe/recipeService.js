(function() {
    "use strict";

    angular
        .module("recipesApp")
        .factory("RecipeService", RecipeService);

    RecipeService.$inject = ["$http"];

    function RecipeService($http) {

        var service = {
            getRecipeContent: getRecipeContent,
            getRecipeVersions: getRecipeVersions,
            deleteRecipePermanently: deleteRecipePermanently,
            deleteRecipeVersion: deleteRecipeVersion,
            deleteAllRecipeVersions: deleteAllRecipeVersions
        };

        //Get recipe
        function getRecipeContent(id) {
            return $http.get("/api/Recipes/GetRecipe/" + id)
                .then(function(response) {
                    return response.data;
                })
                .catch(function() {
                    console.log("Error while retrieving recipe!");
                });
        };

        //Get recipe versions
        function getRecipeVersions(id) {
            return $http.get("/api/RecipeVersions/GetRecipeVersions/" + id)
                .then(function(response) {
                    return response.data;
                })
                .catch(function() {
                    console.log("Error while retrieving recipe versions!");
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

        //Delete recipe version
        function deleteRecipeVersion(id) {
            return $http.delete("/api/RecipeVersions/DeleteRecipeVersion/" + id)
                .then(function(response) {
                    return response.data;
                })
                .catch(function() {
                    console.log("Error when deleting recipe version!");
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