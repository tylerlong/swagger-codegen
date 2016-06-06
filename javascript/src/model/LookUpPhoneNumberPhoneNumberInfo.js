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
    root.RingCentralApi.LookUpPhoneNumberPhoneNumberInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The LookUpPhoneNumberPhoneNumberInfo model module.
   * @module model/LookUpPhoneNumberPhoneNumberInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>LookUpPhoneNumberPhoneNumberInfo</code>.
   * @alias module:model/LookUpPhoneNumberPhoneNumberInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>LookUpPhoneNumberPhoneNumberInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/LookUpPhoneNumberPhoneNumberInfo} obj Optional instance to populate.
   * @return {module:model/LookUpPhoneNumberPhoneNumberInfo} The populated <code>LookUpPhoneNumberPhoneNumberInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
      if (data.hasOwnProperty('formattedNumber')) {
        obj['formattedNumber'] = ApiClient.convertToType(data['formattedNumber'], 'String');
      }
      if (data.hasOwnProperty('vanityPattern')) {
        obj['vanityPattern'] = ApiClient.convertToType(data['vanityPattern'], 'String');
      }
      if (data.hasOwnProperty('rank')) {
        obj['rank'] = ApiClient.convertToType(data['rank'], 'Integer');
      }
    }
    return obj;
  }


  /**
   * Phone number in E.164 format without a '+'
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;

  /**
   * Phone number formatted according to current brand's default country
   * @member {String} formattedNumber
   */
  exports.prototype['formattedNumber'] = undefined;

  /**
   * Vanity pattern for this number. Returned only when vanity search option is requested. Vanity pattern corresponds to request parameters nxx plus line or numberPattern
   * @member {String} vanityPattern
   */
  exports.prototype['vanityPattern'] = undefined;

  /**
   * The value is returned if the extendedSearch parameter is true. '10' is the closest match
   * @member {Integer} rank
   */
  exports.prototype['rank'] = undefined;




  return exports;
}));
