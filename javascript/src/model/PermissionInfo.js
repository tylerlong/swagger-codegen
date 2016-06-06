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
    root.RingCentralApi.PermissionInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The PermissionInfo model module.
   * @module model/PermissionInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>PermissionInfo</code>.
   * @alias module:model/PermissionInfo
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>PermissionInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PermissionInfo} obj Optional instance to populate.
   * @return {module:model/PermissionInfo} The populated <code>PermissionInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('enabled')) {
        obj['enabled'] = ApiClient.convertToType(data['enabled'], 'Boolean');
      }
    }
    return obj;
  }


  /**
   * Specifies if a permission is enabled or not
   * @member {Boolean} enabled
   */
  exports.prototype['enabled'] = undefined;




  return exports;
}));
