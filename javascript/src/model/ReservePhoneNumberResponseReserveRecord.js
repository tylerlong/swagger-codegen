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
    root.RingCentralApi.ReservePhoneNumberResponseReserveRecord = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ReservePhoneNumberResponseReserveRecord model module.
   * @module model/ReservePhoneNumberResponseReserveRecord
   * @version v1.0
   */

  /**
   * Constructs a new <code>ReservePhoneNumberResponseReserveRecord</code>.
   * @alias module:model/ReservePhoneNumberResponseReserveRecord
   * @class
   */
  var exports = function() {







  };

  /**
   * Constructs a <code>ReservePhoneNumberResponseReserveRecord</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ReservePhoneNumberResponseReserveRecord} obj Optional instance to populate.
   * @return {module:model/ReservePhoneNumberResponseReserveRecord} The populated <code>ReservePhoneNumberResponseReserveRecord</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
      if (data.hasOwnProperty('formattedNumber')) {
        obj['formattedNumber'] = ApiClient.convertToType(data['formattedNumber'], 'String');
      }
      if (data.hasOwnProperty('reservedTill')) {
        obj['reservedTill'] = ApiClient.convertToType(data['reservedTill'], 'Date');
      }
      if (data.hasOwnProperty('reservationId')) {
        obj['reservationId'] = ApiClient.convertToType(data['reservationId'], 'String');
      }
      if (data.hasOwnProperty('status')) {
        obj['status'] = ApiClient.convertToType(data['status'], 'String');
      }
      if (data.hasOwnProperty('error')) {
        obj['error'] = ApiClient.convertToType(data['error'], 'String');
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
   * Domestic format of a phone number
   * @member {String} formattedNumber
   */
  exports.prototype['formattedNumber'] = undefined;

  /**
   * The datetime up to which the number is reserved in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. No value means that number is not reserved anymore
   * @member {Date} reservedTill
   */
  exports.prototype['reservedTill'] = undefined;

  /**
   * Internal identifier of phone number reservation; encoded data including reservation type (by brand, by account, by session), particular brand/account/session data, and reservation date and time
   * @member {String} reservationId
   */
  exports.prototype['reservationId'] = undefined;

  /**
   * Phone number status
   * @member {module:model/ReservePhoneNumberResponseReserveRecord.StatusEnum} status
   */
  exports.prototype['status'] = undefined;

  /**
   * The error code in case of reservation/un-reservation failure
   * @member {module:model/ReservePhoneNumberResponseReserveRecord.ErrorEnum} error
   */
  exports.prototype['error'] = undefined;


  /**
   * Allowed values for the <code>status</code> property.
   * @enum {String}
   * @readonly
   */
  exports.StatusEnum = { 
    /**
     * value: Enabled
     * @const
     */
    ENABLED: "Enabled",
    
    /**
     * value: Pending
     * @const
     */
    PENDING: "Pending",
    
    /**
     * value: Disabled
     * @const
     */
    DISABLED: "Disabled"
  };  /**
   * Allowed values for the <code>error</code> property.
   * @enum {String}
   * @readonly
   */
  exports.ErrorEnum = { 
    /**
     * value: NumberIsAlreadyProvisioned
     * @const
     */
    NUMBERISALREADYPROVISIONED: "NumberIsAlreadyProvisioned",
    
    /**
     * value: NumberReserved
     * @const
     */
    NUMBERRESERVED: "NumberReserved",
    
    /**
     * value: NumberNotAvailable
     * @const
     */
    NUMBERNOTAVAILABLE: "NumberNotAvailable"
  };

  return exports;
}));
