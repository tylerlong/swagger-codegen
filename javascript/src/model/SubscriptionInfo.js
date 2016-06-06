(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './DeliveryMode'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./DeliveryMode'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.SubscriptionInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.DeliveryMode);
  }
}(this, function(ApiClient, DeliveryMode) {
  'use strict';

  /**
   * The SubscriptionInfo model module.
   * @module model/SubscriptionInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>SubscriptionInfo</code>.
   * @alias module:model/SubscriptionInfo
   * @class
   */
  var exports = function() {









  };

  /**
   * Constructs a <code>SubscriptionInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/SubscriptionInfo} obj Optional instance to populate.
   * @return {module:model/SubscriptionInfo} The populated <code>SubscriptionInfo</code> instance.
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
      if (data.hasOwnProperty('eventFilters')) {
        obj['eventFilters'] = ApiClient.convertToType(data['eventFilters'], ['String']);
      }
      if (data.hasOwnProperty('expirationTime')) {
        obj['expirationTime'] = ApiClient.convertToType(data['expirationTime'], 'Date');
      }
      if (data.hasOwnProperty('expiresIn')) {
        obj['expiresIn'] = ApiClient.convertToType(data['expiresIn'], 'Integer');
      }
      if (data.hasOwnProperty('status')) {
        obj['status'] = ApiClient.convertToType(data['status'], 'String');
      }
      if (data.hasOwnProperty('creationTime')) {
        obj['creationTime'] = ApiClient.convertToType(data['creationTime'], 'Date');
      }
      if (data.hasOwnProperty('deliveryMode')) {
        obj['deliveryMode'] = DeliveryMode.constructFromObject(data['deliveryMode']);
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a subscription
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a subscription
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Collection of URIs to API resources (message-store/presence/detailed presence)
   * @member {Array.<String>} eventFilters
   */
  exports.prototype['eventFilters'] = undefined;

  /**
   * Subscription expiration datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
   * @member {Date} expirationTime
   */
  exports.prototype['expirationTime'] = undefined;

  /**
   * Subscription lifetime in seconds. The default value is 900
   * @member {Integer} expiresIn
   */
  exports.prototype['expiresIn'] = undefined;

  /**
   * Subscription status
   * @member {module:model/SubscriptionInfo.StatusEnum} status
   */
  exports.prototype['status'] = undefined;

  /**
   * Subscription creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
   * @member {Date} creationTime
   */
  exports.prototype['creationTime'] = undefined;

  /**
   * @member {module:model/DeliveryMode} deliveryMode
   */
  exports.prototype['deliveryMode'] = undefined;


  /**
   * Allowed values for the <code>status</code> property.
   * @enum {String}
   * @readonly
   */
  exports.StatusEnum = { 
    /**
     * value: Active
     * @const
     */
    ACTIVE: "Active",
    
    /**
     * value: Suspended
     * @const
     */
    SUSPENDED: "Suspended"
  };

  return exports;
}));
