'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:OfertascontrollerCtrl
 * @description
 * # OfertascontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('OfertascontrollerCtrl', function ($scope, ofertaservice, $rootScope, $window) {
    $scope.error = false;

    $scope.publicarOferta = function (oferta) {
     ofertaservice.validateOffer(usuario.id, $rootScope.gauchadaActual.id).then(function (vals) {
        var txt = vals;
        if (vals.data == "Usuario registrado con exito") {
          $scope.oferta.Estado = 2;
          $scope.oferta.IdOfertador = $rootScope.usuario.id;
          $scope.oferta.GauchadaId = $rootScope.gauchadaActual.id;
          ofertaservice.registrarOferta(oferta)
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
  });
