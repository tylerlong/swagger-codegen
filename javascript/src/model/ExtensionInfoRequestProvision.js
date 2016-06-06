(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './ExtensionInfoRequestProvisionContactInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ExtensionInfoRequestProvisionContactInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ExtensionInfoRequestProvision = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.ExtensionInfoRequestProvisionContactInfo);
  }
}(this, function(ApiClient, ExtensionInfoRequestProvisionContactInfo) {
  'use strict';

  /**
   * The ExtensionInfoRequestProvision model module.
   * @module model/ExtensionInfoRequestProvision
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionInfoRequestProvision</code>.
   * @alias module:model/ExtensionInfoRequestProvision
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>ExtensionInfoRequestProvision</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionInfoRequestProvision} obj Optional instance to populate.
   * @return {module:model/ExtensionInfoRequestProvision} The populated <code>ExtensionInfoRequestProvision</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('status')) {
        obj['status'] = ApiClient.convertToType(data['status'], 'String');
      }
      if (data.hasOwnProperty('contact')) {
        obj['contact'] = ExtensionInfoRequestProvisionContactInfo.constructFromObject(data['contact']);
      }
    }
    return obj;
  }


  /**
   * Mandatory. Resulting extension status
   * @member {module:model/ExtensionInfoRequestProvision.StatusEnum} status
   */
  exports.prototype['status'] = undefined;

  /**
   * @member {module:model/ExtensionInfoRequestProvisionContactInfo} contact
   */
  exports.prototype['contact'] = undefined;


  /**
   * Allowed values for the <code>status</code> property.
   * @enum {String}
   * @readonly
   */
  exports.StatusEnum = { 
    /**
     * value: NotActivated
     * @const
     */
    NOTACTIVATED: "NotActivated"
  };

  return exports;
}));
