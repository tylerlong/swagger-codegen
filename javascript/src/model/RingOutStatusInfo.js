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
    root.RingCentralApi.RingOutStatusInfo = factory(root.RingCentralApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The RingOutStatusInfo model module.
   * @module model/RingOutStatusInfo
   * @version v1.0
   */

  /**
   * Constructs a new <code>RingOutStatusInfo</code>.
   * @alias module:model/RingOutStatusInfo
   * @class
   */
  var exports = function() {




  };

  /**
   * Constructs a <code>RingOutStatusInfo</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/RingOutStatusInfo} obj Optional instance to populate.
   * @return {module:model/RingOutStatusInfo} The populated <code>RingOutStatusInfo</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) { 
      obj = obj || new exports();

      if (data.hasOwnProperty('callStatus')) {
        obj['callStatus'] = ApiClient.convertToType(data['callStatus'], 'String');
      }
      if (data.hasOwnProperty('callerStatus')) {
        obj['callerStatus'] = ApiClient.convertToType(data['callerStatus'], 'String');
      }
      if (data.hasOwnProperty('calleeStatus')) {
        obj['calleeStatus'] = ApiClient.convertToType(data['calleeStatus'], 'String');
      }
    }
    return obj;
  }


  /**
   * Status of a call
   * @member {module:model/RingOutStatusInfo.CallStatusEnum} callStatus
   */
  exports.prototype['callStatus'] = undefined;

  /**
   * Status of a calling party
   * @member {module:model/RingOutStatusInfo.CallerStatusEnum} callerStatus
   */
  exports.prototype['callerStatus'] = undefined;

  /**
   * Status of a called party
   * @member {module:model/RingOutStatusInfo.CalleeStatusEnum} calleeStatus
   */
  exports.prototype['calleeStatus'] = undefined;


  /**
   * Allowed values for the <code>callStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.CallStatusEnum = { 
    /**
     * value: Invalid
     * @const
     */
    INVALID: "Invalid",
    
    /**
     * value: Success
     * @const
     */
    SUCCESS: "Success",
    
    /**
     * value: InProgress
     * @const
     */
    INPROGRESS: "InProgress",
    
    /**
     * value: Busy
     * @const
     */
    BUSY: "Busy",
    
    /**
     * value: NoAnswer
     * @const
     */
    NOANSWER: "NoAnswer",
    
    /**
     * value: Rejected
     * @const
     */
    REJECTED: "Rejected",
    
    /**
     * value: GenericError
     * @const
     */
    GENERICERROR: "GenericError",
    
    /**
     * value: Finished
     * @const
     */
    FINISHED: "Finished",
    
    /**
     * value: InternationalDisabled
     * @const
     */
    INTERNATIONALDISABLED: "InternationalDisabled",
    
    /**
     * value: DestinationBlocked
     * @const
     */
    DESTINATIONBLOCKED: "DestinationBlocked",
    
    /**
     * value: NotEnoughFunds
     * @const
     */
    NOTENOUGHFUNDS: "NotEnoughFunds",
    
    /**
     * value: NoSuchUser
     * @const
     */
    NOSUCHUSER: "NoSuchUser"
  };  /**
   * Allowed values for the <code>callerStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.CallerStatusEnum = { 
    /**
     * value: Invalid
     * @const
     */
    INVALID: "Invalid",
    
    /**
     * value: Success
     * @const
     */
    SUCCESS: "Success",
    
    /**
     * value: InProgress
     * @const
     */
    INPROGRESS: "InProgress",
    
    /**
     * value: Busy
     * @const
     */
    BUSY: "Busy",
    
    /**
     * value: NoAnswer
     * @const
     */
    NOANSWER: "NoAnswer",
    
    /**
     * value: Rejected
     * @const
     */
    REJECTED: "Rejected",
    
    /**
     * value: GenericError
     * @const
     */
    GENERICERROR: "GenericError",
    
    /**
     * value: Finished
     * @const
     */
    FINISHED: "Finished",
    
    /**
     * value: InternationalDisabled
     * @const
     */
    INTERNATIONALDISABLED: "InternationalDisabled",
    
    /**
     * value: DestinationBlocked
     * @const
     */
    DESTINATIONBLOCKED: "DestinationBlocked",
    
    /**
     * value: NotEnoughFunds
     * @const
     */
    NOTENOUGHFUNDS: "NotEnoughFunds",
    
    /**
     * value: NoSuchUser
     * @const
     */
    NOSUCHUSER: "NoSuchUser"
  };  /**
   * Allowed values for the <code>calleeStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.CalleeStatusEnum = { 
    /**
     * value: Invalid
     * @const
     */
    INVALID: "Invalid",
    
    /**
     * value: Success
     * @const
     */
    SUCCESS: "Success",
    
    /**
     * value: InProgress
     * @const
     */
    INPROGRESS: "InProgress",
    
    /**
     * value: Busy
     * @const
     */
    BUSY: "Busy",
    
    /**
     * value: NoAnswer
     * @const
     */
    NOANSWER: "NoAnswer",
    
    /**
     * value: Rejected
     * @const
     */
    REJECTED: "Rejected",
    
    /**
     * value: GenericError
     * @const
     */
    GENERICERROR: "GenericError",
    
    /**
     * value: Finished
     * @const
     */
    FINISHED: "Finished",
    
    /**
     * value: InternationalDisabled
     * @const
     */
    INTERNATIONALDISABLED: "InternationalDisabled",
    
    /**
     * value: DestinationBlocked
     * @const
     */
    DESTINATIONBLOCKED: "DestinationBlocked",
    
    /**
     * value: NotEnoughFunds
     * @const
     */
    NOTENOUGHFUNDS: "NotEnoughFunds",
    
    /**
     * value: NoSuchUser
     * @const
     */
    NOSUCHUSER: "NoSuchUser"
  };

  return exports;
}));
