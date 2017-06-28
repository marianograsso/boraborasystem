'use strict';

/**
 * @ngdoc service
 * @name clienteApp.ofertaservice
 * @description
 * # ofertaservice
 * Service in the clienteApp.
 */
angular.module('clienteApp')
  .service('ofertaservice', function ($http) {
    var url = 'http://localhost:57875/api/oferta';
    var service = {};

    service.registrarOferta = function (oferta) {
      var result = $http.post(url, oferta);
      return result;
    }

    return service;
  });
