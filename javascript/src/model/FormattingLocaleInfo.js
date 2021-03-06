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
    root.RingCentralApi.FormattingLocaleInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The FormattingLocaleInfo model module.
   * @module model/FormattingLocaleInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>FormattingLocaleInfo</code>.
   * @alias module:model/FormattingLocaleInfo
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>FormattingLocaleInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/FormattingLocaleInfo} obj Optional instance to populate.
   * @return {module:model/FormattingLocaleInfo} The populated <code>FormattingLocaleInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('localeCode')) {
        obj['localeCode'] = ApiClient.convertToType(data['localeCode'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a formatting language
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Localization code of a formatting language
   * @member {String} localeCode
   */
  exports.prototype['localeCode'] = undefined;

  /**
   * Official name of a formatting language
   * @member {String} name
   */
  exports.prototype['name'] = undefined;




  return exports;
}));
