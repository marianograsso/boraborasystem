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
     $scope.usuarioOff = true
     $scope.usuarioOn  = false

     $scope.registrar = function(){
      usuarioService.registrarUsuario($scope.usuario)
      .then(function(vals){
      }, function (error){
        console.error("Error", error)
      })
    };
    $scope.loguear = function(){
      usuarioService.getUsuario($scope.email, $scope.password)
      .then(function(vals){
      }, function(error){
        console.error("Error", error)
      })
      $scope.usuarioOn = true;
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
