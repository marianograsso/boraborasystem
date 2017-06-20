'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:GauchadacontrollerCtrl
 * @description
 * # GauchadacontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('GauchadacontrollerCtrl', function ($scope, $rootScope, gauchadaservice, $window, usuarioService) {
    $rootScope.usuarioActual = {};
    $rootScope.gauchadaActual = {};
    $scope.gauchada = {};
    $scope.errormessage = "";
    $scope.error = false;
    $scope.fecha = new Date();
    gauchadaservice.getAll().then(function (vals) {
      $scope.gauchadas = vals.data
    });

    $scope.publicarGauchada = function (gauchada) {
      if ($scope.gauchada.FechaFin < $scope.fecha) {
        $scope.error = true;
        $scope.errormessage = "La fecha tiene que ser mayor o igual a la de hoy";
      }
      else {
        if ($rootScope.usuario.credito < 1) {
          $scope.error = true;
          $scope.errormessage = "Creditos insuficientes";
        }
        else {
          var x = document.getElementById("myFile")
          if (x.value === ""){
            $scope.gauchada.Imagen = "images/avatar.png"
          }
          else{
            $scope.gauchada.Imagen = x.value;
          }
          
          $rootScope.usuario.credito = $rootScope.usuario.credito - 1;
          $scope.gauchada.AutorId = $rootScope.usuario.id;
          $scope.gauchada.Autor = $rootScope.usuario.nombre;
          $scope.gauchada.FechaInicio = new Date();
          gauchadaservice.registrarGauchada($scope.gauchada)
            .then(function (vals) {
              $window.location.href = "#!/";
            })
          
        }
      }
    };

    $scope.verGauchada = function (gauchada){
      gauchadaservice.getGauchada(gauchada)
            .then(function (vals) {
              $rootScope.gauchadaActual = vals.data;
            })
    };

    $scope.verPibe = function (usuarioId) {
      if ($rootScope.usuarioOn == false){
        alert("Se debe estar logueado para ver el perfil de un usuario!");
      }
      else {
      usuarioService.getUsuarioActual(usuarioId)
        .then(function (vals) {
          $rootScope.usuarioActual = vals.data;
          $window.location.href = "#!/perfil"
        })
      }  
    }
  });
