using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class DeviceInfo :  IEquatable<DeviceInfo>
    { 
    
        /// <summary>
        /// Device type. The default value is 'HardPhone'
        /// </summary>
        /// <value>Device type. The default value is 'HardPhone'</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "SoftPhone")]
            Softphone,
            
            [EnumMember(Value = "OtherPhone")]
            Otherphone,
            
            [EnumMember(Value = "HardPhone")]
            Hardphone
        }

    
        /// <summary>
        /// Device type. The default value is 'HardPhone'
        /// </summary>
        /// <value>Device type. The default value is 'HardPhone'</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInfo" /> class.
        /// Initializes a new instance of the <see cref="DeviceInfo" />class.
        /// </summary>
        /// <param name="Id">Internal identifier of a device.</param>
        /// <param name="Uri">Canonical URI of a device.</param>
        /// <param name="Sku">Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example &#39;HP-56-2-2&#39;.</param>
        /// <param name="Type">Device type. The default value is &#39;HardPhone&#39;.</param>
        /// <param name="Name">Device name. Mandatory if ordering \&quot;SoftPhone\&quot; or \&quot;OtherPhone\&quot;. Optional for \&quot;HardPhone\&quot;. If not specified for HardPhone, then device \&quot;model\&quot; name is used as device \&quot;name\&quot;.</param>
        /// <param name="Serial">Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications.</param>
        /// <param name="ComputerName">PC name for softphone.</param>
        /// <param name="Model">Model.</param>
        /// <param name="Extension">Extension.</param>
        /// <param name="EmergencyServiceAddress">EmergencyServiceAddress.</param>
        /// <param name="PhoneLines">PhoneLines.</param>
        /// <param name="Shipping">Shipping.</param>
        /// <param name="BoxBillingId">Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. Either \&quot;model\&quot; structure, or \&quot;boxBillingId\&quot; must be specified for HardPhone.</param>

        public DeviceInfo(string Id = null, string Uri = null, string Sku = null, TypeEnum? Type = null, string Name = null, string Serial = null, string ComputerName = null, ModelInfo Model = null, DeviceInfoExtensionInfo Extension = null, EmergencyAddressInfo EmergencyServiceAddress = null, PhoneLinesInfo PhoneLines = null, ShippingInfo Shipping = null, int? BoxBillingId = null)
        {
            this.Id = Id;
            this.Uri = Uri;
            this.Sku = Sku;
            this.Type = Type;
            this.Name = Name;
            this.Serial = Serial;
            this.ComputerName = ComputerName;
            this.Model = Model;
            this.Extension = Extension;
            this.EmergencyServiceAddress = EmergencyServiceAddress;
            this.PhoneLines = PhoneLines;
            this.Shipping = Shipping;
            this.BoxBillingId = BoxBillingId;
            
        }
        
    
        /// <summary>
        /// Internal identifier of a device
        /// </summary>
        /// <value>Internal identifier of a device</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Canonical URI of a device
        /// </summary>
        /// <value>Canonical URI of a device</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example &#39;HP-56-2-2&#39;
        /// </summary>
        /// <value>Device identification number (stock keeping unit) in the format TP-ID [-AT-AC], where TP is device type (HP for RC HardPhone, DV for all other devices including softphone); ID - device model ID; AT -addon type ID; AC - addon count (if any). For example &#39;HP-56-2-2&#39;</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
    
        /// <summary>
        /// Device name. Mandatory if ordering \&quot;SoftPhone\&quot; or \&quot;OtherPhone\&quot;. Optional for \&quot;HardPhone\&quot;. If not specified for HardPhone, then device \&quot;model\&quot; name is used as device \&quot;name\&quot;
        /// </summary>
        /// <value>Device name. Mandatory if ordering \&quot;SoftPhone\&quot; or \&quot;OtherPhone\&quot;. Optional for \&quot;HardPhone\&quot;. If not specified for HardPhone, then device \&quot;model\&quot; name is used as device \&quot;name\&quot;</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications
        /// </summary>
        /// <value>Serial number for HardPhone (is returned only when the phone is shipped and provisioned); endpoint_id for softphone and mobile applications</value>
        [DataMember(Name="serial", EmitDefaultValue=false)]
        public string Serial { get; set; }
    
        /// <summary>
        /// PC name for softphone
        /// </summary>
        /// <value>PC name for softphone</value>
        [DataMember(Name="computerName", EmitDefaultValue=false)]
        public string ComputerName { get; set; }
    
        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public ModelInfo Model { get; set; }
    
        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public DeviceInfoExtensionInfo Extension { get; set; }
    
        /// <summary>
        /// Gets or Sets EmergencyServiceAddress
        /// </summary>
        [DataMember(Name="emergencyServiceAddress", EmitDefaultValue=false)]
        public EmergencyAddressInfo EmergencyServiceAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets PhoneLines
        /// </summary>
        [DataMember(Name="phoneLines", EmitDefaultValue=false)]
        public PhoneLinesInfo PhoneLines { get; set; }
    
        /// <summary>
        /// Gets or Sets Shipping
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public ShippingInfo Shipping { get; set; }
    
        /// <summary>
        /// Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. Either \&quot;model\&quot; structure, or \&quot;boxBillingId\&quot; must be specified for HardPhone
        /// </summary>
        /// <value>Box billing identifier of a device. Applicable only for HardPhones. It is an alternative way to identify the device to be ordered. Either \&quot;model\&quot; structure, or \&quot;boxBillingId\&quot; must be specified for HardPhone</value>
        [DataMember(Name="boxBillingId", EmitDefaultValue=false)]
        public int? BoxBillingId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  ComputerName: ").Append(ComputerName).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  EmergencyServiceAddress: ").Append(EmergencyServiceAddress).Append("\n");
            sb.Append("  PhoneLines: ").Append(PhoneLines).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  BoxBillingId: ").Append(BoxBillingId).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as DeviceInfo);
        }

        /// <summary>
        /// Returns true if DeviceInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Serial == other.Serial ||
                    this.Serial != null &&
                    this.Serial.Equals(other.Serial)
                ) && 
                (
                    this.ComputerName == other.ComputerName ||
                    this.ComputerName != null &&
                    this.ComputerName.Equals(other.ComputerName)
                ) && 
                (
                    this.Model == other.Model ||
                    this.Model != null &&
                    this.Model.Equals(other.Model)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.EmergencyServiceAddress == other.EmergencyServiceAddress ||
                    this.EmergencyServiceAddress != null &&
                    this.EmergencyServiceAddress.Equals(other.EmergencyServiceAddress)
                ) && 
                (
                    this.PhoneLines == other.PhoneLines ||
                    this.PhoneLines != null &&
                    this.PhoneLines.Equals(other.PhoneLines)
                ) && 
                (
                    this.Shipping == other.Shipping ||
                    this.Shipping != null &&
                    this.Shipping.Equals(other.Shipping)
                ) && 
                (
                    this.BoxBillingId == other.BoxBillingId ||
                    this.BoxBillingId != null &&
                    this.BoxBillingId.Equals(other.BoxBillingId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Serial != null)
                    hash = hash * 59 + this.Serial.GetHashCode();
                
                if (this.ComputerName != null)
                    hash = hash * 59 + this.ComputerName.GetHashCode();
                
                if (this.Model != null)
                    hash = hash * 59 + this.Model.GetHashCode();
                
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                
                if (this.EmergencyServiceAddress != null)
                    hash = hash * 59 + this.EmergencyServiceAddress.GetHashCode();
                
                if (this.PhoneLines != null)
                    hash = hash * 59 + this.PhoneLines.GetHashCode();
                
                if (this.Shipping != null)
                    hash = hash * 59 + this.Shipping.GetHashCode();
                
                if (this.BoxBillingId != null)
                    hash = hash * 59 + this.BoxBillingId.GetHashCode();
                
                return hash;
            }
        }

    }
}
