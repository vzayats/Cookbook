(function() {
    'use strict';

    angular
        .module('recipesApp')
        .factory('CreateReceipeService', CreateReceipeService);

    CreateReceipeService.$inject = ['$http', 'toastr'];

    function CreateReceipeService($http, toastr) {
        var service = {
            getRecipeById: getRecipeById,
            save: save,
            saveVersion: saveVersion,
            createRecipe: createRecipe
        };

        //Get recipe for editing
        function getRecipeById(id, callback) {
            $http.get('/api/Recipes/GetRecipe/' + id)
                .then(function(response) {
                        if (callback) {
                            callback(response.data);
                        }
                    },
                    function() {
                        console.log('Error while getting role by ID!');
                    });
        }

        //Create recipe
        function createRecipe(recipeData) {
            return $http.post("/api/Recipes/PostRecipe", recipeData)
                .then(function(response) {
                    return response.data;
                })
                .catch(function() {
                    console.log("Error while creating new recipe!");
                });
        };

        //Edit recipe
        function save(data) {
            $http.put("/api/Recipes/PutRecipe/", data)
                .then(function(response) {
                    toastr.success(
                        "Recipe was successfully edited!",
                        "Edit recipe",
                        {
                            closeButton: true,
                            timeOut: 5000
                        });
                    return response.data;
                })
                .catch(function() {
                    console.log("Error while editing recipe!");
                });
        }

        //Save recipe version
        function saveVersion(id, recipeData) {
            return $http.post("/api/RecipeVersions/PostRecipeVersion/" + id, recipeData)
                .then(function(response) {
                    return response.data;
                })
                .catch(function() {
                    console.log("Error while saving receipe version!");
                });
        };

        return service;
    }
})();