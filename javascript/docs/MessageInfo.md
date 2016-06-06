# RingCentralApi.MessageInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** | Internal identifier of a message | [optional] 
**uri** | **String** | Canonical URI of a message | [optional] 
**attachments** | [**[MessageAttachmentInfo]**](MessageAttachmentInfo.md) | The list of message attachments | [optional] 
**availability** | **String** | Message availability status. Message in &#39;Deleted&#39; state is still preserved with all its attachments and can be restored. &#39;Purged&#39; means that all attachments are already deleted and the message itself is about to be physically deleted shortly | [optional] 
**conversationId** | **Integer** | SMS and Pager only. Identifier of the conversation the message belongs to | [optional] 
**creationTime** | **Date** | Message creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**deliveryErrorCode** | **String** | SMS only. Delivery error code returned by gateway | [optional] 
**direction** | **String** | Message direction. Note that for some message types not all directions are allowed. For example voicemail messages can be only inbound | [optional] 
**faxPageCount** | **Integer** | Fax only. Page count in fax message | [optional] 
**faxResolution** | **String** | Fax only. Resolution of fax message. (&#39;High&#39; for black and white image scanned at 200 dpi, &#39;Low&#39; for black and white image scanned at 100 dpi) | [optional] 
**from** | [**MessageInfoCallerInfo**](MessageInfoCallerInfo.md) |  | [optional] 
**lastModifiedTime** | **Date** | The datetime when the message was modified on server in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**messageStatus** | **String** | Message status. Different message types may have different allowed status values. | [optional] 
**pgToDepartment** | **Boolean** | Pager only True if at least one of the message recipients is Department extension | [optional] 
**priority** | **String** | Message priority | [optional] 
**readStatus** | **String** | Message read status | [optional] 
**smsDeliveryTime** | **Date** | SMS only. The datetime when outbound SMS was delivered to recipient&#39;s handset in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. It is filled only if the carrier sends a delivery receipt to RingCentral | [optional] 
**smsSendingAttemptsCount** | **Integer** | SMS only. Number of attempts made to send an outbound SMS to the gateway (if gateway is temporary unavailable) | [optional] 
**subject** | **String** | Message subject. For SMS and Pager messages it replicates message text which is also returned as an attachment | [optional] 
**to** | [**[MessageInfoCallerInfo]**](MessageInfoCallerInfo.md) | Recipient information | [optional] 
**type** | **String** | Message type | [optional] 
**vmTranscriptionStatus** | **String** | Voicemail only. Status of voicemail to text transcription. If VoicemailToText feature is not activated for account, the &#39;NotAvailable&#39; value is returned | [optional] 


