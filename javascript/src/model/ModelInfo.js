(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './AddonInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./AddonInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ModelInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.AddonInfo);
  }
}(this, function(ApiClient, AddonInfo) {
  'use strict';

  /**
   * The ModelInfo model module.
   * @module model/ModelInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ModelInfo</code>.
   * @alias module:model/ModelInfo
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>ModelInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ModelInfo} obj Optional instance to populate.
   * @return {module:model/ModelInfo} The populated <code>ModelInfo</code> instance.
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
      if (data.hasOwnProperty('addons')) {
        obj['addons'] = ApiClient.convertToType(data['addons'], [AddonInfo]);
      }
    }
    return obj;
  }


  /**
   * Device model identifier. Mandatory when ordering a HardPhone if boxBillingId is not used for ordering
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Device name
   * @member {String} name
   */
  exports.prototype['name'] = undefined;

  /**
   * Addons description
   * @member {Array.<module:model/AddonInfo>} addons
   */
  exports.prototype['addons'] = undefined;




  return exports;
}));
