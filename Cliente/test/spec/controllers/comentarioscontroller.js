'use strict';

describe('Controller: ComentarioscontrollerCtrl', function () {

  // load the controller's module
  beforeEach(module('clienteApp'));

  var ComentarioscontrollerCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    ComentarioscontrollerCtrl = $controller('ComentarioscontrollerCtrl', {
      $scope: scope
      // place here mocked dependencies
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(ComentarioscontrollerCtrl.awesomeThings.length).toBe(3);
  });
});
