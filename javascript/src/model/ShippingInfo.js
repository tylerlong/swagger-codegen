(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './ShippingAddress', './ShippingMethod'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ShippingAddress'), require('./ShippingMethod'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ShippingInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.ShippingAddress, root.RingCentralApi.ShippingMethod);
  }
}(this, function(ApiClient, ShippingAddress, ShippingMethod) {
  'use strict';

  /**
   * The ShippingInfo model module.
   * @module model/ShippingInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ShippingInfo</code>.
   * @alias module:model/ShippingInfo
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>ShippingInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ShippingInfo} obj Optional instance to populate.
   * @return {module:model/ShippingInfo} The populated <code>ShippingInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('status')) {
        obj['status'] = ApiClient.convertToType(data['status'], 'String');
      }
      if (data.hasOwnProperty('carrier')) {
        obj['carrier'] = ApiClient.convertToType(data['carrier'], 'String');
      }
      if (data.hasOwnProperty('trackingNumber')) {
        obj['trackingNumber'] = ApiClient.convertToType(data['trackingNumber'], 'String');
      }
      if (data.hasOwnProperty('method')) {
        obj['method'] = ApiClient.convertToType(data['method'], [ShippingMethod]);
      }
      if (data.hasOwnProperty('address')) {
        obj['address'] = ApiClient.convertToType(data['address'], [ShippingAddress]);
      }
    }
    return obj;
  }


  /**
   * Shipping status of the order item. It is set to 'Initial' when the order is submitted. Then it is changed to 'Accepted' when a distributor starts processing the order. Finally it is changed to Shipped which means that distributor has shipped the device.
   * @member {module:model/ShippingInfo.StatusEnum} status
   */
  exports.prototype['status'] = undefined;

  /**
   * Shipping carrier name. Appears only if the device status is \"Shipped\"
   * @member {String} carrier
   */
  exports.prototype['carrier'] = undefined;

  /**
   * Carrier-specific tracking number. Appears only if the device status is \"Shipped\"
   * @member {String} trackingNumber
   */
  exports.prototype['trackingNumber'] = undefined;

  /**
   * Shipping method information
   * @member {Array.<module:model/ShippingMethod>} method
   */
  exports.prototype['method'] = undefined;

  /**
   * Shipping address for the order. If it coincides with the Emergency Service Address, then can be omitted. By default the same value as the emergencyServiceAddress. Multiple addresses can be specified; in case an order contains several devices, they can be delivered to different addresses
   * @member {Array.<module:model/ShippingAddress>} address
   */
  exports.prototype['address'] = undefined;


  /**
   * Allowed values for the <code>status</code> property.
   * @enum {String}
   * @readonly
   */
  exports.StatusEnum = { 
    /**
     * value: Initial
     * @const
     */
    INITIAL: "Initial",
    
    /**
     * value: Accepted
     * @const
     */
    ACCEPTED: "Accepted",
    
    /**
     * value: Shipped
     * @const
     */
    SHIPPED: "Shipped"
  };

  return exports;
}));
