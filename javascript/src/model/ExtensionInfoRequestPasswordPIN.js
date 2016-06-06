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
    root.RingCentralApi.ExtensionInfoRequestPasswordPIN = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ExtensionInfoRequestPasswordPIN model module.
   * @module model/ExtensionInfoRequestPasswordPIN
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionInfoRequestPasswordPIN</code>.
   * @alias module:model/ExtensionInfoRequestPasswordPIN
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>ExtensionInfoRequestPasswordPIN</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionInfoRequestPasswordPIN} obj Optional instance to populate.
   * @return {module:model/ExtensionInfoRequestPasswordPIN} The populated <code>ExtensionInfoRequestPasswordPIN</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('password')) {
        obj['password'] = ApiClient.convertToType(data['password'], 'String');
      }
      if (data.hasOwnProperty('ivrPin')) {
        obj['ivrPin'] = ApiClient.convertToType(data['ivrPin'], 'String');
      }
    }
    return obj;
  }


  /**
   * Password for extension
   * @member {String} password
   */
  exports.prototype['password'] = undefined;

  /**
   * IVR PIN
   * @member {String} ivrPin
   */
  exports.prototype['ivrPin'] = undefined;




  return exports;
}));
