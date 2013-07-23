function HomeCtrl($scope, Customer) {
    $scope.load = function () {
        Customer.get({ Id: 1, format: 'json' });
        Customer.save({Name:'test'});
    };
}

HomeCtrl.$inject = ['$scope','Customer'];