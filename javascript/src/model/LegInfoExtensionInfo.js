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
    root.RingCentralApi.LegInfoExtensionInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The LegInfoExtensionInfo model module.
   * @module model/LegInfoExtensionInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>LegInfoExtensionInfo</code>.
   * @alias module:model/LegInfoExtensionInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>LegInfoExtensionInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/LegInfoExtensionInfo} obj Optional instance to populate.
   * @return {module:model/LegInfoExtensionInfo} The populated <code>LegInfoExtensionInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'Integer');
      }
      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of an extension
   * @member {Integer} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of an extension
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;




  return exports;
}));
