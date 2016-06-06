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
    root.RingCentralApi.RecordingInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The RecordingInfo model module.
   * @module model/RecordingInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>RecordingInfo</code>.
   * @alias module:model/RecordingInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>RecordingInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RecordingInfo} obj Optional instance to populate.
   * @return {module:model/RecordingInfo} The populated <code>RecordingInfo</code> instance.
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
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
      if (data.hasOwnProperty('contentUri')) {
        obj['contentUri'] = ApiClient.convertToType(data['contentUri'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of the call recording
   * @member {Integer} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Link to the call recording metadata resource
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Indicates recording mode used
   * @member {module:model/RecordingInfo.TypeEnum} type
   */
  exports.prototype['type'] = undefined;

  /**
   * Link to the call recording binary content
   * @member {String} contentUri
   */
  exports.prototype['contentUri'] = undefined;


  /**
   * Allowed values for the <code>type</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TypeEnum = { 
    /**
     * value: Automatic
     * @const
     */
    AUTOMATIC: "Automatic",
    
    /**
     * value: OnDemand
     * @const
     */
    ONDEMAND: "OnDemand"
  };

  return exports;
}));
