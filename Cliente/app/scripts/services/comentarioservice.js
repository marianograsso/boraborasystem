'use strict';

/**
 * @ngdoc service
 * @name clienteApp.comentarioservice
 * @description
 * # comentarioservice
 * Service in the clienteApp.
 */
angular.module('clienteApp')
  .service('comentarioservice', function ($http) {
    var url = 'http://localhost:57875/api/comentario';
    var service = {};

    service.publicarComentario = function (comentario){
      return $http.post(url, comentario)
    }

    service.getAll = function (id){
      return $http.get(url + "/" + id)
    }

    service.publicarRespuesta = function (comentario) {
      return $http.put(url + "/" + comentario.id, comentario);
    }

    return service;
    
  });
