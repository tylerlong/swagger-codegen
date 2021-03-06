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
    root.RingCentralApi.ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage model module.
   * @module model/ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage</code>.
   * @alias module:model/ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage} obj Optional instance to populate.
   * @return {module:model/ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage} The populated <code>ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage</code> instance.
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
   * Internal identifier of a greeting language
   * @member {String} id
   */
  exports.prototype['id'] = undefined;




  return exports;
}));
