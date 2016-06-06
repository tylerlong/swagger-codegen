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
    public partial class ConferencingInfoPhoneNumberInfo :  IEquatable<ConferencingInfoPhoneNumberInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferencingInfoPhoneNumberInfo" /> class.
        /// Initializes a new instance of the <see cref="ConferencingInfoPhoneNumberInfo" />class.
        /// </summary>
        /// <param name="Country">Country.</param>
        /// <param name="_Default">&#39;True&#39; if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed.</param>
        /// <param name="HasGreeting">&#39;True&#39; if the greeting message is played on this number.</param>
        /// <param name="Location">Location (city, region, state) of a conference phone number.</param>
        /// <param name="PhoneNumber">Dial-in phone number to connect to a conference.</param>

        public ConferencingInfoPhoneNumberInfo(ConferencingInfoPhoneNumberInfoCountryInfo Country = null, bool? _Default = null, bool? HasGreeting = null, string Location = null, string PhoneNumber = null)
        {
            this.Country = Country;
            this._Default = _Default;
            this.HasGreeting = HasGreeting;
            this.Location = Location;
            this.PhoneNumber = PhoneNumber;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public ConferencingInfoPhoneNumberInfoCountryInfo Country { get; set; }
    
        /// <summary>
        /// &#39;True&#39; if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed
        /// </summary>
        /// <value>&#39;True&#39; if the number is default for the conference. Default conference number is a domestic number that can be set by user (otherwise it is set by the system). Only one default number per country is allowed</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? _Default { get; set; }
    
        /// <summary>
        /// &#39;True&#39; if the greeting message is played on this number
        /// </summary>
        /// <value>&#39;True&#39; if the greeting message is played on this number</value>
        [DataMember(Name="hasGreeting", EmitDefaultValue=false)]
        public bool? HasGreeting { get; set; }
    
        /// <summary>
        /// Location (city, region, state) of a conference phone number
        /// </summary>
        /// <value>Location (city, region, state) of a conference phone number</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
    
        /// <summary>
        /// Dial-in phone number to connect to a conference
        /// </summary>
        /// <value>Dial-in phone number to connect to a conference</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConferencingInfoPhoneNumberInfo {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("  HasGreeting: ").Append(HasGreeting).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(obj as ConferencingInfoPhoneNumberInfo);
        }

        /// <summary>
        /// Returns true if ConferencingInfoPhoneNumberInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ConferencingInfoPhoneNumberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConferencingInfoPhoneNumberInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
                ) && 
                (
                    this.HasGreeting == other.HasGreeting ||
                    this.HasGreeting != null &&
                    this.HasGreeting.Equals(other.HasGreeting)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
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
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
                
                if (this.HasGreeting != null)
                    hash = hash * 59 + this.HasGreeting.GetHashCode();
                
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                return hash;
            }
        }

    }
}
