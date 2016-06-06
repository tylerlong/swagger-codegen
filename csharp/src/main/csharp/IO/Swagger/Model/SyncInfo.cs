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
    public partial class SyncInfo :  IEquatable<SyncInfo>
    { 
    
        /// <summary>
        /// Type of synchronization
        /// </summary>
        /// <value>Type of synchronization</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SyncTypeEnum {
            
            [EnumMember(Value = "FSync")]
            Fsync,
            
            [EnumMember(Value = "ISync")]
            Isync
        }

    
        /// <summary>
        /// Type of synchronization
        /// </summary>
        /// <value>Type of synchronization</value>
        [DataMember(Name="syncType", EmitDefaultValue=false)]
        public SyncTypeEnum? SyncType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SyncInfo" /> class.
        /// Initializes a new instance of the <see cref="SyncInfo" />class.
        /// </summary>
        /// <param name="SyncType">Type of synchronization.</param>
        /// <param name="SyncToken">Synchronization token.</param>
        /// <param name="SyncTime">Last synchronization datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z.</param>

        public SyncInfo(SyncTypeEnum? SyncType = null, string SyncToken = null, DateTime? SyncTime = null)
        {
            this.SyncType = SyncType;
            this.SyncToken = SyncToken;
            this.SyncTime = SyncTime;
            
        }
        
    
        /// <summary>
        /// Synchronization token
        /// </summary>
        /// <value>Synchronization token</value>
        [DataMember(Name="syncToken", EmitDefaultValue=false)]
        public string SyncToken { get; set; }
    
        /// <summary>
        /// Last synchronization datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>Last synchronization datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="syncTime", EmitDefaultValue=false)]
        public DateTime? SyncTime { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyncInfo {\n");
            sb.Append("  SyncType: ").Append(SyncType).Append("\n");
            sb.Append("  SyncToken: ").Append(SyncToken).Append("\n");
            sb.Append("  SyncTime: ").Append(SyncTime).Append("\n");
            
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
            return this.Equals(obj as SyncInfo);
        }

        /// <summary>
        /// Returns true if SyncInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of SyncInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyncInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SyncType == other.SyncType ||
                    this.SyncType != null &&
                    this.SyncType.Equals(other.SyncType)
                ) && 
                (
                    this.SyncToken == other.SyncToken ||
                    this.SyncToken != null &&
                    this.SyncToken.Equals(other.SyncToken)
                ) && 
                (
                    this.SyncTime == other.SyncTime ||
                    this.SyncTime != null &&
                    this.SyncTime.Equals(other.SyncTime)
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
                
                if (this.SyncType != null)
                    hash = hash * 59 + this.SyncType.GetHashCode();
                
                if (this.SyncToken != null)
                    hash = hash * 59 + this.SyncToken.GetHashCode();
                
                if (this.SyncTime != null)
                    hash = hash * 59 + this.SyncTime.GetHashCode();
                
                return hash;
            }
        }

    }
}
