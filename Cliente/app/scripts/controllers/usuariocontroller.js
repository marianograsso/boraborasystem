'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:UsuariocontrollerCtrl
 * @description
 * # UsuariocontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('UsuariocontrollerCtrl', function ($scope, usuarioService) {
     
     
     $scope.registrar = function(){
      usuarioService.registrarUsuario($scope.usuario)
      .then(function(vals){
      }, function (error){
        console.error("Error", error)
      })
    }

    function createUser() {
        var user = {
          Id: '',
          Nombre: '',
          Email: '',
          Apellido: '',
          Password: '',
          Telefono: '',
          Puntaje: '',
          Avatar: '',
          Categoria: '',
          OfertasRealizadas: '',
          GauchadasIniciadas: '',
          Credito: '',
          ComprasRealizadas: '',
        };
    };

    
  });
