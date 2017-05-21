'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:GauchadacontrollerCtrl
 * @description
 * # GauchadacontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('GauchadacontrollerCtrl', function ($scope, gauchadaservice) {
    $scope.registrar = function(){
      usuarioService.registrarUsuario($scope.usuario)
      .then(function(vals){
      }, function (error){
        console.error("Error", error)
      })
    }
  });
