'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:AdmincontrollerCtrl
 * @description
 * # AdmincontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('AdmincontrollerCtrl', function ($scope, $rootScope, categoriaservice, $window) {
    $scope.categorias = {};
    $scope.categoriaNueva = {};

    categoriaservice.getAll().then(function (vals) {
      $scope.categorias = vals.data;
    });


    $scope.agregarCategoria = function (categoria) {
      categoriaservice.registrarCategoria(categoria).then(
        function (vals) {
          $scope.categorias.push(vals.data);
        },
        function (vals) {
          alert("Los datos ingresados ya estan usados para una categoria");
        }
      )
    }

  });
