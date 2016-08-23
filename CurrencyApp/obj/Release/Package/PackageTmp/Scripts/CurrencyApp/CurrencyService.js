CurrencyApp.factory('CurrencyService', ['$http', function ($http) {

    var CurrencyService = {};

    CurrencyService.getCurrency = function (requestedDate) {
        return $http({
            url: '/api/Currency',
            method: 'GET',
            params: { date: requestedDate }
        });
    }
    return CurrencyService;

}]);