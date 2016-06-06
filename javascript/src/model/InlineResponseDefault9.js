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
    root.RingCentralApi.InlineResponseDefault9 = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The InlineResponseDefault9 model module.
   * @module model/InlineResponseDefault9
   * @version v1.0
   */

  /**
   * Constructs a new <code>InlineResponseDefault9</code>.
   * @alias module:model/InlineResponseDefault9
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>InlineResponseDefault9</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/InlineResponseDefault9} obj Optional instance to populate.
   * @return {module:model/InlineResponseDefault9} The populated <code>InlineResponseDefault9</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'Integer');
      }
      if (data.hasOwnProperty('duration')) {
        obj['duration'] = ApiClient.convertToType(data['duration'], 'Integer');
      }
      if (data.hasOwnProperty('contentUri')) {
        obj['contentUri'] = ApiClient.convertToType(data['contentUri'], 'String');
      }
      if (data.hasOwnProperty('contentType')) {
        obj['contentType'] = ApiClient.convertToType(data['contentType'], 'String');
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
   * Recorded call duration
   * @member {Integer} duration
   */
  exports.prototype['duration'] = undefined;

  /**
   * Link to the call recording binary content
   * @member {String} contentUri
   */
  exports.prototype['contentUri'] = undefined;

  /**
   * Call recording file format. Supported format is audio/x-wav
   * @member {String} contentType
   */
  exports.prototype['contentType'] = undefined;




  return exports;
}));
