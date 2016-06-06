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
    root.RingCentralApi.Body9 = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The Body9 model module.
   * @module model/Body9
   * @version v1.0
   */

  /**
   * Constructs a new <code>Body9</code>.
   * @alias module:model/Body9
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>Body9</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Body9} obj Optional instance to populate.
   * @return {module:model/Body9} The populated <code>Body9</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('eventFilters')) {
        obj['eventFilters'] = ApiClient.convertToType(data['eventFilters'], ['String']);
      }
    }
    return obj;
  }


  /**
   * Collection of URIs to API resources (see Event Types). Mandatory field
   * @member {Array.<String>} eventFilters
   */
  exports.prototype['eventFilters'] = undefined;




  return exports;
}));
