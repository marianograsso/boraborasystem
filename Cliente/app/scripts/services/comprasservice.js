'use strict';

/**
 * @ngdoc service
 * @name clienteApp.comprasService
 * @description
 * # comprasService
 * Service in the clienteApp.
 */
angular.module('clienteApp')
  .service('comprasService', function ($http) {
    var url = 'http://localhost:57875/api/compras';
    var service = {};

    service.comprar = function(compra){
      return $http.post(url, compra);
    }

    return service; 
  });
