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
    root.RingCentralApi.ConferencingInfoPhoneNumberInfoCountryInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ConferencingInfoPhoneNumberInfoCountryInfo model module.
   * @module model/ConferencingInfoPhoneNumberInfoCountryInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ConferencingInfoPhoneNumberInfoCountryInfo</code>.
   * @alias module:model/ConferencingInfoPhoneNumberInfoCountryInfo
   * @class
   */
  var exports = function() {







  };

  /**
   * Constructs a <code>ConferencingInfoPhoneNumberInfoCountryInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ConferencingInfoPhoneNumberInfoCountryInfo} obj Optional instance to populate.
   * @return {module:model/ConferencingInfoPhoneNumberInfoCountryInfo} The populated <code>ConferencingInfoPhoneNumberInfoCountryInfo</code> instance.
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
      if (data.hasOwnProperty('callingCode')) {
        obj['callingCode'] = ApiClient.convertToType(data['callingCode'], 'String');
      }
      if (data.hasOwnProperty('emergencyCalling')) {
        obj['emergencyCalling'] = ApiClient.convertToType(data['emergencyCalling'], 'Boolean');
      }
      if (data.hasOwnProperty('isoCode')) {
        obj['isoCode'] = ApiClient.convertToType(data['isoCode'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a country
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a country
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Country calling code defined by ITU-T recommendations E.123 and E.164, see Calling Codes
   * @member {String} callingCode
   */
  exports.prototype['callingCode'] = undefined;

  /**
   * Emergency calling feature availability/emergency address requirement indicator
   * @member {Boolean} emergencyCalling
   */
  exports.prototype['emergencyCalling'] = undefined;

  /**
   * Country code according to the ISO standard, see ISO 3166
   * @member {String} isoCode
   */
  exports.prototype['isoCode'] = undefined;

  /**
   * Official name of a country
   * @member {String} name
   */
  exports.prototype['name'] = undefined;




  return exports;
}));
