(function() {
    "use strict";

    angular.module("recipesApp")
        .controller("RecipesController", RecipesController);

    RecipesController.$inject = ["RecipesService", "$scope", "$http", "toastr", "$window", "$uibModal", "$timeout"];

    function RecipesController(recipesService, $scope, $http, toastr, $window, $uibModal, $timeout) {
        var vm = this;

        vm.getRecipes = getRecipes;
        vm.createRecipe = createRecipe;
        vm.editRecipe = editRecipe;
        vm.removeRecipe = removeRecipe;
        vm.search = search;
        vm.cancelSearch = cancelSearch;

        vm.recipes = [];
        vm.data = vm.recipes.slice(0, 20);

        vm.searchText = "";
        vm.recipesFilter = "";

        $window.document.title = "Recipes - Cookbook";

        activate();

        function activate() {
            getRecipes();
        }

        //Load recipes (dynamic loading)
        function getRecipes() {
            recipesService.getRecipesContent()
                .then(function(data) {
                    vm.data = data.slice(0, vm.data.length + 3);
                });
        }

        //Create new recipe
        function createRecipe(size) {
            var modalInstance = $uibModal.open({
                animation: true,
                templateUrl: "/App/Recipes/Create/CreateRecipe.html",
                windowTemplateUrl: "App/Recipes/Modal.html",
                controller: "CreateReceipeController",
                controllerAs: "createReceipeCtrl",
                keyboard: true,
                size: size,
                resolve: {
                    items: function() {
                    },
                    parentvm: vm
                }
            });
            modalInstance.result.then(function() {
                getRecipes();
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
                        getRecipes();
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
                    recipesService.deleteAllRecipeVersions(id)
                        .then(function() {
                            recipesService.deleteRecipePermanently(id)
                                .then(function() {
                                    getRecipes();
                                    swal({
                                        title: "Deleted!",
                                        text: "Recipe deleted successfully",
                                        timer: 2000,
                                        showConfirmButton: false,
                                        type: "success"
                                    });
                                });
                        });
                });
        }

        //Search recipe
        function search() {
            if (vm.searchText.length >= 1) {
                vm.recipesFilter = vm.searchText;
            } else {
                getRecipes();
            }
        }

        //Clear search form
        function cancelSearch() {
            if (vm.searchText.length >= 1) {
                vm.searchText = "";
                vm.recipesFilter = "";
                getRecipes();
            }
        }
    }
}());