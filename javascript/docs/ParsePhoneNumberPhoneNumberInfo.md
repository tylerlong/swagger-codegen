# RingCentralApi.ParsePhoneNumberPhoneNumberInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**areaCode** | **String** | Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See North American Numbering Plan for details | [optional] 
**country** | [**[ParsePhoneNumberCountryInfo]**](ParsePhoneNumberCountryInfo.md) | Information on a country the phone number belongs to | [optional] 
**dialable** | **String** | Dialing format of a phone number | [optional] 
**e164** | **String** | E.164 (11-digits) format of a phone number | [optional] 
**formattedInternational** | **String** | International format of a phone number | [optional] 
**formattedNational** | **String** | Domestic format of a phone number | [optional] 
**originalString** | **String** | One of the numbers to be parsed, passed as a string in response | [optional] 
**special** | **Boolean** | \&quot;True\&quot; if the number is in a special format (for example N11 code) | [optional] 
**normalized** | **String** | E.164 (11-digits) format of a phone number without the plus sign (&#39;+&#39;) | [optional] 


