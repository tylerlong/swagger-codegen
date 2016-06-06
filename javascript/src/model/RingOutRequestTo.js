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
    root.RingCentralApi.RingOutRequestTo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The RingOutRequestTo model module.
   * @module model/RingOutRequestTo
   * @version v1.0
   */

  /**
   * Constructs a new <code>RingOutRequestTo</code>.
   * @alias module:model/RingOutRequestTo
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>RingOutRequestTo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RingOutRequestTo} obj Optional instance to populate.
   * @return {module:model/RingOutRequestTo} The populated <code>RingOutRequestTo</code> instance.
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
   * Phone number in E.164 format
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;




  return exports;
}));
