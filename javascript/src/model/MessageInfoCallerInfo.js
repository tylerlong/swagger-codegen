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
    root.RingCentralApi.MessageInfoCallerInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The MessageInfoCallerInfo model module.
   * @module model/MessageInfoCallerInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>MessageInfoCallerInfo</code>.
   * @alias module:model/MessageInfoCallerInfo
   * @class
   */
  var exports = function() {







  };

  /**
   * Constructs a <code>MessageInfoCallerInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/MessageInfoCallerInfo} obj Optional instance to populate.
   * @return {module:model/MessageInfoCallerInfo} The populated <code>MessageInfoCallerInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('extensionNumber')) {
        obj['extensionNumber'] = ApiClient.convertToType(data['extensionNumber'], 'String');
      }
      if (data.hasOwnProperty('location')) {
        obj['location'] = ApiClient.convertToType(data['location'], 'String');
      }
      if (data.hasOwnProperty('messageStatus')) {
        obj['messageStatus'] = ApiClient.convertToType(data['messageStatus'], 'String');
      }
      if (data.hasOwnProperty('faxErrorCode')) {
        obj['faxErrorCode'] = ApiClient.convertToType(data['faxErrorCode'], 'String');
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
   * Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message
   * @member {String} extensionNumber
   */
  exports.prototype['extensionNumber'] = undefined;

  /**
   * Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)
   * @member {String} location
   */
  exports.prototype['location'] = undefined;

  /**
   * Status of a message. Returned for outbound fax messages only
   * @member {module:model/MessageInfoCallerInfo.MessageStatusEnum} messageStatus
   */
  exports.prototype['messageStatus'] = undefined;

  /**
   * Fax only. Error code returned in case of fax sending failure. Returned if messageStatus value is 'SendingFailed'
   * @member {module:model/MessageInfoCallerInfo.FaxErrorCodeEnum} faxErrorCode
   */
  exports.prototype['faxErrorCode'] = undefined;

  /**
   * Symbolic name associated with a party. If the phone does not belong to the known extension, only the location is returned, the name is not determined then
   * @member {String} name
   */
  exports.prototype['name'] = undefined;

  /**
   * Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;


  /**
   * Allowed values for the <code>messageStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.MessageStatusEnum = { 
    /**
     * value: Queued
     * @const
     */
    QUEUED: "Queued",
    
    /**
     * value: Sent
     * @const
     */
    SENT: "Sent",
    
    /**
     * value: Delivered
     * @const
     */
    DELIVERED: "Delivered",
    
    /**
     * value: DeliveryFailed
     * @const
     */
    DELIVERYFAILED: "DeliveryFailed",
    
    /**
     * value: SendingFailed
     * @const
     */
    SENDINGFAILED: "SendingFailed",
    
    /**
     * value: Received
     * @const
     */
    RECEIVED: "Received"
  };  /**
   * Allowed values for the <code>faxErrorCode</code> property.
   * @enum {String}
   * @readonly
   */
  exports.FaxErrorCodeEnum = { 
    /**
     * value: Undefined
     * @const
     */
    UNDEFINED: "Undefined",
    
    /**
     * value: NoFaxSendPermission
     * @const
     */
    NOFAXSENDPERMISSION: "NoFaxSendPermission",
    
    /**
     * value: NoInternationalPermission
     * @const
     */
    NOINTERNATIONALPERMISSION: "NoInternationalPermission",
    
    /**
     * value: NoFaxMachine
     * @const
     */
    NOFAXMACHINE: "NoFaxMachine",
    
    /**
     * value: OutgoingCallError
     * @const
     */
    OUTGOINGCALLERROR: "OutgoingCallError",
    
    /**
     * value: RenderingFailed
     * @const
     */
    RENDERINGFAILED: "RenderingFailed",
    
    /**
     * value: TooManyPages
     * @const
     */
    TOOMANYPAGES: "TooManyPages",
    
    /**
     * value: ReturnToDBQueue
     * @const
     */
    RETURNTODBQUEUE: "ReturnToDBQueue",
    
    /**
     * value: NoCallTime
     * @const
     */
    NOCALLTIME: "NoCallTime",
    
    /**
     * value: WrongNumber
     * @const
     */
    WRONGNUMBER: "WrongNumber",
    
    /**
     * value: ProhibitedNumber
     * @const
     */
    PROHIBITEDNUMBER: "ProhibitedNumber",
    
    /**
     * value: InternalError
     * @const
     */
    INTERNALERROR: "InternalError",
    
    /**
     * value: FaxSendingProhibited
     * @const
     */
    FAXSENDINGPROHIBITED: "FaxSendingProhibited",
    
    /**
     * value: ThePhoneIsBlacklisted
     * @const
     */
    THEPHONEISBLACKLISTED: "ThePhoneIsBlacklisted",
    
    /**
     * value: UserNotFound
     * @const
     */
    USERNOTFOUND: "UserNotFound",
    
    /**
     * value: ConvertError
     * @const
     */
    CONVERTERROR: "ConvertError",
    
    /**
     * value: DBGeneralError
     * @const
     */
    DBGENERALERROR: "DBGeneralError",
    
    /**
     * value: SkypeBillingFailed
     * @const
     */
    SKYPEBILLINGFAILED: "SkypeBillingFailed",
    
    /**
     * value: AccountSuspended
     * @const
     */
    ACCOUNTSUSPENDED: "AccountSuspended",
    
    /**
     * value: ProhibitedDestination
     * @const
     */
    PROHIBITEDDESTINATION: "ProhibitedDestination",
    
    /**
     * value: InternationalDisabled
     * @const
     */
    INTERNATIONALDISABLED: "InternationalDisabled"
  };

  return exports;
}));
