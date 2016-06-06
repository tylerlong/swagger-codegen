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
    root.RingCentralApi.ReservePhoneNumberRequestReserveRecord = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ReservePhoneNumberRequestReserveRecord model module.
   * @module model/ReservePhoneNumberRequestReserveRecord
   * @version v1.0
   */

  /**
   * Constructs a new <code>ReservePhoneNumberRequestReserveRecord</code>.
   * @alias module:model/ReservePhoneNumberRequestReserveRecord
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>ReservePhoneNumberRequestReserveRecord</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ReservePhoneNumberRequestReserveRecord} obj Optional instance to populate.
   * @return {module:model/ReservePhoneNumberRequestReserveRecord} The populated <code>ReservePhoneNumberRequestReserveRecord</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
      if (data.hasOwnProperty('reservedTill')) {
        obj['reservedTill'] = ApiClient.convertToType(data['reservedTill'], 'Date');
      }
    }
    return obj;
  }


  /**
   * Phone number in E.164 format without a '+'
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;

  /**
   * The datetime up to which the number is reserved in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. If it is omitted or explicitly set to 'null', the number will be un-reserved if it was reserved previously by the same session. 'Min' value is 30 seconds; 'Max' value is 30 days (for reservation by brand) and 20 minutes (for reservation by account/session)
   * @member {Date} reservedTill
   */
  exports.prototype['reservedTill'] = undefined;




  return exports;
}));
