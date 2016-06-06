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
    root.RingCentralApi.VersionInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The VersionInfo model module.
   * @module model/VersionInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>VersionInfo</code>.
   * @alias module:model/VersionInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>VersionInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/VersionInfo} obj Optional instance to populate.
   * @return {module:model/VersionInfo} The populated <code>VersionInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('versionString')) {
        obj['versionString'] = ApiClient.convertToType(data['versionString'], 'String');
      }
      if (data.hasOwnProperty('releaseDate')) {
        obj['releaseDate'] = ApiClient.convertToType(data['releaseDate'], 'String');
      }
      if (data.hasOwnProperty('uriString')) {
        obj['uriString'] = ApiClient.convertToType(data['uriString'], 'String');
      }
    }
    return obj;
  }


  /**
   * Canonical URI of API versions
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Version of the RingCentral REST API
   * @member {String} versionString
   */
  exports.prototype['versionString'] = undefined;

  /**
   * Release date of this version
   * @member {String} releaseDate
   */
  exports.prototype['releaseDate'] = undefined;

  /**
   * URI part determining the current version
   * @member {String} uriString
   */
  exports.prototype['uriString'] = undefined;




  return exports;
}));
