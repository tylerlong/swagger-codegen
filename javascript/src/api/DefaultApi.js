(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['../ApiClient', '../model/ServerInfo', '../model/Body', '../model/InlineResponseDefault', '../model/Body1', '../model/InlineResponseDefault1', '../model/Body2', '../model/InlineResponseDefault2', '../model/InlineResponseDefault3', '../model/CallLogInfo', '../model/MessageInfo', '../model/Body3', '../model/Body4', '../model/InlineResponseDefault5', '../model/ExtensionInfo', '../model/InlineResponseDefault6', '../model/Body5', '../model/InlineResponseDefault7', '../model/PresenceInfo', '../model/RingOutInfo', '../model/Body6', '../model/Body7', '../model/InlineResponseDefault4', '../model/AccountInfo', '../model/InlineResponseDefault8', '../model/PhoneNumberInfo', '../model/InlineResponseDefault9', '../model/FullCountryInfo', '../model/InlineResponseDefault10', '../model/InlineResponseDefault11', '../model/LanguageInfo', '../model/InlineResponseDefault12', '../model/InlineResponseDefault13', '../model/StateInfo', '../model/InlineResponseDefault14', '../model/TimezoneInfo', '../model/VersionInfo', '../model/Body8', '../model/SubscriptionInfo', '../model/Body9'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/ServerInfo'), require('../model/Body'), require('../model/InlineResponseDefault'), require('../model/Body1'), require('../model/InlineResponseDefault1'), require('../model/Body2'), require('../model/InlineResponseDefault2'), require('../model/InlineResponseDefault3'), require('../model/CallLogInfo'), require('../model/MessageInfo'), require('../model/Body3'), require('../model/Body4'), require('../model/InlineResponseDefault5'), require('../model/ExtensionInfo'), require('../model/InlineResponseDefault6'), require('../model/Body5'), require('../model/InlineResponseDefault7'), require('../model/PresenceInfo'), require('../model/RingOutInfo'), require('../model/Body6'), require('../model/Body7'), require('../model/InlineResponseDefault4'), require('../model/AccountInfo'), require('../model/InlineResponseDefault8'), require('../model/PhoneNumberInfo'), require('../model/InlineResponseDefault9'), require('../model/FullCountryInfo'), require('../model/InlineResponseDefault10'), require('../model/InlineResponseDefault11'), require('../model/LanguageInfo'), require('../model/InlineResponseDefault12'), require('../model/InlineResponseDefault13'), require('../model/StateInfo'), require('../model/InlineResponseDefault14'), require('../model/TimezoneInfo'), require('../model/VersionInfo'), require('../model/Body8'), require('../model/SubscriptionInfo'), require('../model/Body9'));
  } else {
    // Browser globals (root is window)
    if (!root.RingCentralApi) {
      root.RingCentralApi = {};
    }
    root.RingCentralApi.DefaultApi = factory(root.RingCentralApi.ApiClient, root.RingCentralApi.ServerInfo, root.RingCentralApi.Body, root.RingCentralApi.InlineResponseDefault, root.RingCentralApi.Body1, root.RingCentralApi.InlineResponseDefault1, root.RingCentralApi.Body2, root.RingCentralApi.InlineResponseDefault2, root.RingCentralApi.InlineResponseDefault3, root.RingCentralApi.CallLogInfo, root.RingCentralApi.MessageInfo, root.RingCentralApi.Body3, root.RingCentralApi.Body4, root.RingCentralApi.InlineResponseDefault5, root.RingCentralApi.ExtensionInfo, root.RingCentralApi.InlineResponseDefault6, root.RingCentralApi.Body5, root.RingCentralApi.InlineResponseDefault7, root.RingCentralApi.PresenceInfo, root.RingCentralApi.RingOutInfo, root.RingCentralApi.Body6, root.RingCentralApi.Body7, root.RingCentralApi.InlineResponseDefault4, root.RingCentralApi.AccountInfo, root.RingCentralApi.InlineResponseDefault8, root.RingCentralApi.PhoneNumberInfo, root.RingCentralApi.InlineResponseDefault9, root.RingCentralApi.FullCountryInfo, root.RingCentralApi.InlineResponseDefault10, root.RingCentralApi.InlineResponseDefault11, root.RingCentralApi.LanguageInfo, root.RingCentralApi.InlineResponseDefault12, root.RingCentralApi.InlineResponseDefault13, root.RingCentralApi.StateInfo, root.RingCentralApi.InlineResponseDefault14, root.RingCentralApi.TimezoneInfo, root.RingCentralApi.VersionInfo, root.RingCentralApi.Body8, root.RingCentralApi.SubscriptionInfo, root.RingCentralApi.Body9);
  }
}(this, function(ApiClient, ServerInfo, Body, InlineResponseDefault, Body1, InlineResponseDefault1, Body2, InlineResponseDefault2, InlineResponseDefault3, CallLogInfo, MessageInfo, Body3, Body4, InlineResponseDefault5, ExtensionInfo, InlineResponseDefault6, Body5, InlineResponseDefault7, PresenceInfo, RingOutInfo, Body6, Body7, InlineResponseDefault4, AccountInfo, InlineResponseDefault8, PhoneNumberInfo, InlineResponseDefault9, FullCountryInfo, InlineResponseDefault10, InlineResponseDefault11, LanguageInfo, InlineResponseDefault12, InlineResponseDefault13, StateInfo, InlineResponseDefault14, TimezoneInfo, VersionInfo, Body8, SubscriptionInfo, Body9) {
  'use strict';

  /**
   * Default service.
   * @module api/DefaultApi
   * @version v1.0
   */

  /**
   * Constructs a new DefaultApi. 
   * @alias module:api/DefaultApi
   * @class
   * @param {module:ApiClient} apiClient Optional API client implementation to use, default to {@link module:ApiClient#instance}
   * if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the restapiGet operation.
     * @callback module:api/DefaultApi~restapiGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/ServerInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Server Info
     * @param {module:api/DefaultApi~restapiGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/ServerInfo}
     */
    this.restapiGet = function(callback) {
      var postBody = null;


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = ServerInfo;

      return this.apiClient.callApi(
        '/restapi', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiOauthAuthorizePost operation.
     * @callback module:api/DefaultApi~restapiOauthAuthorizePostCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * OAuth2 Authorize
     * @param {Object} opts Optional parameters
     * @param {module:model/Body} opts.body 
     * @param {module:api/DefaultApi~restapiOauthAuthorizePostCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault}
     */
    this.restapiOauthAuthorizePost = function(opts, callback) {
      opts = opts || {};
      var postBody = opts['body'];


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault;

      return this.apiClient.callApi(
        '/restapi/oauth/authorize', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiOauthRevokePost operation.
     * @callback module:api/DefaultApi~restapiOauthRevokePostCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * OAuth2 Revoke Token
     * @param {Object} opts Optional parameters
     * @param {module:model/Body1} opts.body 
     * @param {module:api/DefaultApi~restapiOauthRevokePostCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.restapiOauthRevokePost = function(opts, callback) {
      opts = opts || {};
      var postBody = opts['body'];


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = null;

      return this.apiClient.callApi(
        '/restapi/oauth/revoke', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiOauthTokenPost operation.
     * @callback module:api/DefaultApi~restapiOauthTokenPostCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault1} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * OAuth2 Get Token
     * @param {Object} opts Optional parameters
     * @param {module:model/Body2} opts.body 
     * @param {module:api/DefaultApi~restapiOauthTokenPostCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault1}
     */
    this.restapiOauthTokenPost = function(opts, callback) {
      opts = opts || {};
      var postBody = opts['body'];


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault1;

      return this.apiClient.callApi(
        '/restapi/oauth/token', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdActiveCallsGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdActiveCallsGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault2} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Account Active (Recent) Calls
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {module:model/String} opts.direction The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted
     * @param {module:model/String} opts.type Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted
     * @param {Integer} opts.page Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;.
     * @param {Integer} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default.
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdActiveCallsGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault2}
     */
    this.restapiV10AccountAccountIdActiveCallsGet = function(accountId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdActiveCallsGet";
      }


      var pathParams = {
        'accountId': accountId
      };
      var queryParams = {
        'direction': opts['direction'],
        'type': opts['type'],
        'page': opts['page'],
        'perPage': opts['perPage']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault2;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/active-calls', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdBusinessAddressGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdBusinessAddressGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault3} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Company Business Address
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdBusinessAddressGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault3}
     */
    this.restapiV10AccountAccountIdBusinessAddressGet = function(accountId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdBusinessAddressGet";
      }


      var pathParams = {
        'accountId': accountId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault3;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/business-address', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdCallLogCallLogIdGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdCallLogCallLogIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/CallLogInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Account Call Log Record by ID
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {Integer} callLogId Internal identifier of a call log record
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdCallLogCallLogIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/CallLogInfo}
     */
    this.restapiV10AccountAccountIdCallLogCallLogIdGet = function(accountId, callLogId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdCallLogCallLogIdGet";
      }

      // verify the required parameter 'callLogId' is set
      if (callLogId == undefined || callLogId == null) {
        throw "Missing the required parameter 'callLogId' when calling restapiV10AccountAccountIdCallLogCallLogIdGet";
      }


      var pathParams = {
        'accountId': accountId,
        'callLogId': callLogId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = CallLogInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/call-log/{callLogId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdCallLogGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdCallLogGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault2} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Account Call Log
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {String} opts.extensionNumber Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter
     * @param {String} opts.phoneNumber Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter
     * @param {module:model/String} opts.direction The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted
     * @param {module:model/String} opts.type Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted
     * @param {module:model/String} opts.view The default value is &#39;Simple&#39; for both account and extension call log
     * @param {Boolean} opts.withRecording &#39;True&#39; if only recorded calls have to be returned
     * @param {Date} opts.dateFrom The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
     * @param {Date} opts.dateTo The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
     * @param {Integer} opts.page Indicates the page number to retrieve. Only positive number values are allowed. The default value is &#39;1&#39;
     * @param {Integer} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default.
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdCallLogGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault2}
     */
    this.restapiV10AccountAccountIdCallLogGet = function(accountId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdCallLogGet";
      }


      var pathParams = {
        'accountId': accountId
      };
      var queryParams = {
        'extensionNumber': opts['extensionNumber'],
        'phoneNumber': opts['phoneNumber'],
        'direction': opts['direction'],
        'type': opts['type'],
        'view': opts['view'],
        'withRecording': opts['withRecording'],
        'dateFrom': opts['dateFrom'],
        'dateTo': opts['dateTo'],
        'page': opts['page'],
        'perPage': opts['perPage']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault2;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/call-log', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdActiveCallsGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault2} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Extension Active (Recent) Calls
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {module:model/String} opts.direction The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted
     * @param {module:model/String} opts.type Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted
     * @param {Integer} opts.page Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;
     * @param {Integer} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdActiveCallsGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault2}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet = function(accountId, extensionId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId
      };
      var queryParams = {
        'direction': opts['direction'],
        'type': opts['type'],
        'page': opts['page'],
        'perPage': opts['perPage']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault2;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/CallLogInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Extension Call Log Record by ID
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Integer} callLogId Internal identifier of a call log record
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/CallLogInfo}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet = function(accountId, extensionId, callLogId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet";
      }

      // verify the required parameter 'callLogId' is set
      if (callLogId == undefined || callLogId == null) {
        throw "Missing the required parameter 'callLogId' when calling restapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId,
        'callLogId': callLogId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = CallLogInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callLogId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdCallLogGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdCallLogGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault2} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Extension Call Log
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {String} opts.extensionNumber Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter
     * @param {String} opts.phoneNumber Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter
     * @param {module:model/String} opts.direction The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted
     * @param {module:model/String} opts.type Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted
     * @param {module:model/String} opts.view The default value is &#39;Simple&#39; for both account and extension call log
     * @param {Boolean} opts.withRecording &#39;True&#39; if only recorded calls have to be returned
     * @param {Date} opts.dateTo The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
     * @param {Date} opts.dateFrom The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
     * @param {Integer} opts.page Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;
     * @param {Integer} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdCallLogGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault2}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdCallLogGet = function(accountId, extensionId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdCallLogGet";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdCallLogGet";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId
      };
      var queryParams = {
        'extensionNumber': opts['extensionNumber'],
        'phoneNumber': opts['phoneNumber'],
        'direction': opts['direction'],
        'type': opts['type'],
        'view': opts['view'],
        'withRecording': opts['withRecording'],
        'dateTo': opts['dateTo'],
        'dateFrom': opts['dateFrom'],
        'page': opts['page'],
        'perPage': opts['perPage']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault2;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPostCallback
     * @param {String} error Error message, if any.
     * @param {module:model/MessageInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create and Send Pager Message
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {module:model/Body3} opts.body 
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPostCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/MessageInfo}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost = function(accountId, extensionId, opts, callback) {
      opts = opts || {};
      var postBody = opts['body'];

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = MessageInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdFaxPost operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdFaxPostCallback
     * @param {String} error Error message, if any.
     * @param {module:model/MessageInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create and Send Fax Message
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {module:model/Body4} opts.body 
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdFaxPostCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/MessageInfo}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdFaxPost = function(accountId, extensionId, opts, callback) {
      opts = opts || {};
      var postBody = opts['body'];

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdFaxPost";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdFaxPost";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = MessageInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/fax', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault5} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Forwarding Numbers
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {Integer} opts.page Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;
     * @param {Integer} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault5}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet = function(accountId, extensionId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId
      };
      var queryParams = {
        'page': opts['page'],
        'perPage': opts['perPage']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault5;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/ExtensionInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Extension Info by ID
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/ExtensionInfo}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdGet = function(accountId, extensionId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdGet";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdGet";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = ExtensionInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdMessageStoreGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault6} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Message List
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {module:model/String} opts.availability Specifies the availability status for the resulting messages. Default value is &#39;Alive&#39;. Multiple values are accepted
     * @param {Integer} opts.conversationId Specifies the conversation identifier for the resulting messages
     * @param {Date} opts.dateFrom The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours
     * @param {Date} opts.dateTo The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time
     * @param {module:model/String} opts.direction The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted
     * @param {Boolean} opts.distinctConversations If &#39;True&#39;, then the latest messages per every conversation ID are returned
     * @param {module:model/String} opts.messageType The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted
     * @param {module:model/String} opts.readStatus The read status for the resulting messages. Multiple values are accepted
     * @param {Integer} opts.page Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;
     * @param {Integer} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default
     * @param {String} opts.phoneNumber The phone number. If specified, messages are returned for this particular phone number only
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdMessageStoreGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault6}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet = function(accountId, extensionId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId
      };
      var queryParams = {
        'availability': opts['availability'],
        'conversationId': opts['conversationId'],
        'dateFrom': opts['dateFrom'],
        'dateTo': opts['dateTo'],
        'direction': opts['direction'],
        'distinctConversations': opts['distinctConversations'],
        'messageType': opts['messageType'],
        'readStatus': opts['readStatus'],
        'page': opts['page'],
        'perPage': opts['perPage'],
        'phoneNumber': opts['phoneNumber']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault6;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGetCallback
     * @param {String} error Error message, if any.
     * @param {'String'} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Message Attachment
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Integer} messageId Internal identifier of a message
     * @param {Integer} attachmentId Internal identifier of a message attachment
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {'String'}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet = function(accountId, extensionId, messageId, attachmentId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet";
      }

      // verify the required parameter 'messageId' is set
      if (messageId == undefined || messageId == null) {
        throw "Missing the required parameter 'messageId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet";
      }

      // verify the required parameter 'attachmentId' is set
      if (attachmentId == undefined || attachmentId == null) {
        throw "Missing the required parameter 'attachmentId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId,
        'messageId': messageId,
        'attachmentId': attachmentId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = 'String';

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDeleteCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Delete Message by ID
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Integer} messageId Internal identifier of a message
     * @param {Object} opts Optional parameters
     * @param {Boolean} opts.purge If the value is &#39;True&#39;, then the message is purged immediately with all the attachments. The default value is &#39;False&#39;
     * @param {Integer} opts.conversationId Internal identifier of a message thread
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDeleteCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete = function(accountId, extensionId, messageId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete";
      }

      // verify the required parameter 'messageId' is set
      if (messageId == undefined || messageId == null) {
        throw "Missing the required parameter 'messageId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId,
        'messageId': messageId
      };
      var queryParams = {
        'purge': opts['purge'],
        'conversationId': opts['conversationId']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = null;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}', 'DELETE',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/MessageInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Message by ID
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Integer} messageId Internal identifier of a message
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/MessageInfo}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet = function(accountId, extensionId, messageId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet";
      }

      // verify the required parameter 'messageId' is set
      if (messageId == undefined || messageId == null) {
        throw "Missing the required parameter 'messageId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId,
        'messageId': messageId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = MessageInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPutCallback
     * @param {String} error Error message, if any.
     * @param {module:model/MessageInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Update Message by ID
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Integer} messageId Internal identifier of a message
     * @param {Object} opts Optional parameters
     * @param {module:model/Body5} opts.body 
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPutCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/MessageInfo}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut = function(accountId, extensionId, messageId, opts, callback) {
      opts = opts || {};
      var postBody = opts['body'];

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut";
      }

      // verify the required parameter 'messageId' is set
      if (messageId == undefined || messageId == null) {
        throw "Missing the required parameter 'messageId' when calling restapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId,
        'messageId': messageId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = MessageInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault7} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Extension Phone Numbers
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {module:model/String} opts.usageType Usage type of the phone number
     * @param {Integer} opts.page Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;
     * @param {Integer} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault7}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet = function(accountId, extensionId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId
      };
      var queryParams = {
        'usageType': opts['usageType'],
        'page': opts['page'],
        'perPage': opts['perPage']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault7;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdPresenceGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdPresenceGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/PresenceInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Extension Presence
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdPresenceGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/PresenceInfo}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdPresenceGet = function(accountId, extensionId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdPresenceGet";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdPresenceGet";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = PresenceInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdRingoutPost operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdRingoutPostCallback
     * @param {String} error Error message, if any.
     * @param {module:model/RingOutInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Initiate RingOut Call
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {module:model/Body6} opts.body 
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdRingoutPostCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/RingOutInfo}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdRingoutPost = function(accountId, extensionId, opts, callback) {
      opts = opts || {};
      var postBody = opts['body'];

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdRingoutPost";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdRingoutPost";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = RingOutInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDeleteCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Cancel RingOut Call
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Integer} ringoutId Internal identifier of a RingOut call
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDeleteCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete = function(accountId, extensionId, ringoutId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete";
      }

      // verify the required parameter 'ringoutId' is set
      if (ringoutId == undefined || ringoutId == null) {
        throw "Missing the required parameter 'ringoutId' when calling restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId,
        'ringoutId': ringoutId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = null;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout/{ringoutId}', 'DELETE',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/RingOutInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get RingOut Call Status
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Integer} ringoutId Internal identifier of a RingOut call
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/RingOutInfo}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet = function(accountId, extensionId, ringoutId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet";
      }

      // verify the required parameter 'ringoutId' is set
      if (ringoutId == undefined || ringoutId == null) {
        throw "Missing the required parameter 'ringoutId' when calling restapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId,
        'ringoutId': ringoutId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = RingOutInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout/{ringoutId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionExtensionIdSmsPost operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdSmsPostCallback
     * @param {String} error Error message, if any.
     * @param {module:model/MessageInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create and Send SMS Message
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {String} extensionId Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {module:model/Body7} opts.body 
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionExtensionIdSmsPostCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/MessageInfo}
     */
    this.restapiV10AccountAccountIdExtensionExtensionIdSmsPost = function(accountId, extensionId, opts, callback) {
      opts = opts || {};
      var postBody = opts['body'];

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionExtensionIdSmsPost";
      }

      // verify the required parameter 'extensionId' is set
      if (extensionId == undefined || extensionId == null) {
        throw "Missing the required parameter 'extensionId' when calling restapiV10AccountAccountIdExtensionExtensionIdSmsPost";
      }


      var pathParams = {
        'accountId': accountId,
        'extensionId': extensionId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = MessageInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension/{extensionId}/sms', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdExtensionGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdExtensionGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault4} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Extension List
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {Integer} opts.page Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;
     * @param {Integer} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default.
     * @param {module:model/String} opts.status Extension current state. Multiple values are supported. If &#39;Unassigned&#39; is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned
     * @param {module:model/String} opts.type Extension type. Multiple values are supported
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdExtensionGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault4}
     */
    this.restapiV10AccountAccountIdExtensionGet = function(accountId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdExtensionGet";
      }


      var pathParams = {
        'accountId': accountId
      };
      var queryParams = {
        'page': opts['page'],
        'perPage': opts['perPage'],
        'status': opts['status'],
        'type': opts['type']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault4;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/extension', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/AccountInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Account Info by ID
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/AccountInfo}
     */
    this.restapiV10AccountAccountIdGet = function(accountId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdGet";
      }


      var pathParams = {
        'accountId': accountId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = AccountInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdPhoneNumberGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdPhoneNumberGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault8} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Account Phone Numbers
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {Object} opts Optional parameters
     * @param {Integer} opts.page Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;
     * @param {Integer} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default
     * @param {module:model/String} opts.usageType Usage type of the phone number
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdPhoneNumberGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault8}
     */
    this.restapiV10AccountAccountIdPhoneNumberGet = function(accountId, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdPhoneNumberGet";
      }


      var pathParams = {
        'accountId': accountId
      };
      var queryParams = {
        'page': opts['page'],
        'perPage': opts['perPage'],
        'usageType': opts['usageType']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault8;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/phone-number', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdPhoneNumberPhoneNumberIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/PhoneNumberInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Phone Number by ID
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {Integer} phoneNumberId Internal identifier of a phone number
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdPhoneNumberPhoneNumberIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/PhoneNumberInfo}
     */
    this.restapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet = function(accountId, phoneNumberId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet";
      }

      // verify the required parameter 'phoneNumberId' is set
      if (phoneNumberId == undefined || phoneNumberId == null) {
        throw "Missing the required parameter 'phoneNumberId' when calling restapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet";
      }


      var pathParams = {
        'accountId': accountId,
        'phoneNumberId': phoneNumberId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = PhoneNumberInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdRecordingRecordingIdContentGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdRecordingRecordingIdContentGetCallback
     * @param {String} error Error message, if any.
     * @param {'String'} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Call Recording Content
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {Integer} recordingId Internal identifier of recording (returned in Call Log)
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdRecordingRecordingIdContentGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {'String'}
     */
    this.restapiV10AccountAccountIdRecordingRecordingIdContentGet = function(accountId, recordingId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdRecordingRecordingIdContentGet";
      }

      // verify the required parameter 'recordingId' is set
      if (recordingId == undefined || recordingId == null) {
        throw "Missing the required parameter 'recordingId' when calling restapiV10AccountAccountIdRecordingRecordingIdContentGet";
      }


      var pathParams = {
        'accountId': accountId,
        'recordingId': recordingId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = 'String';

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/recording/{recordingId}/content', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10AccountAccountIdRecordingRecordingIdGet operation.
     * @callback module:api/DefaultApi~restapiV10AccountAccountIdRecordingRecordingIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault9} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Call Recording Metadata
     * @param {String} accountId Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session
     * @param {Integer} recordingId Internal identifier of recording (returned in Call Log)
     * @param {module:api/DefaultApi~restapiV10AccountAccountIdRecordingRecordingIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault9}
     */
    this.restapiV10AccountAccountIdRecordingRecordingIdGet = function(accountId, recordingId, callback) {
      var postBody = null;

      // verify the required parameter 'accountId' is set
      if (accountId == undefined || accountId == null) {
        throw "Missing the required parameter 'accountId' when calling restapiV10AccountAccountIdRecordingRecordingIdGet";
      }

      // verify the required parameter 'recordingId' is set
      if (recordingId == undefined || recordingId == null) {
        throw "Missing the required parameter 'recordingId' when calling restapiV10AccountAccountIdRecordingRecordingIdGet";
      }


      var pathParams = {
        'accountId': accountId,
        'recordingId': recordingId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault9;

      return this.apiClient.callApi(
        '/restapi/v1.0/account/{accountId}/recording/{recordingId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10DictionaryCountryCountryIdGet operation.
     * @callback module:api/DefaultApi~restapiV10DictionaryCountryCountryIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/FullCountryInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Country by ID
     * @param {Integer} countryId Internal identifier of a country
     * @param {module:api/DefaultApi~restapiV10DictionaryCountryCountryIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/FullCountryInfo}
     */
    this.restapiV10DictionaryCountryCountryIdGet = function(countryId, callback) {
      var postBody = null;

      // verify the required parameter 'countryId' is set
      if (countryId == undefined || countryId == null) {
        throw "Missing the required parameter 'countryId' when calling restapiV10DictionaryCountryCountryIdGet";
      }


      var pathParams = {
        'countryId': countryId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = FullCountryInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/dictionary/country/{countryId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10DictionaryCountryGet operation.
     * @callback module:api/DefaultApi~restapiV10DictionaryCountryGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault10} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Country List
     * @param {Object} opts Optional parameters
     * @param {Boolean} opts.loginAllowed Specifies whether login with the phone numbers of this country is enabled or not
     * @param {Boolean} opts.numberSelling Specifies if RingCentral sells phone numbers of this country
     * @param {Integer} opts.page Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;
     * @param {Integer} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default
     * @param {module:api/DefaultApi~restapiV10DictionaryCountryGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault10}
     */
    this.restapiV10DictionaryCountryGet = function(opts, callback) {
      opts = opts || {};
      var postBody = null;


      var pathParams = {
      };
      var queryParams = {
        'loginAllowed': opts['loginAllowed'],
        'numberSelling': opts['numberSelling'],
        'page': opts['page'],
        'perPage': opts['perPage']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault10;

      return this.apiClient.callApi(
        '/restapi/v1.0/dictionary/country', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10DictionaryLanguageGet operation.
     * @callback module:api/DefaultApi~restapiV10DictionaryLanguageGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault11} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Supported Language List
     * @param {module:api/DefaultApi~restapiV10DictionaryLanguageGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault11}
     */
    this.restapiV10DictionaryLanguageGet = function(callback) {
      var postBody = null;


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault11;

      return this.apiClient.callApi(
        '/restapi/v1.0/dictionary/language', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10DictionaryLanguageLanguageIdGet operation.
     * @callback module:api/DefaultApi~restapiV10DictionaryLanguageLanguageIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/LanguageInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Language by ID
     * @param {Integer} languageId Internal identifier of a language
     * @param {module:api/DefaultApi~restapiV10DictionaryLanguageLanguageIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/LanguageInfo}
     */
    this.restapiV10DictionaryLanguageLanguageIdGet = function(languageId, callback) {
      var postBody = null;

      // verify the required parameter 'languageId' is set
      if (languageId == undefined || languageId == null) {
        throw "Missing the required parameter 'languageId' when calling restapiV10DictionaryLanguageLanguageIdGet";
      }


      var pathParams = {
        'languageId': languageId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = LanguageInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/dictionary/language/{languageId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10DictionaryLocationGet operation.
     * @callback module:api/DefaultApi~restapiV10DictionaryLocationGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault12} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Location List
     * @param {Object} opts Optional parameters
     * @param {module:model/String} opts.orderBy Sorts results by the specified property. The default value is &#39;City&#39;
     * @param {Integer} opts.page Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;.
     * @param {Integer} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default.
     * @param {String} opts.stateId Internal identifier of a state
     * @param {Boolean} opts.withNxx Specifies if nxx codes are returned
     * @param {module:api/DefaultApi~restapiV10DictionaryLocationGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault12}
     */
    this.restapiV10DictionaryLocationGet = function(opts, callback) {
      opts = opts || {};
      var postBody = null;


      var pathParams = {
      };
      var queryParams = {
        'orderBy': opts['orderBy'],
        'page': opts['page'],
        'perPage': opts['perPage'],
        'stateId': opts['stateId'],
        'withNxx': opts['withNxx']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault12;

      return this.apiClient.callApi(
        '/restapi/v1.0/dictionary/location', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10DictionaryStateGet operation.
     * @callback module:api/DefaultApi~restapiV10DictionaryStateGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault13} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get State/Province List
     * @param {Object} opts Optional parameters
     * @param {Integer} opts.countryId Internal identifier of a country
     * @param {Integer} opts.page Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;.
     * @param {Integer} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default
     * @param {Boolean} opts.withPhoneNumbers If &#39;True&#39;, the list of states with phone numbers available for buying is returned. The default value is &#39;False&#39;
     * @param {module:api/DefaultApi~restapiV10DictionaryStateGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault13}
     */
    this.restapiV10DictionaryStateGet = function(opts, callback) {
      opts = opts || {};
      var postBody = null;


      var pathParams = {
      };
      var queryParams = {
        'countryId': opts['countryId'],
        'page': opts['page'],
        'perPage': opts['perPage'],
        'withPhoneNumbers': opts['withPhoneNumbers']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault13;

      return this.apiClient.callApi(
        '/restapi/v1.0/dictionary/state', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10DictionaryStateStateIdGet operation.
     * @callback module:api/DefaultApi~restapiV10DictionaryStateStateIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/StateInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get State/Province by ID
     * @param {Integer} stateId Internal identifier of a state
     * @param {module:api/DefaultApi~restapiV10DictionaryStateStateIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/StateInfo}
     */
    this.restapiV10DictionaryStateStateIdGet = function(stateId, callback) {
      var postBody = null;

      // verify the required parameter 'stateId' is set
      if (stateId == undefined || stateId == null) {
        throw "Missing the required parameter 'stateId' when calling restapiV10DictionaryStateStateIdGet";
      }


      var pathParams = {
        'stateId': stateId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = StateInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/dictionary/state/{stateId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10DictionaryTimezoneGet operation.
     * @callback module:api/DefaultApi~restapiV10DictionaryTimezoneGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/InlineResponseDefault14} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Time Zone List
     * @param {Object} opts Optional parameters
     * @param {String} opts.page Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;
     * @param {String} opts.perPage Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default
     * @param {module:api/DefaultApi~restapiV10DictionaryTimezoneGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/InlineResponseDefault14}
     */
    this.restapiV10DictionaryTimezoneGet = function(opts, callback) {
      opts = opts || {};
      var postBody = null;


      var pathParams = {
      };
      var queryParams = {
        'page': opts['page'],
        'perPage': opts['perPage']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = InlineResponseDefault14;

      return this.apiClient.callApi(
        '/restapi/v1.0/dictionary/timezone', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10DictionaryTimezoneTimezoneIdGet operation.
     * @callback module:api/DefaultApi~restapiV10DictionaryTimezoneTimezoneIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/TimezoneInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Time Zone by ID
     * @param {Integer} timezoneId Internal identifier of a timezone
     * @param {module:api/DefaultApi~restapiV10DictionaryTimezoneTimezoneIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/TimezoneInfo}
     */
    this.restapiV10DictionaryTimezoneTimezoneIdGet = function(timezoneId, callback) {
      var postBody = null;

      // verify the required parameter 'timezoneId' is set
      if (timezoneId == undefined || timezoneId == null) {
        throw "Missing the required parameter 'timezoneId' when calling restapiV10DictionaryTimezoneTimezoneIdGet";
      }


      var pathParams = {
        'timezoneId': timezoneId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = TimezoneInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/dictionary/timezone/{timezoneId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10Get operation.
     * @callback module:api/DefaultApi~restapiV10GetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/VersionInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get API Version Info
     * @param {module:api/DefaultApi~restapiV10GetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/VersionInfo}
     */
    this.restapiV10Get = function(callback) {
      var postBody = null;


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = VersionInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10SubscriptionPost operation.
     * @callback module:api/DefaultApi~restapiV10SubscriptionPostCallback
     * @param {String} error Error message, if any.
     * @param {module:model/SubscriptionInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create New Subscription
     * @param {Object} opts Optional parameters
     * @param {Boolean} opts.aggregated If &#39;True&#39; then aggregated presence status is returned in a notification payload in the &#39;presenceStatus&#39; field
     * @param {module:model/Body8} opts.body 
     * @param {module:api/DefaultApi~restapiV10SubscriptionPostCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/SubscriptionInfo}
     */
    this.restapiV10SubscriptionPost = function(opts, callback) {
      opts = opts || {};
      var postBody = opts['body'];


      var pathParams = {
      };
      var queryParams = {
        'aggregated': opts['aggregated']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = SubscriptionInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/subscription', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10SubscriptionSubscriptionIdDelete operation.
     * @callback module:api/DefaultApi~restapiV10SubscriptionSubscriptionIdDeleteCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Cancel Subscription by ID
     * @param {String} subscriptionId Internal identifier of a subscription
     * @param {module:api/DefaultApi~restapiV10SubscriptionSubscriptionIdDeleteCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.restapiV10SubscriptionSubscriptionIdDelete = function(subscriptionId, callback) {
      var postBody = null;

      // verify the required parameter 'subscriptionId' is set
      if (subscriptionId == undefined || subscriptionId == null) {
        throw "Missing the required parameter 'subscriptionId' when calling restapiV10SubscriptionSubscriptionIdDelete";
      }


      var pathParams = {
        'subscriptionId': subscriptionId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = null;

      return this.apiClient.callApi(
        '/restapi/v1.0/subscription/{subscriptionId}', 'DELETE',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10SubscriptionSubscriptionIdGet operation.
     * @callback module:api/DefaultApi~restapiV10SubscriptionSubscriptionIdGetCallback
     * @param {String} error Error message, if any.
     * @param {module:model/SubscriptionInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get Subscription by ID
     * @param {String} subscriptionId Internal identifier of a subscription
     * @param {module:api/DefaultApi~restapiV10SubscriptionSubscriptionIdGetCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/SubscriptionInfo}
     */
    this.restapiV10SubscriptionSubscriptionIdGet = function(subscriptionId, callback) {
      var postBody = null;

      // verify the required parameter 'subscriptionId' is set
      if (subscriptionId == undefined || subscriptionId == null) {
        throw "Missing the required parameter 'subscriptionId' when calling restapiV10SubscriptionSubscriptionIdGet";
      }


      var pathParams = {
        'subscriptionId': subscriptionId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = SubscriptionInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/subscription/{subscriptionId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the restapiV10SubscriptionSubscriptionIdPut operation.
     * @callback module:api/DefaultApi~restapiV10SubscriptionSubscriptionIdPutCallback
     * @param {String} error Error message, if any.
     * @param {module:model/SubscriptionInfo} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Update/Renew Subscription by ID
     * @param {String} subscriptionId Internal identifier of a subscription
     * @param {Object} opts Optional parameters
     * @param {Boolean} opts.aggregated If &#39;True&#39; then aggregated presence status is returned in a notification payload
     * @param {module:model/Body9} opts.body 
     * @param {module:api/DefaultApi~restapiV10SubscriptionSubscriptionIdPutCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {module:model/SubscriptionInfo}
     */
    this.restapiV10SubscriptionSubscriptionIdPut = function(subscriptionId, opts, callback) {
      opts = opts || {};
      var postBody = opts['body'];

      // verify the required parameter 'subscriptionId' is set
      if (subscriptionId == undefined || subscriptionId == null) {
        throw "Missing the required parameter 'subscriptionId' when calling restapiV10SubscriptionSubscriptionIdPut";
      }


      var pathParams = {
        'subscriptionId': subscriptionId
      };
      var queryParams = {
        'aggregated': opts['aggregated']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = SubscriptionInfo;

      return this.apiClient.callApi(
        '/restapi/v1.0/subscription/{subscriptionId}', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
