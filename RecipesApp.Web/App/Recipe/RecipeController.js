(function() {
    "use strict";

    angular.module("recipesApp")
        .controller("RecipeController", RecipeController);

    RecipeController.$inject = [
        "RecipeService", "$scope", "$http", "toastr", "$window", "$stateParams", "$state", "$uibModal", "$timeout"
    ];

    function RecipeController(recipeService,
        $scope,
        $http,
        toastr,
        $window,
        $stateParams,
        $state,
        $uibModal,
        $timeout) {
        var vm = this;

        vm.getRecipe = getRecipe;
        vm.getRecipeVersions = getRecipeVersions;
        vm.editRecipe = editRecipe;
        vm.removeRecipe = removeRecipe;
        vm.removeRecipeVersion = removeRecipeVersion;

        vm.recipes = [];
        vm.recipeVersions = [];

        $window.document.title = "Recipe - Cookbook";

        activate();

        function activate() {
            getRecipe();
            getRecipeVersions();
        }

        //Load recipe
        function getRecipe() {
            recipeService.getRecipeContent($stateParams.Id)
                .then(function(data) {
                    vm.recipes = data;
                });
        }

        //Load recipe versions
        function getRecipeVersions() {
            recipeService.getRecipeVersions($stateParams.Id)
                .then(function(data) {
                    vm.recipeVersions = data;
                });
        }

        //Edit recipe
        function editRecipe(size, id) {
            var modalInstance = $uibModal.open({
                animation: true,
                templateUrl: "/App/Recipes/Create/EditReceipe.html",
                windowTemplateUrl: "App/Recipes/Modal.html",
                controller: "CreateReceipeController",
                controllerAs: "createReceipeCtrl",
                keyboard: true,
                size: size,
                resolve: {
                    items: function() {
                        return id;
                    },
                    parentvm: vm
                }
            });
            modalInstance.result.then(function() {
                $timeout(function() {
                        getRecipe();
                        getRecipeVersions();
                    },
                    1000);
            });
        }

        //Remove recipe
        function removeRecipe(id) {
            swal({
                    title: "Deleting recipe!",
                    text: "Are you sure that you want to delete a recipe?",
                    type: "warning",
                    showCancelButton: true,
                    confirmButtonColor: "#DD6B55",
                    confirmButtonText: "Yes, delete it!",
                    closeOnConfirm: false
                },
                function() {
                    recipeService.deleteAllRecipeVersions(id)
                        .then(function() {
                            recipeService.deleteRecipePermanently(id);
                            $state.go("Recipes");
                            swal({
                                title: "Deleted!",
                                text: "Recipe deleted successfully",
                                timer: 2000,
                                showConfirmButton: false,
                                type: "success"
                            });
                        });
                });
        }

        //Remove recipe version
        function removeRecipeVersion(id) {
            swal({
                    title: "Deleting recipe version!",
                    text: "Are you sure that you want to delete a recipe version?",
                    type: "warning",
                    showCancelButton: true,
                    confirmButtonColor: "#DD6B55",
                    confirmButtonText: "Yes, delete it!",
                    closeOnConfirm: false
                },
                function() {
                    recipeService.deleteRecipeVersion(id)
                        .then(function() {
                            getRecipeVersions();
                            swal({
                                title: "Deleted!",
                                text: "Recipe version deleted successfully",
                                timer: 2000,
                                showConfirmButton: false,
                                type: "success"
                            });
                        });

                });
        }
    }
}());