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
    public partial class AddonInfo :  IEquatable<AddonInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AddonInfo" /> class.
        /// Initializes a new instance of the <see cref="AddonInfo" />class.
        /// </summary>
        /// <param name="Id">Addon identifier. For HardPhones of certain types, which are compatible with this addon identifier.</param>
        /// <param name="Count">Number of addons. For HardPhones of certain types, which are compatible with such addon identifier.</param>

        public AddonInfo(string Id = null, int? Count = null)
        {
            this.Id = Id;
            this.Count = Count;
            
        }
        
    
        /// <summary>
        /// Addon identifier. For HardPhones of certain types, which are compatible with this addon identifier
        /// </summary>
        /// <value>Addon identifier. For HardPhones of certain types, which are compatible with this addon identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Number of addons. For HardPhones of certain types, which are compatible with such addon identifier
        /// </summary>
        /// <value>Number of addons. For HardPhones of certain types, which are compatible with such addon identifier</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddonInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            
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
            return this.Equals(obj as AddonInfo);
        }

        /// <summary>
        /// Returns true if AddonInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of AddonInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddonInfo other)
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
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                
                return hash;
            }
        }

    }
}
