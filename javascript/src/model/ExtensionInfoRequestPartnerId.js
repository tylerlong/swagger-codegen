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
    root.RingCentralApi.ExtensionInfoRequestPartnerId = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ExtensionInfoRequestPartnerId model module.
   * @module model/ExtensionInfoRequestPartnerId
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionInfoRequestPartnerId</code>.
   * @alias module:model/ExtensionInfoRequestPartnerId
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>ExtensionInfoRequestPartnerId</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionInfoRequestPartnerId} obj Optional instance to populate.
   * @return {module:model/ExtensionInfoRequestPartnerId} The populated <code>ExtensionInfoRequestPartnerId</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('partnerId')) {
        obj['partnerId'] = ApiClient.convertToType(data['partnerId'], 'String');
      }
    }
    return obj;
  }


  /**
   * Extension partner identifier
   * @member {String} partnerId
   */
  exports.prototype['partnerId'] = undefined;




  return exports;
}));
