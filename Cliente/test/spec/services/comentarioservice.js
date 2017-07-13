'use strict';

describe('Service: comentarioservice', function () {

  // load the service's module
  beforeEach(module('clienteApp'));

  // instantiate service
  var comentarioservice;
  beforeEach(inject(function (_comentarioservice_) {
    comentarioservice = _comentarioservice_;
  }));

  it('should do something', function () {
    expect(!!comentarioservice).toBe(true);
  });

});
