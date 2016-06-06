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
    root.RingCentralApi.ForwardingNumberInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ForwardingNumberInfo model module.
   * @module model/ForwardingNumberInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ForwardingNumberInfo</code>.
   * @alias module:model/ForwardingNumberInfo
   * @class
   */
  var exports = function() {







  };

  /**
   * Constructs a <code>ForwardingNumberInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ForwardingNumberInfo} obj Optional instance to populate.
   * @return {module:model/ForwardingNumberInfo} The populated <code>ForwardingNumberInfo</code> instance.
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
      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
      if (data.hasOwnProperty('label')) {
        obj['label'] = ApiClient.convertToType(data['label'], 'String');
      }
      if (data.hasOwnProperty('features')) {
        obj['features'] = ApiClient.convertToType(data['features'], 'String');
      }
      if (data.hasOwnProperty('flipNumber')) {
        obj['flipNumber'] = ApiClient.convertToType(data['flipNumber'], 'Integer');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a forwarding/call flip phone number
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a forwarding/call flip phone number
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Forwarding/Call flip phone number
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;

  /**
   * Forwarding/Call flip number title
   * @member {String} label
   */
  exports.prototype['label'] = undefined;

  /**
   * Type of option this phone number is used for. Multiple values are accepted
   * @member {module:model/ForwardingNumberInfo.FeaturesEnum} features
   */
  exports.prototype['features'] = undefined;

  /**
   * Number assigned to the call flip phone number, corresponds to the shortcut dial number
   * @member {Integer} flipNumber
   */
  exports.prototype['flipNumber'] = undefined;


  /**
   * Allowed values for the <code>features</code> property.
   * @enum {String}
   * @readonly
   */
  exports.FeaturesEnum = { 
    /**
     * value: CallFlip
     * @const
     */
    CALLFLIP: "CallFlip",
    
    /**
     * value: CallForwarding
     * @const
     */
    CALLFORWARDING: "CallForwarding"
  };

  return exports;
}));
