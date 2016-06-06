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
    public partial class ServiceFeatureInfo :  IEquatable<ServiceFeatureInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceFeatureInfo" /> class.
        /// Initializes a new instance of the <see cref="ServiceFeatureInfo" />class.
        /// </summary>
        /// <param name="FeatureName">Feature name, see all available values in Service Feature List.</param>
        /// <param name="Enabled">Feature status, shows feature availability for the extension.</param>

        public ServiceFeatureInfo(string FeatureName = null, bool? Enabled = null)
        {
            this.FeatureName = FeatureName;
            this.Enabled = Enabled;
            
        }
        
    
        /// <summary>
        /// Feature name, see all available values in Service Feature List
        /// </summary>
        /// <value>Feature name, see all available values in Service Feature List</value>
        [DataMember(Name="featureName", EmitDefaultValue=false)]
        public string FeatureName { get; set; }
    
        /// <summary>
        /// Feature status, shows feature availability for the extension
        /// </summary>
        /// <value>Feature status, shows feature availability for the extension</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceFeatureInfo {\n");
            sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
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
            return this.Equals(obj as ServiceFeatureInfo);
        }

        /// <summary>
        /// Returns true if ServiceFeatureInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ServiceFeatureInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceFeatureInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FeatureName == other.FeatureName ||
                    this.FeatureName != null &&
                    this.FeatureName.Equals(other.FeatureName)
                ) && 
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
                
                if (this.FeatureName != null)
                    hash = hash * 59 + this.FeatureName.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                return hash;
            }
        }

    }
}
