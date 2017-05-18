(function() {
    "use strict";

    angular.module("recipesApp")
        .controller("VersionController", VersionController);

    VersionController.$inject = [
        "VersionService", "$scope", "$http", "toastr", "$window", "$stateParams", "$state"
    ];

    function VersionController(versionService,
        $scope,
        $http,
        toastr,
        $window,
        $stateParams,
        $state) {
        var vm = this;

        vm.getRecipeVersion = getRecipeVersion;
        vm.removeRecipeVersion = removeRecipeVersion;

        vm.recipeVersion = [];

        $window.document.title = "Recipe version - Cookbook";

        activate();

        function activate() {
            getRecipeVersion();
        }

        //Load recipe version
        function getRecipeVersion() {
            versionService.getRecipeVersion($stateParams.Id)
                .then(function(data) {
                    vm.recipeVersion = data;
                });
        }

        //Remove recipe version
        function removeRecipeVersion(recipeId, id) {
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
                    versionService.deleteRecipeVersion(id)
                        .then(function() {
                            $state.go("Recipe", { Id: recipeId });
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