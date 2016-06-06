(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './ParsePhoneNumberCountryInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ParsePhoneNumberCountryInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ParsePhoneNumberPhoneNumberInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.ParsePhoneNumberCountryInfo);
  }
}(this, function(ApiClient, ParsePhoneNumberCountryInfo) {
  'use strict';

  /**
   * The ParsePhoneNumberPhoneNumberInfo model module.
   * @module model/ParsePhoneNumberPhoneNumberInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ParsePhoneNumberPhoneNumberInfo</code>.
   * @alias module:model/ParsePhoneNumberPhoneNumberInfo
   * @class
   */
  var exports = function() {










  };

  /**
   * Constructs a <code>ParsePhoneNumberPhoneNumberInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ParsePhoneNumberPhoneNumberInfo} obj Optional instance to populate.
   * @return {module:model/ParsePhoneNumberPhoneNumberInfo} The populated <code>ParsePhoneNumberPhoneNumberInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('areaCode')) {
        obj['areaCode'] = ApiClient.convertToType(data['areaCode'], 'String');
      }
      if (data.hasOwnProperty('country')) {
        obj['country'] = ApiClient.convertToType(data['country'], [ParsePhoneNumberCountryInfo]);
      }
      if (data.hasOwnProperty('dialable')) {
        obj['dialable'] = ApiClient.convertToType(data['dialable'], 'String');
      }
      if (data.hasOwnProperty('e164')) {
        obj['e164'] = ApiClient.convertToType(data['e164'], 'String');
      }
      if (data.hasOwnProperty('formattedInternational')) {
        obj['formattedInternational'] = ApiClient.convertToType(data['formattedInternational'], 'String');
      }
      if (data.hasOwnProperty('formattedNational')) {
        obj['formattedNational'] = ApiClient.convertToType(data['formattedNational'], 'String');
      }
      if (data.hasOwnProperty('originalString')) {
        obj['originalString'] = ApiClient.convertToType(data['originalString'], 'String');
      }
      if (data.hasOwnProperty('special')) {
        obj['special'] = ApiClient.convertToType(data['special'], 'Boolean');
      }
      if (data.hasOwnProperty('normalized')) {
        obj['normalized'] = ApiClient.convertToType(data['normalized'], 'String');
      }
    }
    return obj;
  }


  /**
   * Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See North American Numbering Plan for details
   * @member {String} areaCode
   */
  exports.prototype['areaCode'] = undefined;

  /**
   * Information on a country the phone number belongs to
   * @member {Array.<module:model/ParsePhoneNumberCountryInfo>} country
   */
  exports.prototype['country'] = undefined;

  /**
   * Dialing format of a phone number
   * @member {String} dialable
   */
  exports.prototype['dialable'] = undefined;

  /**
   * E.164 (11-digits) format of a phone number
   * @member {String} e164
   */
  exports.prototype['e164'] = undefined;

  /**
   * International format of a phone number
   * @member {String} formattedInternational
   */
  exports.prototype['formattedInternational'] = undefined;

  /**
   * Domestic format of a phone number
   * @member {String} formattedNational
   */
  exports.prototype['formattedNational'] = undefined;

  /**
   * One of the numbers to be parsed, passed as a string in response
   * @member {String} originalString
   */
  exports.prototype['originalString'] = undefined;

  /**
   * \"True\" if the number is in a special format (for example N11 code)
   * @member {Boolean} special
   */
  exports.prototype['special'] = undefined;

  /**
   * E.164 (11-digits) format of a phone number without the plus sign ('+')
   * @member {String} normalized
   */
  exports.prototype['normalized'] = undefined;




  return exports;
}));
