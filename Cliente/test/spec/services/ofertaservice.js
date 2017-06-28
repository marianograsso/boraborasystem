'use strict';

describe('Service: ofertaservice', function () {

  // load the service's module
  beforeEach(module('clienteApp'));

  // instantiate service
  var ofertaservice;
  beforeEach(inject(function (_ofertaservice_) {
    ofertaservice = _ofertaservice_;
  }));

  it('should do something', function () {
    expect(!!ofertaservice).toBe(true);
  });

});
