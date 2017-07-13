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
    var url2 = 'http://localhost:57875/api/ofertas';
    var service = {};

    service.registrarOferta = function (oferta) {
      var result = $http.post(url, oferta);
      return result;
    }

    service.updateOferta = function (oferta) {
      return $http.put(url + "/" + oferta.id, oferta);
    }

    service.rechazarTodas = function (gauchadaId) {
      return $http.put(url2 + "/" + gauchadaId);
    }

    service.validateOffer = function (usuarioId, gauchadaId) {
      return $http.get(url + "/validatoffer/" + usuarioId + "/" + gauchadaId);
    }

    service.getByIdGuachada = function (id){
      return $http.get(url + "/" + id);
    }

    return service;
  });
