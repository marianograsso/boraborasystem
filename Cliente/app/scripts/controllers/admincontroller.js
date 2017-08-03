'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:AdmincontrollerCtrl
 * @description
 * # AdmincontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('AdmincontrollerCtrl', function ($scope, $rootScope, categoriaservice, $window, usuarioService) {
    $scope.categorias = {};
    $scope.categoriaNueva = {};
    $scope.usuarios = {};
    $scope.comprasMensuales = {};

    categoriaservice.getAll().then(function (vals) {
      $scope.categorias = vals.data;
      usuarioService.getRanking().then(function (vals) {
        $scope.usuarios = vals.data;
        usuarioService.getCompras().then(function (vals) {
          $scope.comprasMensuales = vals.data;
        });
      });
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

    $scope.borrarActual = function (categoria) {
      categoriaservice.borrarCategoria(categoria).then(
        function (vals) {
          categoriaservice.getAll().then(function (vals) {
            $scope.categorias = vals.data;
            alert("La categoria fue borrada con exito");
          });

        }
      )
    }

    $scope.editarCategoria = function (categoria) {
      categoriaservice.updateCategoria(categoria).then(
        function (vals) {
          categoriaservice.getAll().then(function (vals) {
            $scope.categorias = vals.data;
          });
        },
        function (vals) {
          alert("Los datos ingresados ya estan usados para una categoria");
        }
      )
    }

    $scope.guardarActual = function (categoria) {
      $scope.categoriaActual = categoria;
    }

    $scope.vaciarActual = function () {
      $scope.categoriaActual = {};
    }



  });
