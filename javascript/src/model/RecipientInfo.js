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
    root.RingCentralApi.RecipientInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The RecipientInfo model module.
   * @module model/RecipientInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>RecipientInfo</code>.
   * @alias module:model/RecipientInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>RecipientInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RecipientInfo} obj Optional instance to populate.
   * @return {module:model/RecipientInfo} The populated <code>RecipientInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
    }
    return obj;
  }


  /**
   * Link to a recipient extension resource
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Internal identifier of a recipient extension
   * @member {String} id
   */
  exports.prototype['id'] = undefined;




  return exports;
}));
