'use strict';

describe('Controller: UsuariocontrollerCtrl', function () {

  // load the controller's module
  beforeEach(module('clienteApp'));

  var UsuariocontrollerCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    UsuariocontrollerCtrl = $controller('UsuariocontrollerCtrl', {
      $scope: scope
      // place here mocked dependencies
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(UsuariocontrollerCtrl.awesomeThings.length).toBe(3);
  });
});
