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
    public partial class LookUpPhoneNumberPhoneNumberInfo :  IEquatable<LookUpPhoneNumberPhoneNumberInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LookUpPhoneNumberPhoneNumberInfo" /> class.
        /// Initializes a new instance of the <see cref="LookUpPhoneNumberPhoneNumberInfo" />class.
        /// </summary>
        /// <param name="PhoneNumber">Phone number in E.164 format without a &#39;+&#39;.</param>
        /// <param name="FormattedNumber">Phone number formatted according to current brand&#39;s default country.</param>
        /// <param name="VanityPattern">Vanity pattern for this number. Returned only when vanity search option is requested. Vanity pattern corresponds to request parameters nxx plus line or numberPattern.</param>
        /// <param name="Rank">The value is returned if the extendedSearch parameter is true. &#39;10&#39; is the closest match.</param>

        public LookUpPhoneNumberPhoneNumberInfo(string PhoneNumber = null, string FormattedNumber = null, string VanityPattern = null, int? Rank = null)
        {
            this.PhoneNumber = PhoneNumber;
            this.FormattedNumber = FormattedNumber;
            this.VanityPattern = VanityPattern;
            this.Rank = Rank;
            
        }
        
    
        /// <summary>
        /// Phone number in E.164 format without a &#39;+&#39;
        /// </summary>
        /// <value>Phone number in E.164 format without a &#39;+&#39;</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Phone number formatted according to current brand&#39;s default country
        /// </summary>
        /// <value>Phone number formatted according to current brand&#39;s default country</value>
        [DataMember(Name="formattedNumber", EmitDefaultValue=false)]
        public string FormattedNumber { get; set; }
    
        /// <summary>
        /// Vanity pattern for this number. Returned only when vanity search option is requested. Vanity pattern corresponds to request parameters nxx plus line or numberPattern
        /// </summary>
        /// <value>Vanity pattern for this number. Returned only when vanity search option is requested. Vanity pattern corresponds to request parameters nxx plus line or numberPattern</value>
        [DataMember(Name="vanityPattern", EmitDefaultValue=false)]
        public string VanityPattern { get; set; }
    
        /// <summary>
        /// The value is returned if the extendedSearch parameter is true. &#39;10&#39; is the closest match
        /// </summary>
        /// <value>The value is returned if the extendedSearch parameter is true. &#39;10&#39; is the closest match</value>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int? Rank { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LookUpPhoneNumberPhoneNumberInfo {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  FormattedNumber: ").Append(FormattedNumber).Append("\n");
            sb.Append("  VanityPattern: ").Append(VanityPattern).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            
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
            return this.Equals(obj as LookUpPhoneNumberPhoneNumberInfo);
        }

        /// <summary>
        /// Returns true if LookUpPhoneNumberPhoneNumberInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of LookUpPhoneNumberPhoneNumberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LookUpPhoneNumberPhoneNumberInfo other)
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
                    this.FormattedNumber == other.FormattedNumber ||
                    this.FormattedNumber != null &&
                    this.FormattedNumber.Equals(other.FormattedNumber)
                ) && 
                (
                    this.VanityPattern == other.VanityPattern ||
                    this.VanityPattern != null &&
                    this.VanityPattern.Equals(other.VanityPattern)
                ) && 
                (
                    this.Rank == other.Rank ||
                    this.Rank != null &&
                    this.Rank.Equals(other.Rank)
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
                
                if (this.FormattedNumber != null)
                    hash = hash * 59 + this.FormattedNumber.GetHashCode();
                
                if (this.VanityPattern != null)
                    hash = hash * 59 + this.VanityPattern.GetHashCode();
                
                if (this.Rank != null)
                    hash = hash * 59 + this.Rank.GetHashCode();
                
                return hash;
            }
        }

    }
}
