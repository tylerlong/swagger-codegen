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
    public partial class PermissionInfo :  IEquatable<PermissionInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionInfo" /> class.
        /// Initializes a new instance of the <see cref="PermissionInfo" />class.
        /// </summary>
        /// <param name="Enabled">Specifies if a permission is enabled or not.</param>

        public PermissionInfo(bool? Enabled = null)
        {
            this.Enabled = Enabled;
            
        }
        
    
        /// <summary>
        /// Specifies if a permission is enabled or not
        /// </summary>
        /// <value>Specifies if a permission is enabled or not</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionInfo {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            
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
            return this.Equals(obj as PermissionInfo);
        }

        /// <summary>
        /// Returns true if PermissionInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of PermissionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
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
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                return hash;
            }
        }

    }
}
