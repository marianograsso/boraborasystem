'use strict';

/**
 * @ngdoc overview
 * @name clienteApp
 * @description
 * # clienteApp
 *
 * Main module of the application.
 */
angular
  .module('clienteApp', [
    'ngAnimate',
    'ngCookies',
    'ngResource',
    'ngRoute',
    'ngSanitize',
    'ngTouch'
  ])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'views/main.html',
        controller: 'GauchadacontrollerCtrl',
        controllerAs: 'main'
      })
      .when('/comprar', {
        templateUrl: 'views/comprar.html',
        controller: 'ComprascontrollerCtrl',
      })
      .when('/publicar', {
        templateUrl: 'views/publicargauchada.html',
        controller: 'GauchadacontrollerCtrl',
      })
      .when('/pagar', {
        templateUrl: 'views/pagar.html',
        controller: 'ComprascontrollerCtrl',
      })
      .when('/registrarusuario', {
        templateUrl: 'views/registrarusuario.html',
        controller: 'UsuariocontrollerCtrl',
      })
      .when('/iniciarsesion', {
        templateUrl: 'views/iniciarsesion.html',
        controller: 'UsuariocontrollerCtrl',
      })
      .when('/vergauchada', {
        templateUrl: 'views/vergauchada.html',
        controller: 'GauchadacontrollerCtrl',
      })
      .when('/perfil', {
        templateUrl: 'views/perfil.html',
        controller: 'PerfilcontrollerCtrl',
      })
      .otherwise({
        redirectTo: '/'
      });
  });
