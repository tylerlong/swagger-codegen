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
    root.RingCentralApi.SubscriptionRequestDeliveryMode = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The SubscriptionRequestDeliveryMode model module.
   * @module model/SubscriptionRequestDeliveryMode
   * @version v1.0
   */

  /**
   * Constructs a new <code>SubscriptionRequestDeliveryMode</code>.
   * @alias module:model/SubscriptionRequestDeliveryMode
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>SubscriptionRequestDeliveryMode</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/SubscriptionRequestDeliveryMode} obj Optional instance to populate.
   * @return {module:model/SubscriptionRequestDeliveryMode} The populated <code>SubscriptionRequestDeliveryMode</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('transportType')) {
        obj['transportType'] = ApiClient.convertToType(data['transportType'], 'String');
      }
      if (data.hasOwnProperty('encryption')) {
        obj['encryption'] = ApiClient.convertToType(data['encryption'], 'Boolean');
      }
    }
    return obj;
  }


  /**
   * Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)
   * @member {module:model/SubscriptionRequestDeliveryMode.TransportTypeEnum} transportType
   */
  exports.prototype['transportType'] = undefined;

  /**
   * Optional parameter. Specifies if the message will be encrypted or not. If request contains any presence event filter the value by default is 'True' (even if specified as 'false'). If request contains only message event filters the value by default is 'False'
   * @member {Boolean} encryption
   */
  exports.prototype['encryption'] = undefined;


  /**
   * Allowed values for the <code>transportType</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TransportTypeEnum = { 
    /**
     * value: PubNub
     * @const
     */
    PUBNUB: "PubNub",
    
    /**
     * value: APNS
     * @const
     */
    APNS: "APNS",
    
    /**
     * value: PubNub/APNS/VoIP
     * @const
     */
    PUBNUB_APNS_VOIP: "PubNub/APNS/VoIP"
  };

  return exports;
}));
