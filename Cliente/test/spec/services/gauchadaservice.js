'use strict';

describe('Service: gauchadaservice', function () {

  // load the service's module
  beforeEach(module('clienteApp'));

  // instantiate service
  var gauchadaservice;
  beforeEach(inject(function (_gauchadaservice_) {
    gauchadaservice = _gauchadaservice_;
  }));

  it('should do something', function () {
    expect(!!gauchadaservice).toBe(true);
  });

});
