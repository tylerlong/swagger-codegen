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
    public partial class RingOutRequestFrom :  IEquatable<RingOutRequestFrom>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RingOutRequestFrom" /> class.
        /// Initializes a new instance of the <see cref="RingOutRequestFrom" />class.
        /// </summary>
        /// <param name="PhoneNumber">Phone number in E.164 format.</param>
        /// <param name="ForwardingNumberId">Internal identifier of a forwarding number; returned in response in the id field. Can be specified instead of the phoneNumber attribute.</param>

        public RingOutRequestFrom(string PhoneNumber = null, string ForwardingNumberId = null)
        {
            this.PhoneNumber = PhoneNumber;
            this.ForwardingNumberId = ForwardingNumberId;
            
        }
        
    
        /// <summary>
        /// Phone number in E.164 format
        /// </summary>
        /// <value>Phone number in E.164 format</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Internal identifier of a forwarding number; returned in response in the id field. Can be specified instead of the phoneNumber attribute
        /// </summary>
        /// <value>Internal identifier of a forwarding number; returned in response in the id field. Can be specified instead of the phoneNumber attribute</value>
        [DataMember(Name="forwardingNumberId", EmitDefaultValue=false)]
        public string ForwardingNumberId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RingOutRequestFrom {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  ForwardingNumberId: ").Append(ForwardingNumberId).Append("\n");
            
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
            return this.Equals(obj as RingOutRequestFrom);
        }

        /// <summary>
        /// Returns true if RingOutRequestFrom instances are equal
        /// </summary>
        /// <param name="other">Instance of RingOutRequestFrom to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RingOutRequestFrom other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.ForwardingNumberId == other.ForwardingNumberId ||
                    this.ForwardingNumberId != null &&
                    this.ForwardingNumberId.Equals(other.ForwardingNumberId)
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
                
                if (this.ForwardingNumberId != null)
                    hash = hash * 59 + this.ForwardingNumberId.GetHashCode();
                
                return hash;
            }
        }

    }
}
