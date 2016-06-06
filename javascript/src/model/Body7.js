(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './CallerInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CallerInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.Body7 = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.CallerInfo);
  }
}(this, function(ApiClient, CallerInfo) {
  'use strict';

  /**
   * The Body7 model module.
   * @module model/Body7
   * @version v1.0
   */

  /**
   * Constructs a new <code>Body7</code>.
   * @alias module:model/Body7
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>Body7</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Body7} obj Optional instance to populate.
   * @return {module:model/Body7} The populated <code>Body7</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('from')) {
        obj['from'] = CallerInfo.constructFromObject(data['from']);
      }
      if (data.hasOwnProperty('to')) {
        obj['to'] = ApiClient.convertToType(data['to'], [CallerInfo]);
      }
      if (data.hasOwnProperty('text')) {
        obj['text'] = ApiClient.convertToType(data['text'], 'String');
      }
    }
    return obj;
  }


  /**
   * @member {module:model/CallerInfo} from
   */
  exports.prototype['from'] = undefined;

  /**
   * Receiver of an SMS message. The phoneNumber property must be filled
   * @member {Array.<module:model/CallerInfo>} to
   */
  exports.prototype['to'] = undefined;

  /**
   * Text of a message. Max length is 1000 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 500 symbols
   * @member {String} text
   */
  exports.prototype['text'] = undefined;




  return exports;
}));
