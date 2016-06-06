# RingCentralApi.PhoneNumberInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **Integer** | Internal identifier of a phone number | [optional] 
**country** | [**CountryInfo**](CountryInfo.md) |  | [optional] 
**extension** | [**PhoneNumberInfoExtensionInfo**](PhoneNumberInfoExtensionInfo.md) |  | [optional] 
**features** | **[String]** | Indicates if this phone number is enabled to appear as CallerId and/or to send outbound SMS from it. Returned only for the request of Extension phone number list | [optional] 
**location** | **String** | Location (City, State). Filled for local US numbers | [optional] 
**paymentType** | **String** | Payment type. &#39;External&#39; is returned for forwarded numbers which are not terminated in the RingCentral phone system | [optional] 
**phoneNumber** | **String** | Phone number | [optional] 
**status** | **String** | Status of a phone number. If the value is &#39;Normal&#39;, the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral | [optional] 
**type** | **String** | Phone number type | [optional] 
**usageType** | **String** | Usage type of the phone number | [optional] 


