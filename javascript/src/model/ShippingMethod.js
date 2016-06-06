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
    root.RingCentralApi.ShippingMethod = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ShippingMethod model module.
   * @module model/ShippingMethod
   * @version v1.0
   */

  /**
   * Constructs a new <code>ShippingMethod</code>.
   * @alias module:model/ShippingMethod
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>ShippingMethod</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ShippingMethod} obj Optional instance to populate.
   * @return {module:model/ShippingMethod} The populated <code>ShippingMethod</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
    }
    return obj;
  }


  /**
   * Method identifier. The default value is \"1\" (Ground)
   * @member {module:model/ShippingMethod.IdEnum} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Method name, corresponding to the identifier
   * @member {module:model/ShippingMethod.NameEnum} name
   */
  exports.prototype['name'] = undefined;


  /**
   * Allowed values for the <code>id</code> property.
   * @enum {String}
   * @readonly
   */
  exports.IdEnum = { 
    /**
     * value: 1
     * @const
     */
    _1: "1",
    
    /**
     * value: 2
     * @const
     */
    _2: "2",
    
    /**
     * value: 3
     * @const
     */
    _3: "3"
  };  /**
   * Allowed values for the <code>name</code> property.
   * @enum {String}
   * @readonly
   */
  exports.NameEnum = { 
    /**
     * value: Ground
     * @const
     */
    GROUND: "Ground",
    
    /**
     * value: 2 Day
     * @const
     */
    _2_DAY: "2 Day",
    
    /**
     * value: Overnight
     * @const
     */
    OVERNIGHT: "Overnight"
  };

  return exports;
}));
