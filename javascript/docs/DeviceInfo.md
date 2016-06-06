# RingCentralApi.DeviceInfo

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** | Internal identifier of a device | [optional] 
**uri** | **String** | Canonical URI of a device | [optional] 
**sku** | **String** | Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example &#39;HP-56-2-2&#39; | [optional] 
**type** | **String** | Device type. The default value is &#39;HardPhone&#39; | [optional] 
**name** | **String** | Device name. Mandatory if ordering \&quot;SoftPhone\&quot; or \&quot;OtherPhone\&quot;. Optional for \&quot;HardPhone\&quot;. If not specified for HardPhone, then device \&quot;model\&quot; name is used as device \&quot;name\&quot; | [optional] 
**serial** | **String** | Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications | [optional] 
**computerName** | **String** | PC name for softphone | [optional] 
**model** | [**ModelInfo**](ModelInfo.md) |  | [optional] 
**extension** | [**DeviceInfoExtensionInfo**](DeviceInfoExtensionInfo.md) |  | [optional] 
**emergencyServiceAddress** | [**EmergencyAddressInfo**](EmergencyAddressInfo.md) |  | [optional] 
**phoneLines** | [**PhoneLinesInfo**](PhoneLinesInfo.md) |  | [optional] 
**shipping** | [**ShippingInfo**](ShippingInfo.md) |  | [optional] 
**boxBillingId** | **Integer** | Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. Either \&quot;model\&quot; structure, or \&quot;boxBillingId\&quot; must be specified for HardPhone | [optional] 


