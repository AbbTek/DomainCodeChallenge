(function () {
    'use strict';

    angular
       .module('domain.matcher')
       .controller('matcherController', matcherController);

    function matcherController($scope, $timeout, $log, domainService) {
        $scope.databaseProperty = {
            Name: "Super ­High APARTMENTS, Sydney",
            Address: "32 Sir John­ Young Crescent, Sydney, NSW.",
            AgencyCode: "ER3344522",
            Latitude: -33.9014586,
            Longitude: 151.206287,
            map: {
                center: {
                    latitude: -33.9014586,
                    longitude: 151.206287
                },
                zoom: 15
            },
            marker: {
                id: 0,
                coords: {
                    latitude: -33.9014586,
                    longitude: 151.206287
                },
                options: { draggable: true },
                events: {
                    dragend: function (marker, eventName, args) {
                        $log.log('marker dragend');
                        var lat = marker.getPosition().lat();
                        var lon = marker.getPosition().lng();
                        $log.log(lat);
                        $log.log(lon);
                        $scope.databaseProperty.Latitude = lat;
                        $scope.databaseProperty.Longitude = lon;
                    }
                }
            }
        };

        $scope.agencyProperty = {
            Name: "*Super *­High! APARTMENTS(Sydney)",
            Address: "32 Sir John­-Young-Crescent, Sydney, NSW.",
            AgencyCode: "ER3344522",
            Latitude: -33.901191,
            Longitude: 151.207628,
            map: {
                center: {
                    latitude: -33.901191,
                    longitude: 151.207628
                },
                zoom: 15
            },
            marker: {
                id: 0,
                coords: {
                    latitude: -33.901191,
                    longitude: 151.207628
                },
                options: { draggable: true },
                events: {
                    dragend: function (marker, eventName, args) {
                        $log.log('marker dragend');
                        var lat = marker.getPosition().lat();
                        var lon = marker.getPosition().lng();
                        $log.log(lat);
                        $log.log(lon);
                        $scope.agencyProperty.Latitude = lat;
                        $scope.agencyProperty.Longitude = lon;
                    }
                }
            }
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