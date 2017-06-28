'use strict';

describe('Controller: OfertascontrollerCtrl', function () {

  // load the controller's module
  beforeEach(module('clienteApp'));

  var OfertascontrollerCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    OfertascontrollerCtrl = $controller('OfertascontrollerCtrl', {
      $scope: scope
      // place here mocked dependencies
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(OfertascontrollerCtrl.awesomeThings.length).toBe(3);
  });
});
