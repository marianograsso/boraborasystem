'use strict';

/**
 * @ngdoc service
 * @name clienteApp.calificacionservice
 * @description
 * # calificacionservice
 * Service in the clienteApp.
 */
angular.module('clienteApp')
  .service('calificacionservice', function ($http) {
    var url = 'http://localhost:57875/api/calificacion';
    var service = {};

    service.publicarCalificacion = function (calificacion){
      return $http.post(url, calificacion)
    }

    service.getByIdCalificacion = function (id){
      return $http.get(url + "/" + id);
    }

    return service;
  });
