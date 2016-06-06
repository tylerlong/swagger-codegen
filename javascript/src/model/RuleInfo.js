(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './RuleInfoForwardingNumberInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./RuleInfoForwardingNumberInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.RuleInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.RuleInfoForwardingNumberInfo);
  }
}(this, function(ApiClient, RuleInfoForwardingNumberInfo) {
  'use strict';

  /**
   * The RuleInfo model module.
   * @module model/RuleInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>RuleInfo</code>.
   * @alias module:model/RuleInfo
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>RuleInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RuleInfo} obj Optional instance to populate.
   * @return {module:model/RuleInfo} The populated <code>RuleInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('index')) {
        obj['index'] = ApiClient.convertToType(data['index'], 'Integer');
      }
      if (data.hasOwnProperty('ringCount')) {
        obj['ringCount'] = ApiClient.convertToType(data['ringCount'], 'Integer');
      }
      if (data.hasOwnProperty('forwardingNumbers')) {
        obj['forwardingNumbers'] = ApiClient.convertToType(data['forwardingNumbers'], [RuleInfoForwardingNumberInfo]);
      }
    }
    return obj;
  }


  /**
   * Forwarding number (or group) ordinal
   * @member {Integer} index
   */
  exports.prototype['index'] = undefined;

  /**
   * Number of rings for a forwarding number (or group)
   * @member {Integer} ringCount
   */
  exports.prototype['ringCount'] = undefined;

  /**
   * Forwarding number (or group) data
   * @member {Array.<module:model/RuleInfoForwardingNumberInfo>} forwardingNumbers
   */
  exports.prototype['forwardingNumbers'] = undefined;




  return exports;
}));
