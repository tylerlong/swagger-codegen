(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './BusinessAddressInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./BusinessAddressInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.InlineResponseDefault3 = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.BusinessAddressInfo);
  }
}(this, function(ApiClient, BusinessAddressInfo) {
  'use strict';

  /**
   * The InlineResponseDefault3 model module.
   * @module model/InlineResponseDefault3
   * @version v1.0
   */

  /**
   * Constructs a new <code>InlineResponseDefault3</code>.
   * @alias module:model/InlineResponseDefault3
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>InlineResponseDefault3</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/InlineResponseDefault3} obj Optional instance to populate.
   * @return {module:model/InlineResponseDefault3} The populated <code>InlineResponseDefault3</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('email')) {
        obj['email'] = ApiClient.convertToType(data['email'], 'String');
      }
      if (data.hasOwnProperty('company')) {
        obj['company'] = ApiClient.convertToType(data['company'], 'String');
      }
      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('businessAddress')) {
        obj['businessAddress'] = BusinessAddressInfo.constructFromObject(data['businessAddress']);
      }
    }
    return obj;
  }


  /**
   * Company business email address
   * @member {String} email
   */
  exports.prototype['email'] = undefined;

  /**
   * Company business name
   * @member {String} company
   */
  exports.prototype['company'] = undefined;

  /**
   * Canonical URI of the business address resource
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * @member {module:model/BusinessAddressInfo} businessAddress
   */
  exports.prototype['businessAddress'] = undefined;




  return exports;
}));
