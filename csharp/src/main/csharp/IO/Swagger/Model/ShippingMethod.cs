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
    public partial class ShippingMethod :  IEquatable<ShippingMethod>
    { 
    
        /// <summary>
        /// Method identifier. The default value is \"1\" (Ground)
        /// </summary>
        /// <value>Method identifier. The default value is \"1\" (Ground)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IdEnum {
            
            [EnumMember(Value = "1")]
            _1,
            
            [EnumMember(Value = "2")]
            _2,
            
            [EnumMember(Value = "3")]
            _3
        }

    
        /// <summary>
        /// Method name, corresponding to the identifier
        /// </summary>
        /// <value>Method name, corresponding to the identifier</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum {
            
            [EnumMember(Value = "Ground")]
            Ground,
            
            [EnumMember(Value = "2 Day")]
            _2Day,
            
            [EnumMember(Value = "Overnight")]
            Overnight
        }

    
        /// <summary>
        /// Method identifier. The default value is \"1\" (Ground)
        /// </summary>
        /// <value>Method identifier. The default value is \"1\" (Ground)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public IdEnum? Id { get; set; }
    
        /// <summary>
        /// Method name, corresponding to the identifier
        /// </summary>
        /// <value>Method name, corresponding to the identifier</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingMethod" /> class.
        /// Initializes a new instance of the <see cref="ShippingMethod" />class.
        /// </summary>
        /// <param name="Id">Method identifier. The default value is \&quot;1\&quot; (Ground).</param>
        /// <param name="Name">Method name, corresponding to the identifier.</param>

        public ShippingMethod(IdEnum? Id = null, NameEnum? Name = null)
        {
            this.Id = Id;
            this.Name = Name;
            
        }
        
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingMethod {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            
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
            return this.Equals(obj as ShippingMethod);
        }

        /// <summary>
        /// Returns true if ShippingMethod instances are equal
        /// </summary>
        /// <param name="other">Instance of ShippingMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingMethod other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }
}
