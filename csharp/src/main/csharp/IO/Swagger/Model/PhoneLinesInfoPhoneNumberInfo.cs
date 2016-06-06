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
    public partial class PhoneLinesInfoPhoneNumberInfo :  IEquatable<PhoneLinesInfoPhoneNumberInfo>
    { 
    
        /// <summary>
        /// Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system
        /// </summary>
        /// <value>Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentTypeEnum {
            
            [EnumMember(Value = "External")]
            External,
            
            [EnumMember(Value = "TollFree")]
            Tollfree,
            
            [EnumMember(Value = "Local")]
            Local
        }

    
        /// <summary>
        /// Phone number type
        /// </summary>
        /// <value>Phone number type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "VoiceFax")]
            Voicefax,
            
            [EnumMember(Value = "FaxOnly")]
            Faxonly,
            
            [EnumMember(Value = "VoiceOnly")]
            Voiceonly
        }

    
        /// <summary>
        /// Usage type of the phone number
        /// </summary>
        /// <value>Usage type of the phone number</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UsageTypeEnum {
            
            [EnumMember(Value = "MainCompanyNumber")]
            Maincompanynumber,
            
            [EnumMember(Value = "AdditionalCompanyNumber")]
            Additionalcompanynumber,
            
            [EnumMember(Value = "CompanyNumber")]
            Companynumber,
            
            [EnumMember(Value = "DirectNumber")]
            Directnumber,
            
            [EnumMember(Value = "CompanyFaxNumber")]
            Companyfaxnumber,
            
            [EnumMember(Value = "ForwardedNumber")]
            Forwardednumber
        }

    
        /// <summary>
        /// Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system
        /// </summary>
        /// <value>Payment type. 'External' is returned for forwarded numbers which are not terminated in the RingCentral phone system</value>
        [DataMember(Name="paymentType", EmitDefaultValue=false)]
        public PaymentTypeEnum? PaymentType { get; set; }
    
        /// <summary>
        /// Phone number type
        /// </summary>
        /// <value>Phone number type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Usage type of the phone number
        /// </summary>
        /// <value>Usage type of the phone number</value>
        [DataMember(Name="usageType", EmitDefaultValue=false)]
        public UsageTypeEnum? UsageType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneLinesInfoPhoneNumberInfo" /> class.
        /// Initializes a new instance of the <see cref="PhoneLinesInfoPhoneNumberInfo" />class.
        /// </summary>
        /// <param name="Id">Internal identifier of a phone number.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Location">Location (City, State). Filled for local US numbers.</param>
        /// <param name="PaymentType">Payment type. &#39;External&#39; is returned for forwarded numbers which are not terminated in the RingCentral phone system.</param>
        /// <param name="PhoneNumber">Phone number.</param>
        /// <param name="Status">Status of a phone number. If the value is &#39;Normal&#39;, the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral.</param>
        /// <param name="Type">Phone number type.</param>
        /// <param name="UsageType">Usage type of the phone number.</param>

        public PhoneLinesInfoPhoneNumberInfo(int? Id = null, CountryInfo Country = null, string Location = null, PaymentTypeEnum? PaymentType = null, string PhoneNumber = null, string Status = null, TypeEnum? Type = null, UsageTypeEnum? UsageType = null)
        {
            this.Id = Id;
            this.Country = Country;
            this.Location = Location;
            this.PaymentType = PaymentType;
            this.PhoneNumber = PhoneNumber;
            this.Status = Status;
            this.Type = Type;
            this.UsageType = UsageType;
            
        }
        
    
        /// <summary>
        /// Internal identifier of a phone number
        /// </summary>
        /// <value>Internal identifier of a phone number</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public CountryInfo Country { get; set; }
    
        /// <summary>
        /// Location (City, State). Filled for local US numbers
        /// </summary>
        /// <value>Location (City, State). Filled for local US numbers</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
    
        /// <summary>
        /// Phone number
        /// </summary>
        /// <value>Phone number</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Status of a phone number. If the value is &#39;Normal&#39;, the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral
        /// </summary>
        /// <value>Status of a phone number. If the value is &#39;Normal&#39;, the phone number is ready to be used. Otherwise it is an external number not yet ported to RingCentral</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneLinesInfoPhoneNumberInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UsageType: ").Append(UsageType).Append("\n");
            
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
            return this.Equals(obj as PhoneLinesInfoPhoneNumberInfo);
        }

        /// <summary>
        /// Returns true if PhoneLinesInfoPhoneNumberInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneLinesInfoPhoneNumberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneLinesInfoPhoneNumberInfo other)
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
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.PaymentType == other.PaymentType ||
                    this.PaymentType != null &&
                    this.PaymentType.Equals(other.PaymentType)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.UsageType == other.UsageType ||
                    this.UsageType != null &&
                    this.UsageType.Equals(other.UsageType)
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
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                
                if (this.PaymentType != null)
                    hash = hash * 59 + this.PaymentType.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.UsageType != null)
                    hash = hash * 59 + this.UsageType.GetHashCode();
                
                return hash;
            }
        }

    }
}
