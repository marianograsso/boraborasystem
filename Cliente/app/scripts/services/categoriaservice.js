'use strict';

/**
 * @ngdoc service
 * @name clienteApp.categoriaservice
 * @description
 * # categoriaservice
 * Service in the clienteApp.
 */
angular.module('clienteApp')
  .service('categoriaservice', function ($http) {
    var url = 'http://localhost:57875/api/categoria/';
    var service = {};

    service.registrarCategoria = function (categoria){
      return $http.post(url, categoria)
    }

    service.getAll = function (){
      return $http.get(url);
    }

    return service;
  });
