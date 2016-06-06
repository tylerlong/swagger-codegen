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
    root.RingCentralApi.TimezoneInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The TimezoneInfo model module.
   * @module model/TimezoneInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>TimezoneInfo</code>.
   * @alias module:model/TimezoneInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>TimezoneInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/TimezoneInfo} obj Optional instance to populate.
   * @return {module:model/TimezoneInfo} The populated <code>TimezoneInfo</code> instance.
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
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('description')) {
        obj['description'] = ApiClient.convertToType(data['description'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a timezone
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a timezone
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Short name of a timezone
   * @member {String} name
   */
  exports.prototype['name'] = undefined;

  /**
   * Meaningful description of the timezone
   * @member {String} description
   */
  exports.prototype['description'] = undefined;




  return exports;
}));
