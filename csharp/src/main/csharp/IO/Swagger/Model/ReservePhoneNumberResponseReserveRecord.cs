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
    public partial class ReservePhoneNumberResponseReserveRecord :  IEquatable<ReservePhoneNumberResponseReserveRecord>
    { 
    
        /// <summary>
        /// Phone number status
        /// </summary>
        /// <value>Phone number status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "Enabled")]
            Enabled,
            
            [EnumMember(Value = "Pending")]
            Pending,
            
            [EnumMember(Value = "Disabled")]
            Disabled
        }

    
        /// <summary>
        /// The error code in case of reservation/un-reservation failure
        /// </summary>
        /// <value>The error code in case of reservation/un-reservation failure</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ErrorEnum {
            
            [EnumMember(Value = "NumberIsAlreadyProvisioned")]
            Numberisalreadyprovisioned,
            
            [EnumMember(Value = "NumberReserved")]
            Numberreserved,
            
            [EnumMember(Value = "NumberNotAvailable")]
            Numbernotavailable
        }

    
        /// <summary>
        /// Phone number status
        /// </summary>
        /// <value>Phone number status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// The error code in case of reservation/un-reservation failure
        /// </summary>
        /// <value>The error code in case of reservation/un-reservation failure</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public ErrorEnum? Error { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservePhoneNumberResponseReserveRecord" /> class.
        /// Initializes a new instance of the <see cref="ReservePhoneNumberResponseReserveRecord" />class.
        /// </summary>
        /// <param name="PhoneNumber">Phone number in E.164 format without a &#39;+&#39;.</param>
        /// <param name="FormattedNumber">Domestic format of a phone number.</param>
        /// <param name="ReservedTill">The datetime up to which the number is reserved in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. No value means that number is not reserved anymore.</param>
        /// <param name="ReservationId">Internal identifier of phone number reservation; encoded data including reservation type (by brand, by account, by session), particular brand/account/session data, and reservation date and time.</param>
        /// <param name="Status">Phone number status.</param>
        /// <param name="Error">The error code in case of reservation/un-reservation failure.</param>

        public ReservePhoneNumberResponseReserveRecord(string PhoneNumber = null, string FormattedNumber = null, DateTime? ReservedTill = null, string ReservationId = null, StatusEnum? Status = null, ErrorEnum? Error = null)
        {
            this.PhoneNumber = PhoneNumber;
            this.FormattedNumber = FormattedNumber;
            this.ReservedTill = ReservedTill;
            this.ReservationId = ReservationId;
            this.Status = Status;
            this.Error = Error;
            
        }
        
    
        /// <summary>
        /// Phone number in E.164 format without a &#39;+&#39;
        /// </summary>
        /// <value>Phone number in E.164 format without a &#39;+&#39;</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Domestic format of a phone number
        /// </summary>
        /// <value>Domestic format of a phone number</value>
        [DataMember(Name="formattedNumber", EmitDefaultValue=false)]
        public string FormattedNumber { get; set; }
    
        /// <summary>
        /// The datetime up to which the number is reserved in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. No value means that number is not reserved anymore
        /// </summary>
        /// <value>The datetime up to which the number is reserved in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z. No value means that number is not reserved anymore</value>
        [DataMember(Name="reservedTill", EmitDefaultValue=false)]
        public DateTime? ReservedTill { get; set; }
    
        /// <summary>
        /// Internal identifier of phone number reservation; encoded data including reservation type (by brand, by account, by session), particular brand/account/session data, and reservation date and time
        /// </summary>
        /// <value>Internal identifier of phone number reservation; encoded data including reservation type (by brand, by account, by session), particular brand/account/session data, and reservation date and time</value>
        [DataMember(Name="reservationId", EmitDefaultValue=false)]
        public string ReservationId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReservePhoneNumberResponseReserveRecord {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  FormattedNumber: ").Append(FormattedNumber).Append("\n");
            sb.Append("  ReservedTill: ").Append(ReservedTill).Append("\n");
            sb.Append("  ReservationId: ").Append(ReservationId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            
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
            return this.Equals(obj as ReservePhoneNumberResponseReserveRecord);
        }

        /// <summary>
        /// Returns true if ReservePhoneNumberResponseReserveRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of ReservePhoneNumberResponseReserveRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReservePhoneNumberResponseReserveRecord other)
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
                    this.ReservedTill == other.ReservedTill ||
                    this.ReservedTill != null &&
                    this.ReservedTill.Equals(other.ReservedTill)
                ) && 
                (
                    this.ReservationId == other.ReservationId ||
                    this.ReservationId != null &&
                    this.ReservationId.Equals(other.ReservationId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
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
                
                if (this.ReservedTill != null)
                    hash = hash * 59 + this.ReservedTill.GetHashCode();
                
                if (this.ReservationId != null)
                    hash = hash * 59 + this.ReservationId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                
                return hash;
            }
        }

    }
}
