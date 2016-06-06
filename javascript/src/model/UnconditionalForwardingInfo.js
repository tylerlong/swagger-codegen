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
    root.RingCentralApi.UnconditionalForwardingInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The UnconditionalForwardingInfo model module.
   * @module model/UnconditionalForwardingInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>UnconditionalForwardingInfo</code>.
   * @alias module:model/UnconditionalForwardingInfo
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>UnconditionalForwardingInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/UnconditionalForwardingInfo} obj Optional instance to populate.
   * @return {module:model/UnconditionalForwardingInfo} The populated <code>UnconditionalForwardingInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
    }
    return obj;
  }


  /**
   * Phone number to which the call is forwarded
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;




  return exports;
}));
