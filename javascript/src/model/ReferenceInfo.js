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
    root.RingCentralApi.ReferenceInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ReferenceInfo model module.
   * @module model/ReferenceInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ReferenceInfo</code>.
   * @alias module:model/ReferenceInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>ReferenceInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ReferenceInfo} obj Optional instance to populate.
   * @return {module:model/ReferenceInfo} The populated <code>ReferenceInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('ref')) {
        obj['ref'] = ApiClient.convertToType(data['ref'], 'String');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
    }
    return obj;
  }


  /**
   * Non-RC identifier of an extension
   * @member {String} ref
   */
  exports.prototype['ref'] = undefined;

  /**
   * Type of external identifier
   * @member {module:model/ReferenceInfo.TypeEnum} type
   */
  exports.prototype['type'] = undefined;


  /**
   * Allowed values for the <code>type</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TypeEnum = { 
    /**
     * value: PartnerId
     * @const
     */
    PARTNERID: "PartnerId",
    
    /**
     * value: CustomerDirectoryId
     * @const
     */
    CUSTOMERDIRECTORYID: "CustomerDirectoryId"
  };

  return exports;
}));
