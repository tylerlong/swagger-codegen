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
    root.RingCentralApi.AttachmentInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The AttachmentInfo model module.
   * @module model/AttachmentInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>AttachmentInfo</code>.
   * @alias module:model/AttachmentInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>AttachmentInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/AttachmentInfo} obj Optional instance to populate.
   * @return {module:model/AttachmentInfo} The populated <code>AttachmentInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('contentType')) {
        obj['contentType'] = ApiClient.convertToType(data['contentType'], 'String');
      }
    }
    return obj;
  }


  /**
   * Link to custom data attachment
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Type of custom data attachment, see also MIME Types
   * @member {String} contentType
   */
  exports.prototype['contentType'] = undefined;




  return exports;
}));
