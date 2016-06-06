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
    root.RingCentralApi.ConferencingRequestPhoneNumber = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ConferencingRequestPhoneNumber model module.
   * @module model/ConferencingRequestPhoneNumber
   * @version v1.0
   */

  /**
   * Constructs a new <code>ConferencingRequestPhoneNumber</code>.
   * @alias module:model/ConferencingRequestPhoneNumber
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>ConferencingRequestPhoneNumber</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ConferencingRequestPhoneNumber} obj Optional instance to populate.
   * @return {module:model/ConferencingRequestPhoneNumber} The populated <code>ConferencingRequestPhoneNumber</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
      if (data.hasOwnProperty('default')) {
        obj['default'] = ApiClient.convertToType(data['default'], 'Boolean');
      }
    }
    return obj;
  }


  /**
   * Dial-in phone number to connect to a conference
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;

  /**
   * 'True' if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed
   * @member {Boolean} default
   */
  exports.prototype['default'] = undefined;




  return exports;
}));
