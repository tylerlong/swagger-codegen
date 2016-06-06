(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './PresenceInfoExtensionInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./PresenceInfoExtensionInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.PresenceInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.PresenceInfoExtensionInfo);
  }
}(this, function(ApiClient, PresenceInfoExtensionInfo) {
  'use strict';

  /**
   * The PresenceInfo model module.
   * @module model/PresenceInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>PresenceInfo</code>.
   * @alias module:model/PresenceInfo
   * @class
   */
  var exports = function() {











  };

  /**
   * Constructs a <code>PresenceInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PresenceInfo} obj Optional instance to populate.
   * @return {module:model/PresenceInfo} The populated <code>PresenceInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('uri')) {
        obj['uri'] = ApiClient.convertToType(data['uri'], 'String');
      }
      if (data.hasOwnProperty('allowSeeMyPresence')) {
        obj['allowSeeMyPresence'] = ApiClient.convertToType(data['allowSeeMyPresence'], 'Boolean');
      }
      if (data.hasOwnProperty('dndStatus')) {
        obj['dndStatus'] = ApiClient.convertToType(data['dndStatus'], 'String');
      }
      if (data.hasOwnProperty('extension')) {
        obj['extension'] = PresenceInfoExtensionInfo.constructFromObject(data['extension']);
      }
      if (data.hasOwnProperty('message')) {
        obj['message'] = ApiClient.convertToType(data['message'], 'String');
      }
      if (data.hasOwnProperty('pickUpCallsOnHold')) {
        obj['pickUpCallsOnHold'] = ApiClient.convertToType(data['pickUpCallsOnHold'], 'Boolean');
      }
      if (data.hasOwnProperty('presenceStatus')) {
        obj['presenceStatus'] = ApiClient.convertToType(data['presenceStatus'], 'String');
      }
      if (data.hasOwnProperty('ringOnMonitoredCall')) {
        obj['ringOnMonitoredCall'] = ApiClient.convertToType(data['ringOnMonitoredCall'], 'Boolean');
      }
      if (data.hasOwnProperty('telephonyStatus')) {
        obj['telephonyStatus'] = ApiClient.convertToType(data['telephonyStatus'], 'String');
      }
      if (data.hasOwnProperty('userStatus')) {
        obj['userStatus'] = ApiClient.convertToType(data['userStatus'], 'String');
      }
    }
    return obj;
  }


  /**
   * Canonical URI of a presence info resource
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * If 'True' enables other extensions to see the extension presence status
   * @member {Boolean} allowSeeMyPresence
   */
  exports.prototype['allowSeeMyPresence'] = undefined;

  /**
   * Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR Menu/Application Extension/Park Location extensions. The 'DoNotAcceptDepartmentCalls' and 'TakeDepartmentCallsOnly' values are applicable only for extensions - members of a Department; if these values are set for department outsiders, the 400 Bad Request error code is returned. The 'TakeDepartmentCallsOnly' status can be set through the old RingCentral user interface and is available for some migrated accounts only.
   * @member {module:model/PresenceInfo.DndStatusEnum} dndStatus
   */
  exports.prototype['dndStatus'] = undefined;

  /**
   * @member {module:model/PresenceInfoExtensionInfo} extension
   */
  exports.prototype['extension'] = undefined;

  /**
   * Custom status message (as previously published by user)
   * @member {String} message
   */
  exports.prototype['message'] = undefined;

  /**
   * If 'True' enables the extension user to pick up a monitored line on hold
   * @member {Boolean} pickUpCallsOnHold
   */
  exports.prototype['pickUpCallsOnHold'] = undefined;

  /**
   * Aggregated presence status, calculated from a number of sources
   * @member {module:model/PresenceInfo.PresenceStatusEnum} presenceStatus
   */
  exports.prototype['presenceStatus'] = undefined;

  /**
   * If 'True' enables to ring extension phone, if any user monitored by this extension is ringing
   * @member {Boolean} ringOnMonitoredCall
   */
  exports.prototype['ringOnMonitoredCall'] = undefined;

  /**
   * Telephony presence status
   * @member {module:model/PresenceInfo.TelephonyStatusEnum} telephonyStatus
   */
  exports.prototype['telephonyStatus'] = undefined;

  /**
   * User-defined presence status (as previously published by the user)
   * @member {module:model/PresenceInfo.UserStatusEnum} userStatus
   */
  exports.prototype['userStatus'] = undefined;


  /**
   * Allowed values for the <code>dndStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.DndStatusEnum = { 
    /**
     * value: TakeAllCalls
     * @const
     */
    TAKEALLCALLS: "TakeAllCalls",
    
    /**
     * value: DoNotAcceptAnyCalls
     * @const
     */
    DONOTACCEPTANYCALLS: "DoNotAcceptAnyCalls",
    
    /**
     * value: DoNotAcceptDepartmentCalls
     * @const
     */
    DONOTACCEPTDEPARTMENTCALLS: "DoNotAcceptDepartmentCalls",
    
    /**
     * value: TakeDepartmentCallsOnly
     * @const
     */
    TAKEDEPARTMENTCALLSONLY: "TakeDepartmentCallsOnly"
  };  /**
   * Allowed values for the <code>presenceStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.PresenceStatusEnum = { 
    /**
     * value: Offline
     * @const
     */
    OFFLINE: "Offline",
    
    /**
     * value: Busy
     * @const
     */
    BUSY: "Busy",
    
    /**
     * value: Available
     * @const
     */
    AVAILABLE: "Available"
  };  /**
   * Allowed values for the <code>telephonyStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TelephonyStatusEnum = { 
    /**
     * value: NoCall
     * @const
     */
    NOCALL: "NoCall",
    
    /**
     * value: CallConnected
     * @const
     */
    CALLCONNECTED: "CallConnected",
    
    /**
     * value: Ringing
     * @const
     */
    RINGING: "Ringing",
    
    /**
     * value: OnHold
     * @const
     */
    ONHOLD: "OnHold",
    
    /**
     * value: ParkedCall
     * @const
     */
    PARKEDCALL: "ParkedCall"
  };  /**
   * Allowed values for the <code>userStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.UserStatusEnum = { 
    /**
     * value: Offline
     * @const
     */
    OFFLINE: "Offline",
    
    /**
     * value: Busy
     * @const
     */
    BUSY: "Busy",
    
    /**
     * value: Available
     * @const
     */
    AVAILABLE: "Available"
  };

  return exports;
}));
