(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './WeeklyScheduleInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./WeeklyScheduleInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.BusinessHourScheduleInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.WeeklyScheduleInfo);
  }
}(this, function(ApiClient, WeeklyScheduleInfo) {
  'use strict';

  /**
   * The BusinessHourScheduleInfo model module.
   * @module model/BusinessHourScheduleInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>BusinessHourScheduleInfo</code>.
   * @alias module:model/BusinessHourScheduleInfo
   * @class
   */
  var exports = function() {


  };

  /**
   * Constructs a <code>BusinessHourScheduleInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/BusinessHourScheduleInfo} obj Optional instance to populate.
   * @return {module:model/BusinessHourScheduleInfo} The populated <code>BusinessHourScheduleInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('weeklyRanges')) {
        obj['weeklyRanges'] = WeeklyScheduleInfo.constructFromObject(data['weeklyRanges']);
      }
    }
    return obj;
  }


  /**
   * @member {module:model/WeeklyScheduleInfo} weeklyRanges
   */
  exports.prototype['weeklyRanges'] = undefined;




  return exports;
}));
