# RingCentralApi.ExtensionInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** | Internal identifier of an extension | [optional] 
**uri** | **String** | Canonical URI of an extension | [optional] 
**contact** | [**ContactInfo**](ContactInfo.md) |  | [optional] 
**departments** | [**DepartmentInfo**](DepartmentInfo.md) |  | [optional] 
**extensionNumber** | **String** | Number of department extension | [optional] 
**name** | **String** | Extension user name | [optional] 
**partnerId** | **String** | For Partner Applications Internal identifier of an extension created by partner. The RingCentral supports the mapping of accounts and stores the corresponding account ID/extension ID for each partner ID of a client application. In request URIs partner IDs are accepted instead of regular RingCentral native IDs as path parameters using pid = XXX clause. Though in response URIs contain the corresponding account IDs and extension IDs. In all request and response bodies these values are reflected via partnerId attributes of account and extension | [optional] 
**permissions** | [**ExtensionPermissions**](ExtensionPermissions.md) |  | [optional] 
**profileImage** | [**ProfileImageInfo**](ProfileImageInfo.md) |  | [optional] 
**references** | [**[ReferenceInfo]**](ReferenceInfo.md) | List of non-RC internal identifiers assigned to an extension | [optional] 
**regionalSettings** | [**RegionalSettings**](RegionalSettings.md) |  | [optional] 
**serviceFeatures** | [**[ExtensionServiceFeatureInfo]**](ExtensionServiceFeatureInfo.md) | Extension service features returned in response only when the logged-in user requests his/her own extension info, see also Extension Service Features | [optional] 
**setupWizardState** | **String** | Specifies extension configuration wizard state (web service setup). The default value is &#39;NotStarted&#39; | [optional] 
**status** | **String** | Extension current state. If the status is &#39;Unassigned&#39;. Returned for all extensions | [optional] 
**statusInfo** | [**StatusInfo**](StatusInfo.md) |  | [optional] 
**type** | **String** | Extension type | [optional] 


