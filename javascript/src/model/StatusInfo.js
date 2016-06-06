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
    root.RingCentralApi.StatusInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The StatusInfo model module.
   * @module model/StatusInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>StatusInfo</code>.
   * @alias module:model/StatusInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>StatusInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/StatusInfo} obj Optional instance to populate.
   * @return {module:model/StatusInfo} The populated <code>StatusInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('comment')) {
        obj['comment'] = ApiClient.convertToType(data['comment'], 'String');
      }
      if (data.hasOwnProperty('reason')) {
        obj['reason'] = ApiClient.convertToType(data['reason'], 'String');
      }
    }
    return obj;
  }


  /**
   * A free-form user comment, describing the status change reason
   * @member {String} comment
   */
  exports.prototype['comment'] = undefined;

  /**
   * Type of suspension
   * @member {module:model/StatusInfo.ReasonEnum} reason
   */
  exports.prototype['reason'] = undefined;


  /**
   * Allowed values for the <code>reason</code> property.
   * @enum {String}
   * @readonly
   */
  exports.ReasonEnum = { 
    /**
     * value: Voluntarily
     * @const
     */
    VOLUNTARILY: "Voluntarily",
    
    /**
     * value: Involuntarily
     * @const
     */
    INVOLUNTARILY: "Involuntarily"
  };

  return exports;
}));
