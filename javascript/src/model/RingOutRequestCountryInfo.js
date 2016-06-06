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
    root.RingCentralApi.RingOutRequestCountryInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The RingOutRequestCountryInfo model module.
   * @module model/RingOutRequestCountryInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>RingOutRequestCountryInfo</code>.
   * @alias module:model/RingOutRequestCountryInfo
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>RingOutRequestCountryInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RingOutRequestCountryInfo} obj Optional instance to populate.
   * @return {module:model/RingOutRequestCountryInfo} The populated <code>RingOutRequestCountryInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
    }
    return obj;
  }


  /**
   * Dialing plan country identifier
   * @member {String} id
   */
  exports.prototype['id'] = undefined;




  return exports;
}));
