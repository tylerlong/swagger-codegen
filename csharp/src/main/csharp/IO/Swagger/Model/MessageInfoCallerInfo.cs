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
    public partial class MessageInfoCallerInfo :  IEquatable<MessageInfoCallerInfo>
    { 
    
        /// <summary>
        /// Status of a message. Returned for outbound fax messages only
        /// </summary>
        /// <value>Status of a message. Returned for outbound fax messages only</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MessageStatusEnum {
            
            [EnumMember(Value = "Queued")]
            Queued,
            
            [EnumMember(Value = "Sent")]
            Sent,
            
            [EnumMember(Value = "Delivered")]
            Delivered,
            
            [EnumMember(Value = "DeliveryFailed")]
            Deliveryfailed,
            
            [EnumMember(Value = "SendingFailed")]
            Sendingfailed,
            
            [EnumMember(Value = "Received")]
            Received
        }

    
        /// <summary>
        /// Fax only. Error code returned in case of fax sending failure. Returned if messageStatus value is 'SendingFailed'
        /// </summary>
        /// <value>Fax only. Error code returned in case of fax sending failure. Returned if messageStatus value is 'SendingFailed'</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FaxErrorCodeEnum {
            
            [EnumMember(Value = "Undefined")]
            Undefined,
            
            [EnumMember(Value = "NoFaxSendPermission")]
            Nofaxsendpermission,
            
            [EnumMember(Value = "NoInternationalPermission")]
            Nointernationalpermission,
            
            [EnumMember(Value = "NoFaxMachine")]
            Nofaxmachine,
            
            [EnumMember(Value = "OutgoingCallError")]
            Outgoingcallerror,
            
            [EnumMember(Value = "RenderingFailed")]
            Renderingfailed,
            
            [EnumMember(Value = "TooManyPages")]
            Toomanypages,
            
            [EnumMember(Value = "ReturnToDBQueue")]
            Returntodbqueue,
            
            [EnumMember(Value = "NoCallTime")]
            Nocalltime,
            
            [EnumMember(Value = "WrongNumber")]
            Wrongnumber,
            
            [EnumMember(Value = "ProhibitedNumber")]
            Prohibitednumber,
            
            [EnumMember(Value = "InternalError")]
            Internalerror,
            
            [EnumMember(Value = "FaxSendingProhibited")]
            Faxsendingprohibited,
            
            [EnumMember(Value = "ThePhoneIsBlacklisted")]
            Thephoneisblacklisted,
            
            [EnumMember(Value = "UserNotFound")]
            Usernotfound,
            
            [EnumMember(Value = "ConvertError")]
            Converterror,
            
            [EnumMember(Value = "DBGeneralError")]
            Dbgeneralerror,
            
            [EnumMember(Value = "SkypeBillingFailed")]
            Skypebillingfailed,
            
            [EnumMember(Value = "AccountSuspended")]
            Accountsuspended,
            
            [EnumMember(Value = "ProhibitedDestination")]
            Prohibiteddestination,
            
            [EnumMember(Value = "InternationalDisabled")]
            Internationaldisabled
        }

    
        /// <summary>
        /// Status of a message. Returned for outbound fax messages only
        /// </summary>
        /// <value>Status of a message. Returned for outbound fax messages only</value>
        [DataMember(Name="messageStatus", EmitDefaultValue=false)]
        public MessageStatusEnum? MessageStatus { get; set; }
    
        /// <summary>
        /// Fax only. Error code returned in case of fax sending failure. Returned if messageStatus value is 'SendingFailed'
        /// </summary>
        /// <value>Fax only. Error code returned in case of fax sending failure. Returned if messageStatus value is 'SendingFailed'</value>
        [DataMember(Name="faxErrorCode", EmitDefaultValue=false)]
        public FaxErrorCodeEnum? FaxErrorCode { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageInfoCallerInfo" /> class.
        /// Initializes a new instance of the <see cref="MessageInfoCallerInfo" />class.
        /// </summary>
        /// <param name="ExtensionNumber">Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message.</param>
        /// <param name="Location">Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers).</param>
        /// <param name="MessageStatus">Status of a message. Returned for outbound fax messages only.</param>
        /// <param name="FaxErrorCode">Fax only. Error code returned in case of fax sending failure. Returned if messageStatus value is &#39;SendingFailed&#39;.</param>
        /// <param name="Name">Symbolic name associated with a party. If the phone does not belong to the known extension, only the location is returned, the name is not determined then.</param>
        /// <param name="PhoneNumber">Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS.</param>

        public MessageInfoCallerInfo(string ExtensionNumber = null, string Location = null, MessageStatusEnum? MessageStatus = null, FaxErrorCodeEnum? FaxErrorCode = null, string Name = null, string PhoneNumber = null)
        {
            this.ExtensionNumber = ExtensionNumber;
            this.Location = Location;
            this.MessageStatus = MessageStatus;
            this.FaxErrorCode = FaxErrorCode;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            
        }
        
    
        /// <summary>
        /// Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message
        /// </summary>
        /// <value>Extension short number (usually 3 or 4 digits). This property is filled when parties communicate by means of short internal numbers, for example when calling to other extension or sending/receiving Company Pager message</value>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }
    
        /// <summary>
        /// Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)
        /// </summary>
        /// <value>Contains party location (city, state) if one can be determined from phoneNumber. This property is filled only when phoneNumber is not empty and server can calculate location information from it (for example, this information is unavailable for US toll-free numbers)</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
    
        /// <summary>
        /// Symbolic name associated with a party. If the phone does not belong to the known extension, only the location is returned, the name is not determined then
        /// </summary>
        /// <value>Symbolic name associated with a party. If the phone does not belong to the known extension, only the location is returned, the name is not determined then</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS
        /// </summary>
        /// <value>Phone number of a party. Usually it is a plain number including country and area code like 18661234567. But sometimes it could be returned from database with some formatting applied, for example (866)123-4567. This property is filled in all cases where parties communicate by means of global phone numbers, for example when calling to direct numbers or sending/receiving SMS</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageInfoCallerInfo {\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  MessageStatus: ").Append(MessageStatus).Append("\n");
            sb.Append("  FaxErrorCode: ").Append(FaxErrorCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as MessageInfoCallerInfo);
        }

        /// <summary>
        /// Returns true if MessageInfoCallerInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of MessageInfoCallerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageInfoCallerInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExtensionNumber == other.ExtensionNumber ||
                    this.ExtensionNumber != null &&
                    this.ExtensionNumber.Equals(other.ExtensionNumber)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.MessageStatus == other.MessageStatus ||
                    this.MessageStatus != null &&
                    this.MessageStatus.Equals(other.MessageStatus)
                ) && 
                (
                    this.FaxErrorCode == other.FaxErrorCode ||
                    this.FaxErrorCode != null &&
                    this.FaxErrorCode.Equals(other.FaxErrorCode)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.ExtensionNumber != null)
                    hash = hash * 59 + this.ExtensionNumber.GetHashCode();
                
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                
                if (this.MessageStatus != null)
                    hash = hash * 59 + this.MessageStatus.GetHashCode();
                
                if (this.FaxErrorCode != null)
                    hash = hash * 59 + this.FaxErrorCode.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                return hash;
            }
        }

    }
}
