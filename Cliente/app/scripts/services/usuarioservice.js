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
    service.getUsuarioActual = function (usuarioId) {
      return $http.get(url + "/" + usuarioId);
    }
    service.deleteUsuario = function(usuario){
      return $http.delete(url + "/" + usuario.id);
    }
    service.updateUsuario = function(usuario){
      return $http.put(url + "/" + usuario.id, usuario);
    }
    service.validateEmail = function(email){
      return $http.get(url + "/validatemail/" + email);
    }
    service.getRanking = function(){
      return $http.get("http://localhost:57875/api/categoria/all/");
    }
    service.getCompras = function(){
      return $http.get("http://localhost:57875/api/compras/");
    }
    return service;
  });
