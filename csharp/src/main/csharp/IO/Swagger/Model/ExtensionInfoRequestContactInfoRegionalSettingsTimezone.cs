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
    public partial class ExtensionInfoRequestContactInfoRegionalSettingsTimezone :  IEquatable<ExtensionInfoRequestContactInfoRegionalSettingsTimezone>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestContactInfoRegionalSettingsTimezone" /> class.
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestContactInfoRegionalSettingsTimezone" />class.
        /// </summary>
        /// <param name="Id">Timezone identifier. The default value is \&quot;58\&quot; (US&amp;Canada).</param>

        public ExtensionInfoRequestContactInfoRegionalSettingsTimezone(string Id = null)
        {
            this.Id = Id;
            
        }
        
    
        /// <summary>
        /// Timezone identifier. The default value is \&quot;58\&quot; (US&amp;Canada)
        /// </summary>
        /// <value>Timezone identifier. The default value is \&quot;58\&quot; (US&amp;Canada)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionInfoRequestContactInfoRegionalSettingsTimezone {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            
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
            return this.Equals(obj as ExtensionInfoRequestContactInfoRegionalSettingsTimezone);
        }

        /// <summary>
        /// Returns true if ExtensionInfoRequestContactInfoRegionalSettingsTimezone instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtensionInfoRequestContactInfoRegionalSettingsTimezone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionInfoRequestContactInfoRegionalSettingsTimezone other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                
                return hash;
            }
        }

    }
}
