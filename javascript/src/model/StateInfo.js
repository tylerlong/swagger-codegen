(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './StateInfoCountryInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./StateInfoCountryInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.StateInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.StateInfoCountryInfo);
  }
}(this, function(ApiClient, StateInfoCountryInfo) {
  'use strict';

  /**
   * The StateInfo model module.
   * @module model/StateInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>StateInfo</code>.
   * @alias module:model/StateInfo
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>StateInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/StateInfo} obj Optional instance to populate.
   * @return {module:model/StateInfo} The populated <code>StateInfo</code> instance.
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
      if (data.hasOwnProperty('country')) {
        obj['country'] = StateInfoCountryInfo.constructFromObject(data['country']);
      }
      if (data.hasOwnProperty('isoCode')) {
        obj['isoCode'] = ApiClient.convertToType(data['isoCode'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a state
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a state
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * @member {module:model/StateInfoCountryInfo} country
   */
  exports.prototype['country'] = undefined;

  /**
   * Short code for a state (2-letter usually)
   * @member {String} isoCode
   */
  exports.prototype['isoCode'] = undefined;

  /**
   * Official name of a state
   * @member {String} name
   */
  exports.prototype['name'] = undefined;




  return exports;
}));
