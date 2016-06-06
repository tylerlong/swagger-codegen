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
    root.RingCentralApi.ContactAddressInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ContactAddressInfo model module.
   * @module model/ContactAddressInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ContactAddressInfo</code>.
   * @alias module:model/ContactAddressInfo
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>ContactAddressInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ContactAddressInfo} obj Optional instance to populate.
   * @return {module:model/ContactAddressInfo} The populated <code>ContactAddressInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('country')) {
        obj['country'] = ApiClient.convertToType(data['country'], 'String');
      }
      if (data.hasOwnProperty('state')) {
        obj['state'] = ApiClient.convertToType(data['state'], 'String');
      }
      if (data.hasOwnProperty('city')) {
        obj['city'] = ApiClient.convertToType(data['city'], 'String');
      }
      if (data.hasOwnProperty('street')) {
        obj['street'] = ApiClient.convertToType(data['street'], 'String');
      }
      if (data.hasOwnProperty('zip')) {
        obj['zip'] = ApiClient.convertToType(data['zip'], 'String');
      }
    }
    return obj;
  }


  /**
   * Country name of extension user company. Not returned for Address Book
   * @member {String} country
   */
  exports.prototype['country'] = undefined;

  /**
   * State/province name of extension user company
   * @member {String} state
   */
  exports.prototype['state'] = undefined;

  /**
   * City name of extension user company
   * @member {String} city
   */
  exports.prototype['city'] = undefined;

  /**
   * Street address of extension user company
   * @member {String} street
   */
  exports.prototype['street'] = undefined;

  /**
   * Zip code of extension user company
   * @member {String} zip
   */
  exports.prototype['zip'] = undefined;




  return exports;
}));
