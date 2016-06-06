# RingCentralApi.ExtensionServiceFeatureInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**enabled** | **Boolean** | Feature status; shows feature availability for an extension | [optional] 
**featureName** | **String** | Feature name, see all available values in Service Feature List | [optional] 
**reason** | **String** | Reason of limitation for a particular service feature. Returned only if the enabled parameter value is &#39;False&#39;, see Service Feature Limitations and Reasons. When retrieving service features for an extension, the reasons for the limitations, if any, are returned in response | [optional] 


