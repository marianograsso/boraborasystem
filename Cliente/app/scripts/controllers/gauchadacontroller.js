'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:GauchadacontrollerCtrl
 * @description
 * # GauchadacontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('GauchadacontrollerCtrl', function ($scope, $rootScope, gauchadaservice, $window) {
    $scope.gauchada = {};
    $scope.errormessage = "";
    $scope.error = false;
    $scope.fecha = new Date();
    gauchadaservice.getAll().then(function (vals) {
      $scope.gauchadas = vals.data
    });


    $scope.ver = function () {
      $scope.tituloAct = $scope.gauchadas.titulo;
      $scope.descAct = $scope.gauchadas.descAct;
      $window.location.href = "http://localhost:9000/#!/gauchada";

    }
    $scope.publicarGauchada = function (gauchada) {
      if ($scope.gauchada.fechalimite < $scope.fecha) {
        $scope.error = true;
        $scope.errormessage = "La fecha tiene que ser mayor o igual a la de hoy";
      }
      else {
        $scope.gauchada.ActorId = null;
        $scope.gauchada.AutorId = $rootScope.usuario.id;
        $scope.gauchada.FechaInicio = new Date();
        $scope.gauchada.FechaFin = $scope.gauchada.fechalimite.toUTCString();
        gauchadaservice.registrarGauchada($scope.gauchada)
          .then(function (vals) {
            $window.location.href = "#!/";
          })
      }
    };

  });
