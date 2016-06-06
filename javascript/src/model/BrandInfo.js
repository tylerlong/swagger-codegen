(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './CountryInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CountryInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.BrandInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.CountryInfo);
  }
}(this, function(ApiClient, CountryInfo) {
  'use strict';

  /**
   * The BrandInfo model module.
   * @module model/BrandInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>BrandInfo</code>.
   * @alias module:model/BrandInfo
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>BrandInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/BrandInfo} obj Optional instance to populate.
   * @return {module:model/BrandInfo} The populated <code>BrandInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('homeCountry')) {
        obj['homeCountry'] = CountryInfo.constructFromObject(data['homeCountry']);
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a brand
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Brand name, for example \"RingCentral UK\", \"ClearFax\"
   * @member {String} name
   */
  exports.prototype['name'] = undefined;

  /**
   * @member {module:model/CountryInfo} homeCountry
   */
  exports.prototype['homeCountry'] = undefined;




  return exports;
}));
