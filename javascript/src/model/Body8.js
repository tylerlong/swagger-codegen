(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './SubscriptionRequestDeliveryMode'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./SubscriptionRequestDeliveryMode'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.Body8 = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.SubscriptionRequestDeliveryMode);
  }
}(this, function(ApiClient, SubscriptionRequestDeliveryMode) {
  'use strict';

  /**
   * The Body8 model module.
   * @module model/Body8
   * @version v1.0
   */

  /**
   * Constructs a new <code>Body8</code>.
   * @alias module:model/Body8
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>Body8</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Body8} obj Optional instance to populate.
   * @return {module:model/Body8} The populated <code>Body8</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('eventFilters')) {
        obj['eventFilters'] = ApiClient.convertToType(data['eventFilters'], ['String']);
      }
      if (data.hasOwnProperty('deliveryMode')) {
        obj['deliveryMode'] = SubscriptionRequestDeliveryMode.constructFromObject(data['deliveryMode']);
      }
    }
    return obj;
  }


  /**
   * Mandatory. Collection of URIs to API resources (see Event Types for details). For APNS transport type only message event filter is available
   * @member {Array.<String>} eventFilters
   */
  exports.prototype['eventFilters'] = undefined;

  /**
   * @member {module:model/SubscriptionRequestDeliveryMode} deliveryMode
   */
  exports.prototype['deliveryMode'] = undefined;




  return exports;
}));
