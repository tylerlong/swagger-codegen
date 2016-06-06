(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './AnsweringRuleInfoCalleeInfo', './AnsweringRuleInfoCallerInfo', './ForwardingInfo', './ScheduleInfo', './UnconditionalForwardingInfo', './VoicemailInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./AnsweringRuleInfoCalleeInfo'), require('./AnsweringRuleInfoCallerInfo'), require('./ForwardingInfo'), require('./ScheduleInfo'), require('./UnconditionalForwardingInfo'), require('./VoicemailInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.AnsweringRuleInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.AnsweringRuleInfoCalleeInfo, root.RingCentralApi.AnsweringRuleInfoCallerInfo, root.RingCentralApi.ForwardingInfo, root.RingCentralApi.ScheduleInfo, root.RingCentralApi.UnconditionalForwardingInfo, root.RingCentralApi.VoicemailInfo);
  }
}(this, function(ApiClient, AnsweringRuleInfoCalleeInfo, AnsweringRuleInfoCallerInfo, ForwardingInfo, ScheduleInfo, UnconditionalForwardingInfo, VoicemailInfo) {
  'use strict';

  /**
   * The AnsweringRuleInfo model module.
   * @module model/AnsweringRuleInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>AnsweringRuleInfo</code>.
   * @alias module:model/AnsweringRuleInfo
   * @class
   */
  var exports = function() {













  };

  /**
   * Constructs a <code>AnsweringRuleInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/AnsweringRuleInfo} obj Optional instance to populate.
   * @return {module:model/AnsweringRuleInfo} The populated <code>AnsweringRuleInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('enabled')) {
        obj['enabled'] = ApiClient.convertToType(data['enabled'], 'Boolean');
      }
      if (data.hasOwnProperty('schedule')) {
        obj['schedule'] = ScheduleInfo.constructFromObject(data['schedule']);
      }
      if (data.hasOwnProperty('calledNumbers')) {
        obj['calledNumbers'] = ApiClient.convertToType(data['calledNumbers'], [AnsweringRuleInfoCalleeInfo]);
      }
      if (data.hasOwnProperty('callers')) {
        obj['callers'] = ApiClient.convertToType(data['callers'], [AnsweringRuleInfoCallerInfo]);
      }
      if (data.hasOwnProperty('callHandlingAction')) {
        obj['callHandlingAction'] = ApiClient.convertToType(data['callHandlingAction'], 'String');
      }
      if (data.hasOwnProperty('forwarding')) {
        obj['forwarding'] = ForwardingInfo.constructFromObject(data['forwarding']);
      }
      if (data.hasOwnProperty('unconditionalForwarding')) {
        obj['unconditionalForwarding'] = UnconditionalForwardingInfo.constructFromObject(data['unconditionalForwarding']);
      }
      if (data.hasOwnProperty('voicemail')) {
        obj['voicemail'] = VoicemailInfo.constructFromObject(data['voicemail']);
      }
    }
    return obj;
  }


  /**
   * Canonical URI to the answering rule resource
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Internal identifier of an asnwering rule
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Type of an answering rule
   * @member {module:model/AnsweringRuleInfo.TypeEnum} type
   */
  exports.prototype['type'] = undefined;

  /**
   * Name of an answering rule specified by user
   * @member {String} name
   */
  exports.prototype['name'] = undefined;

  /**
   * Specifies if an answering rule is active or inactive
   * @member {Boolean} enabled
   */
  exports.prototype['enabled'] = undefined;

  /**
   * @member {module:model/ScheduleInfo} schedule
   */
  exports.prototype['schedule'] = undefined;

  /**
   * Answering rules are applied when calling to selected number(s)
   * @member {Array.<module:model/AnsweringRuleInfoCalleeInfo>} calledNumbers
   */
  exports.prototype['calledNumbers'] = undefined;

  /**
   * Answering rules are applied when calls are received from specified caller(s)
   * @member {Array.<module:model/AnsweringRuleInfoCallerInfo>} callers
   */
  exports.prototype['callers'] = undefined;

  /**
   * Specifies how incoming calls are forwarded
   * @member {module:model/AnsweringRuleInfo.CallHandlingActionEnum} callHandlingAction
   */
  exports.prototype['callHandlingAction'] = undefined;

  /**
   * @member {module:model/ForwardingInfo} forwarding
   */
  exports.prototype['forwarding'] = undefined;

  /**
   * @member {module:model/UnconditionalForwardingInfo} unconditionalForwarding
   */
  exports.prototype['unconditionalForwarding'] = undefined;

  /**
   * @member {module:model/VoicemailInfo} voicemail
   */
  exports.prototype['voicemail'] = undefined;


  /**
   * Allowed values for the <code>type</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TypeEnum = { 
    /**
     * value: BusinessHours
     * @const
     */
    BUSINESSHOURS: "BusinessHours",
    
    /**
     * value: AfterHours
     * @const
     */
    AFTERHOURS: "AfterHours",
    
    /**
     * value: Custom
     * @const
     */
    CUSTOM: "Custom"
  };  /**
   * Allowed values for the <code>callHandlingAction</code> property.
   * @enum {String}
   * @readonly
   */
  exports.CallHandlingActionEnum = { 
    /**
     * value: ForwardCalls
     * @const
     */
    FORWARDCALLS: "ForwardCalls",
    
    /**
     * value: TakeMessagesOnly
     * @const
     */
    TAKEMESSAGESONLY: "TakeMessagesOnly",
    
    /**
     * value: PlayAnnouncementOnly
     * @const
     */
    PLAYANNOUNCEMENTONLY: "PlayAnnouncementOnly",
    
    /**
     * value: UnconditionalForwarding
     * @const
     */
    UNCONDITIONALFORWARDING: "UnconditionalForwarding"
  };

  return exports;
}));
