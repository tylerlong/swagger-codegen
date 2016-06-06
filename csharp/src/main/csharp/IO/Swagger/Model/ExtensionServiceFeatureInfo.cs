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
    public partial class ExtensionServiceFeatureInfo :  IEquatable<ExtensionServiceFeatureInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionServiceFeatureInfo" /> class.
        /// Initializes a new instance of the <see cref="ExtensionServiceFeatureInfo" />class.
        /// </summary>
        /// <param name="Enabled">Feature status; shows feature availability for an extension.</param>
        /// <param name="FeatureName">Feature name, see all available values in Service Feature List.</param>
        /// <param name="Reason">Reason of limitation for a particular service feature. Returned only if the enabled parameter value is &#39;False&#39;, see Service Feature Limitations and Reasons. When retrieving service features for an extension, the reasons for the limitations, if any, are returned in response.</param>

        public ExtensionServiceFeatureInfo(bool? Enabled = null, string FeatureName = null, string Reason = null)
        {
            this.Enabled = Enabled;
            this.FeatureName = FeatureName;
            this.Reason = Reason;
            
        }
        
    
        /// <summary>
        /// Feature status; shows feature availability for an extension
        /// </summary>
        /// <value>Feature status; shows feature availability for an extension</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Feature name, see all available values in Service Feature List
        /// </summary>
        /// <value>Feature name, see all available values in Service Feature List</value>
        [DataMember(Name="featureName", EmitDefaultValue=false)]
        public string FeatureName { get; set; }
    
        /// <summary>
        /// Reason of limitation for a particular service feature. Returned only if the enabled parameter value is &#39;False&#39;, see Service Feature Limitations and Reasons. When retrieving service features for an extension, the reasons for the limitations, if any, are returned in response
        /// </summary>
        /// <value>Reason of limitation for a particular service feature. Returned only if the enabled parameter value is &#39;False&#39;, see Service Feature Limitations and Reasons. When retrieving service features for an extension, the reasons for the limitations, if any, are returned in response</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionServiceFeatureInfo {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            
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
            return this.Equals(obj as ExtensionServiceFeatureInfo);
        }

        /// <summary>
        /// Returns true if ExtensionServiceFeatureInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtensionServiceFeatureInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionServiceFeatureInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.FeatureName == other.FeatureName ||
                    this.FeatureName != null &&
                    this.FeatureName.Equals(other.FeatureName)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                
                if (this.FeatureName != null)
                    hash = hash * 59 + this.FeatureName.GetHashCode();
                
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                
                return hash;
            }
        }

    }
}
