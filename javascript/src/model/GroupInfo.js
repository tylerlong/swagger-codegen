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
    root.RingCentralApi.GroupInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The GroupInfo model module.
   * @module model/GroupInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>GroupInfo</code>.
   * @alias module:model/GroupInfo
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>GroupInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/GroupInfo} obj Optional instance to populate.
   * @return {module:model/GroupInfo} The populated <code>GroupInfo</code> instance.
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
      if (data.hasOwnProperty('contactsCount')) {
        obj['contactsCount'] = ApiClient.convertToType(data['contactsCount'], 'Integer');
      }
      if (data.hasOwnProperty('groupName')) {
        obj['groupName'] = ApiClient.convertToType(data['groupName'], 'String');
      }
      if (data.hasOwnProperty('notes')) {
        obj['notes'] = ApiClient.convertToType(data['notes'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a group
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a group
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Amount of contacts in a group
   * @member {Integer} contactsCount
   */
  exports.prototype['contactsCount'] = undefined;

  /**
   * Name of a group
   * @member {String} groupName
   */
  exports.prototype['groupName'] = undefined;

  /**
   * Notes for a group
   * @member {String} notes
   */
  exports.prototype['notes'] = undefined;




  return exports;
}));
