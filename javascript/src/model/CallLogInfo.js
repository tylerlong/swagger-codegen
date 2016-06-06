(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './CallerInfo', './RecordingInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CallerInfo'), require('./RecordingInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.CallLogInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.CallerInfo, root.RingCentralApi.RecordingInfo);
  }
}(this, function(ApiClient, CallerInfo, RecordingInfo) {
  'use strict';

  /**
   * The CallLogInfo model module.
   * @module model/CallLogInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>CallLogInfo</code>.
   * @alias module:model/CallLogInfo
   * @class
   */
  var exports = function() {













  };

  /**
   * Constructs a <code>CallLogInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/CallLogInfo} obj Optional instance to populate.
   * @return {module:model/CallLogInfo} The populated <code>CallLogInfo</code> instance.
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
      if (data.hasOwnProperty('sessionId')) {
        obj['sessionId'] = ApiClient.convertToType(data['sessionId'], 'String');
      }
      if (data.hasOwnProperty('from')) {
        obj['from'] = CallerInfo.constructFromObject(data['from']);
      }
      if (data.hasOwnProperty('to')) {
        obj['to'] = CallerInfo.constructFromObject(data['to']);
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
      if (data.hasOwnProperty('direction')) {
        obj['direction'] = ApiClient.convertToType(data['direction'], 'String');
      }
      if (data.hasOwnProperty('action')) {
        obj['action'] = ApiClient.convertToType(data['action'], 'String');
      }
      if (data.hasOwnProperty('result')) {
        obj['result'] = ApiClient.convertToType(data['result'], 'String');
      }
      if (data.hasOwnProperty('startTime')) {
        obj['startTime'] = ApiClient.convertToType(data['startTime'], 'Date');
      }
      if (data.hasOwnProperty('duration')) {
        obj['duration'] = ApiClient.convertToType(data['duration'], 'Integer');
      }
      if (data.hasOwnProperty('recording')) {
        obj['recording'] = RecordingInfo.constructFromObject(data['recording']);
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a cal log record
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a call log record
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Internal identifier of a call session
   * @member {String} sessionId
   */
  exports.prototype['sessionId'] = undefined;

  /**
   * @member {module:model/CallerInfo} from
   */
  exports.prototype['from'] = undefined;

  /**
   * @member {module:model/CallerInfo} to
   */
  exports.prototype['to'] = undefined;

  /**
   * Call type
   * @member {module:model/CallLogInfo.TypeEnum} type
   */
  exports.prototype['type'] = undefined;

  /**
   * Call direction
   * @member {module:model/CallLogInfo.DirectionEnum} direction
   */
  exports.prototype['direction'] = undefined;

  /**
   * Action description of the call operation
   * @member {module:model/CallLogInfo.ActionEnum} action
   */
  exports.prototype['action'] = undefined;

  /**
   * Status description of the call operation
   * @member {module:model/CallLogInfo.ResultEnum} result
   */
  exports.prototype['result'] = undefined;

  /**
   * The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
   * @member {Date} startTime
   */
  exports.prototype['startTime'] = undefined;

  /**
   * Call duration in seconds
   * @member {Integer} duration
   */
  exports.prototype['duration'] = undefined;

  /**
   * @member {module:model/RecordingInfo} recording
   */
  exports.prototype['recording'] = undefined;


  /**
   * Allowed values for the <code>type</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TypeEnum = { 
    /**
     * value: Voice
     * @const
     */
    VOICE: "Voice",
    
    /**
     * value: Fax
     * @const
     */
    FAX: "Fax"
  };  /**
   * Allowed values for the <code>direction</code> property.
   * @enum {String}
   * @readonly
   */
  exports.DirectionEnum = { 
    /**
     * value: Inbound
     * @const
     */
    INBOUND: "Inbound",
    
    /**
     * value: Outbound
     * @const
     */
    OUTBOUND: "Outbound"
  };  /**
   * Allowed values for the <code>action</code> property.
   * @enum {String}
   * @readonly
   */
  exports.ActionEnum = { 
    /**
     * value: Unknown
     * @const
     */
    UNKNOWN: "Unknown",
    
    /**
     * value: Phone Call
     * @const
     */
    PHONE_CALL: "Phone Call",
    
    /**
     * value: Phone Login
     * @const
     */
    PHONE_LOGIN: "Phone Login",
    
    /**
     * value: Incoming Fax
     * @const
     */
    INCOMING_FAX: "Incoming Fax",
    
    /**
     * value: Accept Call
     * @const
     */
    ACCEPT_CALL: "Accept Call",
    
    /**
     * value: FindMe
     * @const
     */
    FINDME: "FindMe",
    
    /**
     * value: FollowMe
     * @const
     */
    FOLLOWME: "FollowMe",
    
    /**
     * value: Outgoing Fax
     * @const
     */
    OUTGOING_FAX: "Outgoing Fax",
    
    /**
     * value: Call Return
     * @const
     */
    CALL_RETURN: "Call Return",
    
    /**
     * value: Calling Card
     * @const
     */
    CALLING_CARD: "Calling Card",
    
    /**
     * value: Ring Directly
     * @const
     */
    RING_DIRECTLY: "Ring Directly",
    
    /**
     * value: RingOut Web
     * @const
     */
    RINGOUT_WEB: "RingOut Web",
    
    /**
     * value: VoIP Call
     * @const
     */
    VOIP_CALL: "VoIP Call",
    
    /**
     * value: RingOut PC
     * @const
     */
    RINGOUT_PC: "RingOut PC",
    
    /**
     * value: RingMe
     * @const
     */
    RINGME: "RingMe",
    
    /**
     * value: Transfer
     * @const
     */
    TRANSFER: "Transfer",
    
    /**
     * value: 411 Info
     * @const
     */
    _411_INFO: "411 Info",
    
    /**
     * value: Emergency
     * @const
     */
    EMERGENCY: "Emergency",
    
    /**
     * value: E911 Update
     * @const
     */
    E911_UPDATE: "E911 Update",
    
    /**
     * value: Support
     * @const
     */
    SUPPORT: "Support",
    
    /**
     * value: RingOut Mobile
     * @const
     */
    RINGOUT_MOBILE: "RingOut Mobile"
  };  /**
   * Allowed values for the <code>result</code> property.
   * @enum {String}
   * @readonly
   */
  exports.ResultEnum = { 
    /**
     * value: Unknown
     * @const
     */
    UNKNOWN: "Unknown",
    
    /**
     * value: ResultInProgress
     * @const
     */
    RESULTINPROGRESS: "ResultInProgress",
    
    /**
     * value: Missed
     * @const
     */
    MISSED: "Missed",
    
    /**
     * value: Call accepted
     * @const
     */
    CALL_ACCEPTED: "Call accepted",
    
    /**
     * value: Voicemail
     * @const
     */
    VOICEMAIL: "Voicemail",
    
    /**
     * value: Rejected
     * @const
     */
    REJECTED: "Rejected",
    
    /**
     * value: Reply
     * @const
     */
    REPLY: "Reply",
    
    /**
     * value: Received
     * @const
     */
    RECEIVED: "Received",
    
    /**
     * value: Receive Error
     * @const
     */
    RECEIVE_ERROR: "Receive Error",
    
    /**
     * value: Fax on Demand
     * @const
     */
    FAX_ON_DEMAND: "Fax on Demand",
    
    /**
     * value: Partial Receive
     * @const
     */
    PARTIAL_RECEIVE: "Partial Receive",
    
    /**
     * value: Blocked
     * @const
     */
    BLOCKED: "Blocked",
    
    /**
     * value: Call connected
     * @const
     */
    CALL_CONNECTED: "Call connected",
    
    /**
     * value: No Answer
     * @const
     */
    NO_ANSWER: "No Answer",
    
    /**
     * value: International Disabled
     * @const
     */
    INTERNATIONAL_DISABLED: "International Disabled",
    
    /**
     * value: Busy
     * @const
     */
    BUSY: "Busy",
    
    /**
     * value: Send Error
     * @const
     */
    SEND_ERROR: "Send Error",
    
    /**
     * value: Sent
     * @const
     */
    SENT: "Sent",
    
    /**
     * value: No fax machine
     * @const
     */
    NO_FAX_MACHINE: "No fax machine",
    
    /**
     * value: ResultEmpty
     * @const
     */
    RESULTEMPTY: "ResultEmpty",
    
    /**
     * value: Account
     * @const
     */
    ACCOUNT: "Account",
    
    /**
     * value: Suspended
     * @const
     */
    SUSPENDED: "Suspended",
    
    /**
     * value: Call Failed
     * @const
     */
    CALL_FAILED: "Call Failed",
    
    /**
     * value: Call Failure
     * @const
     */
    CALL_FAILURE: "Call Failure",
    
    /**
     * value: Internal Error
     * @const
     */
    INTERNAL_ERROR: "Internal Error",
    
    /**
     * value: IP Phone offline
     * @const
     */
    IP_PHONE_OFFLINE: "IP Phone offline",
    
    /**
     * value: Restricted Number
     * @const
     */
    RESTRICTED_NUMBER: "Restricted Number",
    
    /**
     * value: Wrong Number
     * @const
     */
    WRONG_NUMBER: "Wrong Number",
    
    /**
     * value: Stopped
     * @const
     */
    STOPPED: "Stopped",
    
    /**
     * value: Hang up
     * @const
     */
    HANG_UP: "Hang up",
    
    /**
     * value: Poor Line Quality
     * @const
     */
    POOR_LINE_QUALITY: "Poor Line Quality",
    
    /**
     * value: Partially Sent
     * @const
     */
    PARTIALLY_SENT: "Partially Sent",
    
    /**
     * value: International Restriction
     * @const
     */
    INTERNATIONAL_RESTRICTION: "International Restriction",
    
    /**
     * value: Abandoned
     * @const
     */
    ABANDONED: "Abandoned",
    
    /**
     * value: Declined
     * @const
     */
    DECLINED: "Declined",
    
    /**
     * value: Fax Receipt Error
     * @const
     */
    FAX_RECEIPT_ERROR: "Fax Receipt Error",
    
    /**
     * value: Fax Send Error
     * @const
     */
    FAX_SEND_ERROR: "Fax Send Error"
  };

  return exports;
}));
