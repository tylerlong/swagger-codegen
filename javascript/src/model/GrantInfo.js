(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './GrantInfoExtensionInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./GrantInfoExtensionInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.GrantInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.GrantInfoExtensionInfo);
  }
}(this, function(ApiClient, GrantInfoExtensionInfo) {
  'use strict';

  /**
   * The GrantInfo model module.
   * @module model/GrantInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>GrantInfo</code>.
   * @alias module:model/GrantInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>GrantInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/GrantInfo} obj Optional instance to populate.
   * @return {module:model/GrantInfo} The populated <code>GrantInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('extension')) {
        obj['extension'] = GrantInfoExtensionInfo.constructFromObject(data['extension']);
      }
      if (data.hasOwnProperty('callPickup')) {
        obj['callPickup'] = ApiClient.convertToType(data['callPickup'], 'Boolean');
      }
      if (data.hasOwnProperty('callMonitoring')) {
        obj['callMonitoring'] = ApiClient.convertToType(data['callMonitoring'], 'Boolean');
      }
    }
    return obj;
  }


  /**
   * Canonical URI of a grant
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * @member {module:model/GrantInfoExtensionInfo} extension
   */
  exports.prototype['extension'] = undefined;

  /**
   * Specifies if picking up of other extensions' calls is allowed for the extension. If 'Presence' feature is disabled for the given extension, the flag is not returned
   * @member {Boolean} callPickup
   */
  exports.prototype['callPickup'] = undefined;

  /**
   * Specifies if monitoring of other extensions' calls is allowed for the extension. If 'CallMonitoring' feature is disabled for the given extension, the flag is not returned
   * @member {Boolean} callMonitoring
   */
  exports.prototype['callMonitoring'] = undefined;




  return exports;
}));
