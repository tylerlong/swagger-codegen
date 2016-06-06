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
    root.RingCentralApi.CallerInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The CallerInfo model module.
   * @module model/CallerInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>CallerInfo</code>.
   * @alias module:model/CallerInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>CallerInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/CallerInfo} obj Optional instance to populate.
   * @return {module:model/CallerInfo} The populated <code>CallerInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
      if (data.hasOwnProperty('extensionNumber')) {
        obj['extensionNumber'] = ApiClient.convertToType(data['extensionNumber'], 'String');
      }
      if (data.hasOwnProperty('location')) {
        obj['location'] = ApiClient.convertToType(data['location'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
    }
    return obj;
  }


  /**
   * Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;

  /**
   * Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message
   * @member {String} extensionNumber
   */
  exports.prototype['extensionNumber'] = undefined;

  /**
   * Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)
   * @member {String} location
   */
  exports.prototype['location'] = undefined;

  /**
   * Symbolic name associated with a party. If the phone does not belong to the known extension, only the location is returned, the name is not determined then
   * @member {String} name
   */
  exports.prototype['name'] = undefined;




  return exports;
}));
