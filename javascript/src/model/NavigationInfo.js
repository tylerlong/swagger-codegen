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
    root.RingCentralApi.NavigationInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The NavigationInfo model module.
   * @module model/NavigationInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>NavigationInfo</code>.
   * @alias module:model/NavigationInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>NavigationInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/NavigationInfo} obj Optional instance to populate.
   * @return {module:model/NavigationInfo} The populated <code>NavigationInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('firstPage')) {
        obj['firstPage'] = ApiClient.convertToType(data['firstPage'], 'String');
      }
      if (data.hasOwnProperty('nextPage')) {
        obj['nextPage'] = ApiClient.convertToType(data['nextPage'], 'String');
      }
      if (data.hasOwnProperty('previousPage')) {
        obj['previousPage'] = ApiClient.convertToType(data['previousPage'], 'String');
      }
      if (data.hasOwnProperty('lastPage')) {
        obj['lastPage'] = ApiClient.convertToType(data['lastPage'], 'String');
      }
    }
    return obj;
  }


  /**
   * Canonical URI for the first page of the list
   * @member {String} firstPage
   */
  exports.prototype['firstPage'] = undefined;

  /**
   * Canonical URI for the next page of the list
   * @member {String} nextPage
   */
  exports.prototype['nextPage'] = undefined;

  /**
   * Canonical URI for the previous page of the list
   * @member {String} previousPage
   */
  exports.prototype['previousPage'] = undefined;

  /**
   * Canonical URI for the last page of the list
   * @member {String} lastPage
   */
  exports.prototype['lastPage'] = undefined;




  return exports;
}));
