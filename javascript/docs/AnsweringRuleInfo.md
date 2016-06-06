# RingCentralApi.AnsweringRuleInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**uri** | **String** | Canonical URI to the answering rule resource | [optional] 
**id** | **String** | Internal identifier of an asnwering rule | [optional] 
**type** | **String** | Type of an answering rule | [optional] 
**name** | **String** | Name of an answering rule specified by user | [optional] 
**enabled** | **Boolean** | Specifies if an answering rule is active or inactive | [optional] 
**schedule** | [**ScheduleInfo**](ScheduleInfo.md) |  | [optional] 
**calledNumbers** | [**[AnsweringRuleInfoCalleeInfo]**](AnsweringRuleInfoCalleeInfo.md) | Answering rules are applied when calling to selected number(s) | [optional] 
**callers** | [**[AnsweringRuleInfoCallerInfo]**](AnsweringRuleInfoCallerInfo.md) | Answering rules are applied when calls are received from specified caller(s) | [optional] 
**callHandlingAction** | **String** | Specifies how incoming calls are forwarded | [optional] 
**forwarding** | [**ForwardingInfo**](ForwardingInfo.md) |  | [optional] 
**unconditionalForwarding** | [**UnconditionalForwardingInfo**](UnconditionalForwardingInfo.md) |  | [optional] 
**voicemail** | [**VoicemailInfo**](VoicemailInfo.md) |  | [optional] 


