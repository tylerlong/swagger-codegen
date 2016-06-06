(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './ContactInfo', './ExtensionInfoRequestContactInfoRegionalSettings'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ContactInfo'), require('./ExtensionInfoRequestContactInfoRegionalSettings'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.ExtensionInfoRequestContactInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.ContactInfo, root.RingCentralApi.ExtensionInfoRequestContactInfoRegionalSettings);
  }
}(this, function(ApiClient, ContactInfo, ExtensionInfoRequestContactInfoRegionalSettings) {
  'use strict';

  /**
   * The ExtensionInfoRequestContactInfo model module.
   * @module model/ExtensionInfoRequestContactInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>ExtensionInfoRequestContactInfo</code>.
   * @alias module:model/ExtensionInfoRequestContactInfo
   * @class
   */
  var exports = function() {





  };

  /**
   * Constructs a <code>ExtensionInfoRequestContactInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ExtensionInfoRequestContactInfo} obj Optional instance to populate.
   * @return {module:model/ExtensionInfoRequestContactInfo} The populated <code>ExtensionInfoRequestContactInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('contact')) {
        obj['contact'] = ContactInfo.constructFromObject(data['contact']);
      }
      if (data.hasOwnProperty('regionalSettings')) {
        obj['regionalSettings'] = ExtensionInfoRequestContactInfoRegionalSettings.constructFromObject(data['regionalSettings']);
      }
      if (data.hasOwnProperty('setupWizardState')) {
        obj['setupWizardState'] = ApiClient.convertToType(data['setupWizardState'], 'String');
      }
      if (data.hasOwnProperty('department')) {
        obj['department'] = ApiClient.convertToType(data['department'], 'String');
      }
    }
    return obj;
  }


  /**
   * @member {module:model/ContactInfo} contact
   */
  exports.prototype['contact'] = undefined;

  /**
   * @member {module:model/ExtensionInfoRequestContactInfoRegionalSettings} regionalSettings
   */
  exports.prototype['regionalSettings'] = undefined;

  /**
   * Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'
   * @member {module:model/ExtensionInfoRequestContactInfo.SetupWizardStateEnum} setupWizardState
   */
  exports.prototype['setupWizardState'] = undefined;

  /**
   * Extension user department
   * @member {String} department
   */
  exports.prototype['department'] = undefined;


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
  };

  return exports;
}));
