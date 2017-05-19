'use strict';

/**
 * @ngdoc service
 * @name clienteApp.gauchadaservice
 * @description
 * # gauchadaservice
 * Service in the clienteApp.
 */
angular.module('clienteApp')
  .service('gauchadaservice', function () {
    var url = 'http://localhost:57875/api/gauchada';
    var service = {};
    service.registrarGauchada = function(gauchada){
      var result = $http.post(url, gauchada);
      return result;
    }
    service.getGauchada = function(){
      return $http.get(url + "/" + gauchada.id);
    }
    service.deleteGauchada = function(gauchada){
      return $http.delete(url + "/" + gauchada.id);
    }
    service.updateGauchada = function(gauchada){
      return $http.put(url + "/" + gauchada.id, gauchada);
    }
    return service;
  });
