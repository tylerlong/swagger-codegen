(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './ExtensionInfoRequestContactInfoRegionalSettingsFormattingLocale', './ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage', './ExtensionInfoRequestContactInfoRegionalSettingsLanguage', './ExtensionInfoRequestContactInfoRegionalSettingsTimezone'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ExtensionInfoRequestContactInfoRegionalSettingsFormattingLocale'), require('./ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage'), require('./ExtensionInfoRequestContactInfoRegionalSettingsLanguage'), require('./ExtensionInfoRequestContactInfoRegionalSettingsTimezone'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ExtensionInfoRequestContactInfoRegionalSettings = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.ExtensionInfoRequestContactInfoRegionalSettingsFormattingLocale, root.RingCentralApi.ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage, root.RingCentralApi.ExtensionInfoRequestContactInfoRegionalSettingsLanguage, root.RingCentralApi.ExtensionInfoRequestContactInfoRegionalSettingsTimezone);
  }
}(this, function(ApiClient, ExtensionInfoRequestContactInfoRegionalSettingsFormattingLocale, ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage, ExtensionInfoRequestContactInfoRegionalSettingsLanguage, ExtensionInfoRequestContactInfoRegionalSettingsTimezone) {
  'use strict';

  /**
   * The ExtensionInfoRequestContactInfoRegionalSettings model module.
   * @module model/ExtensionInfoRequestContactInfoRegionalSettings
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionInfoRequestContactInfoRegionalSettings</code>.
   * @alias module:model/ExtensionInfoRequestContactInfoRegionalSettings
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>ExtensionInfoRequestContactInfoRegionalSettings</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionInfoRequestContactInfoRegionalSettings} obj Optional instance to populate.
   * @return {module:model/ExtensionInfoRequestContactInfoRegionalSettings} The populated <code>ExtensionInfoRequestContactInfoRegionalSettings</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('timezone')) {
        obj['timezone'] = ExtensionInfoRequestContactInfoRegionalSettingsTimezone.constructFromObject(data['timezone']);
      }
      if (data.hasOwnProperty('language')) {
        obj['language'] = ExtensionInfoRequestContactInfoRegionalSettingsLanguage.constructFromObject(data['language']);
      }
      if (data.hasOwnProperty('greetingLanguage')) {
        obj['greetingLanguage'] = ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage.constructFromObject(data['greetingLanguage']);
      }
      if (data.hasOwnProperty('formattingLocale')) {
        obj['formattingLocale'] = ExtensionInfoRequestContactInfoRegionalSettingsFormattingLocale.constructFromObject(data['formattingLocale']);
      }
    }
    return obj;
  }


  /**
   * @member {module:model/ExtensionInfoRequestContactInfoRegionalSettingsTimezone} timezone
   */
  exports.prototype['timezone'] = undefined;

  /**
   * @member {module:model/ExtensionInfoRequestContactInfoRegionalSettingsLanguage} language
   */
  exports.prototype['language'] = undefined;

  /**
   * @member {module:model/ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage} greetingLanguage
   */
  exports.prototype['greetingLanguage'] = undefined;

  /**
   * @member {module:model/ExtensionInfoRequestContactInfoRegionalSettingsFormattingLocale} formattingLocale
   */
  exports.prototype['formattingLocale'] = undefined;




  return exports;
}));
