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
    root.RingCentralApi.ExtensionInfoRequestContactInfoRegionalSettingsLanguage = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ExtensionInfoRequestContactInfoRegionalSettingsLanguage model module.
   * @module model/ExtensionInfoRequestContactInfoRegionalSettingsLanguage
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionInfoRequestContactInfoRegionalSettingsLanguage</code>.
   * @alias module:model/ExtensionInfoRequestContactInfoRegionalSettingsLanguage
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>ExtensionInfoRequestContactInfoRegionalSettingsLanguage</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionInfoRequestContactInfoRegionalSettingsLanguage} obj Optional instance to populate.
   * @return {module:model/ExtensionInfoRequestContactInfoRegionalSettingsLanguage} The populated <code>ExtensionInfoRequestContactInfoRegionalSettingsLanguage</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
    }
    return obj;
  }


  /**
   * Language identifier. The default value is \"1033\" (English US)
   * @member {String} id
   */
  exports.prototype['id'] = undefined;




  return exports;
}));
