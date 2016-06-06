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
    root.RingCentralApi.ExtensionServiceFeatureInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ExtensionServiceFeatureInfo model module.
   * @module model/ExtensionServiceFeatureInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionServiceFeatureInfo</code>.
   * @alias module:model/ExtensionServiceFeatureInfo
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>ExtensionServiceFeatureInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionServiceFeatureInfo} obj Optional instance to populate.
   * @return {module:model/ExtensionServiceFeatureInfo} The populated <code>ExtensionServiceFeatureInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('enabled')) {
        obj['enabled'] = ApiClient.convertToType(data['enabled'], 'Boolean');
      }
      if (data.hasOwnProperty('featureName')) {
        obj['featureName'] = ApiClient.convertToType(data['featureName'], 'String');
      }
      if (data.hasOwnProperty('reason')) {
        obj['reason'] = ApiClient.convertToType(data['reason'], 'String');
      }
    }
    return obj;
  }


  /**
   * Feature status; shows feature availability for an extension
   * @member {Boolean} enabled
   */
  exports.prototype['enabled'] = undefined;

  /**
   * Feature name, see all available values in Service Feature List
   * @member {String} featureName
   */
  exports.prototype['featureName'] = undefined;

  /**
   * Reason of limitation for a particular service feature. Returned only if the enabled parameter value is 'False', see Service Feature Limitations and Reasons. When retrieving service features for an extension, the reasons for the limitations, if any, are returned in response
   * @member {String} reason
   */
  exports.prototype['reason'] = undefined;




  return exports;
}));
