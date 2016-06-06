# RingCentralApi.CallLogInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** | Internal identifier of a cal log record | [optional] 
**uri** | **String** | Canonical URI of a call log record | [optional] 
**sessionId** | **String** | Internal identifier of a call session | [optional] 
**from** | [**CallerInfo**](CallerInfo.md) |  | [optional] 
**to** | [**CallerInfo**](CallerInfo.md) |  | [optional] 
**type** | **String** | Call type | [optional] 
**direction** | **String** | Call direction | [optional] 
**action** | **String** | Action description of the call operation | [optional] 
**result** | **String** | Status description of the call operation | [optional] 
**startTime** | **Date** | The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**duration** | **Integer** | Call duration in seconds | [optional] 
**recording** | [**RecordingInfo**](RecordingInfo.md) |  | [optional] 


