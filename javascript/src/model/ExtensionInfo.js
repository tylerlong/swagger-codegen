(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './ContactInfo', './DepartmentInfo', './ExtensionPermissions', './ExtensionServiceFeatureInfo', './ProfileImageInfo', './ReferenceInfo', './RegionalSettings', './StatusInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ContactInfo'), require('./DepartmentInfo'), require('./ExtensionPermissions'), require('./ExtensionServiceFeatureInfo'), require('./ProfileImageInfo'), require('./ReferenceInfo'), require('./RegionalSettings'), require('./StatusInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ExtensionInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.ContactInfo, root.RingCentralApi.DepartmentInfo, root.RingCentralApi.ExtensionPermissions, root.RingCentralApi.ExtensionServiceFeatureInfo, root.RingCentralApi.ProfileImageInfo, root.RingCentralApi.ReferenceInfo, root.RingCentralApi.RegionalSettings, root.RingCentralApi.StatusInfo);
  }
}(this, function(ApiClient, ContactInfo, DepartmentInfo, ExtensionPermissions, ExtensionServiceFeatureInfo, ProfileImageInfo, ReferenceInfo, RegionalSettings, StatusInfo) {
  'use strict';

  /**
   * The ExtensionInfo model module.
   * @module model/ExtensionInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionInfo</code>.
   * @alias module:model/ExtensionInfo
   * @class
   */
  var exports = function() {

















  };

  /**
   * Constructs a <code>ExtensionInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionInfo} obj Optional instance to populate.
   * @return {module:model/ExtensionInfo} The populated <code>ExtensionInfo</code> instance.
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
      if (data.hasOwnProperty('contact')) {
        obj['contact'] = ContactInfo.constructFromObject(data['contact']);
      }
      if (data.hasOwnProperty('departments')) {
        obj['departments'] = DepartmentInfo.constructFromObject(data['departments']);
      }
      if (data.hasOwnProperty('extensionNumber')) {
        obj['extensionNumber'] = ApiClient.convertToType(data['extensionNumber'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('partnerId')) {
        obj['partnerId'] = ApiClient.convertToType(data['partnerId'], 'String');
      }
      if (data.hasOwnProperty('permissions')) {
        obj['permissions'] = ExtensionPermissions.constructFromObject(data['permissions']);
      }
      if (data.hasOwnProperty('profileImage')) {
        obj['profileImage'] = ProfileImageInfo.constructFromObject(data['profileImage']);
      }
      if (data.hasOwnProperty('references')) {
        obj['references'] = ApiClient.convertToType(data['references'], [ReferenceInfo]);
      }
      if (data.hasOwnProperty('regionalSettings')) {
        obj['regionalSettings'] = RegionalSettings.constructFromObject(data['regionalSettings']);
      }
      if (data.hasOwnProperty('serviceFeatures')) {
        obj['serviceFeatures'] = ApiClient.convertToType(data['serviceFeatures'], [ExtensionServiceFeatureInfo]);
      }
      if (data.hasOwnProperty('setupWizardState')) {
        obj['setupWizardState'] = ApiClient.convertToType(data['setupWizardState'], 'String');
      }
      if (data.hasOwnProperty('status')) {
        obj['status'] = ApiClient.convertToType(data['status'], 'String');
      }
      if (data.hasOwnProperty('statusInfo')) {
        obj['statusInfo'] = StatusInfo.constructFromObject(data['statusInfo']);
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of an extension
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of an extension
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * @member {module:model/ContactInfo} contact
   */
  exports.prototype['contact'] = undefined;

  /**
   * @member {module:model/DepartmentInfo} departments
   */
  exports.prototype['departments'] = undefined;

  /**
   * Number of department extension
   * @member {String} extensionNumber
   */
  exports.prototype['extensionNumber'] = undefined;

  /**
   * Extension user name
   * @member {String} name
   */
  exports.prototype['name'] = undefined;

  /**
   * For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension
   * @member {String} partnerId
   */
  exports.prototype['partnerId'] = undefined;

  /**
   * @member {module:model/ExtensionPermissions} permissions
   */
  exports.prototype['permissions'] = undefined;

  /**
   * @member {module:model/ProfileImageInfo} profileImage
   */
  exports.prototype['profileImage'] = undefined;

  /**
   * List of non-RC internal identifiers assigned to an extension
   * @member {Array.<module:model/ReferenceInfo>} references
   */
  exports.prototype['references'] = undefined;

  /**
   * @member {module:model/RegionalSettings} regionalSettings
   */
  exports.prototype['regionalSettings'] = undefined;

  /**
   * Extension service features returned in response only when the logged-in user requests his/her own extension info, see also Extension Service Features
   * @member {Array.<module:model/ExtensionServiceFeatureInfo>} serviceFeatures
   */
  exports.prototype['serviceFeatures'] = undefined;

  /**
   * Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'
   * @member {module:model/ExtensionInfo.SetupWizardStateEnum} setupWizardState
   */
  exports.prototype['setupWizardState'] = undefined;

  /**
   * Extension current state. If the status is 'Unassigned'. Returned for all extensions
   * @member {module:model/ExtensionInfo.StatusEnum} status
   */
  exports.prototype['status'] = undefined;

  /**
   * @member {module:model/StatusInfo} statusInfo
   */
  exports.prototype['statusInfo'] = undefined;

  /**
   * Extension type
   * @member {module:model/ExtensionInfo.TypeEnum} type
   */
  exports.prototype['type'] = undefined;


  /**
   * Allowed values for the <code>setupWizardState</code> property.
   * @enum {String}
   * @readonly
   */
  exports.SetupWizardStateEnum = { 
    /**
     * value: NotStarted
     * @const
     */
    NOTSTARTED: "NotStarted",
    
    /**
     * value: Incomplete
     * @const
     */
    INCOMPLETE: "Incomplete",
    
    /**
     * value: Completed
     * @const
     */
    COMPLETED: "Completed"
  };  /**
   * Allowed values for the <code>status</code> property.
   * @enum {String}
   * @readonly
   */
  exports.StatusEnum = { 
    /**
     * value: Enabled
     * @const
     */
    ENABLED: "Enabled",
    
    /**
     * value: Disabled
     * @const
     */
    DISABLED: "Disabled",
    
    /**
     * value: NotActivated
     * @const
     */
    NOTACTIVATED: "NotActivated",
    
    /**
     * value: Unassigned
     * @const
     */
    UNASSIGNED: "Unassigned"
  };  /**
   * Allowed values for the <code>type</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TypeEnum = { 
    /**
     * value: User
     * @const
     */
    USER: "User",
    
    /**
     * value: FaxUser
     * @const
     */
    FAXUSER: "FaxUser",
    
    /**
     * value: VirtualUser
     * @const
     */
    VIRTUALUSER: "VirtualUser",
    
    /**
     * value: DigitalUser
     * @const
     */
    DIGITALUSER: "DigitalUser",
    
    /**
     * value: Department
     * @const
     */
    DEPARTMENT: "Department",
    
    /**
     * value: Announcement
     * @const
     */
    ANNOUNCEMENT: "Announcement",
    
    /**
     * value: Voicemail
     * @const
     */
    VOICEMAIL: "Voicemail",
    
    /**
     * value: SharedLinesGroup
     * @const
     */
    SHAREDLINESGROUP: "SharedLinesGroup",
    
    /**
     * value: PagingOnlyGroup
     * @const
     */
    PAGINGONLYGROUP: "PagingOnlyGroup",
    
    /**
     * value: IvrMenu
     * @const
     */
    IVRMENU: "IvrMenu",
    
    /**
     * value: ApplicationExtension
     * @const
     */
    APPLICATIONEXTENSION: "ApplicationExtension",
    
    /**
     * value: ParkLocation
     * @const
     */
    PARKLOCATION: "ParkLocation"
  };

  return exports;
}));
