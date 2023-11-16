/// <reference path="angular.min.js"/>


let myApp = angular.module("myModule", []);

myApp.controller("myController", function ($scope) {

    let personA = {
        firstName: "Bob",
        lastName: "Jackson",
        Gender: "Male"
    }
    let personB = {
        firstName: "Sasuke",
        lastName: "Uchiha",
        Gender: "Male"
    }
    $scope.message = "Some angjs example";
    $scope.personA = personA;
    $scope.personB = personB;
});
