(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './ExtensionInfo', './ServiceInfo', './StatusInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ExtensionInfo'), require('./ServiceInfo'), require('./StatusInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.AccountInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.ExtensionInfo, root.RingCentralApi.ServiceInfo, root.RingCentralApi.StatusInfo);
  }
}(this, function(ApiClient, ExtensionInfo, ServiceInfo, StatusInfo) {
  'use strict';

  /**
   * The AccountInfo model module.
   * @module model/AccountInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>AccountInfo</code>.
   * @alias module:model/AccountInfo
   * @class
   */
  var exports = function() {










  };

  /**
   * Constructs a <code>AccountInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/AccountInfo} obj Optional instance to populate.
   * @return {module:model/AccountInfo} The populated <code>AccountInfo</code> instance.
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
      if (data.hasOwnProperty('mainNumber')) {
        obj['mainNumber'] = ApiClient.convertToType(data['mainNumber'], 'String');
      }
      if (data.hasOwnProperty('operator')) {
        obj['operator'] = ExtensionInfo.constructFromObject(data['operator']);
      }
      if (data.hasOwnProperty('partnerId')) {
        obj['partnerId'] = ApiClient.convertToType(data['partnerId'], 'String');
      }
      if (data.hasOwnProperty('serviceInfo')) {
        obj['serviceInfo'] = ServiceInfo.constructFromObject(data['serviceInfo']);
      }
      if (data.hasOwnProperty('setupWizardState')) {
        obj['setupWizardState'] = ApiClient.convertToType(data['setupWizardState'], 'String');
      }
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
   * Internal identifier of an account
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of an account
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Main phone number of the current account
   * @member {String} mainNumber
   */
  exports.prototype['mainNumber'] = undefined;

  /**
   * @member {module:model/ExtensionInfo} operator
   */
  exports.prototype['operator'] = undefined;

  /**
   * Additional account identifier, developed and applied by the client
   * @member {String} partnerId
   */
  exports.prototype['partnerId'] = undefined;

  /**
   * @member {module:model/ServiceInfo} serviceInfo
   */
  exports.prototype['serviceInfo'] = undefined;

  /**
   * Specifies account configuration wizard state (web service setup). The default value is 'NotStarted'
   * @member {module:model/AccountInfo.SetupWizardStateEnum} setupWizardState
   */
  exports.prototype['setupWizardState'] = undefined;

  /**
   * Status of the current account
   * @member {module:model/AccountInfo.StatusEnum} status
   */
  exports.prototype['status'] = undefined;

  /**
   * @member {module:model/StatusInfo} statusInfo
   */
  exports.prototype['statusInfo'] = undefined;


  /**
   * Allowed values for the <code>setupWizardState</code> property.
   * @enum {String}
   * @readonly
   */
  exports.SetupWizardStateEnum = { 
    /**
     * value: NotStarted
     * @const
     */
    NOTSTARTED: "NotStarted",
    
    /**
     * value: Incomplete
     * @const
     */
    INCOMPLETE: "Incomplete",
    
    /**
     * value: Completed
     * @const
     */
    COMPLETED: "Completed"
  };  /**
   * Allowed values for the <code>status</code> property.
   * @enum {String}
   * @readonly
   */
  exports.StatusEnum = { 
    /**
     * value: Confirmed
     * @const
     */
    CONFIRMED: "Confirmed",
    
    /**
     * value: Disabled
     * @const
     */
    DISABLED: "Disabled"
  };

  return exports;
}));
