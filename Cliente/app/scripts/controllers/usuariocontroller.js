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

     $scope.registrar = function(usuario){
      usuarioService.registrarUsuario(createUser(usuario))
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

    function createUser(usuario) {
        var usuarioResp = {
          Id: '',
          Nombre: usuario.nombre,
          Email: usuario.email,
          Apellido: usuario.apellido,
          Password: usuario.password,
          Telefono: usuario.telefono,
          Puntaje: '',
          Avatar: usuario.avatar,
          Categoria: '',
          OfertasRealizadas: '',
          GauchadasIniciadas: '',
          Credito: '',
          ComprasRealizadas: '',
        };
        return usuarioResp;
    };

    
  })