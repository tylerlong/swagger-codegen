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
    public partial class PresenceInfo :  IEquatable<PresenceInfo>
    { 
    
        /// <summary>
        /// Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR Menu/Application Extension/Park Location extensions. The 'DoNotAcceptDepartmentCalls' and 'TakeDepartmentCallsOnly' values are applicable only for extensions - members of a Department; if these values are set for department outsiders, the 400 Bad Request error code is returned. The 'TakeDepartmentCallsOnly' status can be set through the old RingCentral user interface and is available for some migrated accounts only.
        /// </summary>
        /// <value>Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR Menu/Application Extension/Park Location extensions. The 'DoNotAcceptDepartmentCalls' and 'TakeDepartmentCallsOnly' values are applicable only for extensions - members of a Department; if these values are set for department outsiders, the 400 Bad Request error code is returned. The 'TakeDepartmentCallsOnly' status can be set through the old RingCentral user interface and is available for some migrated accounts only.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DndStatusEnum {
            
            [EnumMember(Value = "TakeAllCalls")]
            Takeallcalls,
            
            [EnumMember(Value = "DoNotAcceptAnyCalls")]
            Donotacceptanycalls,
            
            [EnumMember(Value = "DoNotAcceptDepartmentCalls")]
            Donotacceptdepartmentcalls,
            
            [EnumMember(Value = "TakeDepartmentCallsOnly")]
            Takedepartmentcallsonly
        }

    
        /// <summary>
        /// Aggregated presence status, calculated from a number of sources
        /// </summary>
        /// <value>Aggregated presence status, calculated from a number of sources</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PresenceStatusEnum {
            
            [EnumMember(Value = "Offline")]
            Offline,
            
            [EnumMember(Value = "Busy")]
            Busy,
            
            [EnumMember(Value = "Available")]
            Available
        }

    
        /// <summary>
        /// Telephony presence status
        /// </summary>
        /// <value>Telephony presence status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TelephonyStatusEnum {
            
            [EnumMember(Value = "NoCall")]
            Nocall,
            
            [EnumMember(Value = "CallConnected")]
            Callconnected,
            
            [EnumMember(Value = "Ringing")]
            Ringing,
            
            [EnumMember(Value = "OnHold")]
            Onhold,
            
            [EnumMember(Value = "ParkedCall")]
            Parkedcall
        }

    
        /// <summary>
        /// User-defined presence status (as previously published by the user)
        /// </summary>
        /// <value>User-defined presence status (as previously published by the user)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UserStatusEnum {
            
            [EnumMember(Value = "Offline")]
            Offline,
            
            [EnumMember(Value = "Busy")]
            Busy,
            
            [EnumMember(Value = "Available")]
            Available
        }

    
        /// <summary>
        /// Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR Menu/Application Extension/Park Location extensions. The 'DoNotAcceptDepartmentCalls' and 'TakeDepartmentCallsOnly' values are applicable only for extensions - members of a Department; if these values are set for department outsiders, the 400 Bad Request error code is returned. The 'TakeDepartmentCallsOnly' status can be set through the old RingCentral user interface and is available for some migrated accounts only.
        /// </summary>
        /// <value>Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR Menu/Application Extension/Park Location extensions. The 'DoNotAcceptDepartmentCalls' and 'TakeDepartmentCallsOnly' values are applicable only for extensions - members of a Department; if these values are set for department outsiders, the 400 Bad Request error code is returned. The 'TakeDepartmentCallsOnly' status can be set through the old RingCentral user interface and is available for some migrated accounts only.</value>
        [DataMember(Name="dndStatus", EmitDefaultValue=false)]
        public DndStatusEnum? DndStatus { get; set; }
    
        /// <summary>
        /// Aggregated presence status, calculated from a number of sources
        /// </summary>
        /// <value>Aggregated presence status, calculated from a number of sources</value>
        [DataMember(Name="presenceStatus", EmitDefaultValue=false)]
        public PresenceStatusEnum? PresenceStatus { get; set; }
    
        /// <summary>
        /// Telephony presence status
        /// </summary>
        /// <value>Telephony presence status</value>
        [DataMember(Name="telephonyStatus", EmitDefaultValue=false)]
        public TelephonyStatusEnum? TelephonyStatus { get; set; }
    
        /// <summary>
        /// User-defined presence status (as previously published by the user)
        /// </summary>
        /// <value>User-defined presence status (as previously published by the user)</value>
        [DataMember(Name="userStatus", EmitDefaultValue=false)]
        public UserStatusEnum? UserStatus { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PresenceInfo" /> class.
        /// Initializes a new instance of the <see cref="PresenceInfo" />class.
        /// </summary>
        /// <param name="Uri">Canonical URI of a presence info resource.</param>
        /// <param name="AllowSeeMyPresence">If &#39;True&#39; enables other extensions to see the extension presence status.</param>
        /// <param name="DndStatus">Extended DnD (Do not Disturb) status. Cannot be set for Department/Announcement/Voicemail (Take Messages Only)/Fax User/Shared Lines Group/Paging Only Group/IVR Menu/Application Extension/Park Location extensions. The &#39;DoNotAcceptDepartmentCalls&#39; and &#39;TakeDepartmentCallsOnly&#39; values are applicable only for extensions - members of a Department; if these values are set for department outsiders, the 400 Bad Request error code is returned. The &#39;TakeDepartmentCallsOnly&#39; status can be set through the old RingCentral user interface and is available for some migrated accounts only..</param>
        /// <param name="Extension">Extension.</param>
        /// <param name="Message">Custom status message (as previously published by user).</param>
        /// <param name="PickUpCallsOnHold">If &#39;True&#39; enables the extension user to pick up a monitored line on hold.</param>
        /// <param name="PresenceStatus">Aggregated presence status, calculated from a number of sources.</param>
        /// <param name="RingOnMonitoredCall">If &#39;True&#39; enables to ring extension phone, if any user monitored by this extension is ringing.</param>
        /// <param name="TelephonyStatus">Telephony presence status.</param>
        /// <param name="UserStatus">User-defined presence status (as previously published by the user).</param>

        public PresenceInfo(string Uri = null, bool? AllowSeeMyPresence = null, DndStatusEnum? DndStatus = null, PresenceInfoExtensionInfo Extension = null, string Message = null, bool? PickUpCallsOnHold = null, PresenceStatusEnum? PresenceStatus = null, bool? RingOnMonitoredCall = null, TelephonyStatusEnum? TelephonyStatus = null, UserStatusEnum? UserStatus = null)
        {
            this.Uri = Uri;
            this.AllowSeeMyPresence = AllowSeeMyPresence;
            this.DndStatus = DndStatus;
            this.Extension = Extension;
            this.Message = Message;
            this.PickUpCallsOnHold = PickUpCallsOnHold;
            this.PresenceStatus = PresenceStatus;
            this.RingOnMonitoredCall = RingOnMonitoredCall;
            this.TelephonyStatus = TelephonyStatus;
            this.UserStatus = UserStatus;
            
        }
        
    
        /// <summary>
        /// Canonical URI of a presence info resource
        /// </summary>
        /// <value>Canonical URI of a presence info resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// If &#39;True&#39; enables other extensions to see the extension presence status
        /// </summary>
        /// <value>If &#39;True&#39; enables other extensions to see the extension presence status</value>
        [DataMember(Name="allowSeeMyPresence", EmitDefaultValue=false)]
        public bool? AllowSeeMyPresence { get; set; }
    
        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public PresenceInfoExtensionInfo Extension { get; set; }
    
        /// <summary>
        /// Custom status message (as previously published by user)
        /// </summary>
        /// <value>Custom status message (as previously published by user)</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
    
        /// <summary>
        /// If &#39;True&#39; enables the extension user to pick up a monitored line on hold
        /// </summary>
        /// <value>If &#39;True&#39; enables the extension user to pick up a monitored line on hold</value>
        [DataMember(Name="pickUpCallsOnHold", EmitDefaultValue=false)]
        public bool? PickUpCallsOnHold { get; set; }
    
        /// <summary>
        /// If &#39;True&#39; enables to ring extension phone, if any user monitored by this extension is ringing
        /// </summary>
        /// <value>If &#39;True&#39; enables to ring extension phone, if any user monitored by this extension is ringing</value>
        [DataMember(Name="ringOnMonitoredCall", EmitDefaultValue=false)]
        public bool? RingOnMonitoredCall { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PresenceInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  AllowSeeMyPresence: ").Append(AllowSeeMyPresence).Append("\n");
            sb.Append("  DndStatus: ").Append(DndStatus).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  PickUpCallsOnHold: ").Append(PickUpCallsOnHold).Append("\n");
            sb.Append("  PresenceStatus: ").Append(PresenceStatus).Append("\n");
            sb.Append("  RingOnMonitoredCall: ").Append(RingOnMonitoredCall).Append("\n");
            sb.Append("  TelephonyStatus: ").Append(TelephonyStatus).Append("\n");
            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");
            
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
            return this.Equals(obj as PresenceInfo);
        }

        /// <summary>
        /// Returns true if PresenceInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of PresenceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PresenceInfo other)
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
                    this.AllowSeeMyPresence == other.AllowSeeMyPresence ||
                    this.AllowSeeMyPresence != null &&
                    this.AllowSeeMyPresence.Equals(other.AllowSeeMyPresence)
                ) && 
                (
                    this.DndStatus == other.DndStatus ||
                    this.DndStatus != null &&
                    this.DndStatus.Equals(other.DndStatus)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.PickUpCallsOnHold == other.PickUpCallsOnHold ||
                    this.PickUpCallsOnHold != null &&
                    this.PickUpCallsOnHold.Equals(other.PickUpCallsOnHold)
                ) && 
                (
                    this.PresenceStatus == other.PresenceStatus ||
                    this.PresenceStatus != null &&
                    this.PresenceStatus.Equals(other.PresenceStatus)
                ) && 
                (
                    this.RingOnMonitoredCall == other.RingOnMonitoredCall ||
                    this.RingOnMonitoredCall != null &&
                    this.RingOnMonitoredCall.Equals(other.RingOnMonitoredCall)
                ) && 
                (
                    this.TelephonyStatus == other.TelephonyStatus ||
                    this.TelephonyStatus != null &&
                    this.TelephonyStatus.Equals(other.TelephonyStatus)
                ) && 
                (
                    this.UserStatus == other.UserStatus ||
                    this.UserStatus != null &&
                    this.UserStatus.Equals(other.UserStatus)
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
                
                if (this.AllowSeeMyPresence != null)
                    hash = hash * 59 + this.AllowSeeMyPresence.GetHashCode();
                
                if (this.DndStatus != null)
                    hash = hash * 59 + this.DndStatus.GetHashCode();
                
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                
                if (this.PickUpCallsOnHold != null)
                    hash = hash * 59 + this.PickUpCallsOnHold.GetHashCode();
                
                if (this.PresenceStatus != null)
                    hash = hash * 59 + this.PresenceStatus.GetHashCode();
                
                if (this.RingOnMonitoredCall != null)
                    hash = hash * 59 + this.RingOnMonitoredCall.GetHashCode();
                
                if (this.TelephonyStatus != null)
                    hash = hash * 59 + this.TelephonyStatus.GetHashCode();
                
                if (this.UserStatus != null)
                    hash = hash * 59 + this.UserStatus.GetHashCode();
                
                return hash;
            }
        }

    }
}
