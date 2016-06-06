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
    public partial class UnconditionalForwardingInfo :  IEquatable<UnconditionalForwardingInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UnconditionalForwardingInfo" /> class.
        /// Initializes a new instance of the <see cref="UnconditionalForwardingInfo" />class.
        /// </summary>
        /// <param name="PhoneNumber">Phone number to which the call is forwarded.</param>

        public UnconditionalForwardingInfo(string PhoneNumber = null)
        {
            this.PhoneNumber = PhoneNumber;
            
        }
        
    
        /// <summary>
        /// Phone number to which the call is forwarded
        /// </summary>
        /// <value>Phone number to which the call is forwarded</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnconditionalForwardingInfo {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            
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
            return this.Equals(obj as UnconditionalForwardingInfo);
        }

        /// <summary>
        /// Returns true if UnconditionalForwardingInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of UnconditionalForwardingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnconditionalForwardingInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                return hash;
            }
        }

    }
}
