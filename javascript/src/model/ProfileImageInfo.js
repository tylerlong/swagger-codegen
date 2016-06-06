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
    root.RingCentralApi.ProfileImageInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ProfileImageInfo model module.
   * @module model/ProfileImageInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ProfileImageInfo</code>.
   * @alias module:model/ProfileImageInfo
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>ProfileImageInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ProfileImageInfo} obj Optional instance to populate.
   * @return {module:model/ProfileImageInfo} The populated <code>ProfileImageInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('etag')) {
        obj['etag'] = ApiClient.convertToType(data['etag'], 'String');
      }
      if (data.hasOwnProperty('lastModified')) {
        obj['lastModified'] = ApiClient.convertToType(data['lastModified'], 'Date');
      }
      if (data.hasOwnProperty('contentType')) {
        obj['contentType'] = ApiClient.convertToType(data['contentType'], 'String');
      }
      if (data.hasOwnProperty('scales')) {
        obj['scales'] = ApiClient.convertToType(data['scales'], ['String']);
      }
    }
    return obj;
  }


  /**
   * Link to a profile image. If an image is not uploaded for an extension, only uri is returned
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Identifier of an image
   * @member {String} etag
   */
  exports.prototype['etag'] = undefined;

  /**
   * The datetime when an image was last updated in ISO 8601 format, for example 2016-03-10T18:07:52.534Z
   * @member {Date} lastModified
   */
  exports.prototype['lastModified'] = undefined;

  /**
   * The type of an image
   * @member {String} contentType
   */
  exports.prototype['contentType'] = undefined;

  /**
   * List of URIs to profile images in different dimensions
   * @member {Array.<String>} scales
   */
  exports.prototype['scales'] = undefined;




  return exports;
}));
