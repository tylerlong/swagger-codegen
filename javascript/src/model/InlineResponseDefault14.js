(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './NavigationInfo', './PagingInfo', './TimezoneInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./NavigationInfo'), require('./PagingInfo'), require('./TimezoneInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.InlineResponseDefault14 = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.NavigationInfo, root.RingCentralApi.PagingInfo, root.RingCentralApi.TimezoneInfo);
  }
}(this, function(ApiClient, NavigationInfo, PagingInfo, TimezoneInfo) {
  'use strict';

  /**
   * The InlineResponseDefault14 model module.
   * @module model/InlineResponseDefault14
   * @version v1.0
   */

  /**
   * Constructs a new <code>InlineResponseDefault14</code>.
   * @alias module:model/InlineResponseDefault14
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>InlineResponseDefault14</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/InlineResponseDefault14} obj Optional instance to populate.
   * @return {module:model/InlineResponseDefault14} The populated <code>InlineResponseDefault14</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('navigation')) {
        obj['navigation'] = NavigationInfo.constructFromObject(data['navigation']);
      }
      if (data.hasOwnProperty('records')) {
        obj['records'] = ApiClient.convertToType(data['records'], [TimezoneInfo]);
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
   * List of timezones
   * @member {Array.<module:model/TimezoneInfo>} records
   */
  exports.prototype['records'] = undefined;

  /**
   * @member {module:model/PagingInfo} paging
   */
  exports.prototype['paging'] = undefined;




  return exports;
}));
