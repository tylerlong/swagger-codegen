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
    public partial class ExtensionInfoRequestPartnerId :  IEquatable<ExtensionInfoRequestPartnerId>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestPartnerId" /> class.
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestPartnerId" />class.
        /// </summary>
        /// <param name="PartnerId">Extension partner identifier.</param>

        public ExtensionInfoRequestPartnerId(string PartnerId = null)
        {
            this.PartnerId = PartnerId;
            
        }
        
    
        /// <summary>
        /// Extension partner identifier
        /// </summary>
        /// <value>Extension partner identifier</value>
        [DataMember(Name="partnerId", EmitDefaultValue=false)]
        public string PartnerId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionInfoRequestPartnerId {\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            
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
            return this.Equals(obj as ExtensionInfoRequestPartnerId);
        }

        /// <summary>
        /// Returns true if ExtensionInfoRequestPartnerId instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtensionInfoRequestPartnerId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionInfoRequestPartnerId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PartnerId == other.PartnerId ||
                    this.PartnerId != null &&
                    this.PartnerId.Equals(other.PartnerId)
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
                
                if (this.PartnerId != null)
                    hash = hash * 59 + this.PartnerId.GetHashCode();
                
                return hash;
            }
        }

    }
}
