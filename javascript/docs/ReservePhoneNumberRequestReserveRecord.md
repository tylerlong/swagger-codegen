# RingCentralApi.ReservePhoneNumberRequestReserveRecord

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**phoneNumber** | **String** | Phone number in E.164 format without a &#39;+&#39; | [optional] 
**reservedTill** | **Date** | The datetime up to which the number is reserved in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. If it is omitted or explicitly set to &#39;null&#39;, the number will be un-reserved if it was reserved previously by the same session. &#39;Min&#39; value is 30 seconds; &#39;Max&#39; value is 30 days (for reservation by brand) and 20 minutes (for reservation by account/session) | [optional] 


