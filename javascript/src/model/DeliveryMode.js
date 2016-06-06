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
    root.RingCentralApi.DeliveryMode = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The DeliveryMode model module.
   * @module model/DeliveryMode
   * @version v1.0
   */

  /**
   * Constructs a new <code>DeliveryMode</code>.
   * @alias module:model/DeliveryMode
   * @class
   */
  var exports = function() {








  };

  /**
   * Constructs a <code>DeliveryMode</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/DeliveryMode} obj Optional instance to populate.
   * @return {module:model/DeliveryMode} The populated <code>DeliveryMode</code> instance.
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
      if (data.hasOwnProperty('address')) {
        obj['address'] = ApiClient.convertToType(data['address'], 'String');
      }
      if (data.hasOwnProperty('subscriberKey')) {
        obj['subscriberKey'] = ApiClient.convertToType(data['subscriberKey'], 'String');
      }
      if (data.hasOwnProperty('secretKey')) {
        obj['secretKey'] = ApiClient.convertToType(data['secretKey'], 'String');
      }
      if (data.hasOwnProperty('encryptionAlgorithm')) {
        obj['encryptionAlgorithm'] = ApiClient.convertToType(data['encryptionAlgorithm'], 'String');
      }
      if (data.hasOwnProperty('encryptionKey')) {
        obj['encryptionKey'] = ApiClient.convertToType(data['encryptionKey'], 'String');
      }
    }
    return obj;
  }


  /**
   * Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)
   * @member {module:model/DeliveryMode.TransportTypeEnum} transportType
   */
  exports.prototype['transportType'] = undefined;

  /**
   * Optional parameter. Specifies if the message will be encrypted or not. For APNS transport type the value is always \"false\"
   * @member {Boolean} encryption
   */
  exports.prototype['encryption'] = undefined;

  /**
   * PubNub channel name. For APNS transport type - internal identifier of a device \"device_token\"
   * @member {String} address
   */
  exports.prototype['address'] = undefined;

  /**
   * PubNub subscriber credentials required to subscribe to the channel
   * @member {String} subscriberKey
   */
  exports.prototype['subscriberKey'] = undefined;

  /**
   * PubNub subscriber credentials required to subscribe to the channel. Optional (for PubNub transport type only)
   * @member {String} secretKey
   */
  exports.prototype['secretKey'] = undefined;

  /**
   * Encryption algorithm 'AES' (for PubNub transport type only)
   * @member {String} encryptionAlgorithm
   */
  exports.prototype['encryptionAlgorithm'] = undefined;

  /**
   * Key for notification message decryption (for PubNub transport type only)
   * @member {String} encryptionKey
   */
  exports.prototype['encryptionKey'] = undefined;


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
