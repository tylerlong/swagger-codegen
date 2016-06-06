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
    root.RingCentralApi.GrantInfoExtensionInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The GrantInfoExtensionInfo model module.
   * @module model/GrantInfoExtensionInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>GrantInfoExtensionInfo</code>.
   * @alias module:model/GrantInfoExtensionInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>GrantInfoExtensionInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/GrantInfoExtensionInfo} obj Optional instance to populate.
   * @return {module:model/GrantInfoExtensionInfo} The populated <code>GrantInfoExtensionInfo</code> instance.
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
      if (data.hasOwnProperty('extensionNumber')) {
        obj['extensionNumber'] = ApiClient.convertToType(data['extensionNumber'], 'String');
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
   * Extension short number (usually 3 or 4 digits)
   * @member {String} extensionNumber
   */
  exports.prototype['extensionNumber'] = undefined;

  /**
   * Extension type
   * @member {module:model/GrantInfoExtensionInfo.TypeEnum} type
   */
  exports.prototype['type'] = undefined;


  /**
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
     * value: Fax User
     * @const
     */
    FAX_USER: "Fax User",
    
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
     * value: PagingOnly
     * @const
     */
    PAGINGONLY: "PagingOnly",
    
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
     * value: Park Location
     * @const
     */
    PARK_LOCATION: "Park Location"
  };

  return exports;
}));
