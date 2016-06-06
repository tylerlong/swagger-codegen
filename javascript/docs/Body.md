# RingCentralApi.Body

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**responseType** | **String** | Must be set to code | [optional] 
**clientId** | **String** | Required. Enter your application key (Production or Sandbox) here | [optional] 
**redirectUri** | **String** | Required. This is a callback URI which determines where the response will be sent to. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration. This URI can be HTTP/HTTPS address for web applications or custom scheme URI for mobile or desktop applications. | [optional] 
**state** | **String** | Optional, recommended. An opaque value used by the client to maintain state between the request and callback. The authorization server includes this value when redirecting the user-agent back to the client. The parameter should be used for preventing cross-site request forgery | [optional] 


