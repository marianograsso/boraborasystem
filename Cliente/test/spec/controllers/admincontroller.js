'use strict';

describe('Controller: AdmincontrollerCtrl', function () {

  // load the controller's module
  beforeEach(module('clienteApp'));

  var AdmincontrollerCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    AdmincontrollerCtrl = $controller('AdmincontrollerCtrl', {
      $scope: scope
      // place here mocked dependencies
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(AdmincontrollerCtrl.awesomeThings.length).toBe(3);
  });
});
