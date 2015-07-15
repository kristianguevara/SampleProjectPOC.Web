app.controller('homeController', ['$scope', 'homeService', function ($scope, service) {
    $scope.message = "Welcome to the home page!";

    $scope.login = function()
    {
        var asd = service.login($scope.username, $scope.password);
        console.log(asd);
    }
}]);