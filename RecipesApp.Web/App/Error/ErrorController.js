(function() {
    "use strict";

    angular.module("recipesApp")
        .controller("ErrorController", ErrorController);

    ErrorController.$inject = ["$scope", "$window"];

    function ErrorController($scope, $window) {

        $window.document.title = "404 Error - Cookbook";
    }
}());