'use strict';

describe('Service: comprasService', function () {

  // load the service's module
  beforeEach(module('clienteApp'));

  // instantiate service
  var comprasService;
  beforeEach(inject(function (_comprasService_) {
    comprasService = _comprasService_;
  }));

  it('should do something', function () {
    expect(!!comprasService).toBe(true);
  });

});
