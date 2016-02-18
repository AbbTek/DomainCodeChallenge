(function () {
    'use strict';

    angular
       .module('domain.matcher')
       .controller('matcherController', matcherController);

    function matcherController($scope, $timeout, domainService) {
        $scope.databaseProperty = {
            Name: "Super ­High APARTMENTS, Sydney",
            Address: "32 Sir John­ Young Crescent, Sydney, NSW.",
            AgencyCode: "ER3344522",
            Latitude: -33.9014586,
            Longitude: 151.206287
        };

        $scope.agencyProperty = {
            Name: "*Super *­High! APARTMENTS(Sydney)",
            Address: "32 Sir John­-Young-Crescent, Sydney, NSW.",
            AgencyCode: "ER3344522",
            Latitude: -33.901191,
            Longitude: 151.207628
        };

        $scope.provider = "OTBRE";
        $scope.init = false;
        $scope.isMatch = false;

        $scope.compere = function () {
            domainService.isPropertyMatch({
                DatabaseProperty: $scope.databaseProperty,
                AgencyProperty: $scope.agencyProperty,
                Provider: $scope.provider
            }).then(function (result) {
                $scope.init = true;
                $scope.isMatch = result.data;
                $timeout(function () {
                    $scope.init = false;
                }, 2000);
                //console.info("Service", result);
            });
        };
    }
})();