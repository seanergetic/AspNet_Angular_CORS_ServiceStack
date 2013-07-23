var app = angular.module('app', ['ngResource']);
app.factory('Customer', ['$resource', function($resource) {
    var url = 'http\\://localhost\\:1333/customer/:Id';
    return $resource(url,
        { Id: '@Id' },
        {
            get :{method: 'GET'}
        });
}]);