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
    root.RingCentralApi.BlockedNumberInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The BlockedNumberInfo model module.
   * @module model/BlockedNumberInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>BlockedNumberInfo</code>.
   * @alias module:model/BlockedNumberInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>BlockedNumberInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/BlockedNumberInfo} obj Optional instance to populate.
   * @return {module:model/BlockedNumberInfo} The populated <code>BlockedNumberInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
    }
    return obj;
  }


  /**
   * Standard resource properties ID and canonical URI, see the section called \u201CResource Identification Properties\u201D
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a blocked number resource
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Name assigned by a user to a blocked phone number
   * @member {String} name
   */
  exports.prototype['name'] = undefined;

  /**
   * Phone number to be blocked
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;




  return exports;
}));
