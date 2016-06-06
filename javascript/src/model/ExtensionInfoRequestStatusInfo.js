(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './StatusInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./StatusInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ExtensionInfoRequestStatusInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.StatusInfo);
  }
}(this, function(ApiClient, StatusInfo) {
  'use strict';

  /**
   * The ExtensionInfoRequestStatusInfo model module.
   * @module model/ExtensionInfoRequestStatusInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionInfoRequestStatusInfo</code>.
   * @alias module:model/ExtensionInfoRequestStatusInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>ExtensionInfoRequestStatusInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionInfoRequestStatusInfo} obj Optional instance to populate.
   * @return {module:model/ExtensionInfoRequestStatusInfo} The populated <code>ExtensionInfoRequestStatusInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('status')) {
        obj['status'] = ApiClient.convertToType(data['status'], 'String');
      }
      if (data.hasOwnProperty('statusInfo')) {
        obj['statusInfo'] = StatusInfo.constructFromObject(data['statusInfo']);
      }
    }
    return obj;
  }


  /**
   * Required extension status
   * @member {module:model/ExtensionInfoRequestStatusInfo.StatusEnum} status
   */
  exports.prototype['status'] = undefined;

  /**
   * @member {module:model/StatusInfo} statusInfo
   */
  exports.prototype['statusInfo'] = undefined;


  /**
   * Allowed values for the <code>status</code> property.
   * @enum {String}
   * @readonly
   */
  exports.StatusEnum = { 
    /**
     * value: Disabled
     * @const
     */
    DISABLED: "Disabled",
    
    /**
     * value: Enabled
     * @const
     */
    ENABLED: "Enabled",
    
    /**
     * value: NotActivated
     * @const
     */
    NOTACTIVATED: "NotActivated"
  };

  return exports;
}));
