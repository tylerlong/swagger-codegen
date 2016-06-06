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
    root.RingCentralApi.Body3 = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.CallerInfo);
  }
}(this, function(ApiClient, CallerInfo) {
  'use strict';

  /**
   * The Body3 model module.
   * @module model/Body3
   * @version v1.0
   */

  /**
   * Constructs a new <code>Body3</code>.
   * @alias module:model/Body3
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>Body3</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Body3} obj Optional instance to populate.
   * @return {module:model/Body3} The populated <code>Body3</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('from')) {
        obj['from'] = CallerInfo.constructFromObject(data['from']);
      }
      if (data.hasOwnProperty('replyOn')) {
        obj['replyOn'] = ApiClient.convertToType(data['replyOn'], 'Integer');
      }
      if (data.hasOwnProperty('text')) {
        obj['text'] = ApiClient.convertToType(data['text'], 'String');
      }
      if (data.hasOwnProperty('to')) {
        obj['to'] = ApiClient.convertToType(data['to'], [CallerInfo]);
      }
    }
    return obj;
  }


  /**
   * @member {module:model/CallerInfo} from
   */
  exports.prototype['from'] = undefined;

  /**
   * Internal identifier of a message this message replies to
   * @member {Integer} replyOn
   */
  exports.prototype['replyOn'] = undefined;

  /**
   * Text of a pager message. Max length is 1024 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 512 symbols
   * @member {String} text
   */
  exports.prototype['text'] = undefined;

  /**
   * Optional if replyOn parameter is specified. Receiver of a pager message. The extensionNumber property must be filled
   * @member {Array.<module:model/CallerInfo>} to
   */
  exports.prototype['to'] = undefined;




  return exports;
}));
