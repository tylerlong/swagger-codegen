(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './TimeInterval'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./TimeInterval'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.WeeklyScheduleInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.TimeInterval);
  }
}(this, function(ApiClient, TimeInterval) {
  'use strict';

  /**
   * The WeeklyScheduleInfo model module.
   * @module model/WeeklyScheduleInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>WeeklyScheduleInfo</code>.
   * @alias module:model/WeeklyScheduleInfo
   * @class
   */
  var exports = function() {








  };

  /**
   * Constructs a <code>WeeklyScheduleInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/WeeklyScheduleInfo} obj Optional instance to populate.
   * @return {module:model/WeeklyScheduleInfo} The populated <code>WeeklyScheduleInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('monday')) {
        obj['monday'] = ApiClient.convertToType(data['monday'], [TimeInterval]);
      }
      if (data.hasOwnProperty('tuesday')) {
        obj['tuesday'] = ApiClient.convertToType(data['tuesday'], [TimeInterval]);
      }
      if (data.hasOwnProperty('wednesday')) {
        obj['wednesday'] = ApiClient.convertToType(data['wednesday'], [TimeInterval]);
      }
      if (data.hasOwnProperty('thursday')) {
        obj['thursday'] = ApiClient.convertToType(data['thursday'], [TimeInterval]);
      }
      if (data.hasOwnProperty('friday')) {
        obj['friday'] = ApiClient.convertToType(data['friday'], [TimeInterval]);
      }
      if (data.hasOwnProperty('saturday')) {
        obj['saturday'] = ApiClient.convertToType(data['saturday'], [TimeInterval]);
      }
      if (data.hasOwnProperty('sunday')) {
        obj['sunday'] = ApiClient.convertToType(data['sunday'], [TimeInterval]);
      }
    }
    return obj;
  }


  /**
   * Time intervals for a particular day
   * @member {Array.<module:model/TimeInterval>} monday
   */
  exports.prototype['monday'] = undefined;

  /**
   * Time intervals for a particular day
   * @member {Array.<module:model/TimeInterval>} tuesday
   */
  exports.prototype['tuesday'] = undefined;

  /**
   * Time intervals for a particular day
   * @member {Array.<module:model/TimeInterval>} wednesday
   */
  exports.prototype['wednesday'] = undefined;

  /**
   * Time intervals for a particular day
   * @member {Array.<module:model/TimeInterval>} thursday
   */
  exports.prototype['thursday'] = undefined;

  /**
   * Time intervals for a particular day
   * @member {Array.<module:model/TimeInterval>} friday
   */
  exports.prototype['friday'] = undefined;

  /**
   * Time intervals for a particular day
   * @member {Array.<module:model/TimeInterval>} saturday
   */
  exports.prototype['saturday'] = undefined;

  /**
   * Time intervals for a particular day
   * @member {Array.<module:model/TimeInterval>} sunday
   */
  exports.prototype['sunday'] = undefined;




  return exports;
}));
