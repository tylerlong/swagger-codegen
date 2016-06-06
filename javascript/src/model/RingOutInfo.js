(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './RingOutStatusInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./RingOutStatusInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.RingOutInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.RingOutStatusInfo);
  }
}(this, function(ApiClient, RingOutStatusInfo) {
  'use strict';

  /**
   * The RingOutInfo model module.
   * @module model/RingOutInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>RingOutInfo</code>.
   * @alias module:model/RingOutInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>RingOutInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RingOutInfo} obj Optional instance to populate.
   * @return {module:model/RingOutInfo} The populated <code>RingOutInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('status')) {
        obj['status'] = RingOutStatusInfo.constructFromObject(data['status']);
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a RingOut call
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * @member {module:model/RingOutStatusInfo} status
   */
  exports.prototype['status'] = undefined;




  return exports;
}));
