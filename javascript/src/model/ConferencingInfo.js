(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './ConferencingInfoPhoneNumberInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ConferencingInfoPhoneNumberInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ConferencingInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.ConferencingInfoPhoneNumberInfo);
  }
}(this, function(ApiClient, ConferencingInfoPhoneNumberInfo) {
  'use strict';

  /**
   * The ConferencingInfo model module.
   * @module model/ConferencingInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ConferencingInfo</code>.
   * @alias module:model/ConferencingInfo
   * @class
   */
  var exports = function() {









  };

  /**
   * Constructs a <code>ConferencingInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ConferencingInfo} obj Optional instance to populate.
   * @return {module:model/ConferencingInfo} The populated <code>ConferencingInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('allowJoinBeforeHost')) {
        obj['allowJoinBeforeHost'] = ApiClient.convertToType(data['allowJoinBeforeHost'], 'Boolean');
      }
      if (data.hasOwnProperty('hostCode')) {
        obj['hostCode'] = ApiClient.convertToType(data['hostCode'], 'String');
      }
      if (data.hasOwnProperty('mode')) {
        obj['mode'] = ApiClient.convertToType(data['mode'], 'String');
      }
      if (data.hasOwnProperty('participantCode')) {
        obj['participantCode'] = ApiClient.convertToType(data['participantCode'], 'String');
      }
      if (data.hasOwnProperty('phoneNumber')) {
        obj['phoneNumber'] = ApiClient.convertToType(data['phoneNumber'], 'String');
      }
      if (data.hasOwnProperty('tapToJoinUri')) {
        obj['tapToJoinUri'] = ApiClient.convertToType(data['tapToJoinUri'], 'String');
      }
      if (data.hasOwnProperty('phoneNumbers')) {
        obj['phoneNumbers'] = ApiClient.convertToType(data['phoneNumbers'], [ConferencingInfoPhoneNumberInfo]);
      }
    }
    return obj;
  }


  /**
   * Canonical URI of a conferencing
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Determines if host user allows conference participants to join before the host
   * @member {Boolean} allowJoinBeforeHost
   */
  exports.prototype['allowJoinBeforeHost'] = undefined;

  /**
   * Access code for a host user
   * @member {String} hostCode
   */
  exports.prototype['hostCode'] = undefined;

  /**
   * Internal parameter specifying conferencing engine
   * @member {String} mode
   */
  exports.prototype['mode'] = undefined;

  /**
   * Access code for any participant
   * @member {String} participantCode
   */
  exports.prototype['participantCode'] = undefined;

  /**
   * Primary conference phone number for user's home country returned in E.164 (11-digits) format
   * @member {String} phoneNumber
   */
  exports.prototype['phoneNumber'] = undefined;

  /**
   * Short URL leading to the service web page Tap to Join for audio conference bridge
   * @member {String} tapToJoinUri
   */
  exports.prototype['tapToJoinUri'] = undefined;

  /**
   * List of multiple dial-in phone numbers to connect to audio conference service, relevant for user's brand. Each number is given with the country and location information, in order to let the user choose the less expensive way to connect to a conference. The first number in the list is the primary conference number, that is default and domestic
   * @member {Array.<module:model/ConferencingInfoPhoneNumberInfo>} phoneNumbers
   */
  exports.prototype['phoneNumbers'] = undefined;




  return exports;
}));
