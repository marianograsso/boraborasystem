'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:OfertascontrollerCtrl
 * @description
 * # OfertascontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('OfertascontrollerCtrl', function ($scope, ofertaservice, $rootScope, $window, calificacionservice, gauchadaservice) {
    $scope.error = false;
    $scope.listaOfertas = {};
    $scope.listaGauchadas = {};


    $scope.publicarOferta = function (oferta) {
      ofertaservice.validateOffer($rootScope.usuario.id, $rootScope.gauchadaActual.id).then(function (vals) {
        var txt = vals;
        if (vals.data == "Usuario registrado con exito") {
          $scope.oferta.Estado = 2;
          $scope.oferta.IdOfertador = $rootScope.usuario.id;
          $scope.oferta.nombreOfertador = $rootScope.usuario.nombre;
          $scope.oferta.GauchadaId = $rootScope.gauchadaActual.id;
          ofertaservice.registrarOferta(oferta)
            .then(function (vals) {
              $window.location.href = "#!/";
            })
        }
        else {
          $scope.errormessage = "Ya ofertaste en esta gauchada";
          $scope.error = true;
        }
      })
    };

    $scope.setearFiltro = function (estado) {
      $scope.filter_estado = estado;
    }


    ofertaservice.getByIdOfertador($rootScope.usuario.id).then(function (vals) {
      $scope.listaOfertas = vals.data;
      gauchadaservice.getAllByAutor($rootScope.usuario.id).then(function (vals) {
        $scope.listaGauchadas = vals.data;  //esto se pone aca adentro porque si no error en el servidor 
      });
    });

    $scope.getCalificacion = function (calificacionid) {
      calificacionservice.getByIdCalificacion(calificacionid).then(function (vals) {
        $scope.calificacion = vals.data;
        if ($scope.calificacion.puntaje == 1) {
          alert("La califacion fue positiva");
        }
        else {
          if ($scope.calificacion.puntaje == 2) {
            alert("La califacion fue neutra");
          }
          else {
            if ($scope.calificacion.puntaje == 0) {
              alert("La califacion fue negativa");
            }
            else {
              alert("La oferta aun no está calificada");
            }
          }
        }
      });
    }

    //Aca se pone codigo que iria en perfil controller pero por varios motivos va aca

    $scope.verGauchada = function (gauchada) {
      gauchadaservice.getGauchada(gauchada)
        .then(function (vals) {
          $rootScope.gauchadaActual = vals.data;
          comentarioservice.getAll($rootScope.gauchadaActual.id).then(function (vals) {
            $rootScope.comentarios = vals.data;
          })
        })
    };

    $scope.setearFiltro = function (estado) {
      $scope.filter_estado = estado;
    }

  });
