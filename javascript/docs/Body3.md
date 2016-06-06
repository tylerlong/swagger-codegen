# RingCentralApi.Body3

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**from** | [**CallerInfo**](CallerInfo.md) |  | [optional] 
**replyOn** | **Integer** | Internal identifier of a message this message replies to | [optional] 
**text** | **String** | Text of a pager message. Max length is 1024 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 512 symbols | [optional] 
**to** | [**[CallerInfo]**](CallerInfo.md) | Optional if replyOn parameter is specified. Receiver of a pager message. The extensionNumber property must be filled | [optional] 


