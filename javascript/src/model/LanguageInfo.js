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
    root.RingCentralApi.LanguageInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The LanguageInfo model module.
   * @module model/LanguageInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>LanguageInfo</code>.
   * @alias module:model/LanguageInfo
   * @class
   */
  var exports = function() {








  };

  /**
   * Constructs a <code>LanguageInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/LanguageInfo} obj Optional instance to populate.
   * @return {module:model/LanguageInfo} The populated <code>LanguageInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('greeting')) {
        obj['greeting'] = ApiClient.convertToType(data['greeting'], 'Boolean');
      }
      if (data.hasOwnProperty('formattingLocale')) {
        obj['formattingLocale'] = ApiClient.convertToType(data['formattingLocale'], 'Boolean');
      }
      if (data.hasOwnProperty('localeCode')) {
        obj['localeCode'] = ApiClient.convertToType(data['localeCode'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('ui')) {
        obj['ui'] = ApiClient.convertToType(data['ui'], 'Boolean');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a language
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a language
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Indicates whether a language is available as greeting language
   * @member {Boolean} greeting
   */
  exports.prototype['greeting'] = undefined;

  /**
   * Indicates whether a language is available as formatting locale
   * @member {Boolean} formattingLocale
   */
  exports.prototype['formattingLocale'] = undefined;

  /**
   * Localization code of a language
   * @member {String} localeCode
   */
  exports.prototype['localeCode'] = undefined;

  /**
   * Official name of a language
   * @member {String} name
   */
  exports.prototype['name'] = undefined;

  /**
   * Indicates whether a language is available as UI language
   * @member {Boolean} ui
   */
  exports.prototype['ui'] = undefined;




  return exports;
}));
