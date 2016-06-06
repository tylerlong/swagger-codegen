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
    public partial class ExtensionInfoRequestProvision :  IEquatable<ExtensionInfoRequestProvision>
    { 
    
        /// <summary>
        /// Mandatory. Resulting extension status
        /// </summary>
        /// <value>Mandatory. Resulting extension status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "NotActivated")]
            Notactivated
        }

    
        /// <summary>
        /// Mandatory. Resulting extension status
        /// </summary>
        /// <value>Mandatory. Resulting extension status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestProvision" /> class.
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestProvision" />class.
        /// </summary>
        /// <param name="Status">Mandatory. Resulting extension status.</param>
        /// <param name="Contact">Contact.</param>

        public ExtensionInfoRequestProvision(StatusEnum? Status = null, ExtensionInfoRequestProvisionContactInfo Contact = null)
        {
            this.Status = Status;
            this.Contact = Contact;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public ExtensionInfoRequestProvisionContactInfo Contact { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionInfoRequestProvision {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            
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
            return this.Equals(obj as ExtensionInfoRequestProvision);
        }

        /// <summary>
        /// Returns true if ExtensionInfoRequestProvision instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtensionInfoRequestProvision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionInfoRequestProvision other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                
                return hash;
            }
        }

    }
}
