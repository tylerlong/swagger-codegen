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
    public partial class ExtensionPermissions :  IEquatable<ExtensionPermissions>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionPermissions" /> class.
        /// Initializes a new instance of the <see cref="ExtensionPermissions" />class.
        /// </summary>
        /// <param name="Admin">Admin.</param>
        /// <param name="InternationalCalling">InternationalCalling.</param>

        public ExtensionPermissions(PermissionInfo Admin = null, PermissionInfo InternationalCalling = null)
        {
            this.Admin = Admin;
            this.InternationalCalling = InternationalCalling;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [DataMember(Name="admin", EmitDefaultValue=false)]
        public PermissionInfo Admin { get; set; }
    
        /// <summary>
        /// Gets or Sets InternationalCalling
        /// </summary>
        [DataMember(Name="internationalCalling", EmitDefaultValue=false)]
        public PermissionInfo InternationalCalling { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionPermissions {\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  InternationalCalling: ").Append(InternationalCalling).Append("\n");
            
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
            return this.Equals(obj as ExtensionPermissions);
        }

        /// <summary>
        /// Returns true if ExtensionPermissions instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtensionPermissions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionPermissions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Admin == other.Admin ||
                    this.Admin != null &&
                    this.Admin.Equals(other.Admin)
                ) && 
                (
                    this.InternationalCalling == other.InternationalCalling ||
                    this.InternationalCalling != null &&
                    this.InternationalCalling.Equals(other.InternationalCalling)
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
                
                if (this.Admin != null)
                    hash = hash * 59 + this.Admin.GetHashCode();
                
                if (this.InternationalCalling != null)
                    hash = hash * 59 + this.InternationalCalling.GetHashCode();
                
                return hash;
            }
        }

    }
}
