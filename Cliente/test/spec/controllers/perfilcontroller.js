'use strict';

describe('Controller: PerfilcontrollerCtrl', function () {

  // load the controller's module
  beforeEach(module('clienteApp'));

  var PerfilcontrollerCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    PerfilcontrollerCtrl = $controller('PerfilcontrollerCtrl', {
      $scope: scope
      // place here mocked dependencies
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(PerfilcontrollerCtrl.awesomeThings.length).toBe(3);
  });
});
