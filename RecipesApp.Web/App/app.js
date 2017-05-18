angular.module("recipesApp",
        [
            "ui.router", "toastr", "angular.filter", "angular-loading-bar", "ngAnimate", "infinite-scroll", "ui.bootstrap"
        ])
    .config([
        "$stateProvider", "$urlRouterProvider",
        function($stateProvider, $urlRouterProvider) {

            $stateProvider
                .state("Recipes", // All recipes page
                    {
                        url: "/",
                        templateUrl: "/App/Recipes/Recipes.html",
                        controller: "RecipesController",
                        controllerAs: "recipesCtrl"
                    })
                .state("Recipe", // Recipe page
                    {
                        url: "/Recipe/:Id",
                        templateUrl: "/App/Recipe/Recipe.html",
                        controller: "RecipeController",
                        controllerAs: "recipeCtrl"
                    })
                .state("RecipeVersion", // Recipe version page
                    {
                        url: "/RecipeVersion/:Id",
                        templateUrl: "/App/RecipeVersion/Version.html",
                        controller: "VersionController",
                        controllerAs: "versionCtrl"
                    })
                .state("Error", //Error page
                    {
                        url: "/Error",
                        templateUrl: "/App/Error/Error.html",
                        controller: "ErrorController",
                        controllerAs: "errorCtrl"
                    });

            //This is when any route not matched
            $urlRouterProvider.otherwise("/");
        }
    ]);