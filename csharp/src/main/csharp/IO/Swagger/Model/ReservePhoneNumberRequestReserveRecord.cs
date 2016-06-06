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
    public partial class ReservePhoneNumberRequestReserveRecord :  IEquatable<ReservePhoneNumberRequestReserveRecord>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservePhoneNumberRequestReserveRecord" /> class.
        /// Initializes a new instance of the <see cref="ReservePhoneNumberRequestReserveRecord" />class.
        /// </summary>
        /// <param name="PhoneNumber">Phone number in E.164 format without a &#39;+&#39;.</param>
        /// <param name="ReservedTill">The datetime up to which the number is reserved in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. If it is omitted or explicitly set to &#39;null&#39;, the number will be un-reserved if it was reserved previously by the same session. &#39;Min&#39; value is 30 seconds; &#39;Max&#39; value is 30 days (for reservation by brand) and 20 minutes (for reservation by account/session).</param>

        public ReservePhoneNumberRequestReserveRecord(string PhoneNumber = null, DateTime? ReservedTill = null)
        {
            this.PhoneNumber = PhoneNumber;
            this.ReservedTill = ReservedTill;
            
        }
        
    
        /// <summary>
        /// Phone number in E.164 format without a &#39;+&#39;
        /// </summary>
        /// <value>Phone number in E.164 format without a &#39;+&#39;</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// The datetime up to which the number is reserved in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. If it is omitted or explicitly set to &#39;null&#39;, the number will be un-reserved if it was reserved previously by the same session. &#39;Min&#39; value is 30 seconds; &#39;Max&#39; value is 30 days (for reservation by brand) and 20 minutes (for reservation by account/session)
        /// </summary>
        /// <value>The datetime up to which the number is reserved in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. If it is omitted or explicitly set to &#39;null&#39;, the number will be un-reserved if it was reserved previously by the same session. &#39;Min&#39; value is 30 seconds; &#39;Max&#39; value is 30 days (for reservation by brand) and 20 minutes (for reservation by account/session)</value>
        [DataMember(Name="reservedTill", EmitDefaultValue=false)]
        public DateTime? ReservedTill { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReservePhoneNumberRequestReserveRecord {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  ReservedTill: ").Append(ReservedTill).Append("\n");
            
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
            return this.Equals(obj as ReservePhoneNumberRequestReserveRecord);
        }

        /// <summary>
        /// Returns true if ReservePhoneNumberRequestReserveRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of ReservePhoneNumberRequestReserveRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReservePhoneNumberRequestReserveRecord other)
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
                    this.ReservedTill == other.ReservedTill ||
                    this.ReservedTill != null &&
                    this.ReservedTill.Equals(other.ReservedTill)
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
                
                if (this.ReservedTill != null)
                    hash = hash * 59 + this.ReservedTill.GetHashCode();
                
                return hash;
            }
        }

    }
}
