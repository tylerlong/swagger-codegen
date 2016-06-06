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
    root.RingCentralApi.LocationInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The LocationInfo model module.
   * @module model/LocationInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>LocationInfo</code>.
   * @alias module:model/LocationInfo
   * @class
   */
  var exports = function() {







  };

  /**
   * Constructs a <code>LocationInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/LocationInfo} obj Optional instance to populate.
   * @return {module:model/LocationInfo} The populated <code>LocationInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('areaCode')) {
        obj['areaCode'] = ApiClient.convertToType(data['areaCode'], 'String');
      }
      if (data.hasOwnProperty('city')) {
        obj['city'] = ApiClient.convertToType(data['city'], 'String');
      }
      if (data.hasOwnProperty('npa')) {
        obj['npa'] = ApiClient.convertToType(data['npa'], 'String');
      }
      if (data.hasOwnProperty('nxx')) {
        obj['nxx'] = ApiClient.convertToType(data['nxx'], 'String');
      }
      if (data.hasOwnProperty('state')) {
        obj['state'] = ApiClient.convertToType(data['state'], 'String');
      }
    }
    return obj;
  }


  /**
   * Canonical URI of a location
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Area code of the location
   * @member {String} areaCode
   */
  exports.prototype['areaCode'] = undefined;

  /**
   * Official name of the city, belonging to the certain state
   * @member {String} city
   */
  exports.prototype['city'] = undefined;

  /**
   * Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan
   * @member {String} npa
   */
  exports.prototype['npa'] = undefined;

  /**
   * Central office code of the location, according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See for details North American Numbering Plan
   * @member {String} nxx
   */
  exports.prototype['nxx'] = undefined;

  /**
   * ID and URI of the state this location belongs to, see State Info
   * @member {String} state
   */
  exports.prototype['state'] = undefined;




  return exports;
}));
