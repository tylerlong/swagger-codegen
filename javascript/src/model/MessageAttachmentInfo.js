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
    root.RingCentralApi.MessageAttachmentInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The MessageAttachmentInfo model module.
   * @module model/MessageAttachmentInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>MessageAttachmentInfo</code>.
   * @alias module:model/MessageAttachmentInfo
   * @class
   */
  var exports = function() {






  };

  /**
   * Constructs a <code>MessageAttachmentInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/MessageAttachmentInfo} obj Optional instance to populate.
   * @return {module:model/MessageAttachmentInfo} The populated <code>MessageAttachmentInfo</code> instance.
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
      if (data.hasOwnProperty('type')) {
        obj['type'] = ApiClient.convertToType(data['type'], 'String');
      }
      if (data.hasOwnProperty('contentType')) {
        obj['contentType'] = ApiClient.convertToType(data['contentType'], 'String');
      }
      if (data.hasOwnProperty('vmDuration')) {
        obj['vmDuration'] = ApiClient.convertToType(data['vmDuration'], 'Integer');
      }
    }
    return obj;
  }


  /**
   * Internal identifier of a message attachment
   * @member {String} id
   */
  exports.prototype['id'] = undefined;

  /**
   * Canonical URI of a message attachment
   * @member {String} uri
   */
  exports.prototype['uri'] = undefined;

  /**
   * Type of message attachment
   * @member {module:model/MessageAttachmentInfo.TypeEnum} type
   */
  exports.prototype['type'] = undefined;

  /**
   * MIME type for a given attachment, for instance 'audio/wav'
   * @member {String} contentType
   */
  exports.prototype['contentType'] = undefined;

  /**
   * Voicemail only Duration of the voicemail in seconds
   * @member {Integer} vmDuration
   */
  exports.prototype['vmDuration'] = undefined;


  /**
   * Allowed values for the <code>type</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TypeEnum = { 
    /**
     * value: AudioRecording
     * @const
     */
    AUDIORECORDING: "AudioRecording",
    
    /**
     * value: AudioTranscription
     * @const
     */
    AUDIOTRANSCRIPTION: "AudioTranscription",
    
    /**
     * value: Text
     * @const
     */
    TEXT: "Text",
    
    /**
     * value: SourceDocument
     * @const
     */
    SOURCEDOCUMENT: "SourceDocument",
    
    /**
     * value: RenderedDocument
     * @const
     */
    RENDEREDDOCUMENT: "RenderedDocument"
  };

  return exports;
}));
