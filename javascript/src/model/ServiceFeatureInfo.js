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
    root.RingCentralApi.ServiceFeatureInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ServiceFeatureInfo model module.
   * @module model/ServiceFeatureInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ServiceFeatureInfo</code>.
   * @alias module:model/ServiceFeatureInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>ServiceFeatureInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ServiceFeatureInfo} obj Optional instance to populate.
   * @return {module:model/ServiceFeatureInfo} The populated <code>ServiceFeatureInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('featureName')) {
        obj['featureName'] = ApiClient.convertToType(data['featureName'], 'String');
      }
      if (data.hasOwnProperty('enabled')) {
        obj['enabled'] = ApiClient.convertToType(data['enabled'], 'Boolean');
      }
    }
    return obj;
  }


  /**
   * Feature name, see all available values in Service Feature List
   * @member {String} featureName
   */
  exports.prototype['featureName'] = undefined;

  /**
   * Feature status, shows feature availability for the extension
   * @member {Boolean} enabled
   */
  exports.prototype['enabled'] = undefined;




  return exports;
}));
