# RingCentralApi.SubscriptionInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** | Internal identifier of a subscription | [optional] 
**uri** | **String** | Canonical URI of a subscription | [optional] 
**eventFilters** | **[String]** | Collection of URIs to API resources (message-store/presence/detailed presence) | [optional] 
**expirationTime** | **Date** | Subscription expiration datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**expiresIn** | **Integer** | Subscription lifetime in seconds. The default value is 900 | [optional] 
**status** | **String** | Subscription status | [optional] 
**creationTime** | **Date** | Subscription creation datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z | [optional] 
**deliveryMode** | [**DeliveryMode**](DeliveryMode.md) |  | [optional] 


