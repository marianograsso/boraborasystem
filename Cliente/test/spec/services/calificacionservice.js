'use strict';

describe('Service: calificacionservice', function () {

  // load the service's module
  beforeEach(module('clienteApp'));

  // instantiate service
  var calificacionservice;
  beforeEach(inject(function (_calificacionservice_) {
    calificacionservice = _calificacionservice_;
  }));

  it('should do something', function () {
    expect(!!calificacionservice).toBe(true);
  });

});
