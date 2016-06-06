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
    public partial class ExtensionInfoRequestStatusInfo :  IEquatable<ExtensionInfoRequestStatusInfo>
    { 
    
        /// <summary>
        /// Required extension status
        /// </summary>
        /// <value>Required extension status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "Disabled")]
            Disabled,
            
            [EnumMember(Value = "Enabled")]
            Enabled,
            
            [EnumMember(Value = "NotActivated")]
            Notactivated
        }

    
        /// <summary>
        /// Required extension status
        /// </summary>
        /// <value>Required extension status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestStatusInfo" /> class.
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestStatusInfo" />class.
        /// </summary>
        /// <param name="Status">Required extension status.</param>
        /// <param name="StatusInfo">StatusInfo.</param>

        public ExtensionInfoRequestStatusInfo(StatusEnum? Status = null, StatusInfo StatusInfo = null)
        {
            this.Status = Status;
            this.StatusInfo = StatusInfo;
            
        }
        
    
        /// <summary>
        /// Gets or Sets StatusInfo
        /// </summary>
        [DataMember(Name="statusInfo", EmitDefaultValue=false)]
        public StatusInfo StatusInfo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionInfoRequestStatusInfo {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusInfo: ").Append(StatusInfo).Append("\n");
            
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
            return this.Equals(obj as ExtensionInfoRequestStatusInfo);
        }

        /// <summary>
        /// Returns true if ExtensionInfoRequestStatusInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtensionInfoRequestStatusInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionInfoRequestStatusInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusInfo == other.StatusInfo ||
                    this.StatusInfo != null &&
                    this.StatusInfo.Equals(other.StatusInfo)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.StatusInfo != null)
                    hash = hash * 59 + this.StatusInfo.GetHashCode();
                
                return hash;
            }
        }

    }
}
