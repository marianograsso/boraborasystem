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
    };

    $scope.editarUsuario = function (usuario) {
      if ($rootScope.emailOriginal == usuario.email) {
        usuarioService.updateUsuario(usuario)
          .then(function (vals) {
            usuarioService.getUsuarioActual(usuario.id)
              .then(function (vals) {
                $rootScope.usuarioActual = vals.data;
              })
            $window.location.href = "#!/perfil";
          })
      }
      else {
        usuarioService.validateEmail(usuario.email).then(function (vals) {
          var txt = vals;
          if (vals.data == "Usuario registrado con exito") {
            usuarioService.updateUsuario(usuario)
              .then(function (vals) {
                usuarioService.getUsuarioActual(usuario.id)
                  .then(function (vals) {
                    $rootScope.usuarioActual = vals.data;
                  })
                $window.location.href = "#!/perfil";
              })
          }
          else {
            $scope.errormessage = vals.data;
            $scope.error = true;
          }
        })
      }
    };
  })
