(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './RangesInfo', './WeeklyScheduleInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./RangesInfo'), require('./WeeklyScheduleInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ScheduleInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.RangesInfo, root.RingCentralApi.WeeklyScheduleInfo);
  }
}(this, function(ApiClient, RangesInfo, WeeklyScheduleInfo) {
  'use strict';

  /**
   * The ScheduleInfo model module.
   * @module model/ScheduleInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ScheduleInfo</code>.
   * @alias module:model/ScheduleInfo
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>ScheduleInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ScheduleInfo} obj Optional instance to populate.
   * @return {module:model/ScheduleInfo} The populated <code>ScheduleInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('weeklyRanges')) {
        obj['weeklyRanges'] = WeeklyScheduleInfo.constructFromObject(data['weeklyRanges']);
      }
      if (data.hasOwnProperty('ranges')) {
        obj['ranges'] = RangesInfo.constructFromObject(data['ranges']);
      }
      if (data.hasOwnProperty('ref')) {
        obj['ref'] = ApiClient.convertToType(data['ref'], 'String');
      }
    }
    return obj;
  }


  /**
   * @member {module:model/WeeklyScheduleInfo} weeklyRanges
   */
  exports.prototype['weeklyRanges'] = undefined;

  /**
   * @member {module:model/RangesInfo} ranges
   */
  exports.prototype['ranges'] = undefined;

  /**
   * The user's schedule specified for business hours or after hours; it can also be set/retrieved calling the corresponding method
   * @member {module:model/ScheduleInfo.RefEnum} ref
   */
  exports.prototype['ref'] = undefined;


  /**
   * Allowed values for the <code>ref</code> property.
   * @enum {String}
   * @readonly
   */
  exports.RefEnum = { 
    /**
     * value: BusinessHours
     * @const
     */
    BUSINESSHOURS: "BusinessHours",
    
    /**
     * value: AfterHours
     * @const
     */
    AFTERHOURS: "AfterHours"
  };

  return exports;
}));
