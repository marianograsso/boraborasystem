'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:ComentarioscontrollerCtrl
 * @description
 * # ComentarioscontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('ComentarioscontrollerCtrl', function ($scope, $rootScope, comentarioservice) {
    $scope.comentarios = {};
    comentarioservice.getAll($rootScope.gauchadaActual.id).then(function (vals) {
        $scope.comentarios = vals.data;
      })
  });
