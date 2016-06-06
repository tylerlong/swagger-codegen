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
    public partial class GrantInfo :  IEquatable<GrantInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantInfo" /> class.
        /// Initializes a new instance of the <see cref="GrantInfo" />class.
        /// </summary>
        /// <param name="Uri">Canonical URI of a grant.</param>
        /// <param name="Extension">Extension.</param>
        /// <param name="CallPickup">Specifies if picking up of other extensions&#39; calls is allowed for the extension. If &#39;Presence&#39; feature is disabled for the given extension, the flag is not returned.</param>
        /// <param name="CallMonitoring">Specifies if monitoring of other extensions&#39; calls is allowed for the extension. If &#39;CallMonitoring&#39; feature is disabled for the given extension, the flag is not returned.</param>

        public GrantInfo(string Uri = null, GrantInfoExtensionInfo Extension = null, bool? CallPickup = null, bool? CallMonitoring = null)
        {
            this.Uri = Uri;
            this.Extension = Extension;
            this.CallPickup = CallPickup;
            this.CallMonitoring = CallMonitoring;
            
        }
        
    
        /// <summary>
        /// Canonical URI of a grant
        /// </summary>
        /// <value>Canonical URI of a grant</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public GrantInfoExtensionInfo Extension { get; set; }
    
        /// <summary>
        /// Specifies if picking up of other extensions&#39; calls is allowed for the extension. If &#39;Presence&#39; feature is disabled for the given extension, the flag is not returned
        /// </summary>
        /// <value>Specifies if picking up of other extensions&#39; calls is allowed for the extension. If &#39;Presence&#39; feature is disabled for the given extension, the flag is not returned</value>
        [DataMember(Name="callPickup", EmitDefaultValue=false)]
        public bool? CallPickup { get; set; }
    
        /// <summary>
        /// Specifies if monitoring of other extensions&#39; calls is allowed for the extension. If &#39;CallMonitoring&#39; feature is disabled for the given extension, the flag is not returned
        /// </summary>
        /// <value>Specifies if monitoring of other extensions&#39; calls is allowed for the extension. If &#39;CallMonitoring&#39; feature is disabled for the given extension, the flag is not returned</value>
        [DataMember(Name="callMonitoring", EmitDefaultValue=false)]
        public bool? CallMonitoring { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  CallPickup: ").Append(CallPickup).Append("\n");
            sb.Append("  CallMonitoring: ").Append(CallMonitoring).Append("\n");
            
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
            return this.Equals(obj as GrantInfo);
        }

        /// <summary>
        /// Returns true if GrantInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of GrantInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.CallPickup == other.CallPickup ||
                    this.CallPickup != null &&
                    this.CallPickup.Equals(other.CallPickup)
                ) && 
                (
                    this.CallMonitoring == other.CallMonitoring ||
                    this.CallMonitoring != null &&
                    this.CallMonitoring.Equals(other.CallMonitoring)
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
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                
                if (this.CallPickup != null)
                    hash = hash * 59 + this.CallPickup.GetHashCode();
                
                if (this.CallMonitoring != null)
                    hash = hash * 59 + this.CallMonitoring.GetHashCode();
                
                return hash;
            }
        }

    }
}
