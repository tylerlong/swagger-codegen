(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './PermissionInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./PermissionInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ExtensionPermissions = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.PermissionInfo);
  }
}(this, function(ApiClient, PermissionInfo) {
  'use strict';

  /**
   * The ExtensionPermissions model module.
   * @module model/ExtensionPermissions
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionPermissions</code>.
   * @alias module:model/ExtensionPermissions
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>ExtensionPermissions</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionPermissions} obj Optional instance to populate.
   * @return {module:model/ExtensionPermissions} The populated <code>ExtensionPermissions</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('admin')) {
        obj['admin'] = PermissionInfo.constructFromObject(data['admin']);
      }
      if (data.hasOwnProperty('internationalCalling')) {
        obj['internationalCalling'] = PermissionInfo.constructFromObject(data['internationalCalling']);
      }
    }
    return obj;
  }


  /**
   * @member {module:model/PermissionInfo} admin
   */
  exports.prototype['admin'] = undefined;

  /**
   * @member {module:model/PermissionInfo} internationalCalling
   */
  exports.prototype['internationalCalling'] = undefined;




  return exports;
}));
