using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Server Info
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ServerInfo</returns>
        ServerInfo RestapiGet ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Server Info
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ServerInfo</returns>
        ApiResponse<ServerInfo> RestapiGetWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// OAuth2 Authorize
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>InlineResponseDefault</returns>
        InlineResponseDefault RestapiOauthAuthorizePost (Body body = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// OAuth2 Authorize
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault</returns>
        ApiResponse<InlineResponseDefault> RestapiOauthAuthorizePostWithHttpInfo (Body body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// OAuth2 Revoke Token
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void RestapiOauthRevokePost (Body1 body = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// OAuth2 Revoke Token
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RestapiOauthRevokePostWithHttpInfo (Body1 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// OAuth2 Get Token
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>InlineResponseDefault1</returns>
        InlineResponseDefault1 RestapiOauthTokenPost (Body2 body = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// OAuth2 Get Token
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault1</returns>
        ApiResponse<InlineResponseDefault1> RestapiOauthTokenPostWithHttpInfo (Body2 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Active (Recent) Calls
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <returns>InlineResponseDefault2</returns>
        InlineResponseDefault2 RestapiV10AccountAccountIdActiveCallsGet (string accountId, string direction = null, string type = null, int? page = null, int? perPage = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Active (Recent) Calls
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault2</returns>
        ApiResponse<InlineResponseDefault2> RestapiV10AccountAccountIdActiveCallsGetWithHttpInfo (string accountId, string direction = null, string type = null, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Company Business Address
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <returns>InlineResponseDefault3</returns>
        InlineResponseDefault3 RestapiV10AccountAccountIdBusinessAddressGet (string accountId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Company Business Address
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <returns>ApiResponse of InlineResponseDefault3</returns>
        ApiResponse<InlineResponseDefault3> RestapiV10AccountAccountIdBusinessAddressGetWithHttpInfo (string accountId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Call Log Record by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="callLogId">Internal identifier of a call log record</param>
        /// <returns>CallLogInfo</returns>
        CallLogInfo RestapiV10AccountAccountIdCallLogCallLogIdGet (string accountId, int? callLogId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Call Log Record by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="callLogId">Internal identifier of a call log record</param>
        /// <returns>ApiResponse of CallLogInfo</returns>
        ApiResponse<CallLogInfo> RestapiV10AccountAccountIdCallLogCallLogIdGetWithHttpInfo (string accountId, int? callLogId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Call Log
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param>
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param>
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. The default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <returns>InlineResponseDefault2</returns>
        InlineResponseDefault2 RestapiV10AccountAccountIdCallLogGet (string accountId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? page = null, int? perPage = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Call Log
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param>
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param>
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. The default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault2</returns>
        ApiResponse<InlineResponseDefault2> RestapiV10AccountAccountIdCallLogGetWithHttpInfo (string accountId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Active (Recent) Calls
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>InlineResponseDefault2</returns>
        InlineResponseDefault2 RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet (string accountId, string extensionId, string direction = null, string type = null, int? page = null, int? perPage = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Active (Recent) Calls
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault2</returns>
        ApiResponse<InlineResponseDefault2> RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGetWithHttpInfo (string accountId, string extensionId, string direction = null, string type = null, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Call Log Record by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="callLogId">Internal identifier of a call log record</param>
        /// <returns>CallLogInfo</returns>
        CallLogInfo RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet (string accountId, string extensionId, int? callLogId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Call Log Record by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="callLogId">Internal identifier of a call log record</param>
        /// <returns>ApiResponse of CallLogInfo</returns>
        ApiResponse<CallLogInfo> RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGetWithHttpInfo (string accountId, string extensionId, int? callLogId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Call Log
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param>
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param>
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param>
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>InlineResponseDefault2</returns>
        InlineResponseDefault2 RestapiV10AccountAccountIdExtensionExtensionIdCallLogGet (string accountId, string extensionId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateTo = null, DateTime? dateFrom = null, int? page = null, int? perPage = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Call Log
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param>
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param>
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param>
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault2</returns>
        ApiResponse<InlineResponseDefault2> RestapiV10AccountAccountIdExtensionExtensionIdCallLogGetWithHttpInfo (string accountId, string extensionId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateTo = null, DateTime? dateFrom = null, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create and Send Pager Message
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>MessageInfo</returns>
        MessageInfo RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost (string accountId, string extensionId, Body3 body = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create and Send Pager Message
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of MessageInfo</returns>
        ApiResponse<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPostWithHttpInfo (string accountId, string extensionId, Body3 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create and Send Fax Message
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>MessageInfo</returns>
        MessageInfo RestapiV10AccountAccountIdExtensionExtensionIdFaxPost (string accountId, string extensionId, Body4 body = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create and Send Fax Message
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of MessageInfo</returns>
        ApiResponse<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdFaxPostWithHttpInfo (string accountId, string extensionId, Body4 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Forwarding Numbers
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>InlineResponseDefault5</returns>
        InlineResponseDefault5 RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet (string accountId, string extensionId, int? page = null, int? perPage = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Forwarding Numbers
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault5</returns>
        ApiResponse<InlineResponseDefault5> RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGetWithHttpInfo (string accountId, string extensionId, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Info by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <returns>ExtensionInfo</returns>
        ExtensionInfo RestapiV10AccountAccountIdExtensionExtensionIdGet (string accountId, string extensionId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Info by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <returns>ApiResponse of ExtensionInfo</returns>
        ApiResponse<ExtensionInfo> RestapiV10AccountAccountIdExtensionExtensionIdGetWithHttpInfo (string accountId, string extensionId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Message List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="availability">Specifies the availability status for the resulting messages. Default value is &#39;Alive&#39;. Multiple values are accepted (optional)</param>
        /// <param name="conversationId">Specifies the conversation identifier for the resulting messages (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="dateTo">The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="direction">The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted (optional)</param>
        /// <param name="distinctConversations">If &#39;True&#39;, then the latest messages per every conversation ID are returned (optional)</param>
        /// <param name="messageType">The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted (optional)</param>
        /// <param name="readStatus">The read status for the resulting messages. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="phoneNumber">The phone number. If specified, messages are returned for this particular phone number only (optional)</param>
        /// <returns>InlineResponseDefault6</returns>
        InlineResponseDefault6 RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet (string accountId, string extensionId, string availability = null, long? conversationId = null, DateTime? dateFrom = null, DateTime? dateTo = null, string direction = null, bool? distinctConversations = null, string messageType = null, string readStatus = null, int? page = null, int? perPage = null, string phoneNumber = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Message List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="availability">Specifies the availability status for the resulting messages. Default value is &#39;Alive&#39;. Multiple values are accepted (optional)</param>
        /// <param name="conversationId">Specifies the conversation identifier for the resulting messages (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="dateTo">The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="direction">The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted (optional)</param>
        /// <param name="distinctConversations">If &#39;True&#39;, then the latest messages per every conversation ID are returned (optional)</param>
        /// <param name="messageType">The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted (optional)</param>
        /// <param name="readStatus">The read status for the resulting messages. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="phoneNumber">The phone number. If specified, messages are returned for this particular phone number only (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault6</returns>
        ApiResponse<InlineResponseDefault6> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGetWithHttpInfo (string accountId, string extensionId, string availability = null, long? conversationId = null, DateTime? dateFrom = null, DateTime? dateTo = null, string direction = null, bool? distinctConversations = null, string messageType = null, string readStatus = null, int? page = null, int? perPage = null, string phoneNumber = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Message Attachment
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="attachmentId">Internal identifier of a message attachment</param>
        /// <returns>byte[]</returns>
        byte[] RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet (string accountId, string extensionId, int? messageId, int? attachmentId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Message Attachment
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="attachmentId">Internal identifier of a message attachment</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGetWithHttpInfo (string accountId, string extensionId, int? messageId, int? attachmentId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Delete Message by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="purge">If the value is &#39;True&#39;, then the message is purged immediately with all the attachments. The default value is &#39;False&#39; (optional)</param>
        /// <param name="conversationId">Internal identifier of a message thread (optional)</param>
        /// <returns></returns>
        void RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete (string accountId, string extensionId, int? messageId, bool? purge = null, long? conversationId = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Delete Message by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="purge">If the value is &#39;True&#39;, then the message is purged immediately with all the attachments. The default value is &#39;False&#39; (optional)</param>
        /// <param name="conversationId">Internal identifier of a message thread (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDeleteWithHttpInfo (string accountId, string extensionId, int? messageId, bool? purge = null, long? conversationId = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Message by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <returns>MessageInfo</returns>
        MessageInfo RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet (string accountId, string extensionId, int? messageId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Message by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <returns>ApiResponse of MessageInfo</returns>
        ApiResponse<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGetWithHttpInfo (string accountId, string extensionId, int? messageId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update Message by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="body"> (optional)</param>
        /// <returns>MessageInfo</returns>
        MessageInfo RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut (string accountId, string extensionId, int? messageId, Body5 body = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update Message by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of MessageInfo</returns>
        ApiResponse<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPutWithHttpInfo (string accountId, string extensionId, int? messageId, Body5 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Phone Numbers
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="usageType">Usage type of the phone number (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>InlineResponseDefault7</returns>
        InlineResponseDefault7 RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet (string accountId, string extensionId, string usageType = null, int? page = null, int? perPage = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Phone Numbers
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="usageType">Usage type of the phone number (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault7</returns>
        ApiResponse<InlineResponseDefault7> RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGetWithHttpInfo (string accountId, string extensionId, string usageType = null, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Presence
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <returns>PresenceInfo</returns>
        PresenceInfo RestapiV10AccountAccountIdExtensionExtensionIdPresenceGet (string accountId, string extensionId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Presence
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <returns>ApiResponse of PresenceInfo</returns>
        ApiResponse<PresenceInfo> RestapiV10AccountAccountIdExtensionExtensionIdPresenceGetWithHttpInfo (string accountId, string extensionId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Initiate RingOut Call
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>RingOutInfo</returns>
        RingOutInfo RestapiV10AccountAccountIdExtensionExtensionIdRingoutPost (string accountId, string extensionId, Body6 body = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Initiate RingOut Call
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of RingOutInfo</returns>
        ApiResponse<RingOutInfo> RestapiV10AccountAccountIdExtensionExtensionIdRingoutPostWithHttpInfo (string accountId, string extensionId, Body6 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Cancel RingOut Call
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="ringoutId">Internal identifier of a RingOut call</param>
        /// <returns></returns>
        void RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete (string accountId, string extensionId, int? ringoutId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Cancel RingOut Call
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="ringoutId">Internal identifier of a RingOut call</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDeleteWithHttpInfo (string accountId, string extensionId, int? ringoutId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get RingOut Call Status
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="ringoutId">Internal identifier of a RingOut call</param>
        /// <returns>RingOutInfo</returns>
        RingOutInfo RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet (string accountId, string extensionId, int? ringoutId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get RingOut Call Status
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="ringoutId">Internal identifier of a RingOut call</param>
        /// <returns>ApiResponse of RingOutInfo</returns>
        ApiResponse<RingOutInfo> RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGetWithHttpInfo (string accountId, string extensionId, int? ringoutId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create and Send SMS Message
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>MessageInfo</returns>
        MessageInfo RestapiV10AccountAccountIdExtensionExtensionIdSmsPost (string accountId, string extensionId, Body7 body = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create and Send SMS Message
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of MessageInfo</returns>
        ApiResponse<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdSmsPostWithHttpInfo (string accountId, string extensionId, Body7 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <param name="status">Extension current state. Multiple values are supported. If &#39;Unassigned&#39; is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned (optional)</param>
        /// <param name="type">Extension type. Multiple values are supported (optional)</param>
        /// <returns>InlineResponseDefault4</returns>
        InlineResponseDefault4 RestapiV10AccountAccountIdExtensionGet (string accountId, int? page = null, int? perPage = null, string status = null, string type = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <param name="status">Extension current state. Multiple values are supported. If &#39;Unassigned&#39; is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned (optional)</param>
        /// <param name="type">Extension type. Multiple values are supported (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault4</returns>
        ApiResponse<InlineResponseDefault4> RestapiV10AccountAccountIdExtensionGetWithHttpInfo (string accountId, int? page = null, int? perPage = null, string status = null, string type = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Info by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <returns>AccountInfo</returns>
        AccountInfo RestapiV10AccountAccountIdGet (string accountId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Info by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <returns>ApiResponse of AccountInfo</returns>
        ApiResponse<AccountInfo> RestapiV10AccountAccountIdGetWithHttpInfo (string accountId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Phone Numbers
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="usageType">Usage type of the phone number (optional)</param>
        /// <returns>InlineResponseDefault8</returns>
        InlineResponseDefault8 RestapiV10AccountAccountIdPhoneNumberGet (string accountId, int? page = null, int? perPage = null, string usageType = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Phone Numbers
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="usageType">Usage type of the phone number (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault8</returns>
        ApiResponse<InlineResponseDefault8> RestapiV10AccountAccountIdPhoneNumberGetWithHttpInfo (string accountId, int? page = null, int? perPage = null, string usageType = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Phone Number by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="phoneNumberId">Internal identifier of a phone number</param>
        /// <returns>PhoneNumberInfo</returns>
        PhoneNumberInfo RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet (string accountId, int? phoneNumberId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Phone Number by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="phoneNumberId">Internal identifier of a phone number</param>
        /// <returns>ApiResponse of PhoneNumberInfo</returns>
        ApiResponse<PhoneNumberInfo> RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGetWithHttpInfo (string accountId, int? phoneNumberId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Call Recording Content
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param>
        /// <returns>byte[]</returns>
        byte[] RestapiV10AccountAccountIdRecordingRecordingIdContentGet (string accountId, int? recordingId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Call Recording Content
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> RestapiV10AccountAccountIdRecordingRecordingIdContentGetWithHttpInfo (string accountId, int? recordingId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Call Recording Metadata
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param>
        /// <returns>InlineResponseDefault9</returns>
        InlineResponseDefault9 RestapiV10AccountAccountIdRecordingRecordingIdGet (string accountId, int? recordingId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Call Recording Metadata
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param>
        /// <returns>ApiResponse of InlineResponseDefault9</returns>
        ApiResponse<InlineResponseDefault9> RestapiV10AccountAccountIdRecordingRecordingIdGetWithHttpInfo (string accountId, int? recordingId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Country by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country</param>
        /// <returns>FullCountryInfo</returns>
        FullCountryInfo RestapiV10DictionaryCountryCountryIdGet (int? countryId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Country by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country</param>
        /// <returns>ApiResponse of FullCountryInfo</returns>
        ApiResponse<FullCountryInfo> RestapiV10DictionaryCountryCountryIdGetWithHttpInfo (int? countryId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Country List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginAllowed">Specifies whether login with the phone numbers of this country is enabled or not (optional)</param>
        /// <param name="numberSelling">Specifies if RingCentral sells phone numbers of this country (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>InlineResponseDefault10</returns>
        InlineResponseDefault10 RestapiV10DictionaryCountryGet (bool? loginAllowed = null, bool? numberSelling = null, int? page = null, int? perPage = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Country List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginAllowed">Specifies whether login with the phone numbers of this country is enabled or not (optional)</param>
        /// <param name="numberSelling">Specifies if RingCentral sells phone numbers of this country (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault10</returns>
        ApiResponse<InlineResponseDefault10> RestapiV10DictionaryCountryGetWithHttpInfo (bool? loginAllowed = null, bool? numberSelling = null, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Supported Language List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponseDefault11</returns>
        InlineResponseDefault11 RestapiV10DictionaryLanguageGet ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Supported Language List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponseDefault11</returns>
        ApiResponse<InlineResponseDefault11> RestapiV10DictionaryLanguageGetWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Language by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Internal identifier of a language</param>
        /// <returns>LanguageInfo</returns>
        LanguageInfo RestapiV10DictionaryLanguageLanguageIdGet (int? languageId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Language by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Internal identifier of a language</param>
        /// <returns>ApiResponse of LanguageInfo</returns>
        ApiResponse<LanguageInfo> RestapiV10DictionaryLanguageLanguageIdGetWithHttpInfo (int? languageId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Location List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Sorts results by the specified property. The default value is &#39;City&#39; (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <param name="stateId">Internal identifier of a state (optional)</param>
        /// <param name="withNxx">Specifies if nxx codes are returned (optional)</param>
        /// <returns>InlineResponseDefault12</returns>
        InlineResponseDefault12 RestapiV10DictionaryLocationGet (string orderBy = null, int? page = null, int? perPage = null, string stateId = null, bool? withNxx = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Location List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Sorts results by the specified property. The default value is &#39;City&#39; (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <param name="stateId">Internal identifier of a state (optional)</param>
        /// <param name="withNxx">Specifies if nxx codes are returned (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault12</returns>
        ApiResponse<InlineResponseDefault12> RestapiV10DictionaryLocationGetWithHttpInfo (string orderBy = null, int? page = null, int? perPage = null, string stateId = null, bool? withNxx = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get State/Province List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="withPhoneNumbers">If &#39;True&#39;, the list of states with phone numbers available for buying is returned. The default value is &#39;False&#39; (optional)</param>
        /// <returns>InlineResponseDefault13</returns>
        InlineResponseDefault13 RestapiV10DictionaryStateGet (int? countryId = null, int? page = null, int? perPage = null, bool? withPhoneNumbers = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get State/Province List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="withPhoneNumbers">If &#39;True&#39;, the list of states with phone numbers available for buying is returned. The default value is &#39;False&#39; (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault13</returns>
        ApiResponse<InlineResponseDefault13> RestapiV10DictionaryStateGetWithHttpInfo (int? countryId = null, int? page = null, int? perPage = null, bool? withPhoneNumbers = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get State/Province by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stateId">Internal identifier of a state</param>
        /// <returns>StateInfo</returns>
        StateInfo RestapiV10DictionaryStateStateIdGet (int? stateId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get State/Province by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stateId">Internal identifier of a state</param>
        /// <returns>ApiResponse of StateInfo</returns>
        ApiResponse<StateInfo> RestapiV10DictionaryStateStateIdGetWithHttpInfo (int? stateId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Time Zone List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>InlineResponseDefault14</returns>
        InlineResponseDefault14 RestapiV10DictionaryTimezoneGet (string page = null, string perPage = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Time Zone List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>ApiResponse of InlineResponseDefault14</returns>
        ApiResponse<InlineResponseDefault14> RestapiV10DictionaryTimezoneGetWithHttpInfo (string page = null, string perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Time Zone by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timezoneId">Internal identifier of a timezone</param>
        /// <returns>TimezoneInfo</returns>
        TimezoneInfo RestapiV10DictionaryTimezoneTimezoneIdGet (int? timezoneId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Time Zone by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timezoneId">Internal identifier of a timezone</param>
        /// <returns>ApiResponse of TimezoneInfo</returns>
        ApiResponse<TimezoneInfo> RestapiV10DictionaryTimezoneTimezoneIdGetWithHttpInfo (int? timezoneId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get API Version Info
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VersionInfo</returns>
        VersionInfo RestapiV10Get ();
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get API Version Info
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VersionInfo</returns>
        ApiResponse<VersionInfo> RestapiV10GetWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create New Subscription
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload in the &#39;presenceStatus&#39; field (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>SubscriptionInfo</returns>
        SubscriptionInfo RestapiV10SubscriptionPost (bool? aggregated = null, Body8 body = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create New Subscription
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload in the &#39;presenceStatus&#39; field (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SubscriptionInfo</returns>
        ApiResponse<SubscriptionInfo> RestapiV10SubscriptionPostWithHttpInfo (bool? aggregated = null, Body8 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Cancel Subscription by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <returns></returns>
        void RestapiV10SubscriptionSubscriptionIdDelete (string subscriptionId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Cancel Subscription by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RestapiV10SubscriptionSubscriptionIdDeleteWithHttpInfo (string subscriptionId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Subscription by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <returns>SubscriptionInfo</returns>
        SubscriptionInfo RestapiV10SubscriptionSubscriptionIdGet (string subscriptionId);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Subscription by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <returns>ApiResponse of SubscriptionInfo</returns>
        ApiResponse<SubscriptionInfo> RestapiV10SubscriptionSubscriptionIdGetWithHttpInfo (string subscriptionId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update/Renew Subscription by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>SubscriptionInfo</returns>
        SubscriptionInfo RestapiV10SubscriptionSubscriptionIdPut (string subscriptionId, bool? aggregated = null, Body9 body = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update/Renew Subscription by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of SubscriptionInfo</returns>
        ApiResponse<SubscriptionInfo> RestapiV10SubscriptionSubscriptionIdPutWithHttpInfo (string subscriptionId, bool? aggregated = null, Body9 body = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Server Info
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ServerInfo</returns>
        System.Threading.Tasks.Task<ServerInfo> RestapiGetAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Server Info
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ServerInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerInfo>> RestapiGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// OAuth2 Authorize
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of InlineResponseDefault</returns>
        System.Threading.Tasks.Task<InlineResponseDefault> RestapiOauthAuthorizePostAsync (Body body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// OAuth2 Authorize
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault>> RestapiOauthAuthorizePostAsyncWithHttpInfo (Body body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// OAuth2 Revoke Token
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RestapiOauthRevokePostAsync (Body1 body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// OAuth2 Revoke Token
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RestapiOauthRevokePostAsyncWithHttpInfo (Body1 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// OAuth2 Get Token
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of InlineResponseDefault1</returns>
        System.Threading.Tasks.Task<InlineResponseDefault1> RestapiOauthTokenPostAsync (Body2 body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// OAuth2 Get Token
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault1)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault1>> RestapiOauthTokenPostAsyncWithHttpInfo (Body2 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Active (Recent) Calls
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <returns>Task of InlineResponseDefault2</returns>
        System.Threading.Tasks.Task<InlineResponseDefault2> RestapiV10AccountAccountIdActiveCallsGetAsync (string accountId, string direction = null, string type = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Active (Recent) Calls
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault2)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault2>> RestapiV10AccountAccountIdActiveCallsGetAsyncWithHttpInfo (string accountId, string direction = null, string type = null, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Company Business Address
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <returns>Task of InlineResponseDefault3</returns>
        System.Threading.Tasks.Task<InlineResponseDefault3> RestapiV10AccountAccountIdBusinessAddressGetAsync (string accountId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Company Business Address
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault3)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault3>> RestapiV10AccountAccountIdBusinessAddressGetAsyncWithHttpInfo (string accountId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Call Log Record by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="callLogId">Internal identifier of a call log record</param>
        /// <returns>Task of CallLogInfo</returns>
        System.Threading.Tasks.Task<CallLogInfo> RestapiV10AccountAccountIdCallLogCallLogIdGetAsync (string accountId, int? callLogId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Call Log Record by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="callLogId">Internal identifier of a call log record</param>
        /// <returns>Task of ApiResponse (CallLogInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallLogInfo>> RestapiV10AccountAccountIdCallLogCallLogIdGetAsyncWithHttpInfo (string accountId, int? callLogId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Call Log
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param>
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param>
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. The default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <returns>Task of InlineResponseDefault2</returns>
        System.Threading.Tasks.Task<InlineResponseDefault2> RestapiV10AccountAccountIdCallLogGetAsync (string accountId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Call Log
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param>
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param>
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. The default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault2)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault2>> RestapiV10AccountAccountIdCallLogGetAsyncWithHttpInfo (string accountId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Active (Recent) Calls
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of InlineResponseDefault2</returns>
        System.Threading.Tasks.Task<InlineResponseDefault2> RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGetAsync (string accountId, string extensionId, string direction = null, string type = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Active (Recent) Calls
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault2)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault2>> RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGetAsyncWithHttpInfo (string accountId, string extensionId, string direction = null, string type = null, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Call Log Record by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="callLogId">Internal identifier of a call log record</param>
        /// <returns>Task of CallLogInfo</returns>
        System.Threading.Tasks.Task<CallLogInfo> RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGetAsync (string accountId, string extensionId, int? callLogId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Call Log Record by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="callLogId">Internal identifier of a call log record</param>
        /// <returns>Task of ApiResponse (CallLogInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<CallLogInfo>> RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGetAsyncWithHttpInfo (string accountId, string extensionId, int? callLogId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Call Log
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param>
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param>
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param>
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of InlineResponseDefault2</returns>
        System.Threading.Tasks.Task<InlineResponseDefault2> RestapiV10AccountAccountIdExtensionExtensionIdCallLogGetAsync (string accountId, string extensionId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateTo = null, DateTime? dateFrom = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Call Log
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param>
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param>
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param>
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault2)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault2>> RestapiV10AccountAccountIdExtensionExtensionIdCallLogGetAsyncWithHttpInfo (string accountId, string extensionId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateTo = null, DateTime? dateFrom = null, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create and Send Pager Message
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of MessageInfo</returns>
        System.Threading.Tasks.Task<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPostAsync (string accountId, string extensionId, Body3 body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create and Send Pager Message
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageInfo>> RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPostAsyncWithHttpInfo (string accountId, string extensionId, Body3 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create and Send Fax Message
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of MessageInfo</returns>
        System.Threading.Tasks.Task<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdFaxPostAsync (string accountId, string extensionId, Body4 body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create and Send Fax Message
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageInfo>> RestapiV10AccountAccountIdExtensionExtensionIdFaxPostAsyncWithHttpInfo (string accountId, string extensionId, Body4 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Forwarding Numbers
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of InlineResponseDefault5</returns>
        System.Threading.Tasks.Task<InlineResponseDefault5> RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGetAsync (string accountId, string extensionId, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Forwarding Numbers
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault5)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault5>> RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGetAsyncWithHttpInfo (string accountId, string extensionId, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Info by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <returns>Task of ExtensionInfo</returns>
        System.Threading.Tasks.Task<ExtensionInfo> RestapiV10AccountAccountIdExtensionExtensionIdGetAsync (string accountId, string extensionId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Info by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <returns>Task of ApiResponse (ExtensionInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<ExtensionInfo>> RestapiV10AccountAccountIdExtensionExtensionIdGetAsyncWithHttpInfo (string accountId, string extensionId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Message List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="availability">Specifies the availability status for the resulting messages. Default value is &#39;Alive&#39;. Multiple values are accepted (optional)</param>
        /// <param name="conversationId">Specifies the conversation identifier for the resulting messages (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="dateTo">The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="direction">The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted (optional)</param>
        /// <param name="distinctConversations">If &#39;True&#39;, then the latest messages per every conversation ID are returned (optional)</param>
        /// <param name="messageType">The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted (optional)</param>
        /// <param name="readStatus">The read status for the resulting messages. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="phoneNumber">The phone number. If specified, messages are returned for this particular phone number only (optional)</param>
        /// <returns>Task of InlineResponseDefault6</returns>
        System.Threading.Tasks.Task<InlineResponseDefault6> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGetAsync (string accountId, string extensionId, string availability = null, long? conversationId = null, DateTime? dateFrom = null, DateTime? dateTo = null, string direction = null, bool? distinctConversations = null, string messageType = null, string readStatus = null, int? page = null, int? perPage = null, string phoneNumber = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Message List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="availability">Specifies the availability status for the resulting messages. Default value is &#39;Alive&#39;. Multiple values are accepted (optional)</param>
        /// <param name="conversationId">Specifies the conversation identifier for the resulting messages (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="dateTo">The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="direction">The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted (optional)</param>
        /// <param name="distinctConversations">If &#39;True&#39;, then the latest messages per every conversation ID are returned (optional)</param>
        /// <param name="messageType">The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted (optional)</param>
        /// <param name="readStatus">The read status for the resulting messages. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="phoneNumber">The phone number. If specified, messages are returned for this particular phone number only (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault6)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault6>> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGetAsyncWithHttpInfo (string accountId, string extensionId, string availability = null, long? conversationId = null, DateTime? dateFrom = null, DateTime? dateTo = null, string direction = null, bool? distinctConversations = null, string messageType = null, string readStatus = null, int? page = null, int? perPage = null, string phoneNumber = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Message Attachment
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="attachmentId">Internal identifier of a message attachment</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGetAsync (string accountId, string extensionId, int? messageId, int? attachmentId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Message Attachment
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="attachmentId">Internal identifier of a message attachment</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGetAsyncWithHttpInfo (string accountId, string extensionId, int? messageId, int? attachmentId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Delete Message by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="purge">If the value is &#39;True&#39;, then the message is purged immediately with all the attachments. The default value is &#39;False&#39; (optional)</param>
        /// <param name="conversationId">Internal identifier of a message thread (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDeleteAsync (string accountId, string extensionId, int? messageId, bool? purge = null, long? conversationId = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Delete Message by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="purge">If the value is &#39;True&#39;, then the message is purged immediately with all the attachments. The default value is &#39;False&#39; (optional)</param>
        /// <param name="conversationId">Internal identifier of a message thread (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDeleteAsyncWithHttpInfo (string accountId, string extensionId, int? messageId, bool? purge = null, long? conversationId = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Message by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <returns>Task of MessageInfo</returns>
        System.Threading.Tasks.Task<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGetAsync (string accountId, string extensionId, int? messageId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Message by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <returns>Task of ApiResponse (MessageInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageInfo>> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGetAsyncWithHttpInfo (string accountId, string extensionId, int? messageId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update Message by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of MessageInfo</returns>
        System.Threading.Tasks.Task<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPutAsync (string accountId, string extensionId, int? messageId, Body5 body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update Message by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageInfo>> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPutAsyncWithHttpInfo (string accountId, string extensionId, int? messageId, Body5 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Phone Numbers
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="usageType">Usage type of the phone number (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of InlineResponseDefault7</returns>
        System.Threading.Tasks.Task<InlineResponseDefault7> RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGetAsync (string accountId, string extensionId, string usageType = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Phone Numbers
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="usageType">Usage type of the phone number (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault7)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault7>> RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGetAsyncWithHttpInfo (string accountId, string extensionId, string usageType = null, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Presence
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <returns>Task of PresenceInfo</returns>
        System.Threading.Tasks.Task<PresenceInfo> RestapiV10AccountAccountIdExtensionExtensionIdPresenceGetAsync (string accountId, string extensionId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension Presence
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <returns>Task of ApiResponse (PresenceInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<PresenceInfo>> RestapiV10AccountAccountIdExtensionExtensionIdPresenceGetAsyncWithHttpInfo (string accountId, string extensionId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Initiate RingOut Call
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of RingOutInfo</returns>
        System.Threading.Tasks.Task<RingOutInfo> RestapiV10AccountAccountIdExtensionExtensionIdRingoutPostAsync (string accountId, string extensionId, Body6 body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Initiate RingOut Call
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (RingOutInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<RingOutInfo>> RestapiV10AccountAccountIdExtensionExtensionIdRingoutPostAsyncWithHttpInfo (string accountId, string extensionId, Body6 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Cancel RingOut Call
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="ringoutId">Internal identifier of a RingOut call</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDeleteAsync (string accountId, string extensionId, int? ringoutId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Cancel RingOut Call
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="ringoutId">Internal identifier of a RingOut call</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDeleteAsyncWithHttpInfo (string accountId, string extensionId, int? ringoutId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get RingOut Call Status
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="ringoutId">Internal identifier of a RingOut call</param>
        /// <returns>Task of RingOutInfo</returns>
        System.Threading.Tasks.Task<RingOutInfo> RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGetAsync (string accountId, string extensionId, int? ringoutId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get RingOut Call Status
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="ringoutId">Internal identifier of a RingOut call</param>
        /// <returns>Task of ApiResponse (RingOutInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<RingOutInfo>> RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGetAsyncWithHttpInfo (string accountId, string extensionId, int? ringoutId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create and Send SMS Message
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of MessageInfo</returns>
        System.Threading.Tasks.Task<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdSmsPostAsync (string accountId, string extensionId, Body7 body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create and Send SMS Message
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageInfo>> RestapiV10AccountAccountIdExtensionExtensionIdSmsPostAsyncWithHttpInfo (string accountId, string extensionId, Body7 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <param name="status">Extension current state. Multiple values are supported. If &#39;Unassigned&#39; is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned (optional)</param>
        /// <param name="type">Extension type. Multiple values are supported (optional)</param>
        /// <returns>Task of InlineResponseDefault4</returns>
        System.Threading.Tasks.Task<InlineResponseDefault4> RestapiV10AccountAccountIdExtensionGetAsync (string accountId, int? page = null, int? perPage = null, string status = null, string type = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Extension List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <param name="status">Extension current state. Multiple values are supported. If &#39;Unassigned&#39; is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned (optional)</param>
        /// <param name="type">Extension type. Multiple values are supported (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault4)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault4>> RestapiV10AccountAccountIdExtensionGetAsyncWithHttpInfo (string accountId, int? page = null, int? perPage = null, string status = null, string type = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Info by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <returns>Task of AccountInfo</returns>
        System.Threading.Tasks.Task<AccountInfo> RestapiV10AccountAccountIdGetAsync (string accountId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Info by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <returns>Task of ApiResponse (AccountInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountInfo>> RestapiV10AccountAccountIdGetAsyncWithHttpInfo (string accountId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Phone Numbers
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="usageType">Usage type of the phone number (optional)</param>
        /// <returns>Task of InlineResponseDefault8</returns>
        System.Threading.Tasks.Task<InlineResponseDefault8> RestapiV10AccountAccountIdPhoneNumberGetAsync (string accountId, int? page = null, int? perPage = null, string usageType = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Account Phone Numbers
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="usageType">Usage type of the phone number (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault8)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault8>> RestapiV10AccountAccountIdPhoneNumberGetAsyncWithHttpInfo (string accountId, int? page = null, int? perPage = null, string usageType = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Phone Number by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="phoneNumberId">Internal identifier of a phone number</param>
        /// <returns>Task of PhoneNumberInfo</returns>
        System.Threading.Tasks.Task<PhoneNumberInfo> RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGetAsync (string accountId, int? phoneNumberId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Phone Number by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="phoneNumberId">Internal identifier of a phone number</param>
        /// <returns>Task of ApiResponse (PhoneNumberInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneNumberInfo>> RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGetAsyncWithHttpInfo (string accountId, int? phoneNumberId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Call Recording Content
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> RestapiV10AccountAccountIdRecordingRecordingIdContentGetAsync (string accountId, int? recordingId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Call Recording Content
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> RestapiV10AccountAccountIdRecordingRecordingIdContentGetAsyncWithHttpInfo (string accountId, int? recordingId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Call Recording Metadata
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param>
        /// <returns>Task of InlineResponseDefault9</returns>
        System.Threading.Tasks.Task<InlineResponseDefault9> RestapiV10AccountAccountIdRecordingRecordingIdGetAsync (string accountId, int? recordingId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Call Recording Metadata
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault9)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault9>> RestapiV10AccountAccountIdRecordingRecordingIdGetAsyncWithHttpInfo (string accountId, int? recordingId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Country by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country</param>
        /// <returns>Task of FullCountryInfo</returns>
        System.Threading.Tasks.Task<FullCountryInfo> RestapiV10DictionaryCountryCountryIdGetAsync (int? countryId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Country by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country</param>
        /// <returns>Task of ApiResponse (FullCountryInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<FullCountryInfo>> RestapiV10DictionaryCountryCountryIdGetAsyncWithHttpInfo (int? countryId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Country List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginAllowed">Specifies whether login with the phone numbers of this country is enabled or not (optional)</param>
        /// <param name="numberSelling">Specifies if RingCentral sells phone numbers of this country (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of InlineResponseDefault10</returns>
        System.Threading.Tasks.Task<InlineResponseDefault10> RestapiV10DictionaryCountryGetAsync (bool? loginAllowed = null, bool? numberSelling = null, int? page = null, int? perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Country List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginAllowed">Specifies whether login with the phone numbers of this country is enabled or not (optional)</param>
        /// <param name="numberSelling">Specifies if RingCentral sells phone numbers of this country (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault10)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault10>> RestapiV10DictionaryCountryGetAsyncWithHttpInfo (bool? loginAllowed = null, bool? numberSelling = null, int? page = null, int? perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Supported Language List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponseDefault11</returns>
        System.Threading.Tasks.Task<InlineResponseDefault11> RestapiV10DictionaryLanguageGetAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Supported Language List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponseDefault11)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault11>> RestapiV10DictionaryLanguageGetAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Language by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Internal identifier of a language</param>
        /// <returns>Task of LanguageInfo</returns>
        System.Threading.Tasks.Task<LanguageInfo> RestapiV10DictionaryLanguageLanguageIdGetAsync (int? languageId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Language by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Internal identifier of a language</param>
        /// <returns>Task of ApiResponse (LanguageInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<LanguageInfo>> RestapiV10DictionaryLanguageLanguageIdGetAsyncWithHttpInfo (int? languageId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Location List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Sorts results by the specified property. The default value is &#39;City&#39; (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <param name="stateId">Internal identifier of a state (optional)</param>
        /// <param name="withNxx">Specifies if nxx codes are returned (optional)</param>
        /// <returns>Task of InlineResponseDefault12</returns>
        System.Threading.Tasks.Task<InlineResponseDefault12> RestapiV10DictionaryLocationGetAsync (string orderBy = null, int? page = null, int? perPage = null, string stateId = null, bool? withNxx = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Location List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Sorts results by the specified property. The default value is &#39;City&#39; (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <param name="stateId">Internal identifier of a state (optional)</param>
        /// <param name="withNxx">Specifies if nxx codes are returned (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault12)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault12>> RestapiV10DictionaryLocationGetAsyncWithHttpInfo (string orderBy = null, int? page = null, int? perPage = null, string stateId = null, bool? withNxx = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get State/Province List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="withPhoneNumbers">If &#39;True&#39;, the list of states with phone numbers available for buying is returned. The default value is &#39;False&#39; (optional)</param>
        /// <returns>Task of InlineResponseDefault13</returns>
        System.Threading.Tasks.Task<InlineResponseDefault13> RestapiV10DictionaryStateGetAsync (int? countryId = null, int? page = null, int? perPage = null, bool? withPhoneNumbers = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get State/Province List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="withPhoneNumbers">If &#39;True&#39;, the list of states with phone numbers available for buying is returned. The default value is &#39;False&#39; (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault13)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault13>> RestapiV10DictionaryStateGetAsyncWithHttpInfo (int? countryId = null, int? page = null, int? perPage = null, bool? withPhoneNumbers = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get State/Province by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stateId">Internal identifier of a state</param>
        /// <returns>Task of StateInfo</returns>
        System.Threading.Tasks.Task<StateInfo> RestapiV10DictionaryStateStateIdGetAsync (int? stateId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get State/Province by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stateId">Internal identifier of a state</param>
        /// <returns>Task of ApiResponse (StateInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<StateInfo>> RestapiV10DictionaryStateStateIdGetAsyncWithHttpInfo (int? stateId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Time Zone List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of InlineResponseDefault14</returns>
        System.Threading.Tasks.Task<InlineResponseDefault14> RestapiV10DictionaryTimezoneGetAsync (string page = null, string perPage = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Time Zone List
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault14)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault14>> RestapiV10DictionaryTimezoneGetAsyncWithHttpInfo (string page = null, string perPage = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Time Zone by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timezoneId">Internal identifier of a timezone</param>
        /// <returns>Task of TimezoneInfo</returns>
        System.Threading.Tasks.Task<TimezoneInfo> RestapiV10DictionaryTimezoneTimezoneIdGetAsync (int? timezoneId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Time Zone by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timezoneId">Internal identifier of a timezone</param>
        /// <returns>Task of ApiResponse (TimezoneInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimezoneInfo>> RestapiV10DictionaryTimezoneTimezoneIdGetAsyncWithHttpInfo (int? timezoneId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get API Version Info
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VersionInfo</returns>
        System.Threading.Tasks.Task<VersionInfo> RestapiV10GetAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get API Version Info
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VersionInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionInfo>> RestapiV10GetAsyncWithHttpInfo ();
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create New Subscription
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload in the &#39;presenceStatus&#39; field (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SubscriptionInfo</returns>
        System.Threading.Tasks.Task<SubscriptionInfo> RestapiV10SubscriptionPostAsync (bool? aggregated = null, Body8 body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Create New Subscription
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload in the &#39;presenceStatus&#39; field (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SubscriptionInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionInfo>> RestapiV10SubscriptionPostAsyncWithHttpInfo (bool? aggregated = null, Body8 body = null);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Cancel Subscription by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RestapiV10SubscriptionSubscriptionIdDeleteAsync (string subscriptionId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Cancel Subscription by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RestapiV10SubscriptionSubscriptionIdDeleteAsyncWithHttpInfo (string subscriptionId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Subscription by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <returns>Task of SubscriptionInfo</returns>
        System.Threading.Tasks.Task<SubscriptionInfo> RestapiV10SubscriptionSubscriptionIdGetAsync (string subscriptionId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Subscription by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <returns>Task of ApiResponse (SubscriptionInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionInfo>> RestapiV10SubscriptionSubscriptionIdGetAsyncWithHttpInfo (string subscriptionId);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update/Renew Subscription by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SubscriptionInfo</returns>
        System.Threading.Tasks.Task<SubscriptionInfo> RestapiV10SubscriptionSubscriptionIdPutAsync (string subscriptionId, bool? aggregated = null, Body9 body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Update/Renew Subscription by ID
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SubscriptionInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<SubscriptionInfo>> RestapiV10SubscriptionSubscriptionIdPutAsyncWithHttpInfo (string subscriptionId, bool? aggregated = null, Body9 body = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        ///  Get Server Info
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ServerInfo</returns>
        public ServerInfo RestapiGet ()
        {
             ApiResponse<ServerInfo> localVarResponse = RestapiGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Server Info
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ServerInfo</returns>
        public ApiResponse< ServerInfo > RestapiGetWithHttpInfo ()
        {
            
    
            var localVarPath = "/restapi";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ServerInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerInfo)));
            
        }

        
        /// <summary>
        ///  Get Server Info
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ServerInfo</returns>
        public async System.Threading.Tasks.Task<ServerInfo> RestapiGetAsync ()
        {
             ApiResponse<ServerInfo> localVarResponse = await RestapiGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Server Info
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (ServerInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServerInfo>> RestapiGetAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/restapi";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ServerInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServerInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServerInfo)));
            
        }
        
        /// <summary>
        ///  OAuth2 Authorize
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param> 
        /// <returns>InlineResponseDefault</returns>
        public InlineResponseDefault RestapiOauthAuthorizePost (Body body = null)
        {
             ApiResponse<InlineResponseDefault> localVarResponse = RestapiOauthAuthorizePostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  OAuth2 Authorize
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault</returns>
        public ApiResponse< InlineResponseDefault > RestapiOauthAuthorizePostWithHttpInfo (Body body = null)
        {
            
    
            var localVarPath = "/restapi/oauth/authorize";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiOauthAuthorizePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiOauthAuthorizePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault)));
            
        }

        
        /// <summary>
        ///  OAuth2 Authorize
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of InlineResponseDefault</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault> RestapiOauthAuthorizePostAsync (Body body = null)
        {
             ApiResponse<InlineResponseDefault> localVarResponse = await RestapiOauthAuthorizePostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  OAuth2 Authorize
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault>> RestapiOauthAuthorizePostAsyncWithHttpInfo (Body body = null)
        {
            
    
            var localVarPath = "/restapi/oauth/authorize";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiOauthAuthorizePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiOauthAuthorizePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault)));
            
        }
        
        /// <summary>
        ///  OAuth2 Revoke Token
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param> 
        /// <returns></returns>
        public void RestapiOauthRevokePost (Body1 body = null)
        {
             RestapiOauthRevokePostWithHttpInfo(body);
        }

        /// <summary>
        ///  OAuth2 Revoke Token
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RestapiOauthRevokePostWithHttpInfo (Body1 body = null)
        {
            
    
            var localVarPath = "/restapi/oauth/revoke";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiOauthRevokePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiOauthRevokePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  OAuth2 Revoke Token
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RestapiOauthRevokePostAsync (Body1 body = null)
        {
             await RestapiOauthRevokePostAsyncWithHttpInfo(body);

        }

        /// <summary>
        ///  OAuth2 Revoke Token
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RestapiOauthRevokePostAsyncWithHttpInfo (Body1 body = null)
        {
            
    
            var localVarPath = "/restapi/oauth/revoke";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiOauthRevokePost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiOauthRevokePost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  OAuth2 Get Token
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param> 
        /// <returns>InlineResponseDefault1</returns>
        public InlineResponseDefault1 RestapiOauthTokenPost (Body2 body = null)
        {
             ApiResponse<InlineResponseDefault1> localVarResponse = RestapiOauthTokenPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  OAuth2 Get Token
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault1</returns>
        public ApiResponse< InlineResponseDefault1 > RestapiOauthTokenPostWithHttpInfo (Body2 body = null)
        {
            
    
            var localVarPath = "/restapi/oauth/token";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiOauthTokenPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiOauthTokenPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault1) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault1)));
            
        }

        
        /// <summary>
        ///  OAuth2 Get Token
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of InlineResponseDefault1</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault1> RestapiOauthTokenPostAsync (Body2 body = null)
        {
             ApiResponse<InlineResponseDefault1> localVarResponse = await RestapiOauthTokenPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  OAuth2 Get Token
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault1>> RestapiOauthTokenPostAsyncWithHttpInfo (Body2 body = null)
        {
            
    
            var localVarPath = "/restapi/oauth/token";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiOauthTokenPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiOauthTokenPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault1) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault1)));
            
        }
        
        /// <summary>
        ///  Get Account Active (Recent) Calls
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param> 
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param> 
        /// <returns>InlineResponseDefault2</returns>
        public InlineResponseDefault2 RestapiV10AccountAccountIdActiveCallsGet (string accountId, string direction = null, string type = null, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault2> localVarResponse = RestapiV10AccountAccountIdActiveCallsGetWithHttpInfo(accountId, direction, type, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Account Active (Recent) Calls
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param> 
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault2</returns>
        public ApiResponse< InlineResponseDefault2 > RestapiV10AccountAccountIdActiveCallsGetWithHttpInfo (string accountId, string direction = null, string type = null, int? page = null, int? perPage = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdActiveCallsGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/active-calls";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            if (direction != null) localVarQueryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdActiveCallsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdActiveCallsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault2) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault2)));
            
        }

        
        /// <summary>
        ///  Get Account Active (Recent) Calls
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <returns>Task of InlineResponseDefault2</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault2> RestapiV10AccountAccountIdActiveCallsGetAsync (string accountId, string direction = null, string type = null, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault2> localVarResponse = await RestapiV10AccountAccountIdActiveCallsGetAsyncWithHttpInfo(accountId, direction, type, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Account Active (Recent) Calls
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault2)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault2>> RestapiV10AccountAccountIdActiveCallsGetAsyncWithHttpInfo (string accountId, string direction = null, string type = null, int? page = null, int? perPage = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdActiveCallsGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/active-calls";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            if (direction != null) localVarQueryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdActiveCallsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdActiveCallsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault2) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault2)));
            
        }
        
        /// <summary>
        ///  Get Company Business Address
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <returns>InlineResponseDefault3</returns>
        public InlineResponseDefault3 RestapiV10AccountAccountIdBusinessAddressGet (string accountId)
        {
             ApiResponse<InlineResponseDefault3> localVarResponse = RestapiV10AccountAccountIdBusinessAddressGetWithHttpInfo(accountId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Company Business Address
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <returns>ApiResponse of InlineResponseDefault3</returns>
        public ApiResponse< InlineResponseDefault3 > RestapiV10AccountAccountIdBusinessAddressGetWithHttpInfo (string accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdBusinessAddressGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/business-address";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdBusinessAddressGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdBusinessAddressGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault3>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault3) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault3)));
            
        }

        
        /// <summary>
        ///  Get Company Business Address
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <returns>Task of InlineResponseDefault3</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault3> RestapiV10AccountAccountIdBusinessAddressGetAsync (string accountId)
        {
             ApiResponse<InlineResponseDefault3> localVarResponse = await RestapiV10AccountAccountIdBusinessAddressGetAsyncWithHttpInfo(accountId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Company Business Address
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault3)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault3>> RestapiV10AccountAccountIdBusinessAddressGetAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdBusinessAddressGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/business-address";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdBusinessAddressGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdBusinessAddressGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault3>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault3) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault3)));
            
        }
        
        /// <summary>
        ///  Get Account Call Log Record by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="callLogId">Internal identifier of a call log record</param> 
        /// <returns>CallLogInfo</returns>
        public CallLogInfo RestapiV10AccountAccountIdCallLogCallLogIdGet (string accountId, int? callLogId)
        {
             ApiResponse<CallLogInfo> localVarResponse = RestapiV10AccountAccountIdCallLogCallLogIdGetWithHttpInfo(accountId, callLogId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Account Call Log Record by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="callLogId">Internal identifier of a call log record</param> 
        /// <returns>ApiResponse of CallLogInfo</returns>
        public ApiResponse< CallLogInfo > RestapiV10AccountAccountIdCallLogCallLogIdGetWithHttpInfo (string accountId, int? callLogId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdCallLogCallLogIdGet");
            
            // verify the required parameter 'callLogId' is set
            if (callLogId == null)
                throw new ApiException(400, "Missing required parameter 'callLogId' when calling DefaultApi->RestapiV10AccountAccountIdCallLogCallLogIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/call-log/{callLogId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (callLogId != null) localVarPathParams.Add("callLogId", Configuration.ApiClient.ParameterToString(callLogId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdCallLogCallLogIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdCallLogCallLogIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CallLogInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallLogInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallLogInfo)));
            
        }

        
        /// <summary>
        ///  Get Account Call Log Record by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="callLogId">Internal identifier of a call log record</param>
        /// <returns>Task of CallLogInfo</returns>
        public async System.Threading.Tasks.Task<CallLogInfo> RestapiV10AccountAccountIdCallLogCallLogIdGetAsync (string accountId, int? callLogId)
        {
             ApiResponse<CallLogInfo> localVarResponse = await RestapiV10AccountAccountIdCallLogCallLogIdGetAsyncWithHttpInfo(accountId, callLogId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Account Call Log Record by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="callLogId">Internal identifier of a call log record</param>
        /// <returns>Task of ApiResponse (CallLogInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallLogInfo>> RestapiV10AccountAccountIdCallLogCallLogIdGetAsyncWithHttpInfo (string accountId, int? callLogId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdCallLogCallLogIdGet");
            // verify the required parameter 'callLogId' is set
            if (callLogId == null) throw new ApiException(400, "Missing required parameter 'callLogId' when calling RestapiV10AccountAccountIdCallLogCallLogIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/call-log/{callLogId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (callLogId != null) localVarPathParams.Add("callLogId", Configuration.ApiClient.ParameterToString(callLogId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdCallLogCallLogIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdCallLogCallLogIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallLogInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallLogInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallLogInfo)));
            
        }
        
        /// <summary>
        ///  Get Account Call Log
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param> 
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param> 
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param> 
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param> 
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param> 
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param> 
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param> 
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. The default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param> 
        /// <returns>InlineResponseDefault2</returns>
        public InlineResponseDefault2 RestapiV10AccountAccountIdCallLogGet (string accountId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault2> localVarResponse = RestapiV10AccountAccountIdCallLogGetWithHttpInfo(accountId, extensionNumber, phoneNumber, direction, type, view, withRecording, dateFrom, dateTo, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Account Call Log
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param> 
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param> 
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param> 
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param> 
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param> 
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param> 
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param> 
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. The default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault2</returns>
        public ApiResponse< InlineResponseDefault2 > RestapiV10AccountAccountIdCallLogGetWithHttpInfo (string accountId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? page = null, int? perPage = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdCallLogGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/call-log";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            if (extensionNumber != null) localVarQueryParams.Add("extensionNumber", Configuration.ApiClient.ParameterToString(extensionNumber)); // query parameter
            if (phoneNumber != null) localVarQueryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            if (direction != null) localVarQueryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (view != null) localVarQueryParams.Add("view", Configuration.ApiClient.ParameterToString(view)); // query parameter
            if (withRecording != null) localVarQueryParams.Add("withRecording", Configuration.ApiClient.ParameterToString(withRecording)); // query parameter
            if (dateFrom != null) localVarQueryParams.Add("dateFrom", Configuration.ApiClient.ParameterToString(dateFrom)); // query parameter
            if (dateTo != null) localVarQueryParams.Add("dateTo", Configuration.ApiClient.ParameterToString(dateTo)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdCallLogGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdCallLogGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault2) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault2)));
            
        }

        
        /// <summary>
        ///  Get Account Call Log
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param>
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param>
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. The default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <returns>Task of InlineResponseDefault2</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault2> RestapiV10AccountAccountIdCallLogGetAsync (string accountId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault2> localVarResponse = await RestapiV10AccountAccountIdCallLogGetAsyncWithHttpInfo(accountId, extensionNumber, phoneNumber, direction, type, view, withRecording, dateFrom, dateTo, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Account Call Log
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param>
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param>
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. The default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault2)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault2>> RestapiV10AccountAccountIdCallLogGetAsyncWithHttpInfo (string accountId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateFrom = null, DateTime? dateTo = null, int? page = null, int? perPage = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdCallLogGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/call-log";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            if (extensionNumber != null) localVarQueryParams.Add("extensionNumber", Configuration.ApiClient.ParameterToString(extensionNumber)); // query parameter
            if (phoneNumber != null) localVarQueryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            if (direction != null) localVarQueryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (view != null) localVarQueryParams.Add("view", Configuration.ApiClient.ParameterToString(view)); // query parameter
            if (withRecording != null) localVarQueryParams.Add("withRecording", Configuration.ApiClient.ParameterToString(withRecording)); // query parameter
            if (dateFrom != null) localVarQueryParams.Add("dateFrom", Configuration.ApiClient.ParameterToString(dateFrom)); // query parameter
            if (dateTo != null) localVarQueryParams.Add("dateTo", Configuration.ApiClient.ParameterToString(dateTo)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdCallLogGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdCallLogGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault2) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault2)));
            
        }
        
        /// <summary>
        ///  Get Extension Active (Recent) Calls
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param> 
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <returns>InlineResponseDefault2</returns>
        public InlineResponseDefault2 RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet (string accountId, string extensionId, string direction = null, string type = null, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault2> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGetWithHttpInfo(accountId, extensionId, direction, type, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Extension Active (Recent) Calls
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param> 
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault2</returns>
        public ApiResponse< InlineResponseDefault2 > RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGetWithHttpInfo (string accountId, string extensionId, string direction = null, string type = null, int? page = null, int? perPage = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            if (direction != null) localVarQueryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault2) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault2)));
            
        }

        
        /// <summary>
        ///  Get Extension Active (Recent) Calls
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of InlineResponseDefault2</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault2> RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGetAsync (string accountId, string extensionId, string direction = null, string type = null, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault2> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGetAsyncWithHttpInfo(accountId, extensionId, direction, type, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Extension Active (Recent) Calls
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault2)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault2>> RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGetAsyncWithHttpInfo (string accountId, string extensionId, string direction = null, string type = null, int? page = null, int? perPage = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            if (direction != null) localVarQueryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdActiveCallsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault2) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault2)));
            
        }
        
        /// <summary>
        ///  Get Extension Call Log Record by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="callLogId">Internal identifier of a call log record</param> 
        /// <returns>CallLogInfo</returns>
        public CallLogInfo RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet (string accountId, string extensionId, int? callLogId)
        {
             ApiResponse<CallLogInfo> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGetWithHttpInfo(accountId, extensionId, callLogId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Extension Call Log Record by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="callLogId">Internal identifier of a call log record</param> 
        /// <returns>ApiResponse of CallLogInfo</returns>
        public ApiResponse< CallLogInfo > RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGetWithHttpInfo (string accountId, string extensionId, int? callLogId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet");
            
            // verify the required parameter 'callLogId' is set
            if (callLogId == null)
                throw new ApiException(400, "Missing required parameter 'callLogId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callLogId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (callLogId != null) localVarPathParams.Add("callLogId", Configuration.ApiClient.ParameterToString(callLogId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CallLogInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallLogInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallLogInfo)));
            
        }

        
        /// <summary>
        ///  Get Extension Call Log Record by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="callLogId">Internal identifier of a call log record</param>
        /// <returns>Task of CallLogInfo</returns>
        public async System.Threading.Tasks.Task<CallLogInfo> RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGetAsync (string accountId, string extensionId, int? callLogId)
        {
             ApiResponse<CallLogInfo> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGetAsyncWithHttpInfo(accountId, extensionId, callLogId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Extension Call Log Record by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="callLogId">Internal identifier of a call log record</param>
        /// <returns>Task of ApiResponse (CallLogInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CallLogInfo>> RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGetAsyncWithHttpInfo (string accountId, string extensionId, int? callLogId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet");
            // verify the required parameter 'callLogId' is set
            if (callLogId == null) throw new ApiException(400, "Missing required parameter 'callLogId' when calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callLogId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (callLogId != null) localVarPathParams.Add("callLogId", Configuration.ApiClient.ParameterToString(callLogId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogCallLogIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CallLogInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CallLogInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CallLogInfo)));
            
        }
        
        /// <summary>
        ///  Get Extension Call Log
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param> 
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param> 
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param> 
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param> 
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param> 
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param> 
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param> 
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <returns>InlineResponseDefault2</returns>
        public InlineResponseDefault2 RestapiV10AccountAccountIdExtensionExtensionIdCallLogGet (string accountId, string extensionId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateTo = null, DateTime? dateFrom = null, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault2> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdCallLogGetWithHttpInfo(accountId, extensionId, extensionNumber, phoneNumber, direction, type, view, withRecording, dateTo, dateFrom, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Extension Call Log
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param> 
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param> 
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param> 
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param> 
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param> 
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param> 
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param> 
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault2</returns>
        public ApiResponse< InlineResponseDefault2 > RestapiV10AccountAccountIdExtensionExtensionIdCallLogGetWithHttpInfo (string accountId, string extensionId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateTo = null, DateTime? dateFrom = null, int? page = null, int? perPage = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdCallLogGet");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdCallLogGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            if (extensionNumber != null) localVarQueryParams.Add("extensionNumber", Configuration.ApiClient.ParameterToString(extensionNumber)); // query parameter
            if (phoneNumber != null) localVarQueryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            if (direction != null) localVarQueryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (view != null) localVarQueryParams.Add("view", Configuration.ApiClient.ParameterToString(view)); // query parameter
            if (withRecording != null) localVarQueryParams.Add("withRecording", Configuration.ApiClient.ParameterToString(withRecording)); // query parameter
            if (dateTo != null) localVarQueryParams.Add("dateTo", Configuration.ApiClient.ParameterToString(dateTo)); // query parameter
            if (dateFrom != null) localVarQueryParams.Add("dateFrom", Configuration.ApiClient.ParameterToString(dateFrom)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault2) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault2)));
            
        }

        
        /// <summary>
        ///  Get Extension Call Log
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param>
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param>
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param>
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of InlineResponseDefault2</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault2> RestapiV10AccountAccountIdExtensionExtensionIdCallLogGetAsync (string accountId, string extensionId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateTo = null, DateTime? dateFrom = null, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault2> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdCallLogGetAsyncWithHttpInfo(accountId, extensionId, extensionNumber, phoneNumber, direction, type, view, withRecording, dateTo, dateFrom, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Extension Call Log
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="extensionNumber">Extension number of a user. If specified, returns call log for a particular extension only. Cannot be specified together with the phoneNumber filter (optional)</param>
        /// <param name="phoneNumber">Phone number of a caller/call recipient. If specified, returns all calls (both incoming and outcoming) with the mentioned phone number. Cannot be specified together with the extensionNumber filter (optional)</param>
        /// <param name="direction">The direction for the result records. It is allowed to specify more than one direction. If not specified, both inbound and outbound records are returned. Multiple values are accepted (optional)</param>
        /// <param name="type">Call type of a record. It is allowed to specify more than one type. If not specified, all call types are returned. Multiple values are accepted (optional)</param>
        /// <param name="view">The default value is &#39;Simple&#39; for both account and extension call log (optional)</param>
        /// <param name="withRecording">&#39;True&#39; if only recorded calls have to be returned (optional)</param>
        /// <param name="dateTo">The end datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting records in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault2)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault2>> RestapiV10AccountAccountIdExtensionExtensionIdCallLogGetAsyncWithHttpInfo (string accountId, string extensionId, string extensionNumber = null, string phoneNumber = null, string direction = null, string type = null, string view = null, bool? withRecording = null, DateTime? dateTo = null, DateTime? dateFrom = null, int? page = null, int? perPage = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogGet");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            if (extensionNumber != null) localVarQueryParams.Add("extensionNumber", Configuration.ApiClient.ParameterToString(extensionNumber)); // query parameter
            if (phoneNumber != null) localVarQueryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            if (direction != null) localVarQueryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            if (view != null) localVarQueryParams.Add("view", Configuration.ApiClient.ParameterToString(view)); // query parameter
            if (withRecording != null) localVarQueryParams.Add("withRecording", Configuration.ApiClient.ParameterToString(withRecording)); // query parameter
            if (dateTo != null) localVarQueryParams.Add("dateTo", Configuration.ApiClient.ParameterToString(dateTo)); // query parameter
            if (dateFrom != null) localVarQueryParams.Add("dateFrom", Configuration.ApiClient.ParameterToString(dateFrom)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdCallLogGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault2) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault2)));
            
        }
        
        /// <summary>
        ///  Create and Send Pager Message
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>MessageInfo</returns>
        public MessageInfo RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost (string accountId, string extensionId, Body3 body = null)
        {
             ApiResponse<MessageInfo> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPostWithHttpInfo(accountId, extensionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Create and Send Pager Message
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of MessageInfo</returns>
        public ApiResponse< MessageInfo > RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPostWithHttpInfo (string accountId, string extensionId, Body3 body = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MessageInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageInfo)));
            
        }

        
        /// <summary>
        ///  Create and Send Pager Message
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of MessageInfo</returns>
        public async System.Threading.Tasks.Task<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPostAsync (string accountId, string extensionId, Body3 body = null)
        {
             ApiResponse<MessageInfo> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPostAsyncWithHttpInfo(accountId, extensionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Create and Send Pager Message
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageInfo>> RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPostAsyncWithHttpInfo (string accountId, string extensionId, Body3 body = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdCompanyPagerPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageInfo)));
            
        }
        
        /// <summary>
        ///  Create and Send Fax Message
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>MessageInfo</returns>
        public MessageInfo RestapiV10AccountAccountIdExtensionExtensionIdFaxPost (string accountId, string extensionId, Body4 body = null)
        {
             ApiResponse<MessageInfo> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdFaxPostWithHttpInfo(accountId, extensionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Create and Send Fax Message
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of MessageInfo</returns>
        public ApiResponse< MessageInfo > RestapiV10AccountAccountIdExtensionExtensionIdFaxPostWithHttpInfo (string accountId, string extensionId, Body4 body = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdFaxPost");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdFaxPost");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/fax";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdFaxPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdFaxPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MessageInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageInfo)));
            
        }

        
        /// <summary>
        ///  Create and Send Fax Message
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of MessageInfo</returns>
        public async System.Threading.Tasks.Task<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdFaxPostAsync (string accountId, string extensionId, Body4 body = null)
        {
             ApiResponse<MessageInfo> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdFaxPostAsyncWithHttpInfo(accountId, extensionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Create and Send Fax Message
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageInfo>> RestapiV10AccountAccountIdExtensionExtensionIdFaxPostAsyncWithHttpInfo (string accountId, string extensionId, Body4 body = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdFaxPost");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdFaxPost");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/fax";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdFaxPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdFaxPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageInfo)));
            
        }
        
        /// <summary>
        ///  Get Forwarding Numbers
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <returns>InlineResponseDefault5</returns>
        public InlineResponseDefault5 RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet (string accountId, string extensionId, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault5> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGetWithHttpInfo(accountId, extensionId, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Forwarding Numbers
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault5</returns>
        public ApiResponse< InlineResponseDefault5 > RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGetWithHttpInfo (string accountId, string extensionId, int? page = null, int? perPage = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault5>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault5) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault5)));
            
        }

        
        /// <summary>
        ///  Get Forwarding Numbers
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of InlineResponseDefault5</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault5> RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGetAsync (string accountId, string extensionId, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault5> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGetAsyncWithHttpInfo(accountId, extensionId, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Forwarding Numbers
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault5)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault5>> RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGetAsyncWithHttpInfo (string accountId, string extensionId, int? page = null, int? perPage = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdForwardingNumberGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault5>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault5) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault5)));
            
        }
        
        /// <summary>
        ///  Get Extension Info by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <returns>ExtensionInfo</returns>
        public ExtensionInfo RestapiV10AccountAccountIdExtensionExtensionIdGet (string accountId, string extensionId)
        {
             ApiResponse<ExtensionInfo> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdGetWithHttpInfo(accountId, extensionId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Extension Info by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <returns>ApiResponse of ExtensionInfo</returns>
        public ApiResponse< ExtensionInfo > RestapiV10AccountAccountIdExtensionExtensionIdGetWithHttpInfo (string accountId, string extensionId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdGet");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ExtensionInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionInfo)));
            
        }

        
        /// <summary>
        ///  Get Extension Info by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <returns>Task of ExtensionInfo</returns>
        public async System.Threading.Tasks.Task<ExtensionInfo> RestapiV10AccountAccountIdExtensionExtensionIdGetAsync (string accountId, string extensionId)
        {
             ApiResponse<ExtensionInfo> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdGetAsyncWithHttpInfo(accountId, extensionId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Extension Info by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <returns>Task of ApiResponse (ExtensionInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ExtensionInfo>> RestapiV10AccountAccountIdExtensionExtensionIdGetAsyncWithHttpInfo (string accountId, string extensionId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdGet");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ExtensionInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ExtensionInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ExtensionInfo)));
            
        }
        
        /// <summary>
        ///  Get Message List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="availability">Specifies the availability status for the resulting messages. Default value is &#39;Alive&#39;. Multiple values are accepted (optional)</param> 
        /// <param name="conversationId">Specifies the conversation identifier for the resulting messages (optional)</param> 
        /// <param name="dateFrom">The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param> 
        /// <param name="dateTo">The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param> 
        /// <param name="direction">The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted (optional)</param> 
        /// <param name="distinctConversations">If &#39;True&#39;, then the latest messages per every conversation ID are returned (optional)</param> 
        /// <param name="messageType">The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted (optional)</param> 
        /// <param name="readStatus">The read status for the resulting messages. Multiple values are accepted (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <param name="phoneNumber">The phone number. If specified, messages are returned for this particular phone number only (optional)</param> 
        /// <returns>InlineResponseDefault6</returns>
        public InlineResponseDefault6 RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet (string accountId, string extensionId, string availability = null, long? conversationId = null, DateTime? dateFrom = null, DateTime? dateTo = null, string direction = null, bool? distinctConversations = null, string messageType = null, string readStatus = null, int? page = null, int? perPage = null, string phoneNumber = null)
        {
             ApiResponse<InlineResponseDefault6> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGetWithHttpInfo(accountId, extensionId, availability, conversationId, dateFrom, dateTo, direction, distinctConversations, messageType, readStatus, page, perPage, phoneNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Message List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="availability">Specifies the availability status for the resulting messages. Default value is &#39;Alive&#39;. Multiple values are accepted (optional)</param> 
        /// <param name="conversationId">Specifies the conversation identifier for the resulting messages (optional)</param> 
        /// <param name="dateFrom">The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param> 
        /// <param name="dateTo">The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param> 
        /// <param name="direction">The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted (optional)</param> 
        /// <param name="distinctConversations">If &#39;True&#39;, then the latest messages per every conversation ID are returned (optional)</param> 
        /// <param name="messageType">The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted (optional)</param> 
        /// <param name="readStatus">The read status for the resulting messages. Multiple values are accepted (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <param name="phoneNumber">The phone number. If specified, messages are returned for this particular phone number only (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault6</returns>
        public ApiResponse< InlineResponseDefault6 > RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGetWithHttpInfo (string accountId, string extensionId, string availability = null, long? conversationId = null, DateTime? dateFrom = null, DateTime? dateTo = null, string direction = null, bool? distinctConversations = null, string messageType = null, string readStatus = null, int? page = null, int? perPage = null, string phoneNumber = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            if (availability != null) localVarQueryParams.Add("availability", Configuration.ApiClient.ParameterToString(availability)); // query parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (dateFrom != null) localVarQueryParams.Add("dateFrom", Configuration.ApiClient.ParameterToString(dateFrom)); // query parameter
            if (dateTo != null) localVarQueryParams.Add("dateTo", Configuration.ApiClient.ParameterToString(dateTo)); // query parameter
            if (direction != null) localVarQueryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (distinctConversations != null) localVarQueryParams.Add("distinctConversations", Configuration.ApiClient.ParameterToString(distinctConversations)); // query parameter
            if (messageType != null) localVarQueryParams.Add("messageType", Configuration.ApiClient.ParameterToString(messageType)); // query parameter
            if (readStatus != null) localVarQueryParams.Add("readStatus", Configuration.ApiClient.ParameterToString(readStatus)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (phoneNumber != null) localVarQueryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault6>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault6) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault6)));
            
        }

        
        /// <summary>
        ///  Get Message List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="availability">Specifies the availability status for the resulting messages. Default value is &#39;Alive&#39;. Multiple values are accepted (optional)</param>
        /// <param name="conversationId">Specifies the conversation identifier for the resulting messages (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="dateTo">The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="direction">The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted (optional)</param>
        /// <param name="distinctConversations">If &#39;True&#39;, then the latest messages per every conversation ID are returned (optional)</param>
        /// <param name="messageType">The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted (optional)</param>
        /// <param name="readStatus">The read status for the resulting messages. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="phoneNumber">The phone number. If specified, messages are returned for this particular phone number only (optional)</param>
        /// <returns>Task of InlineResponseDefault6</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault6> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGetAsync (string accountId, string extensionId, string availability = null, long? conversationId = null, DateTime? dateFrom = null, DateTime? dateTo = null, string direction = null, bool? distinctConversations = null, string messageType = null, string readStatus = null, int? page = null, int? perPage = null, string phoneNumber = null)
        {
             ApiResponse<InlineResponseDefault6> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGetAsyncWithHttpInfo(accountId, extensionId, availability, conversationId, dateFrom, dateTo, direction, distinctConversations, messageType, readStatus, page, perPage, phoneNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Message List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="availability">Specifies the availability status for the resulting messages. Default value is &#39;Alive&#39;. Multiple values are accepted (optional)</param>
        /// <param name="conversationId">Specifies the conversation identifier for the resulting messages (optional)</param>
        /// <param name="dateFrom">The start datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is dateTo minus 24 hours (optional)</param>
        /// <param name="dateTo">The end datetime for resulting messages in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. The default value is current time (optional)</param>
        /// <param name="direction">The direction for the resulting messages. If not specified, both inbound and outbound messages are returned. Multiple values are accepted (optional)</param>
        /// <param name="distinctConversations">If &#39;True&#39;, then the latest messages per every conversation ID are returned (optional)</param>
        /// <param name="messageType">The type of the resulting messages. If not specified, all messages without message type filtering are returned. Multiple values are accepted (optional)</param>
        /// <param name="readStatus">The read status for the resulting messages. Multiple values are accepted (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="phoneNumber">The phone number. If specified, messages are returned for this particular phone number only (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault6)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault6>> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGetAsyncWithHttpInfo (string accountId, string extensionId, string availability = null, long? conversationId = null, DateTime? dateFrom = null, DateTime? dateTo = null, string direction = null, bool? distinctConversations = null, string messageType = null, string readStatus = null, int? page = null, int? perPage = null, string phoneNumber = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            if (availability != null) localVarQueryParams.Add("availability", Configuration.ApiClient.ParameterToString(availability)); // query parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (dateFrom != null) localVarQueryParams.Add("dateFrom", Configuration.ApiClient.ParameterToString(dateFrom)); // query parameter
            if (dateTo != null) localVarQueryParams.Add("dateTo", Configuration.ApiClient.ParameterToString(dateTo)); // query parameter
            if (direction != null) localVarQueryParams.Add("direction", Configuration.ApiClient.ParameterToString(direction)); // query parameter
            if (distinctConversations != null) localVarQueryParams.Add("distinctConversations", Configuration.ApiClient.ParameterToString(distinctConversations)); // query parameter
            if (messageType != null) localVarQueryParams.Add("messageType", Configuration.ApiClient.ParameterToString(messageType)); // query parameter
            if (readStatus != null) localVarQueryParams.Add("readStatus", Configuration.ApiClient.ParameterToString(readStatus)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (phoneNumber != null) localVarQueryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault6>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault6) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault6)));
            
        }
        
        /// <summary>
        ///  Get Message Attachment
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="messageId">Internal identifier of a message</param> 
        /// <param name="attachmentId">Internal identifier of a message attachment</param> 
        /// <returns>byte[]</returns>
        public byte[] RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet (string accountId, string extensionId, int? messageId, int? attachmentId)
        {
             ApiResponse<byte[]> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGetWithHttpInfo(accountId, extensionId, messageId, attachmentId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Message Attachment
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="messageId">Internal identifier of a message</param> 
        /// <param name="attachmentId">Internal identifier of a message attachment</param> 
        /// <returns>ApiResponse of byte[]</returns>
        public ApiResponse< byte[] > RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGetWithHttpInfo (string accountId, string extensionId, int? messageId, int? attachmentId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet");
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet");
            
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null)
                throw new ApiException(400, "Missing required parameter 'attachmentId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            if (attachmentId != null) localVarPathParams.Add("attachmentId", Configuration.ApiClient.ParameterToString(attachmentId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
            
        }

        
        /// <summary>
        ///  Get Message Attachment
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="attachmentId">Internal identifier of a message attachment</param>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGetAsync (string accountId, string extensionId, int? messageId, int? attachmentId)
        {
             ApiResponse<byte[]> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGetAsyncWithHttpInfo(accountId, extensionId, messageId, attachmentId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Message Attachment
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="attachmentId">Internal identifier of a message attachment</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<ApiResponse<byte[]>> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGetAsyncWithHttpInfo (string accountId, string extensionId, int? messageId, int? attachmentId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet");
            // verify the required parameter 'messageId' is set
            if (messageId == null) throw new ApiException(400, "Missing required parameter 'messageId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet");
            // verify the required parameter 'attachmentId' is set
            if (attachmentId == null) throw new ApiException(400, "Missing required parameter 'attachmentId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            if (attachmentId != null) localVarPathParams.Add("attachmentId", Configuration.ApiClient.ParameterToString(attachmentId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdContentAttachmentIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
            
        }
        
        /// <summary>
        ///  Delete Message by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="messageId">Internal identifier of a message</param> 
        /// <param name="purge">If the value is &#39;True&#39;, then the message is purged immediately with all the attachments. The default value is &#39;False&#39; (optional)</param> 
        /// <param name="conversationId">Internal identifier of a message thread (optional)</param> 
        /// <returns></returns>
        public void RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete (string accountId, string extensionId, int? messageId, bool? purge = null, long? conversationId = null)
        {
             RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDeleteWithHttpInfo(accountId, extensionId, messageId, purge, conversationId);
        }

        /// <summary>
        ///  Delete Message by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="messageId">Internal identifier of a message</param> 
        /// <param name="purge">If the value is &#39;True&#39;, then the message is purged immediately with all the attachments. The default value is &#39;False&#39; (optional)</param> 
        /// <param name="conversationId">Internal identifier of a message thread (optional)</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDeleteWithHttpInfo (string accountId, string extensionId, int? messageId, bool? purge = null, long? conversationId = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete");
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            if (purge != null) localVarQueryParams.Add("purge", Configuration.ApiClient.ParameterToString(purge)); // query parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  Delete Message by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="purge">If the value is &#39;True&#39;, then the message is purged immediately with all the attachments. The default value is &#39;False&#39; (optional)</param>
        /// <param name="conversationId">Internal identifier of a message thread (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDeleteAsync (string accountId, string extensionId, int? messageId, bool? purge = null, long? conversationId = null)
        {
             await RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDeleteAsyncWithHttpInfo(accountId, extensionId, messageId, purge, conversationId);

        }

        /// <summary>
        ///  Delete Message by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="purge">If the value is &#39;True&#39;, then the message is purged immediately with all the attachments. The default value is &#39;False&#39; (optional)</param>
        /// <param name="conversationId">Internal identifier of a message thread (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDeleteAsyncWithHttpInfo (string accountId, string extensionId, int? messageId, bool? purge = null, long? conversationId = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete");
            // verify the required parameter 'messageId' is set
            if (messageId == null) throw new ApiException(400, "Missing required parameter 'messageId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            if (purge != null) localVarQueryParams.Add("purge", Configuration.ApiClient.ParameterToString(purge)); // query parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  Get Message by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="messageId">Internal identifier of a message</param> 
        /// <returns>MessageInfo</returns>
        public MessageInfo RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet (string accountId, string extensionId, int? messageId)
        {
             ApiResponse<MessageInfo> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGetWithHttpInfo(accountId, extensionId, messageId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Message by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="messageId">Internal identifier of a message</param> 
        /// <returns>ApiResponse of MessageInfo</returns>
        public ApiResponse< MessageInfo > RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGetWithHttpInfo (string accountId, string extensionId, int? messageId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet");
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MessageInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageInfo)));
            
        }

        
        /// <summary>
        ///  Get Message by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <returns>Task of MessageInfo</returns>
        public async System.Threading.Tasks.Task<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGetAsync (string accountId, string extensionId, int? messageId)
        {
             ApiResponse<MessageInfo> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGetAsyncWithHttpInfo(accountId, extensionId, messageId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Message by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <returns>Task of ApiResponse (MessageInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageInfo>> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGetAsyncWithHttpInfo (string accountId, string extensionId, int? messageId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet");
            // verify the required parameter 'messageId' is set
            if (messageId == null) throw new ApiException(400, "Missing required parameter 'messageId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageInfo)));
            
        }
        
        /// <summary>
        ///  Update Message by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="messageId">Internal identifier of a message</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>MessageInfo</returns>
        public MessageInfo RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut (string accountId, string extensionId, int? messageId, Body5 body = null)
        {
             ApiResponse<MessageInfo> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPutWithHttpInfo(accountId, extensionId, messageId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Update Message by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="messageId">Internal identifier of a message</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of MessageInfo</returns>
        public ApiResponse< MessageInfo > RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPutWithHttpInfo (string accountId, string extensionId, int? messageId, Body5 body = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut");
            
            // verify the required parameter 'messageId' is set
            if (messageId == null)
                throw new ApiException(400, "Missing required parameter 'messageId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MessageInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageInfo)));
            
        }

        
        /// <summary>
        ///  Update Message by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of MessageInfo</returns>
        public async System.Threading.Tasks.Task<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPutAsync (string accountId, string extensionId, int? messageId, Body5 body = null)
        {
             ApiResponse<MessageInfo> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPutAsyncWithHttpInfo(accountId, extensionId, messageId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Update Message by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="messageId">Internal identifier of a message</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageInfo>> RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPutAsyncWithHttpInfo (string accountId, string extensionId, int? messageId, Body5 body = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut");
            // verify the required parameter 'messageId' is set
            if (messageId == null) throw new ApiException(400, "Missing required parameter 'messageId' when calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (messageId != null) localVarPathParams.Add("messageId", Configuration.ApiClient.ParameterToString(messageId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdMessageStoreMessageIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageInfo)));
            
        }
        
        /// <summary>
        ///  Get Extension Phone Numbers
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="usageType">Usage type of the phone number (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <returns>InlineResponseDefault7</returns>
        public InlineResponseDefault7 RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet (string accountId, string extensionId, string usageType = null, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault7> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGetWithHttpInfo(accountId, extensionId, usageType, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Extension Phone Numbers
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="usageType">Usage type of the phone number (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault7</returns>
        public ApiResponse< InlineResponseDefault7 > RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGetWithHttpInfo (string accountId, string extensionId, string usageType = null, int? page = null, int? perPage = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            if (usageType != null) localVarQueryParams.Add("usageType", Configuration.ApiClient.ParameterToString(usageType)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault7>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault7) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault7)));
            
        }

        
        /// <summary>
        ///  Get Extension Phone Numbers
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="usageType">Usage type of the phone number (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of InlineResponseDefault7</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault7> RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGetAsync (string accountId, string extensionId, string usageType = null, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault7> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGetAsyncWithHttpInfo(accountId, extensionId, usageType, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Extension Phone Numbers
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="usageType">Usage type of the phone number (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault7)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault7>> RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGetAsyncWithHttpInfo (string accountId, string extensionId, string usageType = null, int? page = null, int? perPage = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            if (usageType != null) localVarQueryParams.Add("usageType", Configuration.ApiClient.ParameterToString(usageType)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdPhoneNumberGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault7>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault7) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault7)));
            
        }
        
        /// <summary>
        ///  Get Extension Presence
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <returns>PresenceInfo</returns>
        public PresenceInfo RestapiV10AccountAccountIdExtensionExtensionIdPresenceGet (string accountId, string extensionId)
        {
             ApiResponse<PresenceInfo> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdPresenceGetWithHttpInfo(accountId, extensionId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Extension Presence
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <returns>ApiResponse of PresenceInfo</returns>
        public ApiResponse< PresenceInfo > RestapiV10AccountAccountIdExtensionExtensionIdPresenceGetWithHttpInfo (string accountId, string extensionId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdPresenceGet");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdPresenceGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdPresenceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdPresenceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PresenceInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PresenceInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PresenceInfo)));
            
        }

        
        /// <summary>
        ///  Get Extension Presence
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <returns>Task of PresenceInfo</returns>
        public async System.Threading.Tasks.Task<PresenceInfo> RestapiV10AccountAccountIdExtensionExtensionIdPresenceGetAsync (string accountId, string extensionId)
        {
             ApiResponse<PresenceInfo> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdPresenceGetAsyncWithHttpInfo(accountId, extensionId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Extension Presence
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <returns>Task of ApiResponse (PresenceInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PresenceInfo>> RestapiV10AccountAccountIdExtensionExtensionIdPresenceGetAsyncWithHttpInfo (string accountId, string extensionId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdPresenceGet");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdPresenceGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdPresenceGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdPresenceGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PresenceInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PresenceInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PresenceInfo)));
            
        }
        
        /// <summary>
        ///  Initiate RingOut Call
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>RingOutInfo</returns>
        public RingOutInfo RestapiV10AccountAccountIdExtensionExtensionIdRingoutPost (string accountId, string extensionId, Body6 body = null)
        {
             ApiResponse<RingOutInfo> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdRingoutPostWithHttpInfo(accountId, extensionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Initiate RingOut Call
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of RingOutInfo</returns>
        public ApiResponse< RingOutInfo > RestapiV10AccountAccountIdExtensionExtensionIdRingoutPostWithHttpInfo (string accountId, string extensionId, Body6 body = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdRingoutPost");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdRingoutPost");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RingOutInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RingOutInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RingOutInfo)));
            
        }

        
        /// <summary>
        ///  Initiate RingOut Call
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of RingOutInfo</returns>
        public async System.Threading.Tasks.Task<RingOutInfo> RestapiV10AccountAccountIdExtensionExtensionIdRingoutPostAsync (string accountId, string extensionId, Body6 body = null)
        {
             ApiResponse<RingOutInfo> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdRingoutPostAsyncWithHttpInfo(accountId, extensionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Initiate RingOut Call
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (RingOutInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RingOutInfo>> RestapiV10AccountAccountIdExtensionExtensionIdRingoutPostAsyncWithHttpInfo (string accountId, string extensionId, Body6 body = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutPost");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutPost");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RingOutInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RingOutInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RingOutInfo)));
            
        }
        
        /// <summary>
        ///  Cancel RingOut Call
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="ringoutId">Internal identifier of a RingOut call</param> 
        /// <returns></returns>
        public void RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete (string accountId, string extensionId, int? ringoutId)
        {
             RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDeleteWithHttpInfo(accountId, extensionId, ringoutId);
        }

        /// <summary>
        ///  Cancel RingOut Call
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="ringoutId">Internal identifier of a RingOut call</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDeleteWithHttpInfo (string accountId, string extensionId, int? ringoutId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete");
            
            // verify the required parameter 'ringoutId' is set
            if (ringoutId == null)
                throw new ApiException(400, "Missing required parameter 'ringoutId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout/{ringoutId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (ringoutId != null) localVarPathParams.Add("ringoutId", Configuration.ApiClient.ParameterToString(ringoutId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  Cancel RingOut Call
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="ringoutId">Internal identifier of a RingOut call</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDeleteAsync (string accountId, string extensionId, int? ringoutId)
        {
             await RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDeleteAsyncWithHttpInfo(accountId, extensionId, ringoutId);

        }

        /// <summary>
        ///  Cancel RingOut Call
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="ringoutId">Internal identifier of a RingOut call</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDeleteAsyncWithHttpInfo (string accountId, string extensionId, int? ringoutId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete");
            // verify the required parameter 'ringoutId' is set
            if (ringoutId == null) throw new ApiException(400, "Missing required parameter 'ringoutId' when calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout/{ringoutId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (ringoutId != null) localVarPathParams.Add("ringoutId", Configuration.ApiClient.ParameterToString(ringoutId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  Get RingOut Call Status
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="ringoutId">Internal identifier of a RingOut call</param> 
        /// <returns>RingOutInfo</returns>
        public RingOutInfo RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet (string accountId, string extensionId, int? ringoutId)
        {
             ApiResponse<RingOutInfo> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGetWithHttpInfo(accountId, extensionId, ringoutId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get RingOut Call Status
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="ringoutId">Internal identifier of a RingOut call</param> 
        /// <returns>ApiResponse of RingOutInfo</returns>
        public ApiResponse< RingOutInfo > RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGetWithHttpInfo (string accountId, string extensionId, int? ringoutId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet");
            
            // verify the required parameter 'ringoutId' is set
            if (ringoutId == null)
                throw new ApiException(400, "Missing required parameter 'ringoutId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout/{ringoutId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (ringoutId != null) localVarPathParams.Add("ringoutId", Configuration.ApiClient.ParameterToString(ringoutId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<RingOutInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RingOutInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RingOutInfo)));
            
        }

        
        /// <summary>
        ///  Get RingOut Call Status
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="ringoutId">Internal identifier of a RingOut call</param>
        /// <returns>Task of RingOutInfo</returns>
        public async System.Threading.Tasks.Task<RingOutInfo> RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGetAsync (string accountId, string extensionId, int? ringoutId)
        {
             ApiResponse<RingOutInfo> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGetAsyncWithHttpInfo(accountId, extensionId, ringoutId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get RingOut Call Status
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="ringoutId">Internal identifier of a RingOut call</param>
        /// <returns>Task of ApiResponse (RingOutInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RingOutInfo>> RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGetAsyncWithHttpInfo (string accountId, string extensionId, int? ringoutId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet");
            // verify the required parameter 'ringoutId' is set
            if (ringoutId == null) throw new ApiException(400, "Missing required parameter 'ringoutId' when calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/ringout/{ringoutId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            if (ringoutId != null) localVarPathParams.Add("ringoutId", Configuration.ApiClient.ParameterToString(ringoutId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdRingoutRingoutIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RingOutInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RingOutInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RingOutInfo)));
            
        }
        
        /// <summary>
        ///  Create and Send SMS Message
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>MessageInfo</returns>
        public MessageInfo RestapiV10AccountAccountIdExtensionExtensionIdSmsPost (string accountId, string extensionId, Body7 body = null)
        {
             ApiResponse<MessageInfo> localVarResponse = RestapiV10AccountAccountIdExtensionExtensionIdSmsPostWithHttpInfo(accountId, extensionId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Create and Send SMS Message
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of MessageInfo</returns>
        public ApiResponse< MessageInfo > RestapiV10AccountAccountIdExtensionExtensionIdSmsPostWithHttpInfo (string accountId, string extensionId, Body7 body = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdSmsPost");
            
            // verify the required parameter 'extensionId' is set
            if (extensionId == null)
                throw new ApiException(400, "Missing required parameter 'extensionId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionExtensionIdSmsPost");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/sms";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdSmsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdSmsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<MessageInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageInfo)));
            
        }

        
        /// <summary>
        ///  Create and Send SMS Message
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of MessageInfo</returns>
        public async System.Threading.Tasks.Task<MessageInfo> RestapiV10AccountAccountIdExtensionExtensionIdSmsPostAsync (string accountId, string extensionId, Body7 body = null)
        {
             ApiResponse<MessageInfo> localVarResponse = await RestapiV10AccountAccountIdExtensionExtensionIdSmsPostAsyncWithHttpInfo(accountId, extensionId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Create and Send SMS Message
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="extensionId">Internal identifier of an extension or tilde (~) to indicate the extension assigned to the account logged-in within the current session</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageInfo>> RestapiV10AccountAccountIdExtensionExtensionIdSmsPostAsyncWithHttpInfo (string accountId, string extensionId, Body7 body = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionExtensionIdSmsPost");
            // verify the required parameter 'extensionId' is set
            if (extensionId == null) throw new ApiException(400, "Missing required parameter 'extensionId' when calling RestapiV10AccountAccountIdExtensionExtensionIdSmsPost");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension/{extensionId}/sms";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (extensionId != null) localVarPathParams.Add("extensionId", Configuration.ApiClient.ParameterToString(extensionId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdSmsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionExtensionIdSmsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<MessageInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageInfo)));
            
        }
        
        /// <summary>
        ///  Get Extension List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param> 
        /// <param name="status">Extension current state. Multiple values are supported. If &#39;Unassigned&#39; is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned (optional)</param> 
        /// <param name="type">Extension type. Multiple values are supported (optional)</param> 
        /// <returns>InlineResponseDefault4</returns>
        public InlineResponseDefault4 RestapiV10AccountAccountIdExtensionGet (string accountId, int? page = null, int? perPage = null, string status = null, string type = null)
        {
             ApiResponse<InlineResponseDefault4> localVarResponse = RestapiV10AccountAccountIdExtensionGetWithHttpInfo(accountId, page, perPage, status, type);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Extension List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param> 
        /// <param name="status">Extension current state. Multiple values are supported. If &#39;Unassigned&#39; is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned (optional)</param> 
        /// <param name="type">Extension type. Multiple values are supported (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault4</returns>
        public ApiResponse< InlineResponseDefault4 > RestapiV10AccountAccountIdExtensionGetWithHttpInfo (string accountId, int? page = null, int? perPage = null, string status = null, string type = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdExtensionGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault4>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault4) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault4)));
            
        }

        
        /// <summary>
        ///  Get Extension List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <param name="status">Extension current state. Multiple values are supported. If &#39;Unassigned&#39; is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned (optional)</param>
        /// <param name="type">Extension type. Multiple values are supported (optional)</param>
        /// <returns>Task of InlineResponseDefault4</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault4> RestapiV10AccountAccountIdExtensionGetAsync (string accountId, int? page = null, int? perPage = null, string status = null, string type = null)
        {
             ApiResponse<InlineResponseDefault4> localVarResponse = await RestapiV10AccountAccountIdExtensionGetAsyncWithHttpInfo(accountId, page, perPage, status, type);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Extension List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <param name="status">Extension current state. Multiple values are supported. If &#39;Unassigned&#39; is specified, then extensions without extensionNumber are returned. If not specified, then all extensions are returned (optional)</param>
        /// <param name="type">Extension type. Multiple values are supported (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault4)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault4>> RestapiV10AccountAccountIdExtensionGetAsyncWithHttpInfo (string accountId, int? page = null, int? perPage = null, string status = null, string type = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdExtensionGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/extension";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            if (type != null) localVarQueryParams.Add("type", Configuration.ApiClient.ParameterToString(type)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdExtensionGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault4>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault4) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault4)));
            
        }
        
        /// <summary>
        ///  Get Account Info by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <returns>AccountInfo</returns>
        public AccountInfo RestapiV10AccountAccountIdGet (string accountId)
        {
             ApiResponse<AccountInfo> localVarResponse = RestapiV10AccountAccountIdGetWithHttpInfo(accountId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Account Info by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <returns>ApiResponse of AccountInfo</returns>
        public ApiResponse< AccountInfo > RestapiV10AccountAccountIdGetWithHttpInfo (string accountId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AccountInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountInfo)));
            
        }

        
        /// <summary>
        ///  Get Account Info by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <returns>Task of AccountInfo</returns>
        public async System.Threading.Tasks.Task<AccountInfo> RestapiV10AccountAccountIdGetAsync (string accountId)
        {
             ApiResponse<AccountInfo> localVarResponse = await RestapiV10AccountAccountIdGetAsyncWithHttpInfo(accountId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Account Info by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <returns>Task of ApiResponse (AccountInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountInfo>> RestapiV10AccountAccountIdGetAsyncWithHttpInfo (string accountId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AccountInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AccountInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountInfo)));
            
        }
        
        /// <summary>
        ///  Get Account Phone Numbers
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <param name="usageType">Usage type of the phone number (optional)</param> 
        /// <returns>InlineResponseDefault8</returns>
        public InlineResponseDefault8 RestapiV10AccountAccountIdPhoneNumberGet (string accountId, int? page = null, int? perPage = null, string usageType = null)
        {
             ApiResponse<InlineResponseDefault8> localVarResponse = RestapiV10AccountAccountIdPhoneNumberGetWithHttpInfo(accountId, page, perPage, usageType);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Account Phone Numbers
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <param name="usageType">Usage type of the phone number (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault8</returns>
        public ApiResponse< InlineResponseDefault8 > RestapiV10AccountAccountIdPhoneNumberGetWithHttpInfo (string accountId, int? page = null, int? perPage = null, string usageType = null)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdPhoneNumberGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/phone-number";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (usageType != null) localVarQueryParams.Add("usageType", Configuration.ApiClient.ParameterToString(usageType)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdPhoneNumberGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdPhoneNumberGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault8>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault8) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault8)));
            
        }

        
        /// <summary>
        ///  Get Account Phone Numbers
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="usageType">Usage type of the phone number (optional)</param>
        /// <returns>Task of InlineResponseDefault8</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault8> RestapiV10AccountAccountIdPhoneNumberGetAsync (string accountId, int? page = null, int? perPage = null, string usageType = null)
        {
             ApiResponse<InlineResponseDefault8> localVarResponse = await RestapiV10AccountAccountIdPhoneNumberGetAsyncWithHttpInfo(accountId, page, perPage, usageType);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Account Phone Numbers
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="usageType">Usage type of the phone number (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault8)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault8>> RestapiV10AccountAccountIdPhoneNumberGetAsyncWithHttpInfo (string accountId, int? page = null, int? perPage = null, string usageType = null)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdPhoneNumberGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/phone-number";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (usageType != null) localVarQueryParams.Add("usageType", Configuration.ApiClient.ParameterToString(usageType)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdPhoneNumberGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdPhoneNumberGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault8>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault8) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault8)));
            
        }
        
        /// <summary>
        ///  Get Phone Number by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="phoneNumberId">Internal identifier of a phone number</param> 
        /// <returns>PhoneNumberInfo</returns>
        public PhoneNumberInfo RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet (string accountId, int? phoneNumberId)
        {
             ApiResponse<PhoneNumberInfo> localVarResponse = RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGetWithHttpInfo(accountId, phoneNumberId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Phone Number by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="phoneNumberId">Internal identifier of a phone number</param> 
        /// <returns>ApiResponse of PhoneNumberInfo</returns>
        public ApiResponse< PhoneNumberInfo > RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGetWithHttpInfo (string accountId, int? phoneNumberId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet");
            
            // verify the required parameter 'phoneNumberId' is set
            if (phoneNumberId == null)
                throw new ApiException(400, "Missing required parameter 'phoneNumberId' when calling DefaultApi->RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (phoneNumberId != null) localVarPathParams.Add("phoneNumberId", Configuration.ApiClient.ParameterToString(phoneNumberId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PhoneNumberInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneNumberInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneNumberInfo)));
            
        }

        
        /// <summary>
        ///  Get Phone Number by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="phoneNumberId">Internal identifier of a phone number</param>
        /// <returns>Task of PhoneNumberInfo</returns>
        public async System.Threading.Tasks.Task<PhoneNumberInfo> RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGetAsync (string accountId, int? phoneNumberId)
        {
             ApiResponse<PhoneNumberInfo> localVarResponse = await RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGetAsyncWithHttpInfo(accountId, phoneNumberId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Phone Number by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="phoneNumberId">Internal identifier of a phone number</param>
        /// <returns>Task of ApiResponse (PhoneNumberInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneNumberInfo>> RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGetAsyncWithHttpInfo (string accountId, int? phoneNumberId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet");
            // verify the required parameter 'phoneNumberId' is set
            if (phoneNumberId == null) throw new ApiException(400, "Missing required parameter 'phoneNumberId' when calling RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (phoneNumberId != null) localVarPathParams.Add("phoneNumberId", Configuration.ApiClient.ParameterToString(phoneNumberId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdPhoneNumberPhoneNumberIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PhoneNumberInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PhoneNumberInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneNumberInfo)));
            
        }
        
        /// <summary>
        ///  Get Call Recording Content
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param> 
        /// <returns>byte[]</returns>
        public byte[] RestapiV10AccountAccountIdRecordingRecordingIdContentGet (string accountId, int? recordingId)
        {
             ApiResponse<byte[]> localVarResponse = RestapiV10AccountAccountIdRecordingRecordingIdContentGetWithHttpInfo(accountId, recordingId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Call Recording Content
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param> 
        /// <returns>ApiResponse of byte[]</returns>
        public ApiResponse< byte[] > RestapiV10AccountAccountIdRecordingRecordingIdContentGetWithHttpInfo (string accountId, int? recordingId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdRecordingRecordingIdContentGet");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling DefaultApi->RestapiV10AccountAccountIdRecordingRecordingIdContentGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/recording/{recordingId}/content";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdRecordingRecordingIdContentGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdRecordingRecordingIdContentGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
            
        }

        
        /// <summary>
        ///  Get Call Recording Content
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> RestapiV10AccountAccountIdRecordingRecordingIdContentGetAsync (string accountId, int? recordingId)
        {
             ApiResponse<byte[]> localVarResponse = await RestapiV10AccountAccountIdRecordingRecordingIdContentGetAsyncWithHttpInfo(accountId, recordingId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Call Recording Content
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<ApiResponse<byte[]>> RestapiV10AccountAccountIdRecordingRecordingIdContentGetAsyncWithHttpInfo (string accountId, int? recordingId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdRecordingRecordingIdContentGet");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling RestapiV10AccountAccountIdRecordingRecordingIdContentGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/recording/{recordingId}/content";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdRecordingRecordingIdContentGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdRecordingRecordingIdContentGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
            
        }
        
        /// <summary>
        ///  Get Call Recording Metadata
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param> 
        /// <returns>InlineResponseDefault9</returns>
        public InlineResponseDefault9 RestapiV10AccountAccountIdRecordingRecordingIdGet (string accountId, int? recordingId)
        {
             ApiResponse<InlineResponseDefault9> localVarResponse = RestapiV10AccountAccountIdRecordingRecordingIdGetWithHttpInfo(accountId, recordingId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Call Recording Metadata
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param> 
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param> 
        /// <returns>ApiResponse of InlineResponseDefault9</returns>
        public ApiResponse< InlineResponseDefault9 > RestapiV10AccountAccountIdRecordingRecordingIdGetWithHttpInfo (string accountId, int? recordingId)
        {
            
            // verify the required parameter 'accountId' is set
            if (accountId == null)
                throw new ApiException(400, "Missing required parameter 'accountId' when calling DefaultApi->RestapiV10AccountAccountIdRecordingRecordingIdGet");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling DefaultApi->RestapiV10AccountAccountIdRecordingRecordingIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/recording/{recordingId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdRecordingRecordingIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdRecordingRecordingIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault9>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault9) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault9)));
            
        }

        
        /// <summary>
        ///  Get Call Recording Metadata
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param>
        /// <returns>Task of InlineResponseDefault9</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault9> RestapiV10AccountAccountIdRecordingRecordingIdGetAsync (string accountId, int? recordingId)
        {
             ApiResponse<InlineResponseDefault9> localVarResponse = await RestapiV10AccountAccountIdRecordingRecordingIdGetAsyncWithHttpInfo(accountId, recordingId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Call Recording Metadata
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">Internal identifier of a RingCentral account or tilde (~) to indicate the account logged-in within the current session</param>
        /// <param name="recordingId">Internal identifier of recording (returned in Call Log)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault9)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault9>> RestapiV10AccountAccountIdRecordingRecordingIdGetAsyncWithHttpInfo (string accountId, int? recordingId)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling RestapiV10AccountAccountIdRecordingRecordingIdGet");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling RestapiV10AccountAccountIdRecordingRecordingIdGet");
            
    
            var localVarPath = "/restapi/v1.0/account/{accountId}/recording/{recordingId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (accountId != null) localVarPathParams.Add("accountId", Configuration.ApiClient.ParameterToString(accountId)); // path parameter
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdRecordingRecordingIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10AccountAccountIdRecordingRecordingIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault9>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault9) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault9)));
            
        }
        
        /// <summary>
        ///  Get Country by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country</param> 
        /// <returns>FullCountryInfo</returns>
        public FullCountryInfo RestapiV10DictionaryCountryCountryIdGet (int? countryId)
        {
             ApiResponse<FullCountryInfo> localVarResponse = RestapiV10DictionaryCountryCountryIdGetWithHttpInfo(countryId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Country by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country</param> 
        /// <returns>ApiResponse of FullCountryInfo</returns>
        public ApiResponse< FullCountryInfo > RestapiV10DictionaryCountryCountryIdGetWithHttpInfo (int? countryId)
        {
            
            // verify the required parameter 'countryId' is set
            if (countryId == null)
                throw new ApiException(400, "Missing required parameter 'countryId' when calling DefaultApi->RestapiV10DictionaryCountryCountryIdGet");
            
    
            var localVarPath = "/restapi/v1.0/dictionary/country/{countryId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (countryId != null) localVarPathParams.Add("countryId", Configuration.ApiClient.ParameterToString(countryId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryCountryCountryIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryCountryCountryIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<FullCountryInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FullCountryInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FullCountryInfo)));
            
        }

        
        /// <summary>
        ///  Get Country by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country</param>
        /// <returns>Task of FullCountryInfo</returns>
        public async System.Threading.Tasks.Task<FullCountryInfo> RestapiV10DictionaryCountryCountryIdGetAsync (int? countryId)
        {
             ApiResponse<FullCountryInfo> localVarResponse = await RestapiV10DictionaryCountryCountryIdGetAsyncWithHttpInfo(countryId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Country by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country</param>
        /// <returns>Task of ApiResponse (FullCountryInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FullCountryInfo>> RestapiV10DictionaryCountryCountryIdGetAsyncWithHttpInfo (int? countryId)
        {
            // verify the required parameter 'countryId' is set
            if (countryId == null) throw new ApiException(400, "Missing required parameter 'countryId' when calling RestapiV10DictionaryCountryCountryIdGet");
            
    
            var localVarPath = "/restapi/v1.0/dictionary/country/{countryId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (countryId != null) localVarPathParams.Add("countryId", Configuration.ApiClient.ParameterToString(countryId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryCountryCountryIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryCountryCountryIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<FullCountryInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FullCountryInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FullCountryInfo)));
            
        }
        
        /// <summary>
        ///  Get Country List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginAllowed">Specifies whether login with the phone numbers of this country is enabled or not (optional)</param> 
        /// <param name="numberSelling">Specifies if RingCentral sells phone numbers of this country (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <returns>InlineResponseDefault10</returns>
        public InlineResponseDefault10 RestapiV10DictionaryCountryGet (bool? loginAllowed = null, bool? numberSelling = null, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault10> localVarResponse = RestapiV10DictionaryCountryGetWithHttpInfo(loginAllowed, numberSelling, page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Country List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginAllowed">Specifies whether login with the phone numbers of this country is enabled or not (optional)</param> 
        /// <param name="numberSelling">Specifies if RingCentral sells phone numbers of this country (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault10</returns>
        public ApiResponse< InlineResponseDefault10 > RestapiV10DictionaryCountryGetWithHttpInfo (bool? loginAllowed = null, bool? numberSelling = null, int? page = null, int? perPage = null)
        {
            
    
            var localVarPath = "/restapi/v1.0/dictionary/country";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (loginAllowed != null) localVarQueryParams.Add("loginAllowed", Configuration.ApiClient.ParameterToString(loginAllowed)); // query parameter
            if (numberSelling != null) localVarQueryParams.Add("numberSelling", Configuration.ApiClient.ParameterToString(numberSelling)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryCountryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryCountryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault10>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault10) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault10)));
            
        }

        
        /// <summary>
        ///  Get Country List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginAllowed">Specifies whether login with the phone numbers of this country is enabled or not (optional)</param>
        /// <param name="numberSelling">Specifies if RingCentral sells phone numbers of this country (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of InlineResponseDefault10</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault10> RestapiV10DictionaryCountryGetAsync (bool? loginAllowed = null, bool? numberSelling = null, int? page = null, int? perPage = null)
        {
             ApiResponse<InlineResponseDefault10> localVarResponse = await RestapiV10DictionaryCountryGetAsyncWithHttpInfo(loginAllowed, numberSelling, page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Country List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginAllowed">Specifies whether login with the phone numbers of this country is enabled or not (optional)</param>
        /// <param name="numberSelling">Specifies if RingCentral sells phone numbers of this country (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault10)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault10>> RestapiV10DictionaryCountryGetAsyncWithHttpInfo (bool? loginAllowed = null, bool? numberSelling = null, int? page = null, int? perPage = null)
        {
            
    
            var localVarPath = "/restapi/v1.0/dictionary/country";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (loginAllowed != null) localVarQueryParams.Add("loginAllowed", Configuration.ApiClient.ParameterToString(loginAllowed)); // query parameter
            if (numberSelling != null) localVarQueryParams.Add("numberSelling", Configuration.ApiClient.ParameterToString(numberSelling)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryCountryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryCountryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault10>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault10) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault10)));
            
        }
        
        /// <summary>
        ///  Get Supported Language List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponseDefault11</returns>
        public InlineResponseDefault11 RestapiV10DictionaryLanguageGet ()
        {
             ApiResponse<InlineResponseDefault11> localVarResponse = RestapiV10DictionaryLanguageGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Supported Language List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponseDefault11</returns>
        public ApiResponse< InlineResponseDefault11 > RestapiV10DictionaryLanguageGetWithHttpInfo ()
        {
            
    
            var localVarPath = "/restapi/v1.0/dictionary/language";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryLanguageGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryLanguageGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault11>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault11) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault11)));
            
        }

        
        /// <summary>
        ///  Get Supported Language List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponseDefault11</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault11> RestapiV10DictionaryLanguageGetAsync ()
        {
             ApiResponse<InlineResponseDefault11> localVarResponse = await RestapiV10DictionaryLanguageGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Supported Language List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponseDefault11)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault11>> RestapiV10DictionaryLanguageGetAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/restapi/v1.0/dictionary/language";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryLanguageGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryLanguageGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault11>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault11) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault11)));
            
        }
        
        /// <summary>
        ///  Get Language by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Internal identifier of a language</param> 
        /// <returns>LanguageInfo</returns>
        public LanguageInfo RestapiV10DictionaryLanguageLanguageIdGet (int? languageId)
        {
             ApiResponse<LanguageInfo> localVarResponse = RestapiV10DictionaryLanguageLanguageIdGetWithHttpInfo(languageId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Language by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Internal identifier of a language</param> 
        /// <returns>ApiResponse of LanguageInfo</returns>
        public ApiResponse< LanguageInfo > RestapiV10DictionaryLanguageLanguageIdGetWithHttpInfo (int? languageId)
        {
            
            // verify the required parameter 'languageId' is set
            if (languageId == null)
                throw new ApiException(400, "Missing required parameter 'languageId' when calling DefaultApi->RestapiV10DictionaryLanguageLanguageIdGet");
            
    
            var localVarPath = "/restapi/v1.0/dictionary/language/{languageId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (languageId != null) localVarPathParams.Add("languageId", Configuration.ApiClient.ParameterToString(languageId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryLanguageLanguageIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryLanguageLanguageIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LanguageInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LanguageInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LanguageInfo)));
            
        }

        
        /// <summary>
        ///  Get Language by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Internal identifier of a language</param>
        /// <returns>Task of LanguageInfo</returns>
        public async System.Threading.Tasks.Task<LanguageInfo> RestapiV10DictionaryLanguageLanguageIdGetAsync (int? languageId)
        {
             ApiResponse<LanguageInfo> localVarResponse = await RestapiV10DictionaryLanguageLanguageIdGetAsyncWithHttpInfo(languageId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Language by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="languageId">Internal identifier of a language</param>
        /// <returns>Task of ApiResponse (LanguageInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LanguageInfo>> RestapiV10DictionaryLanguageLanguageIdGetAsyncWithHttpInfo (int? languageId)
        {
            // verify the required parameter 'languageId' is set
            if (languageId == null) throw new ApiException(400, "Missing required parameter 'languageId' when calling RestapiV10DictionaryLanguageLanguageIdGet");
            
    
            var localVarPath = "/restapi/v1.0/dictionary/language/{languageId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (languageId != null) localVarPathParams.Add("languageId", Configuration.ApiClient.ParameterToString(languageId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryLanguageLanguageIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryLanguageLanguageIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LanguageInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LanguageInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LanguageInfo)));
            
        }
        
        /// <summary>
        ///  Get Location List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Sorts results by the specified property. The default value is &#39;City&#39; (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param> 
        /// <param name="stateId">Internal identifier of a state (optional)</param> 
        /// <param name="withNxx">Specifies if nxx codes are returned (optional)</param> 
        /// <returns>InlineResponseDefault12</returns>
        public InlineResponseDefault12 RestapiV10DictionaryLocationGet (string orderBy = null, int? page = null, int? perPage = null, string stateId = null, bool? withNxx = null)
        {
             ApiResponse<InlineResponseDefault12> localVarResponse = RestapiV10DictionaryLocationGetWithHttpInfo(orderBy, page, perPage, stateId, withNxx);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Location List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Sorts results by the specified property. The default value is &#39;City&#39; (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param> 
        /// <param name="stateId">Internal identifier of a state (optional)</param> 
        /// <param name="withNxx">Specifies if nxx codes are returned (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault12</returns>
        public ApiResponse< InlineResponseDefault12 > RestapiV10DictionaryLocationGetWithHttpInfo (string orderBy = null, int? page = null, int? perPage = null, string stateId = null, bool? withNxx = null)
        {
            
    
            var localVarPath = "/restapi/v1.0/dictionary/location";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (orderBy != null) localVarQueryParams.Add("orderBy", Configuration.ApiClient.ParameterToString(orderBy)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (stateId != null) localVarQueryParams.Add("stateId", Configuration.ApiClient.ParameterToString(stateId)); // query parameter
            if (withNxx != null) localVarQueryParams.Add("withNxx", Configuration.ApiClient.ParameterToString(withNxx)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryLocationGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryLocationGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault12>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault12) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault12)));
            
        }

        
        /// <summary>
        ///  Get Location List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Sorts results by the specified property. The default value is &#39;City&#39; (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <param name="stateId">Internal identifier of a state (optional)</param>
        /// <param name="withNxx">Specifies if nxx codes are returned (optional)</param>
        /// <returns>Task of InlineResponseDefault12</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault12> RestapiV10DictionaryLocationGetAsync (string orderBy = null, int? page = null, int? perPage = null, string stateId = null, bool? withNxx = null)
        {
             ApiResponse<InlineResponseDefault12> localVarResponse = await RestapiV10DictionaryLocationGetAsyncWithHttpInfo(orderBy, page, perPage, stateId, withNxx);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Location List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderBy">Sorts results by the specified property. The default value is &#39;City&#39; (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default. (optional)</param>
        /// <param name="stateId">Internal identifier of a state (optional)</param>
        /// <param name="withNxx">Specifies if nxx codes are returned (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault12)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault12>> RestapiV10DictionaryLocationGetAsyncWithHttpInfo (string orderBy = null, int? page = null, int? perPage = null, string stateId = null, bool? withNxx = null)
        {
            
    
            var localVarPath = "/restapi/v1.0/dictionary/location";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (orderBy != null) localVarQueryParams.Add("orderBy", Configuration.ApiClient.ParameterToString(orderBy)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (stateId != null) localVarQueryParams.Add("stateId", Configuration.ApiClient.ParameterToString(stateId)); // query parameter
            if (withNxx != null) localVarQueryParams.Add("withNxx", Configuration.ApiClient.ParameterToString(withNxx)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryLocationGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryLocationGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault12>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault12) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault12)));
            
        }
        
        /// <summary>
        ///  Get State/Province List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <param name="withPhoneNumbers">If &#39;True&#39;, the list of states with phone numbers available for buying is returned. The default value is &#39;False&#39; (optional)</param> 
        /// <returns>InlineResponseDefault13</returns>
        public InlineResponseDefault13 RestapiV10DictionaryStateGet (int? countryId = null, int? page = null, int? perPage = null, bool? withPhoneNumbers = null)
        {
             ApiResponse<InlineResponseDefault13> localVarResponse = RestapiV10DictionaryStateGetWithHttpInfo(countryId, page, perPage, withPhoneNumbers);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get State/Province List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country (optional)</param> 
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <param name="withPhoneNumbers">If &#39;True&#39;, the list of states with phone numbers available for buying is returned. The default value is &#39;False&#39; (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault13</returns>
        public ApiResponse< InlineResponseDefault13 > RestapiV10DictionaryStateGetWithHttpInfo (int? countryId = null, int? page = null, int? perPage = null, bool? withPhoneNumbers = null)
        {
            
    
            var localVarPath = "/restapi/v1.0/dictionary/state";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (countryId != null) localVarQueryParams.Add("countryId", Configuration.ApiClient.ParameterToString(countryId)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (withPhoneNumbers != null) localVarQueryParams.Add("withPhoneNumbers", Configuration.ApiClient.ParameterToString(withPhoneNumbers)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryStateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryStateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault13>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault13) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault13)));
            
        }

        
        /// <summary>
        ///  Get State/Province List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="withPhoneNumbers">If &#39;True&#39;, the list of states with phone numbers available for buying is returned. The default value is &#39;False&#39; (optional)</param>
        /// <returns>Task of InlineResponseDefault13</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault13> RestapiV10DictionaryStateGetAsync (int? countryId = null, int? page = null, int? perPage = null, bool? withPhoneNumbers = null)
        {
             ApiResponse<InlineResponseDefault13> localVarResponse = await RestapiV10DictionaryStateGetAsyncWithHttpInfo(countryId, page, perPage, withPhoneNumbers);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get State/Province List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="countryId">Internal identifier of a country (optional)</param>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39;. (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <param name="withPhoneNumbers">If &#39;True&#39;, the list of states with phone numbers available for buying is returned. The default value is &#39;False&#39; (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault13)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault13>> RestapiV10DictionaryStateGetAsyncWithHttpInfo (int? countryId = null, int? page = null, int? perPage = null, bool? withPhoneNumbers = null)
        {
            
    
            var localVarPath = "/restapi/v1.0/dictionary/state";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (countryId != null) localVarQueryParams.Add("countryId", Configuration.ApiClient.ParameterToString(countryId)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (withPhoneNumbers != null) localVarQueryParams.Add("withPhoneNumbers", Configuration.ApiClient.ParameterToString(withPhoneNumbers)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryStateGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryStateGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault13>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault13) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault13)));
            
        }
        
        /// <summary>
        ///  Get State/Province by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stateId">Internal identifier of a state</param> 
        /// <returns>StateInfo</returns>
        public StateInfo RestapiV10DictionaryStateStateIdGet (int? stateId)
        {
             ApiResponse<StateInfo> localVarResponse = RestapiV10DictionaryStateStateIdGetWithHttpInfo(stateId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get State/Province by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stateId">Internal identifier of a state</param> 
        /// <returns>ApiResponse of StateInfo</returns>
        public ApiResponse< StateInfo > RestapiV10DictionaryStateStateIdGetWithHttpInfo (int? stateId)
        {
            
            // verify the required parameter 'stateId' is set
            if (stateId == null)
                throw new ApiException(400, "Missing required parameter 'stateId' when calling DefaultApi->RestapiV10DictionaryStateStateIdGet");
            
    
            var localVarPath = "/restapi/v1.0/dictionary/state/{stateId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (stateId != null) localVarPathParams.Add("stateId", Configuration.ApiClient.ParameterToString(stateId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryStateStateIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryStateStateIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<StateInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StateInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StateInfo)));
            
        }

        
        /// <summary>
        ///  Get State/Province by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stateId">Internal identifier of a state</param>
        /// <returns>Task of StateInfo</returns>
        public async System.Threading.Tasks.Task<StateInfo> RestapiV10DictionaryStateStateIdGetAsync (int? stateId)
        {
             ApiResponse<StateInfo> localVarResponse = await RestapiV10DictionaryStateStateIdGetAsyncWithHttpInfo(stateId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get State/Province by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stateId">Internal identifier of a state</param>
        /// <returns>Task of ApiResponse (StateInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StateInfo>> RestapiV10DictionaryStateStateIdGetAsyncWithHttpInfo (int? stateId)
        {
            // verify the required parameter 'stateId' is set
            if (stateId == null) throw new ApiException(400, "Missing required parameter 'stateId' when calling RestapiV10DictionaryStateStateIdGet");
            
    
            var localVarPath = "/restapi/v1.0/dictionary/state/{stateId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (stateId != null) localVarPathParams.Add("stateId", Configuration.ApiClient.ParameterToString(stateId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryStateStateIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryStateStateIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StateInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (StateInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StateInfo)));
            
        }
        
        /// <summary>
        ///  Get Time Zone List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <returns>InlineResponseDefault14</returns>
        public InlineResponseDefault14 RestapiV10DictionaryTimezoneGet (string page = null, string perPage = null)
        {
             ApiResponse<InlineResponseDefault14> localVarResponse = RestapiV10DictionaryTimezoneGetWithHttpInfo(page, perPage);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Time Zone List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param> 
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param> 
        /// <returns>ApiResponse of InlineResponseDefault14</returns>
        public ApiResponse< InlineResponseDefault14 > RestapiV10DictionaryTimezoneGetWithHttpInfo (string page = null, string perPage = null)
        {
            
    
            var localVarPath = "/restapi/v1.0/dictionary/timezone";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryTimezoneGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryTimezoneGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InlineResponseDefault14>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault14) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault14)));
            
        }

        
        /// <summary>
        ///  Get Time Zone List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of InlineResponseDefault14</returns>
        public async System.Threading.Tasks.Task<InlineResponseDefault14> RestapiV10DictionaryTimezoneGetAsync (string page = null, string perPage = null)
        {
             ApiResponse<InlineResponseDefault14> localVarResponse = await RestapiV10DictionaryTimezoneGetAsyncWithHttpInfo(page, perPage);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Time Zone List
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page">Indicates the page number to retrieve. Only positive number values are allowed. Default value is &#39;1&#39; (optional)</param>
        /// <param name="perPage">Indicates the page size (number of items). If not specified, the value is &#39;100&#39; by default (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponseDefault14)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponseDefault14>> RestapiV10DictionaryTimezoneGetAsyncWithHttpInfo (string page = null, string perPage = null)
        {
            
    
            var localVarPath = "/restapi/v1.0/dictionary/timezone";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("perPage", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryTimezoneGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryTimezoneGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InlineResponseDefault14>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponseDefault14) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponseDefault14)));
            
        }
        
        /// <summary>
        ///  Get Time Zone by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timezoneId">Internal identifier of a timezone</param> 
        /// <returns>TimezoneInfo</returns>
        public TimezoneInfo RestapiV10DictionaryTimezoneTimezoneIdGet (int? timezoneId)
        {
             ApiResponse<TimezoneInfo> localVarResponse = RestapiV10DictionaryTimezoneTimezoneIdGetWithHttpInfo(timezoneId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Time Zone by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timezoneId">Internal identifier of a timezone</param> 
        /// <returns>ApiResponse of TimezoneInfo</returns>
        public ApiResponse< TimezoneInfo > RestapiV10DictionaryTimezoneTimezoneIdGetWithHttpInfo (int? timezoneId)
        {
            
            // verify the required parameter 'timezoneId' is set
            if (timezoneId == null)
                throw new ApiException(400, "Missing required parameter 'timezoneId' when calling DefaultApi->RestapiV10DictionaryTimezoneTimezoneIdGet");
            
    
            var localVarPath = "/restapi/v1.0/dictionary/timezone/{timezoneId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (timezoneId != null) localVarPathParams.Add("timezoneId", Configuration.ApiClient.ParameterToString(timezoneId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryTimezoneTimezoneIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryTimezoneTimezoneIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TimezoneInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimezoneInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimezoneInfo)));
            
        }

        
        /// <summary>
        ///  Get Time Zone by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timezoneId">Internal identifier of a timezone</param>
        /// <returns>Task of TimezoneInfo</returns>
        public async System.Threading.Tasks.Task<TimezoneInfo> RestapiV10DictionaryTimezoneTimezoneIdGetAsync (int? timezoneId)
        {
             ApiResponse<TimezoneInfo> localVarResponse = await RestapiV10DictionaryTimezoneTimezoneIdGetAsyncWithHttpInfo(timezoneId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Time Zone by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="timezoneId">Internal identifier of a timezone</param>
        /// <returns>Task of ApiResponse (TimezoneInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TimezoneInfo>> RestapiV10DictionaryTimezoneTimezoneIdGetAsyncWithHttpInfo (int? timezoneId)
        {
            // verify the required parameter 'timezoneId' is set
            if (timezoneId == null) throw new ApiException(400, "Missing required parameter 'timezoneId' when calling RestapiV10DictionaryTimezoneTimezoneIdGet");
            
    
            var localVarPath = "/restapi/v1.0/dictionary/timezone/{timezoneId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (timezoneId != null) localVarPathParams.Add("timezoneId", Configuration.ApiClient.ParameterToString(timezoneId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryTimezoneTimezoneIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10DictionaryTimezoneTimezoneIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TimezoneInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TimezoneInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TimezoneInfo)));
            
        }
        
        /// <summary>
        ///  Get API Version Info
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VersionInfo</returns>
        public VersionInfo RestapiV10Get ()
        {
             ApiResponse<VersionInfo> localVarResponse = RestapiV10GetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get API Version Info
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VersionInfo</returns>
        public ApiResponse< VersionInfo > RestapiV10GetWithHttpInfo ()
        {
            
    
            var localVarPath = "/restapi/v1.0";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10Get: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10Get: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VersionInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VersionInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionInfo)));
            
        }

        
        /// <summary>
        ///  Get API Version Info
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VersionInfo</returns>
        public async System.Threading.Tasks.Task<VersionInfo> RestapiV10GetAsync ()
        {
             ApiResponse<VersionInfo> localVarResponse = await RestapiV10GetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get API Version Info
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VersionInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VersionInfo>> RestapiV10GetAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/restapi/v1.0";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10Get: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10Get: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VersionInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VersionInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionInfo)));
            
        }
        
        /// <summary>
        ///  Create New Subscription
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload in the &#39;presenceStatus&#39; field (optional)</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>SubscriptionInfo</returns>
        public SubscriptionInfo RestapiV10SubscriptionPost (bool? aggregated = null, Body8 body = null)
        {
             ApiResponse<SubscriptionInfo> localVarResponse = RestapiV10SubscriptionPostWithHttpInfo(aggregated, body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Create New Subscription
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload in the &#39;presenceStatus&#39; field (optional)</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of SubscriptionInfo</returns>
        public ApiResponse< SubscriptionInfo > RestapiV10SubscriptionPostWithHttpInfo (bool? aggregated = null, Body8 body = null)
        {
            
    
            var localVarPath = "/restapi/v1.0/subscription";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (aggregated != null) localVarQueryParams.Add("aggregated", Configuration.ApiClient.ParameterToString(aggregated)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SubscriptionInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubscriptionInfo)));
            
        }

        
        /// <summary>
        ///  Create New Subscription
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload in the &#39;presenceStatus&#39; field (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SubscriptionInfo</returns>
        public async System.Threading.Tasks.Task<SubscriptionInfo> RestapiV10SubscriptionPostAsync (bool? aggregated = null, Body8 body = null)
        {
             ApiResponse<SubscriptionInfo> localVarResponse = await RestapiV10SubscriptionPostAsyncWithHttpInfo(aggregated, body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Create New Subscription
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload in the &#39;presenceStatus&#39; field (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SubscriptionInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionInfo>> RestapiV10SubscriptionPostAsyncWithHttpInfo (bool? aggregated = null, Body8 body = null)
        {
            
    
            var localVarPath = "/restapi/v1.0/subscription";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (aggregated != null) localVarQueryParams.Add("aggregated", Configuration.ApiClient.ParameterToString(aggregated)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SubscriptionInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubscriptionInfo)));
            
        }
        
        /// <summary>
        ///  Cancel Subscription by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param> 
        /// <returns></returns>
        public void RestapiV10SubscriptionSubscriptionIdDelete (string subscriptionId)
        {
             RestapiV10SubscriptionSubscriptionIdDeleteWithHttpInfo(subscriptionId);
        }

        /// <summary>
        ///  Cancel Subscription by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> RestapiV10SubscriptionSubscriptionIdDeleteWithHttpInfo (string subscriptionId)
        {
            
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling DefaultApi->RestapiV10SubscriptionSubscriptionIdDelete");
            
    
            var localVarPath = "/restapi/v1.0/subscription/{subscriptionId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (subscriptionId != null) localVarPathParams.Add("subscriptionId", Configuration.ApiClient.ParameterToString(subscriptionId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionSubscriptionIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionSubscriptionIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        ///  Cancel Subscription by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RestapiV10SubscriptionSubscriptionIdDeleteAsync (string subscriptionId)
        {
             await RestapiV10SubscriptionSubscriptionIdDeleteAsyncWithHttpInfo(subscriptionId);

        }

        /// <summary>
        ///  Cancel Subscription by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> RestapiV10SubscriptionSubscriptionIdDeleteAsyncWithHttpInfo (string subscriptionId)
        {
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null) throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling RestapiV10SubscriptionSubscriptionIdDelete");
            
    
            var localVarPath = "/restapi/v1.0/subscription/{subscriptionId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (subscriptionId != null) localVarPathParams.Add("subscriptionId", Configuration.ApiClient.ParameterToString(subscriptionId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionSubscriptionIdDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionSubscriptionIdDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  Get Subscription by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param> 
        /// <returns>SubscriptionInfo</returns>
        public SubscriptionInfo RestapiV10SubscriptionSubscriptionIdGet (string subscriptionId)
        {
             ApiResponse<SubscriptionInfo> localVarResponse = RestapiV10SubscriptionSubscriptionIdGetWithHttpInfo(subscriptionId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Subscription by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param> 
        /// <returns>ApiResponse of SubscriptionInfo</returns>
        public ApiResponse< SubscriptionInfo > RestapiV10SubscriptionSubscriptionIdGetWithHttpInfo (string subscriptionId)
        {
            
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling DefaultApi->RestapiV10SubscriptionSubscriptionIdGet");
            
    
            var localVarPath = "/restapi/v1.0/subscription/{subscriptionId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (subscriptionId != null) localVarPathParams.Add("subscriptionId", Configuration.ApiClient.ParameterToString(subscriptionId)); // path parameter
            
            
            
            
            

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionSubscriptionIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionSubscriptionIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SubscriptionInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubscriptionInfo)));
            
        }

        
        /// <summary>
        ///  Get Subscription by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <returns>Task of SubscriptionInfo</returns>
        public async System.Threading.Tasks.Task<SubscriptionInfo> RestapiV10SubscriptionSubscriptionIdGetAsync (string subscriptionId)
        {
             ApiResponse<SubscriptionInfo> localVarResponse = await RestapiV10SubscriptionSubscriptionIdGetAsyncWithHttpInfo(subscriptionId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Subscription by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <returns>Task of ApiResponse (SubscriptionInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionInfo>> RestapiV10SubscriptionSubscriptionIdGetAsyncWithHttpInfo (string subscriptionId)
        {
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null) throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling RestapiV10SubscriptionSubscriptionIdGet");
            
    
            var localVarPath = "/restapi/v1.0/subscription/{subscriptionId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (subscriptionId != null) localVarPathParams.Add("subscriptionId", Configuration.ApiClient.ParameterToString(subscriptionId)); // path parameter
            
            
            
            
            

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionSubscriptionIdGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionSubscriptionIdGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SubscriptionInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubscriptionInfo)));
            
        }
        
        /// <summary>
        ///  Update/Renew Subscription by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param> 
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload (optional)</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>SubscriptionInfo</returns>
        public SubscriptionInfo RestapiV10SubscriptionSubscriptionIdPut (string subscriptionId, bool? aggregated = null, Body9 body = null)
        {
             ApiResponse<SubscriptionInfo> localVarResponse = RestapiV10SubscriptionSubscriptionIdPutWithHttpInfo(subscriptionId, aggregated, body);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Update/Renew Subscription by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param> 
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload (optional)</param> 
        /// <param name="body"> (optional)</param> 
        /// <returns>ApiResponse of SubscriptionInfo</returns>
        public ApiResponse< SubscriptionInfo > RestapiV10SubscriptionSubscriptionIdPutWithHttpInfo (string subscriptionId, bool? aggregated = null, Body9 body = null)
        {
            
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null)
                throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling DefaultApi->RestapiV10SubscriptionSubscriptionIdPut");
            
    
            var localVarPath = "/restapi/v1.0/subscription/{subscriptionId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (subscriptionId != null) localVarPathParams.Add("subscriptionId", Configuration.ApiClient.ParameterToString(subscriptionId)); // path parameter
            
            if (aggregated != null) localVarQueryParams.Add("aggregated", Configuration.ApiClient.ParameterToString(aggregated)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionSubscriptionIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionSubscriptionIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<SubscriptionInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubscriptionInfo)));
            
        }

        
        /// <summary>
        ///  Update/Renew Subscription by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of SubscriptionInfo</returns>
        public async System.Threading.Tasks.Task<SubscriptionInfo> RestapiV10SubscriptionSubscriptionIdPutAsync (string subscriptionId, bool? aggregated = null, Body9 body = null)
        {
             ApiResponse<SubscriptionInfo> localVarResponse = await RestapiV10SubscriptionSubscriptionIdPutAsyncWithHttpInfo(subscriptionId, aggregated, body);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Update/Renew Subscription by ID
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="subscriptionId">Internal identifier of a subscription</param>
        /// <param name="aggregated">If &#39;True&#39; then aggregated presence status is returned in a notification payload (optional)</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (SubscriptionInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SubscriptionInfo>> RestapiV10SubscriptionSubscriptionIdPutAsyncWithHttpInfo (string subscriptionId, bool? aggregated = null, Body9 body = null)
        {
            // verify the required parameter 'subscriptionId' is set
            if (subscriptionId == null) throw new ApiException(400, "Missing required parameter 'subscriptionId' when calling RestapiV10SubscriptionSubscriptionIdPut");
            
    
            var localVarPath = "/restapi/v1.0/subscription/{subscriptionId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (subscriptionId != null) localVarPathParams.Add("subscriptionId", Configuration.ApiClient.ParameterToString(subscriptionId)); // path parameter
            
            if (aggregated != null) localVarQueryParams.Add("aggregated", Configuration.ApiClient.ParameterToString(aggregated)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (oauth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionSubscriptionIdPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling RestapiV10SubscriptionSubscriptionIdPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<SubscriptionInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SubscriptionInfo) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SubscriptionInfo)));
            
        }
        
    }
    
}
