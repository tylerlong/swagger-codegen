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
    root.RingCentralApi.RingOutRequestFrom = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The RingOutRequestFrom model module.
   * @module model/RingOutRequestFrom
   * @version v1.0
   */

  /**
   * Constructs a new <code>RingOutRequestFrom</code>.
   * @alias module:model/RingOutRequestFrom
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>RingOutRequestFrom</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RingOutRequestFrom} obj Optional instance to populate.
   * @return {module:model/RingOutRequestFrom} The populated <code>RingOutRequestFrom</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
      if (data.hasOwnProperty('forwardingNumberId')) {
        obj['forwardingNumberId'] = ApiClient.convertToType(data['forwardingNumberId'], 'String');
      }
    }
    return obj;
  }


  /**
   * Phone number in E.164 format
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;

  /**
   * Internal identifier of a forwarding number; returned in response in the id field. Can be specified instead of the phoneNumber attribute
   * @member {String} forwardingNumberId
   */
  exports.prototype['forwardingNumberId'] = undefined;




  return exports;
}));
