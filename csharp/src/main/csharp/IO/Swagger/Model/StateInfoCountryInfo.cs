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
    public partial class StateInfoCountryInfo :  IEquatable<StateInfoCountryInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StateInfoCountryInfo" /> class.
        /// Initializes a new instance of the <see cref="StateInfoCountryInfo" />class.
        /// </summary>
        /// <param name="Id">Internal identifier of a state.</param>
        /// <param name="Uri">Canonical URI of a state.</param>

        public StateInfoCountryInfo(string Id = null, string Uri = null)
        {
            this.Id = Id;
            this.Uri = Uri;
            
        }
        
    
        /// <summary>
        /// Internal identifier of a state
        /// </summary>
        /// <value>Internal identifier of a state</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Canonical URI of a state
        /// </summary>
        /// <value>Canonical URI of a state</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateInfoCountryInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            
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
            return this.Equals(obj as StateInfoCountryInfo);
        }

        /// <summary>
        /// Returns true if StateInfoCountryInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of StateInfoCountryInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateInfoCountryInfo other)
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
                
                return hash;
            }
        }

    }
}
