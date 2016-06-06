# RingCentralApi.DeliveryMode

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transportType** | **String** | Notifications transportation provider name. &#39;APNS&#39; (Apple Push Notifications Service) | [optional] 
**encryption** | **Boolean** | Optional parameter. Specifies if the message will be encrypted or not. For APNS transport type the value is always \&quot;false\&quot; | [optional] 
**address** | **String** | PubNub channel name. For APNS transport type - internal identifier of a device \&quot;device_token\&quot; | [optional] 
**subscriberKey** | **String** | PubNub subscriber credentials required to subscribe to the channel | [optional] 
**secretKey** | **String** | PubNub subscriber credentials required to subscribe to the channel. Optional (for PubNub transport type only) | [optional] 
**encryptionAlgorithm** | **String** | Encryption algorithm &#39;AES&#39; (for PubNub transport type only) | [optional] 
**encryptionKey** | **String** | Key for notification message decryption (for PubNub transport type only) | [optional] 


