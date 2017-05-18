(function() {
    "use strict";

    angular
        .module("recipesApp")
        .factory("VersionService", VersionService);

    VersionService.$inject = ["$http"];

    function VersionService($http) {

        var service = {
            getRecipeVersion: getRecipeVersion,
            deleteRecipeVersion: deleteRecipeVersion
        };

        //Get recipe version
        function getRecipeVersion(id) {
            return $http.get("/api/RecipeVersions/GetRecipeVersion/" + id)
                .then(function(response) {
                    return response.data;
                })
                .catch(function() {
                    console.log("Error while retrieving recipe version!");
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

        return service;
    }
})();