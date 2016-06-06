# RingCentralApi.PresenceInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**uri** | **String** | Canonical URI of a presence info resource | [optional] 
**allowSeeMyPresence** | **Boolean** | If &#39;True&#39; enables other extensions to see the extension presence status | [optional] 
**dndStatus** | **String** | Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR Menu/Application Extension/Park Location extensions. The &#39;DoNotAcceptDepartmentCalls&#39; and &#39;TakeDepartmentCallsOnly&#39; values are applicable only for extensions - members of a Department; if these values are set for department outsiders, the 400 Bad Request error code is returned. The &#39;TakeDepartmentCallsOnly&#39; status can be set through the old RingCentral user interface and is available for some migrated accounts only. | [optional] 
**extension** | [**PresenceInfoExtensionInfo**](PresenceInfoExtensionInfo.md) |  | [optional] 
**message** | **String** | Custom status message (as previously published by user) | [optional] 
**pickUpCallsOnHold** | **Boolean** | If &#39;True&#39; enables the extension user to pick up a monitored line on hold | [optional] 
**presenceStatus** | **String** | Aggregated presence status, calculated from a number of sources | [optional] 
**ringOnMonitoredCall** | **Boolean** | If &#39;True&#39; enables to ring extension phone, if any user monitored by this extension is ringing | [optional] 
**telephonyStatus** | **String** | Telephony presence status | [optional] 
**userStatus** | **String** | User-defined presence status (as previously published by the user) | [optional] 


