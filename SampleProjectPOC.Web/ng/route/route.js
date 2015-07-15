app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider.
        when('/login', {
            templateUrl: '../ng/views/login.html',
            controller: 'homeController'
        }).
        otherwise({
            redirectTo: '/',
            templateUrl: '../ng/views/index.html',
            controller: 'homeController'
        });

    // use the HTML5 History API
    $locationProvider.html5Mode(true);
}]);