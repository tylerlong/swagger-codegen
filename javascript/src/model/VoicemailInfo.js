(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './RecipientInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./RecipientInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.VoicemailInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.RecipientInfo);
  }
}(this, function(ApiClient, RecipientInfo) {
  'use strict';

  /**
   * The VoicemailInfo model module.
   * @module model/VoicemailInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>VoicemailInfo</code>.
   * @alias module:model/VoicemailInfo
   * @class
   */
  var exports = function() {



  };

  /**
   * Constructs a <code>VoicemailInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/VoicemailInfo} obj Optional instance to populate.
   * @return {module:model/VoicemailInfo} The populated <code>VoicemailInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('enabled')) {
        obj['enabled'] = ApiClient.convertToType(data['enabled'], 'Boolean');
      }
      if (data.hasOwnProperty('recipient')) {
        obj['recipient'] = RecipientInfo.constructFromObject(data['recipient']);
      }
    }
    return obj;
  }


  /**
   * If 'True' then voicemails are allowed to be received
   * @member {Boolean} enabled
   */
  exports.prototype['enabled'] = undefined;

  /**
   * @member {module:model/RecipientInfo} recipient
   */
  exports.prototype['recipient'] = undefined;




  return exports;
}));
