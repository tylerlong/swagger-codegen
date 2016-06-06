(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './ConferencingInfoPhoneNumberInfoCountryInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ConferencingInfoPhoneNumberInfoCountryInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ConferencingInfoPhoneNumberInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.ConferencingInfoPhoneNumberInfoCountryInfo);
  }
}(this, function(ApiClient, ConferencingInfoPhoneNumberInfoCountryInfo) {
  'use strict';

  /**
   * The ConferencingInfoPhoneNumberInfo model module.
   * @module model/ConferencingInfoPhoneNumberInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ConferencingInfoPhoneNumberInfo</code>.
   * @alias module:model/ConferencingInfoPhoneNumberInfo
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>ConferencingInfoPhoneNumberInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ConferencingInfoPhoneNumberInfo} obj Optional instance to populate.
   * @return {module:model/ConferencingInfoPhoneNumberInfo} The populated <code>ConferencingInfoPhoneNumberInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('country')) {
        obj['country'] = ConferencingInfoPhoneNumberInfoCountryInfo.constructFromObject(data['country']);
      }
      if (data.hasOwnProperty('default')) {
        obj['default'] = ApiClient.convertToType(data['default'], 'Boolean');
      }
      if (data.hasOwnProperty('hasGreeting')) {
        obj['hasGreeting'] = ApiClient.convertToType(data['hasGreeting'], 'Boolean');
      }
      if (data.hasOwnProperty('location')) {
        obj['location'] = ApiClient.convertToType(data['location'], 'String');
      }
      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
    }
    return obj;
  }


  /**
   * @member {module:model/ConferencingInfoPhoneNumberInfoCountryInfo} country
   */
  exports.prototype['country'] = undefined;

  /**
   * 'True' if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed
   * @member {Boolean} default
   */
  exports.prototype['default'] = undefined;

  /**
   * 'True' if the greeting message is played on this number
   * @member {Boolean} hasGreeting
   */
  exports.prototype['hasGreeting'] = undefined;

  /**
   * Location (city, region, state) of a conference phone number
   * @member {String} location
   */
  exports.prototype['location'] = undefined;

  /**
   * Dial-in phone number to connect to a conference
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;




  return exports;
}));
