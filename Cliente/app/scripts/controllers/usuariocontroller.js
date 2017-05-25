'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:UsuariocontrollerCtrl
 * @description
 * # UsuariocontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('UsuariocontrollerCtrl', function ($scope, usuarioService, $rootScope) {
    $rootScope.usuarioOn = false;
    $rootScope.usuarioOff = true;

    $scope.registrar = function (usuario) {
      usuarioService.registrarUsuario(createUser(usuario))
        .then(function (vals) {
          // aca iria el usuario
        }, function (error) {
          console.error("Error", error)
        })
    };
    $scope.loguear = function () {
      usuarioService.getUsuario($scope.email, $scope.password)
        .then(function (vals) {
          $rootScope.usuario = vals.data;
          $rootScope.usuarioOn = true;
          $rootScope.usuarioOff = false;
        }, function (error) {
          console.error("Error", error)
        })

    };

    $scope.cerrarSesion = function () {
      $rootScope.usuario = {};
      $rootScope.usuarioOn = false;
      $rootScope.usuarioOff = true;
    };

    function createUser(usuario) {
      var usuario = {
        Nombre: usuario.nombre,
        Email: usuario.email,
        Apellido: usuario.apellido,
        Password: usuario.password,
        Telefono: usuario.telefono,
        Avatar: usuario.avatar,
      };
      return usuario;
    };

    $scope.add = function () {
      var f = document.getElementById('file').files[0],
        r = new FileReader();

      r.onloadend = function (e) {
        var data = e.target.result;
        //send your binary data via $http or $resource or do anything else with it
      }

      r.readAsBinaryString(f);
    }


  })