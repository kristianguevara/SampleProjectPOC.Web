app.service('homeService', ['$http', function ($http) {
    var baseUrl = "http://localhost:4363/api";


    var login = function (username, password) {
        $http({
            method: 'POST', url: baseUrl + '/login', headers: { 'Content-Type': 'application/json' },
            data: { username: username, password: password }
        }).
          success(function (data, status, headers, config) {
              console.log("success");
              console.log(data);
          }).
          error(function (data, status, headers, config) {
              console.log("error");
              console.log(data);
          });
    }

    return{
        login: function (username, password) { login(username, password); }
    }
}]);