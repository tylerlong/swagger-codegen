(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './RingOutRequestCountryInfo', './RingOutRequestFrom', './RingOutRequestTo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./RingOutRequestCountryInfo'), require('./RingOutRequestFrom'), require('./RingOutRequestTo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.Body6 = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.RingOutRequestCountryInfo, root.RingCentralApi.RingOutRequestFrom, root.RingCentralApi.RingOutRequestTo);
  }
}(this, function(ApiClient, RingOutRequestCountryInfo, RingOutRequestFrom, RingOutRequestTo) {
  'use strict';

  /**
   * The Body6 model module.
   * @module model/Body6
   * @version v1.0
   */

  /**
   * Constructs a new <code>Body6</code>.
   * @alias module:model/Body6
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>Body6</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Body6} obj Optional instance to populate.
   * @return {module:model/Body6} The populated <code>Body6</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('from')) {
        obj['from'] = RingOutRequestFrom.constructFromObject(data['from']);
      }
      if (data.hasOwnProperty('to')) {
        obj['to'] = RingOutRequestTo.constructFromObject(data['to']);
      }
      if (data.hasOwnProperty('callerId')) {
        obj['callerId'] = RingOutRequestTo.constructFromObject(data['callerId']);
      }
      if (data.hasOwnProperty('playPrompt')) {
        obj['playPrompt'] = ApiClient.convertToType(data['playPrompt'], 'Boolean');
      }
      if (data.hasOwnProperty('country')) {
        obj['country'] = RingOutRequestCountryInfo.constructFromObject(data['country']);
      }
    }
    return obj;
  }


  /**
   * @member {module:model/RingOutRequestFrom} from
   */
  exports.prototype['from'] = undefined;

  /**
   * @member {module:model/RingOutRequestTo} to
   */
  exports.prototype['to'] = undefined;

  /**
   * @member {module:model/RingOutRequestTo} callerId
   */
  exports.prototype['callerId'] = undefined;

  /**
   * The audio prompt that the calling party hears when the call is connected
   * @member {Boolean} playPrompt
   */
  exports.prototype['playPrompt'] = undefined;

  /**
   * @member {module:model/RingOutRequestCountryInfo} country
   */
  exports.prototype['country'] = undefined;




  return exports;
}));
