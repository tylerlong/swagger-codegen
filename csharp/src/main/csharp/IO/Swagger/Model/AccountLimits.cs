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
    public partial class AccountLimits :  IEquatable<AccountLimits>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLimits" /> class.
        /// Initializes a new instance of the <see cref="AccountLimits" />class.
        /// </summary>
        /// <param name="FreeSoftPhoneLinesPerExtension">The maximum number of free softphone digital lines per user extension.</param>
        /// <param name="MeetingSize">The maximum number of participants in RingCentral Meeting hosted by this account&#39;s user.</param>
        /// <param name="MaxMonitoredExtensionsPerUser">The maximum number of extensions which can be included in the list of users monitored for Presence.</param>

        public AccountLimits(int? FreeSoftPhoneLinesPerExtension = null, int? MeetingSize = null, int? MaxMonitoredExtensionsPerUser = null)
        {
            this.FreeSoftPhoneLinesPerExtension = FreeSoftPhoneLinesPerExtension;
            this.MeetingSize = MeetingSize;
            this.MaxMonitoredExtensionsPerUser = MaxMonitoredExtensionsPerUser;
            
        }
        
    
        /// <summary>
        /// The maximum number of free softphone digital lines per user extension
        /// </summary>
        /// <value>The maximum number of free softphone digital lines per user extension</value>
        [DataMember(Name="freeSoftPhoneLinesPerExtension", EmitDefaultValue=false)]
        public int? FreeSoftPhoneLinesPerExtension { get; set; }
    
        /// <summary>
        /// The maximum number of participants in RingCentral Meeting hosted by this account&#39;s user
        /// </summary>
        /// <value>The maximum number of participants in RingCentral Meeting hosted by this account&#39;s user</value>
        [DataMember(Name="meetingSize", EmitDefaultValue=false)]
        public int? MeetingSize { get; set; }
    
        /// <summary>
        /// The maximum number of extensions which can be included in the list of users monitored for Presence
        /// </summary>
        /// <value>The maximum number of extensions which can be included in the list of users monitored for Presence</value>
        [DataMember(Name="maxMonitoredExtensionsPerUser", EmitDefaultValue=false)]
        public int? MaxMonitoredExtensionsPerUser { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountLimits {\n");
            sb.Append("  FreeSoftPhoneLinesPerExtension: ").Append(FreeSoftPhoneLinesPerExtension).Append("\n");
            sb.Append("  MeetingSize: ").Append(MeetingSize).Append("\n");
            sb.Append("  MaxMonitoredExtensionsPerUser: ").Append(MaxMonitoredExtensionsPerUser).Append("\n");
            
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
            return this.Equals(obj as AccountLimits);
        }

        /// <summary>
        /// Returns true if AccountLimits instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountLimits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountLimits other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FreeSoftPhoneLinesPerExtension == other.FreeSoftPhoneLinesPerExtension ||
                    this.FreeSoftPhoneLinesPerExtension != null &&
                    this.FreeSoftPhoneLinesPerExtension.Equals(other.FreeSoftPhoneLinesPerExtension)
                ) && 
                (
                    this.MeetingSize == other.MeetingSize ||
                    this.MeetingSize != null &&
                    this.MeetingSize.Equals(other.MeetingSize)
                ) && 
                (
                    this.MaxMonitoredExtensionsPerUser == other.MaxMonitoredExtensionsPerUser ||
                    this.MaxMonitoredExtensionsPerUser != null &&
                    this.MaxMonitoredExtensionsPerUser.Equals(other.MaxMonitoredExtensionsPerUser)
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
                
                if (this.FreeSoftPhoneLinesPerExtension != null)
                    hash = hash * 59 + this.FreeSoftPhoneLinesPerExtension.GetHashCode();
                
                if (this.MeetingSize != null)
                    hash = hash * 59 + this.MeetingSize.GetHashCode();
                
                if (this.MaxMonitoredExtensionsPerUser != null)
                    hash = hash * 59 + this.MaxMonitoredExtensionsPerUser.GetHashCode();
                
                return hash;
            }
        }

    }
}
