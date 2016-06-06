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
    root.RingCentralApi.ExtensionInfoRequestProvisionContactInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ExtensionInfoRequestProvisionContactInfo model module.
   * @module model/ExtensionInfoRequestProvisionContactInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionInfoRequestProvisionContactInfo</code>.
   * @alias module:model/ExtensionInfoRequestProvisionContactInfo
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>ExtensionInfoRequestProvisionContactInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionInfoRequestProvisionContactInfo} obj Optional instance to populate.
   * @return {module:model/ExtensionInfoRequestProvisionContactInfo} The populated <code>ExtensionInfoRequestProvisionContactInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('firstName')) {
        obj['firstName'] = ApiClient.convertToType(data['firstName'], 'String');
      }
      if (data.hasOwnProperty('lastName')) {
        obj['lastName'] = ApiClient.convertToType(data['lastName'], 'String');
      }
      if (data.hasOwnProperty('email')) {
        obj['email'] = ApiClient.convertToType(data['email'], 'String');
      }
    }
    return obj;
  }


  /**
   * Mandatory. Extension user first name
   * @member {String} firstName
   */
  exports.prototype['firstName'] = undefined;

  /**
   * Mandatory. Extension user last name
   * @member {String} lastName
   */
  exports.prototype['lastName'] = undefined;

  /**
   * Mandatory. Extension user contact email
   * @member {String} email
   */
  exports.prototype['email'] = undefined;




  return exports;
}));
