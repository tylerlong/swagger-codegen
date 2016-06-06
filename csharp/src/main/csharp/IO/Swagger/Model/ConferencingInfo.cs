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
    public partial class ConferencingInfo :  IEquatable<ConferencingInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConferencingInfo" /> class.
        /// Initializes a new instance of the <see cref="ConferencingInfo" />class.
        /// </summary>
        /// <param name="Uri">Canonical URI of a conferencing.</param>
        /// <param name="AllowJoinBeforeHost">Determines if host user allows conference participants to join before the host.</param>
        /// <param name="HostCode">Access code for a host user.</param>
        /// <param name="Mode">Internal parameter specifying conferencing engine.</param>
        /// <param name="ParticipantCode">Access code for any participant.</param>
        /// <param name="PhoneNumber">Primary conference phone number for user&#39;s home country returned in E.164 (11-digits) format.</param>
        /// <param name="TapToJoinUri">Short URL leading to the service web page Tap to Join for audio conference bridge.</param>
        /// <param name="PhoneNumbers">List of multiple dial-in phone numbers to connect to audio conference service, relevant for user&#39;s brand. Each number is given with the country and location information, in order to let the user choose the less expensive way to connect to a conference. The first number in the list is the primary conference number, that is default and domestic.</param>

        public ConferencingInfo(string Uri = null, bool? AllowJoinBeforeHost = null, string HostCode = null, string Mode = null, string ParticipantCode = null, string PhoneNumber = null, string TapToJoinUri = null, List<ConferencingInfoPhoneNumberInfo> PhoneNumbers = null)
        {
            this.Uri = Uri;
            this.AllowJoinBeforeHost = AllowJoinBeforeHost;
            this.HostCode = HostCode;
            this.Mode = Mode;
            this.ParticipantCode = ParticipantCode;
            this.PhoneNumber = PhoneNumber;
            this.TapToJoinUri = TapToJoinUri;
            this.PhoneNumbers = PhoneNumbers;
            
        }
        
    
        /// <summary>
        /// Canonical URI of a conferencing
        /// </summary>
        /// <value>Canonical URI of a conferencing</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Determines if host user allows conference participants to join before the host
        /// </summary>
        /// <value>Determines if host user allows conference participants to join before the host</value>
        [DataMember(Name="allowJoinBeforeHost", EmitDefaultValue=false)]
        public bool? AllowJoinBeforeHost { get; set; }
    
        /// <summary>
        /// Access code for a host user
        /// </summary>
        /// <value>Access code for a host user</value>
        [DataMember(Name="hostCode", EmitDefaultValue=false)]
        public string HostCode { get; set; }
    
        /// <summary>
        /// Internal parameter specifying conferencing engine
        /// </summary>
        /// <value>Internal parameter specifying conferencing engine</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public string Mode { get; set; }
    
        /// <summary>
        /// Access code for any participant
        /// </summary>
        /// <value>Access code for any participant</value>
        [DataMember(Name="participantCode", EmitDefaultValue=false)]
        public string ParticipantCode { get; set; }
    
        /// <summary>
        /// Primary conference phone number for user&#39;s home country returned in E.164 (11-digits) format
        /// </summary>
        /// <value>Primary conference phone number for user&#39;s home country returned in E.164 (11-digits) format</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Short URL leading to the service web page Tap to Join for audio conference bridge
        /// </summary>
        /// <value>Short URL leading to the service web page Tap to Join for audio conference bridge</value>
        [DataMember(Name="tapToJoinUri", EmitDefaultValue=false)]
        public string TapToJoinUri { get; set; }
    
        /// <summary>
        /// List of multiple dial-in phone numbers to connect to audio conference service, relevant for user&#39;s brand. Each number is given with the country and location information, in order to let the user choose the less expensive way to connect to a conference. The first number in the list is the primary conference number, that is default and domestic
        /// </summary>
        /// <value>List of multiple dial-in phone numbers to connect to audio conference service, relevant for user&#39;s brand. Each number is given with the country and location information, in order to let the user choose the less expensive way to connect to a conference. The first number in the list is the primary conference number, that is default and domestic</value>
        [DataMember(Name="phoneNumbers", EmitDefaultValue=false)]
        public List<ConferencingInfoPhoneNumberInfo> PhoneNumbers { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConferencingInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  AllowJoinBeforeHost: ").Append(AllowJoinBeforeHost).Append("\n");
            sb.Append("  HostCode: ").Append(HostCode).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  ParticipantCode: ").Append(ParticipantCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  TapToJoinUri: ").Append(TapToJoinUri).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            
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
            return this.Equals(obj as ConferencingInfo);
        }

        /// <summary>
        /// Returns true if ConferencingInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ConferencingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConferencingInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.AllowJoinBeforeHost == other.AllowJoinBeforeHost ||
                    this.AllowJoinBeforeHost != null &&
                    this.AllowJoinBeforeHost.Equals(other.AllowJoinBeforeHost)
                ) && 
                (
                    this.HostCode == other.HostCode ||
                    this.HostCode != null &&
                    this.HostCode.Equals(other.HostCode)
                ) && 
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
                ) && 
                (
                    this.ParticipantCode == other.ParticipantCode ||
                    this.ParticipantCode != null &&
                    this.ParticipantCode.Equals(other.ParticipantCode)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.TapToJoinUri == other.TapToJoinUri ||
                    this.TapToJoinUri != null &&
                    this.TapToJoinUri.Equals(other.TapToJoinUri)
                ) && 
                (
                    this.PhoneNumbers == other.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(other.PhoneNumbers)
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
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                if (this.AllowJoinBeforeHost != null)
                    hash = hash * 59 + this.AllowJoinBeforeHost.GetHashCode();
                
                if (this.HostCode != null)
                    hash = hash * 59 + this.HostCode.GetHashCode();
                
                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();
                
                if (this.ParticipantCode != null)
                    hash = hash * 59 + this.ParticipantCode.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.TapToJoinUri != null)
                    hash = hash * 59 + this.TapToJoinUri.GetHashCode();
                
                if (this.PhoneNumbers != null)
                    hash = hash * 59 + this.PhoneNumbers.GetHashCode();
                
                return hash;
            }
        }

    }
}
