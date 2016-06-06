(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './BillingPlanInfo', './BrandInfo', './ServicePlanInfo', './TargetServicePlanInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./BillingPlanInfo'), require('./BrandInfo'), require('./ServicePlanInfo'), require('./TargetServicePlanInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ServiceInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.BillingPlanInfo, root.RingCentralApi.BrandInfo, root.RingCentralApi.ServicePlanInfo, root.RingCentralApi.TargetServicePlanInfo);
  }
}(this, function(ApiClient, BillingPlanInfo, BrandInfo, ServicePlanInfo, TargetServicePlanInfo) {
  'use strict';

  /**
   * The ServiceInfo model module.
   * @module model/ServiceInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ServiceInfo</code>.
   * @alias module:model/ServiceInfo
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>ServiceInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ServiceInfo} obj Optional instance to populate.
   * @return {module:model/ServiceInfo} The populated <code>ServiceInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('billingPlan')) {
        obj['billingPlan'] = BillingPlanInfo.constructFromObject(data['billingPlan']);
      }
      if (data.hasOwnProperty('brand')) {
        obj['brand'] = BrandInfo.constructFromObject(data['brand']);
      }
      if (data.hasOwnProperty('servicePlan')) {
        obj['servicePlan'] = ServicePlanInfo.constructFromObject(data['servicePlan']);
      }
      if (data.hasOwnProperty('targetServicePlan')) {
        obj['targetServicePlan'] = TargetServicePlanInfo.constructFromObject(data['targetServicePlan']);
      }
    }
    return obj;
  }


  /**
   * Canonical URI of a service info resource
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * @member {module:model/BillingPlanInfo} billingPlan
   */
  exports.prototype['billingPlan'] = undefined;

  /**
   * @member {module:model/BrandInfo} brand
   */
  exports.prototype['brand'] = undefined;

  /**
   * @member {module:model/ServicePlanInfo} servicePlan
   */
  exports.prototype['servicePlan'] = undefined;

  /**
   * @member {module:model/TargetServicePlanInfo} targetServicePlan
   */
  exports.prototype['targetServicePlan'] = undefined;




  return exports;
}));
