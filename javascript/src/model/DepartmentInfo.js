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
    root.RingCentralApi.DepartmentInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The DepartmentInfo model module.
   * @module model/DepartmentInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>DepartmentInfo</code>.
   * @alias module:model/DepartmentInfo
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>DepartmentInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/DepartmentInfo} obj Optional instance to populate.
   * @return {module:model/DepartmentInfo} The populated <code>DepartmentInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('extensionNumber')) {
        obj['extensionNumber'] = ApiClient.convertToType(data['extensionNumber'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a department extension
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a department extension
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Number of a department extension
   * @member {String} extensionNumber
   */
  exports.prototype['extensionNumber'] = undefined;




  return exports;
}));
