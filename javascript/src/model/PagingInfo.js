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
    root.RingCentralApi.PagingInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The PagingInfo model module.
   * @module model/PagingInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>PagingInfo</code>.
   * @alias module:model/PagingInfo
   * @class
   */
  var exports = function() {







  };

  /**
   * Constructs a <code>PagingInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PagingInfo} obj Optional instance to populate.
   * @return {module:model/PagingInfo} The populated <code>PagingInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('page')) {
        obj['page'] = ApiClient.convertToType(data['page'], 'Integer');
      }
      if (data.hasOwnProperty('perPage')) {
        obj['perPage'] = ApiClient.convertToType(data['perPage'], 'Integer');
      }
      if (data.hasOwnProperty('pageStart')) {
        obj['pageStart'] = ApiClient.convertToType(data['pageStart'], 'Integer');
      }
      if (data.hasOwnProperty('pageEnd')) {
        obj['pageEnd'] = ApiClient.convertToType(data['pageEnd'], 'Integer');
      }
      if (data.hasOwnProperty('totalPages')) {
        obj['totalPages'] = ApiClient.convertToType(data['totalPages'], 'Integer');
      }
      if (data.hasOwnProperty('totalElements')) {
        obj['totalElements'] = ApiClient.convertToType(data['totalElements'], 'Integer');
      }
    }
    return obj;
  }


  /**
   * The current page number. 1-indexed, so the first page is 1 by default. May be omitted if result is empty (because non-existent page was specified or perPage=0 was requested)
   * @member {Integer} page
   */
  exports.prototype['page'] = undefined;

  /**
   * Current page size, describes how many items are in each page. Default value is 100. Maximum value is 1000. If perPage value in the request is greater than 1000, the maximum value (1000) is applied
   * @member {Integer} perPage
   */
  exports.prototype['perPage'] = undefined;

  /**
   * The zero-based number of the first element on the current page. Omitted if the page is omitted or result is empty
   * @member {Integer} pageStart
   */
  exports.prototype['pageStart'] = undefined;

  /**
   * The zero-based index of the last element on the current page. Omitted if the page is omitted or result is empty
   * @member {Integer} pageEnd
   */
  exports.prototype['pageEnd'] = undefined;

  /**
   * The total number of pages in a dataset. May be omitted for some resources due to performance reasons
   * @member {Integer} totalPages
   */
  exports.prototype['totalPages'] = undefined;

  /**
   * The total number of elements in a dataset. May be omitted for some resource due to performance reasons
   * @member {Integer} totalElements
   */
  exports.prototype['totalElements'] = undefined;




  return exports;
}));
