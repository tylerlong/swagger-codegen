# RingCentralApi.InlineResponseDefault1

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**endpointId** | **String** | Unique identifier of a client application passed by the client, or auto-generated by server if not specified in request | [optional] 
**scope** | **String** | List of permissions allowed with this access token, white-space separated | [optional] 
**ownerId** | **String** | Extension identifier | [optional] 
**tokenType** | **String** | Type of token. Use this parameter in Authorization header of requests | [optional] 
**expiresIn** | **Integer** | Issued access token TTL (time to live), in seconds | [optional] 
**refreshToken** | **String** | Refresh token to get a new access token, when the issued one expires | [optional] 
**refreshTokenExpiresIn** | **Integer** | Issued refresh token TTL (time to live), in seconds | [optional] 
**accessToken** | **String** | Access token to pass to subsequent API requests | [optional] 

