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
    root.RingCentralApi.BusinessAddressInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The BusinessAddressInfo model module.
   * @module model/BusinessAddressInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>BusinessAddressInfo</code>.
   * @alias module:model/BusinessAddressInfo
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>BusinessAddressInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/BusinessAddressInfo} obj Optional instance to populate.
   * @return {module:model/BusinessAddressInfo} The populated <code>BusinessAddressInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('country')) {
        obj['country'] = ApiClient.convertToType(data['country'], 'String');
      }
      if (data.hasOwnProperty('state')) {
        obj['state'] = ApiClient.convertToType(data['state'], 'String');
      }
      if (data.hasOwnProperty('city')) {
        obj['city'] = ApiClient.convertToType(data['city'], 'String');
      }
      if (data.hasOwnProperty('street')) {
        obj['street'] = ApiClient.convertToType(data['street'], 'String');
      }
      if (data.hasOwnProperty('zip')) {
        obj['zip'] = ApiClient.convertToType(data['zip'], 'String');
      }
    }
    return obj;
  }


  /**
   * Name of a country
   * @member {String} country
   */
  exports.prototype['country'] = undefined;

  /**
   * Name of a state/province
   * @member {String} state
   */
  exports.prototype['state'] = undefined;

  /**
   * Name of a city
   * @member {String} city
   */
  exports.prototype['city'] = undefined;

  /**
   * Street address
   * @member {String} street
   */
  exports.prototype['street'] = undefined;

  /**
   * Zip code
   * @member {String} zip
   */
  exports.prototype['zip'] = undefined;




  return exports;
}));
