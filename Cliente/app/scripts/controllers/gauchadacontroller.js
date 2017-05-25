'use strict';

/**
 * @ngdoc function
 * @name clienteApp.controller:GauchadacontrollerCtrl
 * @description
 * # GauchadacontrollerCtrl
 * Controller of the clienteApp
 */
angular.module('clienteApp')
  .controller('GauchadacontrollerCtrl', function ($scope, gauchadaservice, $window) {
    $scope.tituloAct = "";
    $scope.descAct = "";
    $scope.gauchadas = [
        { titulo: "Ayuda!", descripcion: "Como obtengo el valor que retorna una funcion en AngularJS?", imagen:"https://yt3.ggpht.com/-FJXWJ1x1bEQ/AAAAAAAAAAI/AAAAAAAAAAA/ZtyuZ-elFr4/s900-c-k-no-mo-rj-c0xffffff/photo.jpg" },
        { titulo: "Bue", descripcion: "Esta gauchada es inventada", imagen:"https://i.blogs.es/85042c/as17-148-22727/650_1200.jpg" },
        
        

    ];
    $scope.ver = function(){
      $scope.tituloAct = $scope.gauchadas.titulo;
      $scope.descAct = $scope.gauchadas.descAct;
      $window.location.href = "http://localhost:9000/#!/gauchada";

    }
    $scope.registrar = function(){
      usuarioService.registrarUsuario($scope.usuario)
      .then(function(vals){
      }, function (error){
        console.error("Error", error)
      })
    }
  });
