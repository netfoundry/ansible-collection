/**
 * untitled API
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 5170
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', process.cwd()+'/src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require(process.cwd()+'/src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.UntitledApi);
  }
}(this, function(expect, UntitledApi) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new UntitledApi.InlineResponse2023ConfigIdByConfigTypeId();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('InlineResponse2023ConfigIdByConfigTypeId', function() {
    it('should create an instance of InlineResponse2023ConfigIdByConfigTypeId', function() {
      // uncomment below and update the code to test InlineResponse2023ConfigIdByConfigTypeId
      //var instane = new UntitledApi.InlineResponse2023ConfigIdByConfigTypeId();
      //expect(instance).to.be.a(UntitledApi.InlineResponse2023ConfigIdByConfigTypeId);
    });

    it('should have the property _714a918a79354b4f82c3Afbadcd9e59b (base name: "714a918a-7935-4b4f-82c3-afbadcd9e59b")', function() {
      // uncomment below and update the code to test the property _714a918a79354b4f82c3Afbadcd9e59b
      //var instane = new UntitledApi.InlineResponse2023ConfigIdByConfigTypeId();
      //expect(instance).to.be();
    });

    it('should have the property _7cafedc517b84c1e8b6f0d9bc1b4b7bc (base name: "7cafedc5-17b8-4c1e-8b6f-0d9bc1b4b7bc")', function() {
      // uncomment below and update the code to test the property _7cafedc517b84c1e8b6f0d9bc1b4b7bc
      //var instane = new UntitledApi.InlineResponse2023ConfigIdByConfigTypeId();
      //expect(instance).to.be();
    });

    it('should have the property d75e27f0Ebab45678440C24f02f2eca5 (base name: "d75e27f0-ebab-4567-8440-c24f02f2eca5")', function() {
      // uncomment below and update the code to test the property d75e27f0Ebab45678440C24f02f2eca5
      //var instane = new UntitledApi.InlineResponse2023ConfigIdByConfigTypeId();
      //expect(instance).to.be();
    });

    it('should have the property ea6e632bD8e1420fBd8fAd50b067bad6 (base name: "ea6e632b-d8e1-420f-bd8f-ad50b067bad6")', function() {
      // uncomment below and update the code to test the property ea6e632bD8e1420fBd8fAd50b067bad6
      //var instane = new UntitledApi.InlineResponse2023ConfigIdByConfigTypeId();
      //expect(instance).to.be();
    });

  });

}));