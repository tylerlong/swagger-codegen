(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './PhoneLinesInfoPhoneNumberInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./PhoneLinesInfoPhoneNumberInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.PhoneLinesInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.PhoneLinesInfoPhoneNumberInfo);
  }
}(this, function(ApiClient, PhoneLinesInfoPhoneNumberInfo) {
  'use strict';

  /**
   * The PhoneLinesInfo model module.
   * @module model/PhoneLinesInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>PhoneLinesInfo</code>.
   * @alias module:model/PhoneLinesInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>PhoneLinesInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PhoneLinesInfo} obj Optional instance to populate.
   * @return {module:model/PhoneLinesInfo} The populated <code>PhoneLinesInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('lineType')) {
        obj['lineType'] = ApiClient.convertToType(data['lineType'], 'String');
      }
      if (data.hasOwnProperty('phoneInfo')) {
        obj['phoneInfo'] = PhoneLinesInfoPhoneNumberInfo.constructFromObject(data['phoneInfo']);
      }
    }
    return obj;
  }


  /**
   * Type of phone line
   * @member {module:model/PhoneLinesInfo.LineTypeEnum} lineType
   */
  exports.prototype['lineType'] = undefined;

  /**
   * @member {module:model/PhoneLinesInfoPhoneNumberInfo} phoneInfo
   */
  exports.prototype['phoneInfo'] = undefined;


  /**
   * Allowed values for the <code>lineType</code> property.
   * @enum {String}
   * @readonly
   */
  exports.LineTypeEnum = { 
    /**
     * value: Standalone
     * @const
     */
    STANDALONE: "Standalone",
    
    /**
     * value: StandaloneFree
     * @const
     */
    STANDALONEFREE: "StandaloneFree",
    
    /**
     * value: BlaPrimary
     * @const
     */
    BLAPRIMARY: "BlaPrimary",
    
    /**
     * value: BlaSecondary
     * @const
     */
    BLASECONDARY: "BlaSecondary"
  };

  return exports;
}));
