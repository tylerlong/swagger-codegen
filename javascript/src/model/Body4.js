(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './CallerInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CallerInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.Body4 = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.CallerInfo);
  }
}(this, function(ApiClient, CallerInfo) {
  'use strict';

  /**
   * The Body4 model module.
   * @module model/Body4
   * @version v1.0
   */

  /**
   * Constructs a new <code>Body4</code>.
   * @alias module:model/Body4
   * @class
   */
  var exports = function() {







  };

  /**
   * Constructs a <code>Body4</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Body4} obj Optional instance to populate.
   * @return {module:model/Body4} The populated <code>Body4</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('to')) {
        obj['to'] = ApiClient.convertToType(data['to'], [CallerInfo]);
      }
      if (data.hasOwnProperty('resolution')) {
        obj['resolution'] = ApiClient.convertToType(data['resolution'], 'String');
      }
      if (data.hasOwnProperty('sendTime')) {
        obj['sendTime'] = ApiClient.convertToType(data['sendTime'], 'Date');
      }
      if (data.hasOwnProperty('coverIndex')) {
        obj['coverIndex'] = ApiClient.convertToType(data['coverIndex'], 'Integer');
      }
      if (data.hasOwnProperty('coverPageText')) {
        obj['coverPageText'] = ApiClient.convertToType(data['coverPageText'], 'String');
      }
      if (data.hasOwnProperty('originalMessageId')) {
        obj['originalMessageId'] = ApiClient.convertToType(data['originalMessageId'], 'String');
      }
    }
    return obj;
  }


  /**
   * Recipient information. Phone number property is mandatory. Optional for resend fax request
   * @member {Array.<module:model/CallerInfo>} to
   */
  exports.prototype['to'] = undefined;

  /**
   * Fax resolution
   * @member {module:model/Body4.ResolutionEnum} resolution
   */
  exports.prototype['resolution'] = undefined;

  /**
   * The datetime to send fax at, in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. If time is not specified, the fax will be send immediately
   * @member {Date} sendTime
   */
  exports.prototype['sendTime'] = undefined;

  /**
   * Optional. Cover page index. If not specified, the default cover page which is configured in \"Outbound Fax Settings\" is attached. See also 'Available Cover Pages' table below
   * @member {Integer} coverIndex
   */
  exports.prototype['coverIndex'] = undefined;

  /**
   * Optional. Cover page text, entered by the fax sender and printed on the cover page. Maximum length is limited to 1024 symbols
   * @member {String} coverPageText
   */
  exports.prototype['coverPageText'] = undefined;

  /**
   * Internal identifier of the original fax message which needs to be resent. Mandatory for resend fax request
   * @member {String} originalMessageId
   */
  exports.prototype['originalMessageId'] = undefined;


  /**
   * Allowed values for the <code>resolution</code> property.
   * @enum {String}
   * @readonly
   */
  exports.ResolutionEnum = { 
    /**
     * value: High
     * @const
     */
    HIGH: "High",
    
    /**
     * value: Low
     * @const
     */
    LOW: "Low"
  };

  return exports;
}));
