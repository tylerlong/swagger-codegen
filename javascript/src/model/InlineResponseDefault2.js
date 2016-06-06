(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './CallLogRecord', './NavigationInfo', './PagingInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CallLogRecord'), require('./NavigationInfo'), require('./PagingInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.InlineResponseDefault2 = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.CallLogRecord, root.RingCentralApi.NavigationInfo, root.RingCentralApi.PagingInfo);
  }
}(this, function(ApiClient, CallLogRecord, NavigationInfo, PagingInfo) {
  'use strict';

  /**
   * The InlineResponseDefault2 model module.
   * @module model/InlineResponseDefault2
   * @version v1.0
   */

  /**
   * Constructs a new <code>InlineResponseDefault2</code>.
   * @alias module:model/InlineResponseDefault2
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>InlineResponseDefault2</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/InlineResponseDefault2} obj Optional instance to populate.
   * @return {module:model/InlineResponseDefault2} The populated <code>InlineResponseDefault2</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('navigation')) {
        obj['navigation'] = NavigationInfo.constructFromObject(data['navigation']);
      }
      if (data.hasOwnProperty('records')) {
        obj['records'] = ApiClient.convertToType(data['records'], [CallLogRecord]);
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
   * List of call log records
   * @member {Array.<module:model/CallLogRecord>} records
   */
  exports.prototype['records'] = undefined;

  /**
   * @member {module:model/PagingInfo} paging
   */
  exports.prototype['paging'] = undefined;




  return exports;
}));
