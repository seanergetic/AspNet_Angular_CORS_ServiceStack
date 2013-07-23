function HomeCtrl($scope, Customer) {
    $scope.load = function () {
        Customer.get({ Id: 1, format: 'json' },function (res) {
            alert(JSON.stringify(res));
        });
        Customer.save({Name:'test'},function (res) {
            alert(JSON.stringify(res));
        });
    };
}

HomeCtrl.$inject = ['$scope','Customer'];