'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:GauchadacontrollerCtrl
 * @description
 * # GauchadacontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('GauchadacontrollerCtrl', function ($scope, $rootScope, gauchadaservice, $window, usuarioService, comentarioservice, ofertaservice, calificacionservice) {

    $scope.calificacion = {
      texto: "",
      puntaje: 0
    }
    $scope.ofertas = {};
    $scope.respuesta = {};
    $rootScope.usuarioActual = {};
    $rootScope.gauchadaActual = {};
    $scope.comentario = {};
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
          if (x.value === "") {
            $scope.gauchada.Imagen = "images/avatar.png"
          }
          else {
            $scope.gauchada.Imagen = x.value;
          }

          $rootScope.usuario.credito = $rootScope.usuario.credito - 1;
          $scope.gauchada.AutorId = $rootScope.usuario.id;
          $scope.gauchada.Estado = 2;
          $scope.gauchada.Autor = $rootScope.usuario.nombre;
          $scope.gauchada.FechaInicio = new Date();
          gauchadaservice.registrarGauchada($scope.gauchada)
            .then(function (vals) {
              $window.location.href = "#!/";
            })

        }
      }
    };

    $scope.editarGauchada = function () {
      if ($rootScope.gauchadaEdit.FechaFin < $scope.fecha) {
        alert("La gauchada no se puede editar porque ya caduco");
      }
      else {
        ofertaservice.getByIdGuachada($rootScope.gauchadaEdit.id).then(function (vals) {
          $scope.ofertas = vals.data
          if ($scope.ofertas != 0) {
            alert("La gauchada no se puede editar porque posee ofertas realizadas");
          }
          else {
            gauchadaservice.updateGauchada($rootScope.gauchadaEdit).then(function (vals) {
              $window.location.href = "#!/"
            });
          }
        });
      }
    }

    $scope.rechazarOferta = function (oferta) {
      oferta.estado = 0;
      ofertaservice.updateOferta(oferta).then(function (vals) {
        alert("La oferta ha sido rechazada con exito");
        $scope.verOfertas();
      })
    }

    $scope.aceptarOferta = function (oferta) {
      ofertaservice.rechazarTodas($rootScope.gauchadaOffer.id).then(function (vals) {
        oferta.estado = 1;
        $rootScope.gauchadaOffer.estado = 1;
        gauchadaservice.updateGauchada($rootScope.gauchadaOffer);
        ofertaservice.updateOferta(oferta).then(function (vals) {
          ofertaservice.getByIdGuachada($rootScope.gauchadaOffer.id).then(function (vals) {
            $rootScope.ofertasList = vals.data;
          })
        })
      })
    }

    $scope.calificarPositivo = function (oferta, calificacion) {
      calificacion.puntaje = 1;
      calificacionservice.publicarCalificacion(calificacion).then(function (vals) {
        oferta.idCalificacion = vals.data.id;
        ofertaservice.updateOferta(oferta);
        $rootScope.gauchadaOffer.actorId = oferta.idOfertador;
        $rootScope.gauchadaOffer.estado = 0;
        gauchadaservice.updateGauchada($rootScope.gauchadaOffer);
        usuarioService.getUsuarioActual(oferta.idOfertador)
          .then(function (vals) {
            var user = vals.data;
            user.puntaje = user.puntaje + 1;
            user.credito = user.credito + 1;
            usuarioService.updateUsuario(user);
          })
      })
    }

    $scope.calificarNegativo = function (oferta, calificacion) {
      calificacionservice.publicarCalificacion(calificacion).then(function (vals) {
        oferta.idCalificacion = vals.data.id;
        ofertaservice.updateOferta(oferta);
        $rootScope.gauchadaOffer.actorId = oferta.idOfertador;
        $rootScope.gauchadaOffer.estado = 0;
        gauchadaservice.updateGauchada($rootScope.gauchadaOffer);
        usuarioService.getUsuarioActual(oferta.idOfertador)
          .then(function (vals) {
            var user = vals.data;
            if (user.credito > 1) {
              user.credito = user.credito - 2;
            }
            else {
              user.credito = 0;
            }
            if (user.puntaje > 1) {
              user.puntaje = user.puntaje - 2;
            }
            else {
              user.puntaje = 0;
            }
            usuarioService.updateUsuario(user);
          })
      })
    }
    
    $scope.calificarNeutro = function (oferta, calificacion) {
      calificacion.puntaje = 2;
      calificacionservice.publicarCalificacion(calificacion).then(function (vals) {
        oferta.idCalificacion = vals.data.id;
        ofertaservice.updateOferta(oferta);
        $rootScope.gauchadaOffer.actorId = oferta.idOfertador;
        $rootScope.gauchadaOffer.estado = 0;
        gauchadaservice.updateGauchada($rootScope.gauchadaOffer);
      })
    }

    $scope.actualizar = function () {
      $rootScope.gauchadaEdit = $rootScope.gauchadaActual;
      $window.location.href = "#!/editargauchada";
    }

    $scope.verOfertas = function () {
      $rootScope.gauchadaOffer = $rootScope.gauchadaActual;
      ofertaservice.getByIdGuachada($rootScope.gauchadaActual.id).then(function (vals) {
        $rootScope.ofertasList = vals.data
      })
      $window.location.href = "#!/listaofertas";
    }

    $scope.publicarComentario = function (comentario) {
      comentario.respuesta = "";
      comentario.gauchadaId = $rootScope.gauchadaActual.id;
      comentario.nombreautor = $rootScope.usuario.nombre;
      comentarioservice.publicarComentario(comentario).then(function (vals) {
        comentarioservice.getAll($rootScope.gauchadaActual.id).then(function (vals) {
          $rootScope.comentarios = vals.data;
        })
      });
    }

    $scope.publicarRespuesta = function (respuesta, comentario) {
      comentario.respuesta = respuesta.texto;
      comentarioservice.publicarRespuesta(comentario).then(function (vals) {
        comentarioservice.getAll($rootScope.gauchadaActual.id).then(function (vals) {
          $rootScope.comentarios = vals.data;
        })
      });
    }

    $scope.borrarGauchada = function () {
      if ($rootScope.gauchadaActual.FechaFin < $scope.fecha) {
        alert("La gauchada no se puede borrar porque ya caduco");
      }
      else {
        ofertaservice.getByIdGuachada($rootScope.gauchadaActual.id).then(function (vals) {
          $scope.ofertas = vals.data
          if ($scope.ofertas != 0) {
            alert("La gauchada no se puede borrar porque posee ofertas realizadas");
          }
          else {
            $rootScope.gauchadaActual.estado = 0;
            gauchadaservice.updateGauchada($rootScope.gauchadaActual).then(function (vals) {
              $window.location.href = "#!/"
            });
          }
        });
      }
    }

    $scope.verGauchada = function (gauchada) {
      gauchadaservice.getGauchada(gauchada)
        .then(function (vals) {
          $rootScope.gauchadaActual = vals.data;
          comentarioservice.getAll($rootScope.gauchadaActual.id).then(function (vals) {
            $rootScope.comentarios = vals.data;
          })
        })
    };

    $scope.verPibe = function (usuarioId) {
      if ($rootScope.usuarioOn == false) {
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
