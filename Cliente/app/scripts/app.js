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
    'ngTouch',
  ])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'views/main.html',
        controller: 'MainCtrl',
        controllerAs: 'main'
      })
      .when('/about', {
        templateUrl: 'views/about.html',
        controller: 'AboutCtrl',
        controllerAs: 'about'
      })
      .when('/comprar', {
        templateUrl: 'views/comprar.html',
        controller: 'ComprascontrollerCtrl',
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
      .otherwise({
        redirectTo: '/'
      });
  });
