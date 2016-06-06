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
    root.RingCentralApi.AccountLimits = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The AccountLimits model module.
   * @module model/AccountLimits
   * @version v1.0
   */

  /**
   * Constructs a new <code>AccountLimits</code>.
   * @alias module:model/AccountLimits
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>AccountLimits</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/AccountLimits} obj Optional instance to populate.
   * @return {module:model/AccountLimits} The populated <code>AccountLimits</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('freeSoftPhoneLinesPerExtension')) {
        obj['freeSoftPhoneLinesPerExtension'] = ApiClient.convertToType(data['freeSoftPhoneLinesPerExtension'], 'Integer');
      }
      if (data.hasOwnProperty('meetingSize')) {
        obj['meetingSize'] = ApiClient.convertToType(data['meetingSize'], 'Integer');
      }
      if (data.hasOwnProperty('maxMonitoredExtensionsPerUser')) {
        obj['maxMonitoredExtensionsPerUser'] = ApiClient.convertToType(data['maxMonitoredExtensionsPerUser'], 'Integer');
      }
    }
    return obj;
  }


  /**
   * The maximum number of free softphone digital lines per user extension
   * @member {Integer} freeSoftPhoneLinesPerExtension
   */
  exports.prototype['freeSoftPhoneLinesPerExtension'] = undefined;

  /**
   * The maximum number of participants in RingCentral Meeting hosted by this account's user
   * @member {Integer} meetingSize
   */
  exports.prototype['meetingSize'] = undefined;

  /**
   * The maximum number of extensions which can be included in the list of users monitored for Presence
   * @member {Integer} maxMonitoredExtensionsPerUser
   */
  exports.prototype['maxMonitoredExtensionsPerUser'] = undefined;




  return exports;
}));
