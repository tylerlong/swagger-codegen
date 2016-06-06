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
    public partial class ExtensionInfoRequestProvisionContactInfo :  IEquatable<ExtensionInfoRequestProvisionContactInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestProvisionContactInfo" /> class.
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestProvisionContactInfo" />class.
        /// </summary>
        /// <param name="FirstName">Mandatory. Extension user first name.</param>
        /// <param name="LastName">Mandatory. Extension user last name.</param>
        /// <param name="Email">Mandatory. Extension user contact email.</param>

        public ExtensionInfoRequestProvisionContactInfo(string FirstName = null, string LastName = null, string Email = null)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            
        }
        
    
        /// <summary>
        /// Mandatory. Extension user first name
        /// </summary>
        /// <value>Mandatory. Extension user first name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
    
        /// <summary>
        /// Mandatory. Extension user last name
        /// </summary>
        /// <value>Mandatory. Extension user last name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
    
        /// <summary>
        /// Mandatory. Extension user contact email
        /// </summary>
        /// <value>Mandatory. Extension user contact email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionInfoRequestProvisionContactInfo {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            
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
            return this.Equals(obj as ExtensionInfoRequestProvisionContactInfo);
        }

        /// <summary>
        /// Returns true if ExtensionInfoRequestProvisionContactInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtensionInfoRequestProvisionContactInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionInfoRequestProvisionContactInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
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
                
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                return hash;
            }
        }

    }
}
