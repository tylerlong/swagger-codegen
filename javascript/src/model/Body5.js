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
    root.RingCentralApi.Body5 = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The Body5 model module.
   * @module model/Body5
   * @version v1.0
   */

  /**
   * Constructs a new <code>Body5</code>.
   * @alias module:model/Body5
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>Body5</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Body5} obj Optional instance to populate.
   * @return {module:model/Body5} The populated <code>Body5</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('readStatus')) {
        obj['readStatus'] = ApiClient.convertToType(data['readStatus'], 'String');
      }
    }
    return obj;
  }


  /**
   * Read status of a message to be changed. Multiple values are accepted
   * @member {module:model/Body5.ReadStatusEnum} readStatus
   */
  exports.prototype['readStatus'] = undefined;


  /**
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
  };

  return exports;
}));
