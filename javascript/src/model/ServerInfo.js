(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './VersionInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./VersionInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ServerInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.VersionInfo);
  }
}(this, function(ApiClient, VersionInfo) {
  'use strict';

  /**
   * The ServerInfo model module.
   * @module model/ServerInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ServerInfo</code>.
   * @alias module:model/ServerInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>ServerInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ServerInfo} obj Optional instance to populate.
   * @return {module:model/ServerInfo} The populated <code>ServerInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('apiVersions')) {
        obj['apiVersions'] = ApiClient.convertToType(data['apiVersions'], [VersionInfo]);
      }
      if (data.hasOwnProperty('serverVersion')) {
        obj['serverVersion'] = ApiClient.convertToType(data['serverVersion'], 'String');
      }
      if (data.hasOwnProperty('serverRevision')) {
        obj['serverRevision'] = ApiClient.convertToType(data['serverRevision'], 'String');
      }
    }
    return obj;
  }


  /**
   * Canonical URI of the API version
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Full API version information: uri, number, release date
   * @member {Array.<module:model/VersionInfo>} apiVersions
   */
  exports.prototype['apiVersions'] = undefined;

  /**
   * Server version
   * @member {String} serverVersion
   */
  exports.prototype['serverVersion'] = undefined;

  /**
   * Server revision
   * @member {String} serverRevision
   */
  exports.prototype['serverRevision'] = undefined;




  return exports;
}));
