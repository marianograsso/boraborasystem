'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:ComprascontrollerCtrl
 * @description
 * # ComprascontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('ComprascontrollerCtrl', function ($scope, $window, $rootScope, comprasService) {

    $scope.cantidad = 1;
    $scope.precio = 10;
    $scope.fecha = new Date();
    $scope.error = false;
    $scope.errormessage = "";

    $scope.comprar = function (cantidad) {
      $rootScope.cantidadFinal = Number (cantidad);
      $rootScope.precioFinal = cantidad * $scope.precio;
      $window.location.href = "#!/pagar";
    }

    function sleep(milliseconds) {
      var start = new Date().getTime();
      for (var i = 0; i < 1e7; i++) {
        if ((new Date().getTime() - start) > milliseconds) {
          break;
        }
      }
    }

    $scope.pagar = function (cantidadFinal, precioFinal) {
      $rootScope.usuario.credito = $rootScope.usuario.credito + cantidadFinal;
      var id = $rootScope.usuario.id;
      var compra = {
        CantCreditos: cantidadFinal,
        Precio: precioFinal,
        IdComprador: id,
        Fecha: new Date(),
      };
      if ($scope.pago.tarjeta != 6666666666666666) {
        comprasService.comprar(compra)
          .then(function (vals) {
            var status = vals.status;
            if (status == 200) {
              alert("Compra realizada con exito");
              sleep(3000);
              $window.location.href = "#!/";
            }
            else {
              alert("Faltan completar campos");
            }

          });
      }
      else {
        $scope.error = true;
        $scope.errormessage = "La tarjeta no tiene saldo suficiente para realizar la compra";
      }
    }
  });

