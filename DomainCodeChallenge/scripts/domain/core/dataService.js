(function () {
    'use strict';

    angular
        .module('domain.core')
        .factory('domainService', domainService);

    function domainService($http) {

        return {
            isPropertyMatch: function (param) {
                return $http.post('/api/propertymatcher/ismatch', param);
            }
        };
    }
})();