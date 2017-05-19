'use strict';

describe('Controller: GauchadacontrollerCtrl', function () {

  // load the controller's module
  beforeEach(module('clienteApp'));

  var GauchadacontrollerCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    GauchadacontrollerCtrl = $controller('GauchadacontrollerCtrl', {
      $scope: scope
      // place here mocked dependencies
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(GauchadacontrollerCtrl.awesomeThings.length).toBe(3);
  });
});
