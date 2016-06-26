var myApp = angular.module('myApp', []);
var url = 'Api/Homes/';

myApp.directive('customButton', function () {
    return {
        restrict: 'EAC', // Element ,Attribrute,Class
        link: function (scope, element, attrs) {
            //DOM manipulation comes here
        },
        template: "<button type='button' class='btn btn-primary '> Directive button </button>"

    };
})

myApp.directive('customManipulate', function () {
    return {
        restrict: 'EA', // Element ,Attribrute,Class
        link: function (scope, element, attrs) {
            element.bind("mouseenter", function () {
                element.html("you are here");
            });
            element.bind("mouseleave", function () {
                element.html("You are gone");
            });

        } 
    };
})
 
myApp.filter('titlecase', function () {
    return function (text) {
        if (text != "") {
            return text.charAt(0).toUpperCase() + text.substring(1);
        }
        else {
            return "";
        }
    };
});
myApp.factory('user', function () {
    var Q = function () {
        this.firstName = "";
        this.lastName = "";

    };
    return Q;
});
