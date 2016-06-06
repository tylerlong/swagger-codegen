(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './NavigationInfo', './PagingInfo', './PhoneNumberInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./NavigationInfo'), require('./PagingInfo'), require('./PhoneNumberInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.InlineResponseDefault7 = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.NavigationInfo, root.RingCentralApi.PagingInfo, root.RingCentralApi.PhoneNumberInfo);
  }
}(this, function(ApiClient, NavigationInfo, PagingInfo, PhoneNumberInfo) {
  'use strict';

  /**
   * The InlineResponseDefault7 model module.
   * @module model/InlineResponseDefault7
   * @version v1.0
   */

  /**
   * Constructs a new <code>InlineResponseDefault7</code>.
   * @alias module:model/InlineResponseDefault7
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>InlineResponseDefault7</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/InlineResponseDefault7} obj Optional instance to populate.
   * @return {module:model/InlineResponseDefault7} The populated <code>InlineResponseDefault7</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('navigation')) {
        obj['navigation'] = NavigationInfo.constructFromObject(data['navigation']);
      }
      if (data.hasOwnProperty('records')) {
        obj['records'] = ApiClient.convertToType(data['records'], [PhoneNumberInfo]);
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
   * List of phone numbers
   * @member {Array.<module:model/PhoneNumberInfo>} records
   */
  exports.prototype['records'] = undefined;

  /**
   * @member {module:model/PagingInfo} paging
   */
  exports.prototype['paging'] = undefined;




  return exports;
}));
