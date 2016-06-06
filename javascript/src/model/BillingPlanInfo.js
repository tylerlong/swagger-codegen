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
    root.RingCentralApi.BillingPlanInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The BillingPlanInfo model module.
   * @module model/BillingPlanInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>BillingPlanInfo</code>.
   * @alias module:model/BillingPlanInfo
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>BillingPlanInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/BillingPlanInfo} obj Optional instance to populate.
   * @return {module:model/BillingPlanInfo} The populated <code>BillingPlanInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('durationUnit')) {
        obj['durationUnit'] = ApiClient.convertToType(data['durationUnit'], 'String');
      }
      if (data.hasOwnProperty('duration')) {
        obj['duration'] = ApiClient.convertToType(data['duration'], 'String');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a billing plan
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Billing plan name
   * @member {String} name
   */
  exports.prototype['name'] = undefined;

  /**
   * Duration period
   * @member {module:model/BillingPlanInfo.DurationUnitEnum} durationUnit
   */
  exports.prototype['durationUnit'] = undefined;

  /**
   * Number of duration units
   * @member {String} duration
   */
  exports.prototype['duration'] = undefined;

  /**
   * Billing plan type
   * @member {module:model/BillingPlanInfo.TypeEnum} type
   */
  exports.prototype['type'] = undefined;


  /**
   * Allowed values for the <code>durationUnit</code> property.
   * @enum {String}
   * @readonly
   */
  exports.DurationUnitEnum = { 
    /**
     * value: Month
     * @const
     */
    MONTH: "Month",
    
    /**
     * value: Day
     * @const
     */
    DAY: "Day"
  };  /**
   * Allowed values for the <code>type</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TypeEnum = { 
    /**
     * value: Initial
     * @const
     */
    INITIAL: "Initial",
    
    /**
     * value: Regular
     * @const
     */
    REGULAR: "Regular",
    
    /**
     * value: Suspended
     * @const
     */
    SUSPENDED: "Suspended",
    
    /**
     * value: Trial
     * @const
     */
    TRIAL: "Trial",
    
    /**
     * value: TrialNoCC
     * @const
     */
    TRIALNOCC: "TrialNoCC",
    
    /**
     * value: Free
     * @const
     */
    FREE: "Free"
  };

  return exports;
}));
