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
    root.RingCentralApi.DeviceInfoExtensionInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The DeviceInfoExtensionInfo model module.
   * @module model/DeviceInfoExtensionInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>DeviceInfoExtensionInfo</code>.
   * @alias module:model/DeviceInfoExtensionInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>DeviceInfoExtensionInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/DeviceInfoExtensionInfo} obj Optional instance to populate.
   * @return {module:model/DeviceInfoExtensionInfo} The populated <code>DeviceInfoExtensionInfo</code> instance.
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
      if (data.hasOwnProperty('extensionNumber')) {
        obj['extensionNumber'] = ApiClient.convertToType(data['extensionNumber'], 'String');
      }
      if (data.hasOwnProperty('partnerId')) {
        obj['partnerId'] = ApiClient.convertToType(data['partnerId'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of an extension
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of an extension
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Number of department extension
   * @member {String} extensionNumber
   */
  exports.prototype['extensionNumber'] = undefined;

  /**
   * For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
   * @member {String} partnerId
   */
  exports.prototype['partnerId'] = undefined;




  return exports;
}));
