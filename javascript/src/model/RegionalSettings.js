(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './CountryInfo', './FormattingLocaleInfo', './GreetingLanguageInfo', './LanguageInfo', './TimezoneInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CountryInfo'), require('./FormattingLocaleInfo'), require('./GreetingLanguageInfo'), require('./LanguageInfo'), require('./TimezoneInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.RegionalSettings = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.CountryInfo, root.RingCentralApi.FormattingLocaleInfo, root.RingCentralApi.GreetingLanguageInfo, root.RingCentralApi.LanguageInfo, root.RingCentralApi.TimezoneInfo);
  }
}(this, function(ApiClient, CountryInfo, FormattingLocaleInfo, GreetingLanguageInfo, LanguageInfo, TimezoneInfo) {
  'use strict';

  /**
   * The RegionalSettings model module.
   * @module model/RegionalSettings
   * @version v1.0
   */

  /**
   * Constructs a new <code>RegionalSettings</code>.
   * @alias module:model/RegionalSettings
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>RegionalSettings</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RegionalSettings} obj Optional instance to populate.
   * @return {module:model/RegionalSettings} The populated <code>RegionalSettings</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('homeCountry')) {
        obj['homeCountry'] = CountryInfo.constructFromObject(data['homeCountry']);
      }
      if (data.hasOwnProperty('timezone')) {
        obj['timezone'] = TimezoneInfo.constructFromObject(data['timezone']);
      }
      if (data.hasOwnProperty('language')) {
        obj['language'] = LanguageInfo.constructFromObject(data['language']);
      }
      if (data.hasOwnProperty('greetingLanguage')) {
        obj['greetingLanguage'] = GreetingLanguageInfo.constructFromObject(data['greetingLanguage']);
      }
      if (data.hasOwnProperty('formattingLocale')) {
        obj['formattingLocale'] = FormattingLocaleInfo.constructFromObject(data['formattingLocale']);
      }
    }
    return obj;
  }


  /**
   * @member {module:model/CountryInfo} homeCountry
   */
  exports.prototype['homeCountry'] = undefined;

  /**
   * @member {module:model/TimezoneInfo} timezone
   */
  exports.prototype['timezone'] = undefined;

  /**
   * @member {module:model/LanguageInfo} language
   */
  exports.prototype['language'] = undefined;

  /**
   * @member {module:model/GreetingLanguageInfo} greetingLanguage
   */
  exports.prototype['greetingLanguage'] = undefined;

  /**
   * @member {module:model/FormattingLocaleInfo} formattingLocale
   */
  exports.prototype['formattingLocale'] = undefined;




  return exports;
}));
