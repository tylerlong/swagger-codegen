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
    root.RingCentralApi.AnsweringRuleInfoCallerInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The AnsweringRuleInfoCallerInfo model module.
   * @module model/AnsweringRuleInfoCallerInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>AnsweringRuleInfoCallerInfo</code>.
   * @alias module:model/AnsweringRuleInfoCallerInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>AnsweringRuleInfoCallerInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/AnsweringRuleInfoCallerInfo} obj Optional instance to populate.
   * @return {module:model/AnsweringRuleInfoCallerInfo} The populated <code>AnsweringRuleInfoCallerInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('callerId')) {
        obj['callerId'] = ApiClient.convertToType(data['callerId'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
    }
    return obj;
  }


  /**
   * Phone number of a caller
   * @member {String} callerId
   */
  exports.prototype['callerId'] = undefined;

  /**
   * Contact name of a caller
   * @member {String} name
   */
  exports.prototype['name'] = undefined;




  return exports;
}));
