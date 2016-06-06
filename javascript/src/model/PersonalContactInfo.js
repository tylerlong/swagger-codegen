(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', './ContactAddressInfo'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ContactAddressInfo'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.PersonalContactInfo = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.ContactAddressInfo);
  }
}(this, function(ApiClient, ContactAddressInfo) {
  'use strict';

  /**
   * The PersonalContactInfo model module.
   * @module model/PersonalContactInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>PersonalContactInfo</code>.
   * @alias module:model/PersonalContactInfo
   * @class
   */
  var exports = function() {































  };

  /**
   * Constructs a <code>PersonalContactInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/PersonalContactInfo} obj Optional instance to populate.
   * @return {module:model/PersonalContactInfo} The populated <code>PersonalContactInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'Integer');
      }
      if (data.hasOwnProperty('url')) {
        obj['url'] = ApiClient.convertToType(data['url'], 'String');
      }
      if (data.hasOwnProperty('availability')) {
        obj['availability'] = ApiClient.convertToType(data['availability'], 'String');
      }
      if (data.hasOwnProperty('firstName')) {
        obj['firstName'] = ApiClient.convertToType(data['firstName'], 'String');
      }
      if (data.hasOwnProperty('lastName')) {
        obj['lastName'] = ApiClient.convertToType(data['lastName'], 'String');
      }
      if (data.hasOwnProperty('middleName')) {
        obj['middleName'] = ApiClient.convertToType(data['middleName'], 'String');
      }
      if (data.hasOwnProperty('nickName')) {
        obj['nickName'] = ApiClient.convertToType(data['nickName'], 'String');
      }
      if (data.hasOwnProperty('company')) {
        obj['company'] = ApiClient.convertToType(data['company'], 'String');
      }
      if (data.hasOwnProperty('jobTitle')) {
        obj['jobTitle'] = ApiClient.convertToType(data['jobTitle'], 'String');
      }
      if (data.hasOwnProperty('homePhone')) {
        obj['homePhone'] = ApiClient.convertToType(data['homePhone'], 'String');
      }
      if (data.hasOwnProperty('homePhone2')) {
        obj['homePhone2'] = ApiClient.convertToType(data['homePhone2'], 'String');
      }
      if (data.hasOwnProperty('businessPhone')) {
        obj['businessPhone'] = ApiClient.convertToType(data['businessPhone'], 'String');
      }
      if (data.hasOwnProperty('businessPhone2')) {
        obj['businessPhone2'] = ApiClient.convertToType(data['businessPhone2'], 'String');
      }
      if (data.hasOwnProperty('mobilePhone')) {
        obj['mobilePhone'] = ApiClient.convertToType(data['mobilePhone'], 'String');
      }
      if (data.hasOwnProperty('businessFax')) {
        obj['businessFax'] = ApiClient.convertToType(data['businessFax'], 'String');
      }
      if (data.hasOwnProperty('companyPhone')) {
        obj['companyPhone'] = ApiClient.convertToType(data['companyPhone'], 'String');
      }
      if (data.hasOwnProperty('assistantPhone')) {
        obj['assistantPhone'] = ApiClient.convertToType(data['assistantPhone'], 'String');
      }
      if (data.hasOwnProperty('carPhone')) {
        obj['carPhone'] = ApiClient.convertToType(data['carPhone'], 'String');
      }
      if (data.hasOwnProperty('otherPhone')) {
        obj['otherPhone'] = ApiClient.convertToType(data['otherPhone'], 'String');
      }
      if (data.hasOwnProperty('otherFax')) {
        obj['otherFax'] = ApiClient.convertToType(data['otherFax'], 'String');
      }
      if (data.hasOwnProperty('callbackPhone')) {
        obj['callbackPhone'] = ApiClient.convertToType(data['callbackPhone'], 'String');
      }
      if (data.hasOwnProperty('email')) {
        obj['email'] = ApiClient.convertToType(data['email'], 'String');
      }
      if (data.hasOwnProperty('email2')) {
        obj['email2'] = ApiClient.convertToType(data['email2'], 'String');
      }
      if (data.hasOwnProperty('email3')) {
        obj['email3'] = ApiClient.convertToType(data['email3'], 'String');
      }
      if (data.hasOwnProperty('homeAddress')) {
        obj['homeAddress'] = ContactAddressInfo.constructFromObject(data['homeAddress']);
      }
      if (data.hasOwnProperty('businessAddress')) {
        obj['businessAddress'] = ContactAddressInfo.constructFromObject(data['businessAddress']);
      }
      if (data.hasOwnProperty('otherAddress')) {
        obj['otherAddress'] = ContactAddressInfo.constructFromObject(data['otherAddress']);
      }
      if (data.hasOwnProperty('birthday')) {
        obj['birthday'] = ApiClient.convertToType(data['birthday'], 'Date');
      }
      if (data.hasOwnProperty('webPage')) {
        obj['webPage'] = ApiClient.convertToType(data['webPage'], 'String');
      }
      if (data.hasOwnProperty('notes')) {
        obj['notes'] = ApiClient.convertToType(data['notes'], 'String');
      }
    }
    return obj;
  }


  /**
   * Standard resource properties ID
   * @member {Integer} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI
   * @member {String} url
   */
  exports.prototype['url'] = undefined;

  /**
   * This property has a special meaning only on Address Book Sync (e.g. a contact can be 'Deleted'). For simple contact list reading it has always the default value - 'Alive'
   * @member {module:model/PersonalContactInfo.AvailabilityEnum} availability
   */
  exports.prototype['availability'] = undefined;

  /**
   * First name of a personal contact
   * @member {String} firstName
   */
  exports.prototype['firstName'] = undefined;

  /**
   * Last name of a personal contact
   * @member {String} lastName
   */
  exports.prototype['lastName'] = undefined;

  /**
   * Middle name of a personal contact
   * @member {String} middleName
   */
  exports.prototype['middleName'] = undefined;

  /**
   * Nick name of a personal contact
   * @member {String} nickName
   */
  exports.prototype['nickName'] = undefined;

  /**
   * Company name of a personal contact
   * @member {String} company
   */
  exports.prototype['company'] = undefined;

  /**
   * Job title of a personal contact
   * @member {String} jobTitle
   */
  exports.prototype['jobTitle'] = undefined;

  /**
   * Home phone of a personal contact
   * @member {String} homePhone
   */
  exports.prototype['homePhone'] = undefined;

  /**
   * The 2-d home phone of a personal contact
   * @member {String} homePhone2
   */
  exports.prototype['homePhone2'] = undefined;

  /**
   * Business phone of a personal contact
   * @member {String} businessPhone
   */
  exports.prototype['businessPhone'] = undefined;

  /**
   * The 2-d business phone of a personal contact
   * @member {String} businessPhone2
   */
  exports.prototype['businessPhone2'] = undefined;

  /**
   * Mobile phone of a personal contact
   * @member {String} mobilePhone
   */
  exports.prototype['mobilePhone'] = undefined;

  /**
   * Business fax of a personal contact
   * @member {String} businessFax
   */
  exports.prototype['businessFax'] = undefined;

  /**
   * Company phone of a personal contact
   * @member {String} companyPhone
   */
  exports.prototype['companyPhone'] = undefined;

  /**
   * Assistant phone of a personal contact
   * @member {String} assistantPhone
   */
  exports.prototype['assistantPhone'] = undefined;

  /**
   * Car phone of a personal contact
   * @member {String} carPhone
   */
  exports.prototype['carPhone'] = undefined;

  /**
   * Other phone of a personal contact
   * @member {String} otherPhone
   */
  exports.prototype['otherPhone'] = undefined;

  /**
   * Other fax of a personal contact
   * @member {String} otherFax
   */
  exports.prototype['otherFax'] = undefined;

  /**
   * Callback phone of a personal contact
   * @member {String} callbackPhone
   */
  exports.prototype['callbackPhone'] = undefined;

  /**
   * Email of a personal contact
   * @member {String} email
   */
  exports.prototype['email'] = undefined;

  /**
   * The 2-d email of a personal contact
   * @member {String} email2
   */
  exports.prototype['email2'] = undefined;

  /**
   * The 3-d email of a personal contact
   * @member {String} email3
   */
  exports.prototype['email3'] = undefined;

  /**
   * @member {module:model/ContactAddressInfo} homeAddress
   */
  exports.prototype['homeAddress'] = undefined;

  /**
   * @member {module:model/ContactAddressInfo} businessAddress
   */
  exports.prototype['businessAddress'] = undefined;

  /**
   * @member {module:model/ContactAddressInfo} otherAddress
   */
  exports.prototype['otherAddress'] = undefined;

  /**
   * Date of birth of a personal contact in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
   * @member {Date} birthday
   */
  exports.prototype['birthday'] = undefined;

  /**
   * Web page of a personal contact
   * @member {String} webPage
   */
  exports.prototype['webPage'] = undefined;

  /**
   * Notes of a personal contact
   * @member {String} notes
   */
  exports.prototype['notes'] = undefined;


  /**
   * Allowed values for the <code>availability</code> property.
   * @enum {String}
   * @readonly
   */
  exports.AvailabilityEnum = { 
    /**
     * value: Alive
     * @const
     */
    ALIVE: "Alive",
    
    /**
     * value: Deleted
     * @const
     */
    DELETED: "Deleted",
    
    /**
     * value: Purged
     * @const
     */
    PURGED: "Purged"
  };

  return exports;
}));
