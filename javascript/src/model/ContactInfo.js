(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './ContactAddressInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ContactAddressInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ContactInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.ContactAddressInfo);
  }
}(this, function(ApiClient, ContactAddressInfo) {
  'use strict';

  /**
   * The ContactInfo model module.
   * @module model/ContactInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ContactInfo</code>.
   * @alias module:model/ContactInfo
   * @class
   */
  var exports = function() {







  };

  /**
   * Constructs a <code>ContactInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ContactInfo} obj Optional instance to populate.
   * @return {module:model/ContactInfo} The populated <code>ContactInfo</code> instance.
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
      if (data.hasOwnProperty('company')) {
        obj['company'] = ApiClient.convertToType(data['company'], 'String');
      }
      if (data.hasOwnProperty('email')) {
        obj['email'] = ApiClient.convertToType(data['email'], 'String');
      }
      if (data.hasOwnProperty('businessPhone')) {
        obj['businessPhone'] = ApiClient.convertToType(data['businessPhone'], 'String');
      }
      if (data.hasOwnProperty('businessAddress')) {
        obj['businessAddress'] = ContactAddressInfo.constructFromObject(data['businessAddress']);
      }
    }
    return obj;
  }


  /**
   * For User extension type only. Extension user first name
   * @member {String} firstName
   */
  exports.prototype['firstName'] = undefined;

  /**
   * For User extension type only. Extension user last name
   * @member {String} lastName
   */
  exports.prototype['lastName'] = undefined;

  /**
   * Extension user company name
   * @member {String} company
   */
  exports.prototype['company'] = undefined;

  /**
   * Email of extension user
   * @member {String} email
   */
  exports.prototype['email'] = undefined;

  /**
   * Extension user contact phone number
   * @member {String} businessPhone
   */
  exports.prototype['businessPhone'] = undefined;

  /**
   * @member {module:model/ContactAddressInfo} businessAddress
   */
  exports.prototype['businessAddress'] = undefined;




  return exports;
}));
