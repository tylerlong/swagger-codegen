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
    root.RingCentralApi.SyncInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The SyncInfo model module.
   * @module model/SyncInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>SyncInfo</code>.
   * @alias module:model/SyncInfo
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>SyncInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/SyncInfo} obj Optional instance to populate.
   * @return {module:model/SyncInfo} The populated <code>SyncInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('syncType')) {
        obj['syncType'] = ApiClient.convertToType(data['syncType'], 'String');
      }
      if (data.hasOwnProperty('syncToken')) {
        obj['syncToken'] = ApiClient.convertToType(data['syncToken'], 'String');
      }
      if (data.hasOwnProperty('syncTime')) {
        obj['syncTime'] = ApiClient.convertToType(data['syncTime'], 'Date');
      }
    }
    return obj;
  }


  /**
   * Type of synchronization
   * @member {module:model/SyncInfo.SyncTypeEnum} syncType
   */
  exports.prototype['syncType'] = undefined;

  /**
   * Synchronization token
   * @member {String} syncToken
   */
  exports.prototype['syncToken'] = undefined;

  /**
   * Last synchronization datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
   * @member {Date} syncTime
   */
  exports.prototype['syncTime'] = undefined;


  /**
   * Allowed values for the <code>syncType</code> property.
   * @enum {String}
   * @readonly
   */
  exports.SyncTypeEnum = { 
    /**
     * value: FSync
     * @const
     */
    FSYNC: "FSync",
    
    /**
     * value: ISync
     * @const
     */
    ISYNC: "ISync"
  };

  return exports;
}));
