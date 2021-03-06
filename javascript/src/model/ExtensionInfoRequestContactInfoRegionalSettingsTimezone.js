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
    root.RingCentralApi.ExtensionInfoRequestContactInfoRegionalSettingsTimezone = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ExtensionInfoRequestContactInfoRegionalSettingsTimezone model module.
   * @module model/ExtensionInfoRequestContactInfoRegionalSettingsTimezone
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionInfoRequestContactInfoRegionalSettingsTimezone</code>.
   * @alias module:model/ExtensionInfoRequestContactInfoRegionalSettingsTimezone
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>ExtensionInfoRequestContactInfoRegionalSettingsTimezone</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionInfoRequestContactInfoRegionalSettingsTimezone} obj Optional instance to populate.
   * @return {module:model/ExtensionInfoRequestContactInfoRegionalSettingsTimezone} The populated <code>ExtensionInfoRequestContactInfoRegionalSettingsTimezone</code> instance.
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
   * Timezone identifier. The default value is \"58\" (US&Canada)
   * @member {String} id
   */
  exports.prototype['id'] = undefined;




  return exports;
}));
