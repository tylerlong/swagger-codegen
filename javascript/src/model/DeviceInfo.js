(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './DeviceInfoExtensionInfo', './EmergencyAddressInfo', './ModelInfo', './PhoneLinesInfo', './ShippingInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./DeviceInfoExtensionInfo'), require('./EmergencyAddressInfo'), require('./ModelInfo'), require('./PhoneLinesInfo'), require('./ShippingInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.DeviceInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.DeviceInfoExtensionInfo, root.RingCentralApi.EmergencyAddressInfo, root.RingCentralApi.ModelInfo, root.RingCentralApi.PhoneLinesInfo, root.RingCentralApi.ShippingInfo);
  }
}(this, function(ApiClient, DeviceInfoExtensionInfo, EmergencyAddressInfo, ModelInfo, PhoneLinesInfo, ShippingInfo) {
  'use strict';

  /**
   * The DeviceInfo model module.
   * @module model/DeviceInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>DeviceInfo</code>.
   * @alias module:model/DeviceInfo
   * @class
   */
  var exports = function() {














  };

  /**
   * Constructs a <code>DeviceInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/DeviceInfo} obj Optional instance to populate.
   * @return {module:model/DeviceInfo} The populated <code>DeviceInfo</code> instance.
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
      if (data.hasOwnProperty('sku')) {
        obj['sku'] = ApiClient.convertToType(data['sku'], 'String');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('serial')) {
        obj['serial'] = ApiClient.convertToType(data['serial'], 'String');
      }
      if (data.hasOwnProperty('computerName')) {
        obj['computerName'] = ApiClient.convertToType(data['computerName'], 'String');
      }
      if (data.hasOwnProperty('model')) {
        obj['model'] = ModelInfo.constructFromObject(data['model']);
      }
      if (data.hasOwnProperty('extension')) {
        obj['extension'] = DeviceInfoExtensionInfo.constructFromObject(data['extension']);
      }
      if (data.hasOwnProperty('emergencyServiceAddress')) {
        obj['emergencyServiceAddress'] = EmergencyAddressInfo.constructFromObject(data['emergencyServiceAddress']);
      }
      if (data.hasOwnProperty('phoneLines')) {
        obj['phoneLines'] = PhoneLinesInfo.constructFromObject(data['phoneLines']);
      }
      if (data.hasOwnProperty('shipping')) {
        obj['shipping'] = ShippingInfo.constructFromObject(data['shipping']);
      }
      if (data.hasOwnProperty('boxBillingId')) {
        obj['boxBillingId'] = ApiClient.convertToType(data['boxBillingId'], 'Integer');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a device
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a device
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example 'HP-56-2-2'
   * @member {String} sku
   */
  exports.prototype['sku'] = undefined;

  /**
   * Device type. The default value is 'HardPhone'
   * @member {module:model/DeviceInfo.TypeEnum} type
   */
  exports.prototype['type'] = undefined;

  /**
   * Device name. Mandatory if ordering \"SoftPhone\" or \"OtherPhone\". Optional for \"HardPhone\". If not specified for HardPhone, then device \"model\" name is used as device \"name\"
   * @member {String} name
   */
  exports.prototype['name'] = undefined;

  /**
   * Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications
   * @member {String} serial
   */
  exports.prototype['serial'] = undefined;

  /**
   * PC name for softphone
   * @member {String} computerName
   */
  exports.prototype['computerName'] = undefined;

  /**
   * @member {module:model/ModelInfo} model
   */
  exports.prototype['model'] = undefined;

  /**
   * @member {module:model/DeviceInfoExtensionInfo} extension
   */
  exports.prototype['extension'] = undefined;

  /**
   * @member {module:model/EmergencyAddressInfo} emergencyServiceAddress
   */
  exports.prototype['emergencyServiceAddress'] = undefined;

  /**
   * @member {module:model/PhoneLinesInfo} phoneLines
   */
  exports.prototype['phoneLines'] = undefined;

  /**
   * @member {module:model/ShippingInfo} shipping
   */
  exports.prototype['shipping'] = undefined;

  /**
   * Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. Either \"model\" structure, or \"boxBillingId\" must be specified for HardPhone
   * @member {Integer} boxBillingId
   */
  exports.prototype['boxBillingId'] = undefined;


  /**
   * Allowed values for the <code>type</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TypeEnum = { 
    /**
     * value: SoftPhone
     * @const
     */
    SOFTPHONE: "SoftPhone",
    
    /**
     * value: OtherPhone
     * @const
     */
    OTHERPHONE: "OtherPhone",
    
    /**
     * value: HardPhone
     * @const
     */
    HARDPHONE: "HardPhone"
  };

  return exports;
}));
