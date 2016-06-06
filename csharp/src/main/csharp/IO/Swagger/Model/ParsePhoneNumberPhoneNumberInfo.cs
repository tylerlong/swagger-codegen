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
    public partial class ParsePhoneNumberPhoneNumberInfo :  IEquatable<ParsePhoneNumberPhoneNumberInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParsePhoneNumberPhoneNumberInfo" /> class.
        /// Initializes a new instance of the <see cref="ParsePhoneNumberPhoneNumberInfo" />class.
        /// </summary>
        /// <param name="AreaCode">Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See North American Numbering Plan for details.</param>
        /// <param name="Country">Information on a country the phone number belongs to.</param>
        /// <param name="Dialable">Dialing format of a phone number.</param>
        /// <param name="E164">E.164 (11-digits) format of a phone number.</param>
        /// <param name="FormattedInternational">International format of a phone number.</param>
        /// <param name="FormattedNational">Domestic format of a phone number.</param>
        /// <param name="OriginalString">One of the numbers to be parsed, passed as a string in response.</param>
        /// <param name="Special">\&quot;True\&quot; if the number is in a special format (for example N11 code).</param>
        /// <param name="Normalized">E.164 (11-digits) format of a phone number without the plus sign (&#39;+&#39;).</param>

        public ParsePhoneNumberPhoneNumberInfo(string AreaCode = null, List<ParsePhoneNumberCountryInfo> Country = null, string Dialable = null, string E164 = null, string FormattedInternational = null, string FormattedNational = null, string OriginalString = null, bool? Special = null, string Normalized = null)
        {
            this.AreaCode = AreaCode;
            this.Country = Country;
            this.Dialable = Dialable;
            this.E164 = E164;
            this.FormattedInternational = FormattedInternational;
            this.FormattedNational = FormattedNational;
            this.OriginalString = OriginalString;
            this.Special = Special;
            this.Normalized = Normalized;
            
        }
        
    
        /// <summary>
        /// Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See North American Numbering Plan for details
        /// </summary>
        /// <value>Area code of the location (3-digit usually), according to the NANP number format, that can be summarized as NPA-NXX-xxxx and covers Canada, the United States, parts of the Caribbean Sea, and some Atlantic and Pacific islands. See North American Numbering Plan for details</value>
        [DataMember(Name="areaCode", EmitDefaultValue=false)]
        public string AreaCode { get; set; }
    
        /// <summary>
        /// Information on a country the phone number belongs to
        /// </summary>
        /// <value>Information on a country the phone number belongs to</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public List<ParsePhoneNumberCountryInfo> Country { get; set; }
    
        /// <summary>
        /// Dialing format of a phone number
        /// </summary>
        /// <value>Dialing format of a phone number</value>
        [DataMember(Name="dialable", EmitDefaultValue=false)]
        public string Dialable { get; set; }
    
        /// <summary>
        /// E.164 (11-digits) format of a phone number
        /// </summary>
        /// <value>E.164 (11-digits) format of a phone number</value>
        [DataMember(Name="e164", EmitDefaultValue=false)]
        public string E164 { get; set; }
    
        /// <summary>
        /// International format of a phone number
        /// </summary>
        /// <value>International format of a phone number</value>
        [DataMember(Name="formattedInternational", EmitDefaultValue=false)]
        public string FormattedInternational { get; set; }
    
        /// <summary>
        /// Domestic format of a phone number
        /// </summary>
        /// <value>Domestic format of a phone number</value>
        [DataMember(Name="formattedNational", EmitDefaultValue=false)]
        public string FormattedNational { get; set; }
    
        /// <summary>
        /// One of the numbers to be parsed, passed as a string in response
        /// </summary>
        /// <value>One of the numbers to be parsed, passed as a string in response</value>
        [DataMember(Name="originalString", EmitDefaultValue=false)]
        public string OriginalString { get; set; }
    
        /// <summary>
        /// \&quot;True\&quot; if the number is in a special format (for example N11 code)
        /// </summary>
        /// <value>\&quot;True\&quot; if the number is in a special format (for example N11 code)</value>
        [DataMember(Name="special", EmitDefaultValue=false)]
        public bool? Special { get; set; }
    
        /// <summary>
        /// E.164 (11-digits) format of a phone number without the plus sign (&#39;+&#39;)
        /// </summary>
        /// <value>E.164 (11-digits) format of a phone number without the plus sign (&#39;+&#39;)</value>
        [DataMember(Name="normalized", EmitDefaultValue=false)]
        public string Normalized { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParsePhoneNumberPhoneNumberInfo {\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Dialable: ").Append(Dialable).Append("\n");
            sb.Append("  E164: ").Append(E164).Append("\n");
            sb.Append("  FormattedInternational: ").Append(FormattedInternational).Append("\n");
            sb.Append("  FormattedNational: ").Append(FormattedNational).Append("\n");
            sb.Append("  OriginalString: ").Append(OriginalString).Append("\n");
            sb.Append("  Special: ").Append(Special).Append("\n");
            sb.Append("  Normalized: ").Append(Normalized).Append("\n");
            
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
            return this.Equals(obj as ParsePhoneNumberPhoneNumberInfo);
        }

        /// <summary>
        /// Returns true if ParsePhoneNumberPhoneNumberInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ParsePhoneNumberPhoneNumberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParsePhoneNumberPhoneNumberInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AreaCode == other.AreaCode ||
                    this.AreaCode != null &&
                    this.AreaCode.Equals(other.AreaCode)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.SequenceEqual(other.Country)
                ) && 
                (
                    this.Dialable == other.Dialable ||
                    this.Dialable != null &&
                    this.Dialable.Equals(other.Dialable)
                ) && 
                (
                    this.E164 == other.E164 ||
                    this.E164 != null &&
                    this.E164.Equals(other.E164)
                ) && 
                (
                    this.FormattedInternational == other.FormattedInternational ||
                    this.FormattedInternational != null &&
                    this.FormattedInternational.Equals(other.FormattedInternational)
                ) && 
                (
                    this.FormattedNational == other.FormattedNational ||
                    this.FormattedNational != null &&
                    this.FormattedNational.Equals(other.FormattedNational)
                ) && 
                (
                    this.OriginalString == other.OriginalString ||
                    this.OriginalString != null &&
                    this.OriginalString.Equals(other.OriginalString)
                ) && 
                (
                    this.Special == other.Special ||
                    this.Special != null &&
                    this.Special.Equals(other.Special)
                ) && 
                (
                    this.Normalized == other.Normalized ||
                    this.Normalized != null &&
                    this.Normalized.Equals(other.Normalized)
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
                
                if (this.AreaCode != null)
                    hash = hash * 59 + this.AreaCode.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                if (this.Dialable != null)
                    hash = hash * 59 + this.Dialable.GetHashCode();
                
                if (this.E164 != null)
                    hash = hash * 59 + this.E164.GetHashCode();
                
                if (this.FormattedInternational != null)
                    hash = hash * 59 + this.FormattedInternational.GetHashCode();
                
                if (this.FormattedNational != null)
                    hash = hash * 59 + this.FormattedNational.GetHashCode();
                
                if (this.OriginalString != null)
                    hash = hash * 59 + this.OriginalString.GetHashCode();
                
                if (this.Special != null)
                    hash = hash * 59 + this.Special.GetHashCode();
                
                if (this.Normalized != null)
                    hash = hash * 59 + this.Normalized.GetHashCode();
                
                return hash;
            }
        }

    }
}
