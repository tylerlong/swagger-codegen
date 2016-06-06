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
    root.RingCentralApi.AnsweringRuleInfoCalleeInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The AnsweringRuleInfoCalleeInfo model module.
   * @module model/AnsweringRuleInfoCalleeInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>AnsweringRuleInfoCalleeInfo</code>.
   * @alias module:model/AnsweringRuleInfoCalleeInfo
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>AnsweringRuleInfoCalleeInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/AnsweringRuleInfoCalleeInfo} obj Optional instance to populate.
   * @return {module:model/AnsweringRuleInfoCalleeInfo} The populated <code>AnsweringRuleInfoCalleeInfo</code> instance.
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
   * Called phone number
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;




  return exports;
}));
