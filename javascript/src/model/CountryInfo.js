(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.CountryInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The CountryInfo model module.
   * @module model/CountryInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>CountryInfo</code>.
   * @alias module:model/CountryInfo
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>CountryInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/CountryInfo} obj Optional instance to populate.
   * @return {module:model/CountryInfo} The populated <code>CountryInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a home country
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a home country
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Official name of a home country
   * @member {String} name
   */
  exports.prototype['name'] = undefined;




  return exports;
}));
