CurrencyApp.directive('datePicker', function () {
    return {
        restrict: 'A',
        require: 'ngModel',
        link: function (scope, element, attrs, ngModelCtrl) {
            scope.selectedDate = '2012/01/01';
            console.log('link');
            $(element).datepicker({
                dateFormat: 'yy/mm/dd',
                maxDate: '2014/12/31',
                onSelect: function (date) {
                    scope.selectedDate = date;
                    scope.$apply();
                }
            });
        }
    };
});