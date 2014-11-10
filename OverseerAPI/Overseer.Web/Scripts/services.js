'use strict';

// Demonstrate how to register services
// In this case it is a simple value service.

var authService = angular.module('app.services', []);
    authService.service('AuthService', [
        '$http', '$q', function($http, $q) {

            this.login = function (credentials) {
                var deferred = $q.defer();
                $http({
                    url: 'http://localhost:53874' + '/api/Account/Token',
                    method: 'POST',
                    params: {

                    },
                    data: {
                        credentials: credentials,
                    },
                    dataType: "json",
                    headers: { 'Content-Type': 'application/json' }
                }).success(function(data) {
                    deferred.resolve(data);
                }).error(function() {
                    deferred.reject("Fel inträffade vid hämtning av order");
                });

                return deferred.promise;
            };
        }]);