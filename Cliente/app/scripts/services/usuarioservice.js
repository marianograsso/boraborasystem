'use strict';

/**
 * @ngdoc service
 * @name clienteApp.usuarioService
 * @description
 * # usuarioService
 * Service in the clienteApp.
 */
angular.module('clienteApp')
  .service('usuarioService', function ($http) {
    var url = 'http://localhost:57875/api/usuario';
    var service = {};
    service.registrarUsuario = function(usuario){
      var result = $http.post(url, usuario);
      return result;
    }
    service.getUsuario = function(email, password){
      return $http.get(url + "/" + email + "/" + password);
    }
    service.deleteUsuario = function(usuario){
      return $http.delete(url + "/" + usuario.id);
    }
    service.updateUsuario = function(usuario){
      return $http.put(url + "/" + usuario.id, usuario);
    }
    return service;
  });
