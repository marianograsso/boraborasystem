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

    service.getByStart = function(start){
      return $http.get(url + start);
    }

    service.getAll = function (){
      return $http.get(url);
    }

    service.updateCategoria = function (categoria) {
      return $http.put(url + categoria.id, categoria);
    }

    service.borrarCategoria = function (categoria){
      return $http.delete(url + categoria.id)
    }

    return service;
  });
