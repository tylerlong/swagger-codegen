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
    public partial class ReferenceInfo :  IEquatable<ReferenceInfo>
    { 
    
        /// <summary>
        /// Type of external identifier
        /// </summary>
        /// <value>Type of external identifier</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "PartnerId")]
            Partnerid,
            
            [EnumMember(Value = "CustomerDirectoryId")]
            Customerdirectoryid
        }

    
        /// <summary>
        /// Type of external identifier
        /// </summary>
        /// <value>Type of external identifier</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceInfo" /> class.
        /// Initializes a new instance of the <see cref="ReferenceInfo" />class.
        /// </summary>
        /// <param name="_Ref">Non-RC identifier of an extension.</param>
        /// <param name="Type">Type of external identifier.</param>

        public ReferenceInfo(string _Ref = null, TypeEnum? Type = null)
        {
            this._Ref = _Ref;
            this.Type = Type;
            
        }
        
    
        /// <summary>
        /// Non-RC identifier of an extension
        /// </summary>
        /// <value>Non-RC identifier of an extension</value>
        [DataMember(Name="ref", EmitDefaultValue=false)]
        public string _Ref { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferenceInfo {\n");
            sb.Append("  _Ref: ").Append(_Ref).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            
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
            return this.Equals(obj as ReferenceInfo);
        }

        /// <summary>
        /// Returns true if ReferenceInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ReferenceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferenceInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Ref == other._Ref ||
                    this._Ref != null &&
                    this._Ref.Equals(other._Ref)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this._Ref != null)
                    hash = hash * 59 + this._Ref.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }

    }
}
