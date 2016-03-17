var myApp = angular.module('myApp', []);
var url ='Api/Homes/'

myApp.controller('homeCtrl', function ($scope,$http) {
    $scope.test = "hllo";

    $http.get(url).success(function (resp) {
        $scope.users = resp;;
        console.log(resp);

    });
});