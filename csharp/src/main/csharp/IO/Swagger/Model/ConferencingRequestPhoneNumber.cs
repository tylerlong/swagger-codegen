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
    public partial class ConferencingRequestPhoneNumber :  IEquatable<ConferencingRequestPhoneNumber>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferencingRequestPhoneNumber" /> class.
        /// Initializes a new instance of the <see cref="ConferencingRequestPhoneNumber" />class.
        /// </summary>
        /// <param name="PhoneNumber">Dial-in phone number to connect to a conference.</param>
        /// <param name="_Default">&#39;True&#39; if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed.</param>

        public ConferencingRequestPhoneNumber(string PhoneNumber = null, bool? _Default = null)
        {
            this.PhoneNumber = PhoneNumber;
            this._Default = _Default;
            
        }
        
    
        /// <summary>
        /// Dial-in phone number to connect to a conference
        /// </summary>
        /// <value>Dial-in phone number to connect to a conference</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// &#39;True&#39; if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed
        /// </summary>
        /// <value>&#39;True&#39; if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? _Default { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConferencingRequestPhoneNumber {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            
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
            return this.Equals(obj as ConferencingRequestPhoneNumber);
        }

        /// <summary>
        /// Returns true if ConferencingRequestPhoneNumber instances are equal
        /// </summary>
        /// <param name="other">Instance of ConferencingRequestPhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConferencingRequestPhoneNumber other)
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
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
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
                
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
                
                return hash;
            }
        }

    }
}
