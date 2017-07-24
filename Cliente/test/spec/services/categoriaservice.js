'use strict';

describe('Service: categoriaservice', function () {

  // load the service's module
  beforeEach(module('clienteApp'));

  // instantiate service
  var categoriaservice;
  beforeEach(inject(function (_categoriaservice_) {
    categoriaservice = _categoriaservice_;
  }));

  it('should do something', function () {
    expect(!!categoriaservice).toBe(true);
  });

});
