(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './RuleInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./RuleInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ForwardingInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.RuleInfo);
  }
}(this, function(ApiClient, RuleInfo) {
  'use strict';

  /**
   * The ForwardingInfo model module.
   * @module model/ForwardingInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ForwardingInfo</code>.
   * @alias module:model/ForwardingInfo
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>ForwardingInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ForwardingInfo} obj Optional instance to populate.
   * @return {module:model/ForwardingInfo} The populated <code>ForwardingInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('notifyMySoftPhones')) {
        obj['notifyMySoftPhones'] = ApiClient.convertToType(data['notifyMySoftPhones'], 'Boolean');
      }
      if (data.hasOwnProperty('notifyAdminSoftPhones')) {
        obj['notifyAdminSoftPhones'] = ApiClient.convertToType(data['notifyAdminSoftPhones'], 'Boolean');
      }
      if (data.hasOwnProperty('softPhonesRingCount')) {
        obj['softPhonesRingCount'] = ApiClient.convertToType(data['softPhonesRingCount'], 'Integer');
      }
      if (data.hasOwnProperty('ringingMode')) {
        obj['ringingMode'] = ApiClient.convertToType(data['ringingMode'], 'String');
      }
      if (data.hasOwnProperty('rules')) {
        obj['rules'] = ApiClient.convertToType(data['rules'], [RuleInfo]);
      }
    }
    return obj;
  }


  /**
   * Specifies if the user's softphone(s) are notified before forwarding the incoming call to desk phones and forwarding numbers
   * @member {Boolean} notifyMySoftPhones
   */
  exports.prototype['notifyMySoftPhones'] = undefined;

  /**
   * Specifies if the administrator's softphone is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is 'False'
   * @member {Boolean} notifyAdminSoftPhones
   */
  exports.prototype['notifyAdminSoftPhones'] = undefined;

  /**
   * Number of rings before forwarding starts
   * @member {Integer} softPhonesRingCount
   */
  exports.prototype['softPhonesRingCount'] = undefined;

  /**
   * Specifies the order in which forwarding numbers ring. 'Sequentially' means that forwarding numbers are ringing one at a time, in order of priority. 'Simultaneously' means that forwarding numbers are ring all at the same time
   * @member {module:model/ForwardingInfo.RingingModeEnum} ringingMode
   */
  exports.prototype['ringingMode'] = undefined;

  /**
   * Information on a call forwarding rule
   * @member {Array.<module:model/RuleInfo>} rules
   */
  exports.prototype['rules'] = undefined;


  /**
   * Allowed values for the <code>ringingMode</code> property.
   * @enum {String}
   * @readonly
   */
  exports.RingingModeEnum = { 
    /**
     * value: Sequentially
     * @const
     */
    SEQUENTIALLY: "Sequentially",
    
    /**
     * value: Simultaneously
     * @const
     */
    SIMULTANEOUSLY: "Simultaneously"
  };

  return exports;
}));
