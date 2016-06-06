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
    root.RingCentralApi.RangesInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The RangesInfo model module.
   * @module model/RangesInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>RangesInfo</code>.
   * @alias module:model/RangesInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>RangesInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RangesInfo} obj Optional instance to populate.
   * @return {module:model/RangesInfo} The populated <code>RangesInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('from')) {
        obj['from'] = ApiClient.convertToType(data['from'], 'Date');
      }
      if (data.hasOwnProperty('to')) {
        obj['to'] = ApiClient.convertToType(data['to'], 'Date');
      }
    }
    return obj;
  }


  /**
   * Date and time in format YYYY-MM-DD hh:mm
   * @member {Date} from
   */
  exports.prototype['from'] = undefined;

  /**
   * Date and time in format YYYY-MM-DD hh:mm
   * @member {Date} to
   */
  exports.prototype['to'] = undefined;




  return exports;
}));
