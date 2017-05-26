'use strict';

describe('Controller: ComprascontrollerCtrl', function () {

  // load the controller's module
  beforeEach(module('clienteApp'));

  var ComprascontrollerCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    ComprascontrollerCtrl = $controller('ComprascontrollerCtrl', {
      $scope: scope
      // place here mocked dependencies
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(ComprascontrollerCtrl.awesomeThings.length).toBe(3);
  });
});
