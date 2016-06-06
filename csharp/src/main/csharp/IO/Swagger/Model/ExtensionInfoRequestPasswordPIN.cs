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
    public partial class ExtensionInfoRequestPasswordPIN :  IEquatable<ExtensionInfoRequestPasswordPIN>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestPasswordPIN" /> class.
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestPasswordPIN" />class.
        /// </summary>
        /// <param name="Password">Password for extension.</param>
        /// <param name="IvrPin">IVR PIN.</param>

        public ExtensionInfoRequestPasswordPIN(string Password = null, string IvrPin = null)
        {
            this.Password = Password;
            this.IvrPin = IvrPin;
            
        }
        
    
        /// <summary>
        /// Password for extension
        /// </summary>
        /// <value>Password for extension</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
    
        /// <summary>
        /// IVR PIN
        /// </summary>
        /// <value>IVR PIN</value>
        [DataMember(Name="ivrPin", EmitDefaultValue=false)]
        public string IvrPin { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionInfoRequestPasswordPIN {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  IvrPin: ").Append(IvrPin).Append("\n");
            
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
            return this.Equals(obj as ExtensionInfoRequestPasswordPIN);
        }

        /// <summary>
        /// Returns true if ExtensionInfoRequestPasswordPIN instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtensionInfoRequestPasswordPIN to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionInfoRequestPasswordPIN other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.IvrPin == other.IvrPin ||
                    this.IvrPin != null &&
                    this.IvrPin.Equals(other.IvrPin)
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
                
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                
                if (this.IvrPin != null)
                    hash = hash * 59 + this.IvrPin.GetHashCode();
                
                return hash;
            }
        }

    }
}
