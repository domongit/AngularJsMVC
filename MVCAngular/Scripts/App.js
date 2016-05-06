var myApp = angular.module('myApp', []);
var url ='Api/Homes/'

//myApp.controller('homeCtrl', function ($scope, $http) {
//    $scope.test = "hllo";


 

//  $scope.GetUsers = function () {
//      $http.get(url).success(function (resp) {
//          $scope.users = resp;
//          $scope.newUser = angular.copy($scope.users[0]);
//          $scope.newUser.FirstName = '';
//          $scope.newUser.LastName = '';
//          $scope.newUser.Id = '';
//      });

//  };

//  $scope.AddUserModal = function () {
//      alert('asdas');
//      $('#myModal').modal('show')

//  }

//    $scope.AddUser = function () {
//        $http.post(url, $scope.newUser).success(function (response) {
//            $scope.GetUsers();
//        });
//    }

//    //$http.post(url, $scope.users).success(function (response) {
//    //});

//    $scope.user = function () {
//        this.FirstName = '';
//        this.LastName = '';

//    };
//});

myApp.service('user', function () {
    this.firstName = '';
    this.lastName = '';
     
});
 
