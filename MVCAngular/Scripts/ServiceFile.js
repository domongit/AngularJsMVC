myApp.service('surveyService', function ($http) {
    this.SelectAll = function () {
        return $http.get(ROOT + url);
    };

    this.AddUser = function (user) {
        return $http.post(ROOT + url, user)
    };

    this.UpdateUser = function (user) {
        return $http.put(ROOT + url, user)
    }

    this.DeleteUser = function (id) {
        return $http.delete(ROOT + url + id)
    }

});



myApp.controller('homeCtrl', function ($scope, $http, user, surveyService) {

    $scope.GetUsers = function () {
        //$http.get(ROOT + url).success(function (resp) {
        //    $scope.users = resp;
        //    $scope.newUser = new user();
        //    $scope.newUser.FirstName = '';
        //    $scope.newUser.LastName = '';
        //    $scope.newUser.Id = '';
        //});
        surveyService.SelectAll().success(function (resp) {
            $scope.users = resp;
            $scope.newUser = new user();
            $scope.newUser.FirstName = '';
            $scope.newUser.LastName = '';
            $scope.newUser.Id = '';
        });

    };

    $scope.GetUsers();

    $scope.AddUserModal = function () {
        $scope.newUser = new user();

        $scope.newUser.FirstName = '';
        $scope.newUser.LastName = '';
        $scope.newUser.Id = '';
        $('#myModal').modal("show");
    }

    $scope.AddUser = function () {
        if ($scope.newUser.Id > 0) {

            surveyService.UpdateUser($scope.newUser).success(function (response) {
                $scope.GetUsers();
                $('#myModal').modal("hide");
            });
        }
        else {
            surveyService.AddUser($scope.newUser).success(function (response) {
                $scope.GetUsers();
                $('#myModal').modal("hide");
            });
        }
    }

    $scope.EditUser = function (id) {

        $scope.newUser = angular.copy($scope.users[id]);
        console.log($scope.newUser);
        $('#myModal').modal("show");
    };

    $scope.DeleteUser = function (id) {
        var id = $scope.users[id].Id;
        surveyService.DeleteUser(id).success(function (response) {
            $scope.GetUsers();
            $('#myModal').modal("hide");
        });
    }
});


myApp.controller('testCtrl', function ($scope) {
    $scope.TestValue = function () {
        return "I am here";
    };

});