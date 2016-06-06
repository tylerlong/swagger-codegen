(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './LanguageInfo', './NavigationInfo', './PagingInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./LanguageInfo'), require('./NavigationInfo'), require('./PagingInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.InlineResponseDefault11 = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.LanguageInfo, root.RingCentralApi.NavigationInfo, root.RingCentralApi.PagingInfo);
  }
}(this, function(ApiClient, LanguageInfo, NavigationInfo, PagingInfo) {
  'use strict';

  /**
   * The InlineResponseDefault11 model module.
   * @module model/InlineResponseDefault11
   * @version v1.0
   */

  /**
   * Constructs a new <code>InlineResponseDefault11</code>.
   * @alias module:model/InlineResponseDefault11
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>InlineResponseDefault11</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/InlineResponseDefault11} obj Optional instance to populate.
   * @return {module:model/InlineResponseDefault11} The populated <code>InlineResponseDefault11</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('navigation')) {
        obj['navigation'] = NavigationInfo.constructFromObject(data['navigation']);
      }
      if (data.hasOwnProperty('records')) {
        obj['records'] = ApiClient.convertToType(data['records'], [LanguageInfo]);
      }
      if (data.hasOwnProperty('paging')) {
        obj['paging'] = PagingInfo.constructFromObject(data['paging']);
      }
    }
    return obj;
  }


  /**
   * @member {module:model/NavigationInfo} navigation
   */
  exports.prototype['navigation'] = undefined;

  /**
   * Language data
   * @member {Array.<module:model/LanguageInfo>} records
   */
  exports.prototype['records'] = undefined;

  /**
   * @member {module:model/PagingInfo} paging
   */
  exports.prototype['paging'] = undefined;




  return exports;
}));
