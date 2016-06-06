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
    root.RingCentralApi.InlineResponseDefault = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The InlineResponseDefault model module.
   * @module model/InlineResponseDefault
   * @version v1.0
   */

  /**
   * Constructs a new <code>InlineResponseDefault</code>.
   * @alias module:model/InlineResponseDefault
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>InlineResponseDefault</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/InlineResponseDefault} obj Optional instance to populate.
   * @return {module:model/InlineResponseDefault} The populated <code>InlineResponseDefault</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('state')) {
        obj['state'] = ApiClient.convertToType(data['state'], 'String');
      }
      if (data.hasOwnProperty('expires_in')) {
        obj['expires_in'] = ApiClient.convertToType(data['expires_in'], 'Integer');
      }
      if (data.hasOwnProperty('code')) {
        obj['code'] = ApiClient.convertToType(data['code'], 'String');
      }
    }
    return obj;
  }


  /**
   * This parameter will be included in response if it was specified in the client authorization request. The value will be copied from the one received from the client
   * @member {String} state
   */
  exports.prototype['state'] = undefined;

  /**
   * The remaining lifetime of the authorization code
   * @member {Integer} expires_in
   */
  exports.prototype['expires_in'] = undefined;

  /**
   * The authorization code returned for your application
   * @member {String} code
   */
  exports.prototype['code'] = undefined;




  return exports;
}));
