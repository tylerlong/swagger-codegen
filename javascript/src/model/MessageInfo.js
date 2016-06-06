(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './MessageAttachmentInfo', './MessageInfoCallerInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./MessageAttachmentInfo'), require('./MessageInfoCallerInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.MessageInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.MessageAttachmentInfo, root.RingCentralApi.MessageInfoCallerInfo);
  }
}(this, function(ApiClient, MessageAttachmentInfo, MessageInfoCallerInfo) {
  'use strict';

  /**
   * The MessageInfo model module.
   * @module model/MessageInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>MessageInfo</code>.
   * @alias module:model/MessageInfo
   * @class
   */
  var exports = function() {























  };

  /**
   * Constructs a <code>MessageInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/MessageInfo} obj Optional instance to populate.
   * @return {module:model/MessageInfo} The populated <code>MessageInfo</code> instance.
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
      if (data.hasOwnProperty('attachments')) {
        obj['attachments'] = ApiClient.convertToType(data['attachments'], [MessageAttachmentInfo]);
      }
      if (data.hasOwnProperty('availability')) {
        obj['availability'] = ApiClient.convertToType(data['availability'], 'String');
      }
      if (data.hasOwnProperty('conversationId')) {
        obj['conversationId'] = ApiClient.convertToType(data['conversationId'], 'Integer');
      }
      if (data.hasOwnProperty('creationTime')) {
        obj['creationTime'] = ApiClient.convertToType(data['creationTime'], 'Date');
      }
      if (data.hasOwnProperty('deliveryErrorCode')) {
        obj['deliveryErrorCode'] = ApiClient.convertToType(data['deliveryErrorCode'], 'String');
      }
      if (data.hasOwnProperty('direction')) {
        obj['direction'] = ApiClient.convertToType(data['direction'], 'String');
      }
      if (data.hasOwnProperty('faxPageCount')) {
        obj['faxPageCount'] = ApiClient.convertToType(data['faxPageCount'], 'Integer');
      }
      if (data.hasOwnProperty('faxResolution')) {
        obj['faxResolution'] = ApiClient.convertToType(data['faxResolution'], 'String');
      }
      if (data.hasOwnProperty('from')) {
        obj['from'] = MessageInfoCallerInfo.constructFromObject(data['from']);
      }
      if (data.hasOwnProperty('lastModifiedTime')) {
        obj['lastModifiedTime'] = ApiClient.convertToType(data['lastModifiedTime'], 'Date');
      }
      if (data.hasOwnProperty('messageStatus')) {
        obj['messageStatus'] = ApiClient.convertToType(data['messageStatus'], 'String');
      }
      if (data.hasOwnProperty('pgToDepartment')) {
        obj['pgToDepartment'] = ApiClient.convertToType(data['pgToDepartment'], 'Boolean');
      }
      if (data.hasOwnProperty('priority')) {
        obj['priority'] = ApiClient.convertToType(data['priority'], 'String');
      }
      if (data.hasOwnProperty('readStatus')) {
        obj['readStatus'] = ApiClient.convertToType(data['readStatus'], 'String');
      }
      if (data.hasOwnProperty('smsDeliveryTime')) {
        obj['smsDeliveryTime'] = ApiClient.convertToType(data['smsDeliveryTime'], 'Date');
      }
      if (data.hasOwnProperty('smsSendingAttemptsCount')) {
        obj['smsSendingAttemptsCount'] = ApiClient.convertToType(data['smsSendingAttemptsCount'], 'Integer');
      }
      if (data.hasOwnProperty('subject')) {
        obj['subject'] = ApiClient.convertToType(data['subject'], 'String');
      }
      if (data.hasOwnProperty('to')) {
        obj['to'] = ApiClient.convertToType(data['to'], [MessageInfoCallerInfo]);
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
      if (data.hasOwnProperty('vmTranscriptionStatus')) {
        obj['vmTranscriptionStatus'] = ApiClient.convertToType(data['vmTranscriptionStatus'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a message
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a message
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * The list of message attachments
   * @member {Array.<module:model/MessageAttachmentInfo>} attachments
   */
  exports.prototype['attachments'] = undefined;

  /**
   * Message availability status. Message in 'Deleted' state is still preserved with all its attachments and can be restored. 'Purged' means that all attachments are already deleted and the message itself is about to be physically deleted shortly
   * @member {module:model/MessageInfo.AvailabilityEnum} availability
   */
  exports.prototype['availability'] = undefined;

  /**
   * SMS and Pager only. Identifier of the conversation the message belongs to
   * @member {Integer} conversationId
   */
  exports.prototype['conversationId'] = undefined;

  /**
   * Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
   * @member {Date} creationTime
   */
  exports.prototype['creationTime'] = undefined;

  /**
   * SMS only. Delivery error code returned by gateway
   * @member {String} deliveryErrorCode
   */
  exports.prototype['deliveryErrorCode'] = undefined;

  /**
   * Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound
   * @member {module:model/MessageInfo.DirectionEnum} direction
   */
  exports.prototype['direction'] = undefined;

  /**
   * Fax only. Page count in fax message
   * @member {Integer} faxPageCount
   */
  exports.prototype['faxPageCount'] = undefined;

  /**
   * Fax only. Resolution of fax message. ('High' for black and white image scanned at 200 dpi, 'Low' for black and white image scanned at 100 dpi)
   * @member {module:model/MessageInfo.FaxResolutionEnum} faxResolution
   */
  exports.prototype['faxResolution'] = undefined;

  /**
   * @member {module:model/MessageInfoCallerInfo} from
   */
  exports.prototype['from'] = undefined;

  /**
   * The datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
   * @member {Date} lastModifiedTime
   */
  exports.prototype['lastModifiedTime'] = undefined;

  /**
   * Message status. Different message types may have different allowed status values.
   * @member {module:model/MessageInfo.MessageStatusEnum} messageStatus
   */
  exports.prototype['messageStatus'] = undefined;

  /**
   * Pager only True if at least one of the message recipients is Department extension
   * @member {Boolean} pgToDepartment
   */
  exports.prototype['pgToDepartment'] = undefined;

  /**
   * Message priority
   * @member {module:model/MessageInfo.PriorityEnum} priority
   */
  exports.prototype['priority'] = undefined;

  /**
   * Message read status
   * @member {module:model/MessageInfo.ReadStatusEnum} readStatus
   */
  exports.prototype['readStatus'] = undefined;

  /**
   * SMS only. The datetime when outbound SMS was delivered to recipient's handset in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. It is filled only if the carrier sends a delivery receipt to RingCentral
   * @member {Date} smsDeliveryTime
   */
  exports.prototype['smsDeliveryTime'] = undefined;

  /**
   * SMS only. Number of attempts made to send an outbound SMS to the gateway (if gateway is temporary unavailable)
   * @member {Integer} smsSendingAttemptsCount
   */
  exports.prototype['smsSendingAttemptsCount'] = undefined;

  /**
   * Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment
   * @member {String} subject
   */
  exports.prototype['subject'] = undefined;

  /**
   * Recipient information
   * @member {Array.<module:model/MessageInfoCallerInfo>} to
   */
  exports.prototype['to'] = undefined;

  /**
   * Message type
   * @member {module:model/MessageInfo.TypeEnum} type
   */
  exports.prototype['type'] = undefined;

  /**
   * Voicemail only. Status of voicemail to text transcription. If VoicemailToText feature is not activated for account, the 'NotAvailable' value is returned
   * @member {module:model/MessageInfo.VmTranscriptionStatusEnum} vmTranscriptionStatus
   */
  exports.prototype['vmTranscriptionStatus'] = undefined;


  /**
   * Allowed values for the <code>availability</code> property.
   * @enum {String}
   * @readonly
   */
  exports.AvailabilityEnum = { 
    /**
     * value: Alive
     * @const
     */
    ALIVE: "Alive",
    
    /**
     * value: Deleted
     * @const
     */
    DELETED: "Deleted",
    
    /**
     * value: Purged
     * @const
     */
    PURGED: "Purged"
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
   * Allowed values for the <code>faxResolution</code> property.
   * @enum {String}
   * @readonly
   */
  exports.FaxResolutionEnum = { 
    /**
     * value: High
     * @const
     */
    HIGH: "High",
    
    /**
     * value: Low
     * @const
     */
    LOW: "Low"
  };  /**
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
   * Allowed values for the <code>priority</code> property.
   * @enum {String}
   * @readonly
   */
  exports.PriorityEnum = { 
    /**
     * value: Normal
     * @const
     */
    NORMAL: "Normal",
    
    /**
     * value: High
     * @const
     */
    HIGH: "High"
  };  /**
   * Allowed values for the <code>readStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.ReadStatusEnum = { 
    /**
     * value: Read
     * @const
     */
    READ: "Read",
    
    /**
     * value: Unread
     * @const
     */
    UNREAD: "Unread"
  };  /**
   * Allowed values for the <code>type</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TypeEnum = { 
    /**
     * value: Fax
     * @const
     */
    FAX: "Fax",
    
    /**
     * value: SMS
     * @const
     */
    SMS: "SMS",
    
    /**
     * value: VoiceMail
     * @const
     */
    VOICEMAIL: "VoiceMail",
    
    /**
     * value: Pager
     * @const
     */
    PAGER: "Pager",
    
    /**
     * value: Text
     * @const
     */
    TEXT: "Text"
  };  /**
   * Allowed values for the <code>vmTranscriptionStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.VmTranscriptionStatusEnum = { 
    /**
     * value: NotAvailable
     * @const
     */
    NOTAVAILABLE: "NotAvailable",
    
    /**
     * value: InProgress
     * @const
     */
    INPROGRESS: "InProgress",
    
    /**
     * value: TimedOut
     * @const
     */
    TIMEDOUT: "TimedOut",
    
    /**
     * value: Completed
     * @const
     */
    COMPLETED: "Completed",
    
    /**
     * value: CompletedPartially
     * @const
     */
    COMPLETEDPARTIALLY: "CompletedPartially",
    
    /**
     * value: Failed
     * @const
     */
    FAILED: "Failed"
  };

  return exports;
}));
