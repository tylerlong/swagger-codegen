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
    root.RingCentralApi.EmergencyAddressInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The EmergencyAddressInfo model module.
   * @module model/EmergencyAddressInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>EmergencyAddressInfo</code>.
   * @alias module:model/EmergencyAddressInfo
   * @class
   */
  var exports = function() {








  };

  /**
   * Constructs a <code>EmergencyAddressInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/EmergencyAddressInfo} obj Optional instance to populate.
   * @return {module:model/EmergencyAddressInfo} The populated <code>EmergencyAddressInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('customerName')) {
        obj['customerName'] = ApiClient.convertToType(data['customerName'], 'String');
      }
      if (data.hasOwnProperty('street')) {
        obj['street'] = ApiClient.convertToType(data['street'], 'String');
      }
      if (data.hasOwnProperty('street2')) {
        obj['street2'] = ApiClient.convertToType(data['street2'], 'String');
      }
      if (data.hasOwnProperty('city')) {
        obj['city'] = ApiClient.convertToType(data['city'], 'String');
      }
      if (data.hasOwnProperty('state')) {
        obj['state'] = ApiClient.convertToType(data['state'], 'String');
      }
      if (data.hasOwnProperty('zip')) {
        obj['zip'] = ApiClient.convertToType(data['zip'], 'String');
      }
      if (data.hasOwnProperty('country')) {
        obj['country'] = ApiClient.convertToType(data['country'], 'String');
      }
    }
    return obj;
  }


  /**
   * Name of a customer
   * @member {String} customerName
   */
  exports.prototype['customerName'] = undefined;

  /**
   * Street address, line 1 - street address, P.O. box, company name, c/o
   * @member {String} street
   */
  exports.prototype['street'] = undefined;

  /**
   * Street address, line 2 - apartment, suite, unit, building, floor, etc.
   * @member {String} street2
   */
  exports.prototype['street2'] = undefined;

  /**
   * City name
   * @member {String} city
   */
  exports.prototype['city'] = undefined;

  /**
   * State/province name
   * @member {String} state
   */
  exports.prototype['state'] = undefined;

  /**
   * Zip code
   * @member {String} zip
   */
  exports.prototype['zip'] = undefined;

  /**
   * Country name
   * @member {String} country
   */
  exports.prototype['country'] = undefined;




  return exports;
}));
