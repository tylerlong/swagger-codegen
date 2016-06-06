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
    root.RingCentralApi.ServicePlanInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ServicePlanInfo model module.
   * @module model/ServicePlanInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ServicePlanInfo</code>.
   * @alias module:model/ServicePlanInfo
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>ServicePlanInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ServicePlanInfo} obj Optional instance to populate.
   * @return {module:model/ServicePlanInfo} The populated <code>ServicePlanInfo</code> instance.
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
      if (data.hasOwnProperty('edition')) {
        obj['edition'] = ApiClient.convertToType(data['edition'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a service plan
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Name of a service plan
   * @member {String} name
   */
  exports.prototype['name'] = undefined;

  /**
   * Edition of a service plan
   * @member {String} edition
   */
  exports.prototype['edition'] = undefined;




  return exports;
}));
