'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:PerfilcontrollerCtrl
 * @description
 * # PerfilcontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('PerfilcontrollerCtrl', function ($scope, usuarioService, $rootScope, $window) {

    $scope.verUsuario = function (usuarioId) {
      usuarioService.getUsuarioActual(usuarioId)
        .then(function (vals) {
          $rootScope.usuarioActual = vals.data;
        })
    }

  });
