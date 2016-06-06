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
    root.RingCentralApi.RuleInfoForwardingNumberInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The RuleInfoForwardingNumberInfo model module.
   * @module model/RuleInfoForwardingNumberInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>RuleInfoForwardingNumberInfo</code>.
   * @alias module:model/RuleInfoForwardingNumberInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>RuleInfoForwardingNumberInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RuleInfoForwardingNumberInfo} obj Optional instance to populate.
   * @return {module:model/RuleInfoForwardingNumberInfo} The populated <code>RuleInfoForwardingNumberInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
      if (data.hasOwnProperty('label')) {
        obj['label'] = ApiClient.convertToType(data['label'], 'String');
      }
    }
    return obj;
  }


  /**
   * Link to a forwarding number resource
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Internal identifier of a forwarding number
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Phone number to which the call is forwarded
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;

  /**
   * Title of a forwarding number
   * @member {String} label
   */
  exports.prototype['label'] = undefined;




  return exports;
}));
