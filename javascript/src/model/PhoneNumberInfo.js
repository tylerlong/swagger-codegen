(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './CountryInfo', './PhoneNumberInfoExtensionInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CountryInfo'), require('./PhoneNumberInfoExtensionInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.PhoneNumberInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.CountryInfo, root.RingCentralApi.PhoneNumberInfoExtensionInfo);
  }
}(this, function(ApiClient, CountryInfo, PhoneNumberInfoExtensionInfo) {
  'use strict';

  /**
   * The PhoneNumberInfo model module.
   * @module model/PhoneNumberInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>PhoneNumberInfo</code>.
   * @alias module:model/PhoneNumberInfo
   * @class
   */
  var exports = function() {











  };

  /**
   * Constructs a <code>PhoneNumberInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PhoneNumberInfo} obj Optional instance to populate.
   * @return {module:model/PhoneNumberInfo} The populated <code>PhoneNumberInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'Integer');
      }
      if (data.hasOwnProperty('country')) {
        obj['country'] = CountryInfo.constructFromObject(data['country']);
      }
      if (data.hasOwnProperty('extension')) {
        obj['extension'] = PhoneNumberInfoExtensionInfo.constructFromObject(data['extension']);
      }
      if (data.hasOwnProperty('features')) {
        obj['features'] = ApiClient.convertToType(data['features'], ['String']);
      }
      if (data.hasOwnProperty('location')) {
        obj['location'] = ApiClient.convertToType(data['location'], 'String');
      }
      if (data.hasOwnProperty('paymentType')) {
        obj['paymentType'] = ApiClient.convertToType(data['paymentType'], 'String');
      }
      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
      if (data.hasOwnProperty('status')) {
        obj['status'] = ApiClient.convertToType(data['status'], 'String');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
      if (data.hasOwnProperty('usageType')) {
        obj['usageType'] = ApiClient.convertToType(data['usageType'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a phone number
   * @member {Integer} id
   */
  exports.prototype['id'] = undefined;

  /**
   * @member {module:model/CountryInfo} country
   */
  exports.prototype['country'] = undefined;

  /**
   * @member {module:model/PhoneNumberInfoExtensionInfo} extension
   */
  exports.prototype['extension'] = undefined;

  /**
   * Indicates if this phone number is enabled to appear as CallerId and/or to send outbound SMS from it. Returned only for the request of Extension phone number list
   * @member {Array.<String>} features
   */
  exports.prototype['features'] = undefined;

  /**
   * Location (City, State). Filled for local US numbers
   * @member {String} location
   */
  exports.prototype['location'] = undefined;

  /**
   * Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system
   * @member {module:model/PhoneNumberInfo.PaymentTypeEnum} paymentType
   */
  exports.prototype['paymentType'] = undefined;

  /**
   * Phone number
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;

  /**
   * Status of a phone number. If the value is 'Normal', the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral
   * @member {String} status
   */
  exports.prototype['status'] = undefined;

  /**
   * Phone number type
   * @member {module:model/PhoneNumberInfo.TypeEnum} type
   */
  exports.prototype['type'] = undefined;

  /**
   * Usage type of the phone number
   * @member {module:model/PhoneNumberInfo.UsageTypeEnum} usageType
   */
  exports.prototype['usageType'] = undefined;


  /**
   * Allowed values for the <code>paymentType</code> property.
   * @enum {String}
   * @readonly
   */
  exports.PaymentTypeEnum = { 
    /**
     * value: External
     * @const
     */
    EXTERNAL: "External",
    
    /**
     * value: TollFree
     * @const
     */
    TOLLFREE: "TollFree",
    
    /**
     * value: Local
     * @const
     */
    LOCAL: "Local"
  };  /**
   * Allowed values for the <code>type</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TypeEnum = { 
    /**
     * value: VoiceFax
     * @const
     */
    VOICEFAX: "VoiceFax",
    
    /**
     * value: FaxOnly
     * @const
     */
    FAXONLY: "FaxOnly",
    
    /**
     * value: VoiceOnly
     * @const
     */
    VOICEONLY: "VoiceOnly"
  };  /**
   * Allowed values for the <code>usageType</code> property.
   * @enum {String}
   * @readonly
   */
  exports.UsageTypeEnum = { 
    /**
     * value: MainCompanyNumber
     * @const
     */
    MAINCOMPANYNUMBER: "MainCompanyNumber",
    
    /**
     * value: AdditionalCompanyNumber
     * @const
     */
    ADDITIONALCOMPANYNUMBER: "AdditionalCompanyNumber",
    
    /**
     * value: CompanyNumber
     * @const
     */
    COMPANYNUMBER: "CompanyNumber",
    
    /**
     * value: DirectNumber
     * @const
     */
    DIRECTNUMBER: "DirectNumber",
    
    /**
     * value: CompanyFaxNumber
     * @const
     */
    COMPANYFAXNUMBER: "CompanyFaxNumber",
    
    /**
     * value: ForwardedNumber
     * @const
     */
    FORWARDEDNUMBER: "ForwardedNumber"
  };

  return exports;
}));
