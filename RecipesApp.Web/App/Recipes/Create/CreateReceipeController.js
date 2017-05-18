(function() {
    "use strict";

    angular.module("recipesApp")
        .controller("CreateReceipeController", CreateReceipeController);

    CreateReceipeController.$inject = ["CreateReceipeService", "$uibModalInstance", "items", "$window", "toastr"];

    function CreateReceipeController(createReceipeService, $uibModalInstance, items, $window, toastr) {
        var vm = this;

        vm.createRecipe = createRecipe;
        vm.saveRecipe = saveRecipe;
        vm.cancel = cancel;

        vm.recipe = {};

        activate();

        function activate() {
            if (items !== undefined) {
                createReceipeService.getRecipeById(items,
                    function(data) {
                        vm.recipe = data;
                    });
            }
        }

        //Create new recipe
        function createRecipe() {
            createReceipeService.createRecipe(vm.recipe)
                .then(function() {
                    toastr.success(
                        "Recipe was successfully created!",
                        "New recipe",
                        {
                            closeButton: true,
                            timeOut: 5000
                        });
                    $uibModalInstance.close();
                });
        }

        //Save edited recipe
        function saveRecipe() {
            createReceipeService.save(vm.recipe);
            createReceipeService.saveVersion(items, vm.recipe);
            $uibModalInstance.close();
        }

        function cancel() {
            $uibModalInstance.dismiss("cancel");
        };
    }
}());