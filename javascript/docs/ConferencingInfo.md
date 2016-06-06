# RingCentralApi.ConferencingInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**uri** | **String** | Canonical URI of a conferencing | [optional] 
**allowJoinBeforeHost** | **Boolean** | Determines if host user allows conference participants to join before the host | [optional] 
**hostCode** | **String** | Access code for a host user | [optional] 
**mode** | **String** | Internal parameter specifying conferencing engine | [optional] 
**participantCode** | **String** | Access code for any participant | [optional] 
**phoneNumber** | **String** | Primary conference phone number for user&#39;s home country returned in E.164 (11-digits) format | [optional] 
**tapToJoinUri** | **String** | Short URL leading to the service web page Tap to Join for audio conference bridge | [optional] 
**phoneNumbers** | [**[ConferencingInfoPhoneNumberInfo]**](ConferencingInfoPhoneNumberInfo.md) | List of multiple dial-in phone numbers to connect to audio conference service, relevant for user&#39;s brand. Each number is given with the country and location information, in order to let the user choose the less expensive way to connect to a conference. The first number in the list is the primary conference number, that is default and domestic | [optional] 


