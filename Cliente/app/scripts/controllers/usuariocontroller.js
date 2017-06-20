'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:UsuariocontrollerCtrl
 * @description
 * # UsuariocontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('UsuariocontrollerCtrl', function ($scope, usuarioService, $rootScope, $window) {
    $scope.error = false;
    $rootScope.usuarioOn = false;
    $rootScope.usuarioOff = true;

    $scope.registrar = function (usuario) {
      usuarioService.validateEmail(usuario.email).then(function (vals) {
        var txt = vals;
        if (vals.data == "Usuario registrado con exito") {
          usuario.credito = 0;
          usuarioService.registrarUsuario(createUser(usuario))
            .then(function (vals) {
              $window.location.href = "#!/";
            })
        }
        else {
          $scope.errormessage = vals.data;
          $scope.error = true;
        }
      })
    };


    $scope.loguear = function () {
      usuarioService.getUsuario($scope.email, $scope.password)
        .then(function (vals) {
          if (vals.data == "") {
            alert("Usuario o contraseña no válido");
            sleep(1000);
          }
          else {
            $rootScope.usuario = vals.data;
            $rootScope.usuarioOn = true;
            $rootScope.usuarioOff = false;
            $rootScope.emailOriginal = $rootScope.usuario.email;
            $window.location.href = "#!/";
          }

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
        Credito: usuario.credito,
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
    };


  })