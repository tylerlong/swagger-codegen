# RingCentralApi.Body7

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**from** | [**CallerInfo**](CallerInfo.md) |  | [optional] 
**to** | [**[CallerInfo]**](CallerInfo.md) | Receiver of an SMS message. The phoneNumber property must be filled | [optional] 
**text** | **String** | Text of a message. Max length is 1000 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 500 symbols | [optional] 


