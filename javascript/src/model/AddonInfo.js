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
    root.RingCentralApi.AddonInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The AddonInfo model module.
   * @module model/AddonInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>AddonInfo</code>.
   * @alias module:model/AddonInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>AddonInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/AddonInfo} obj Optional instance to populate.
   * @return {module:model/AddonInfo} The populated <code>AddonInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('count')) {
        obj['count'] = ApiClient.convertToType(data['count'], 'Integer');
      }
    }
    return obj;
  }


  /**
   * Addon identifier. For HardPhones of certain types, which are compatible with this addon identifier
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Number of addons. For HardPhones of certain types, which are compatible with such addon identifier
   * @member {Integer} count
   */
  exports.prototype['count'] = undefined;




  return exports;
}));
