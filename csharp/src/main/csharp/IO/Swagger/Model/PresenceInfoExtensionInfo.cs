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
    public partial class PresenceInfoExtensionInfo :  IEquatable<PresenceInfoExtensionInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceInfoExtensionInfo" /> class.
        /// Initializes a new instance of the <see cref="PresenceInfoExtensionInfo" />class.
        /// </summary>
        /// <param name="Id">Internal identifier of an extension.</param>
        /// <param name="Uri">Canonical URI of an extension.</param>
        /// <param name="ExtensionNumber">Extension number (usually 3 or 4 digits).</param>

        public PresenceInfoExtensionInfo(string Id = null, string Uri = null, string ExtensionNumber = null)
        {
            this.Id = Id;
            this.Uri = Uri;
            this.ExtensionNumber = ExtensionNumber;
            
        }
        
    
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        /// <value>Internal identifier of an extension</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Canonical URI of an extension
        /// </summary>
        /// <value>Canonical URI of an extension</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Extension number (usually 3 or 4 digits)
        /// </summary>
        /// <value>Extension number (usually 3 or 4 digits)</value>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PresenceInfoExtensionInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            
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
            return this.Equals(obj as PresenceInfoExtensionInfo);
        }

        /// <summary>
        /// Returns true if PresenceInfoExtensionInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of PresenceInfoExtensionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PresenceInfoExtensionInfo other)
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
                    this.ExtensionNumber == other.ExtensionNumber ||
                    this.ExtensionNumber != null &&
                    this.ExtensionNumber.Equals(other.ExtensionNumber)
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
                
                if (this.ExtensionNumber != null)
                    hash = hash * 59 + this.ExtensionNumber.GetHashCode();
                
                return hash;
            }
        }

    }
}
