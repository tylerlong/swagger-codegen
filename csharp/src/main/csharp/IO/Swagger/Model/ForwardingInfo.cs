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
    public partial class ForwardingInfo :  IEquatable<ForwardingInfo>
    { 
    
        /// <summary>
        /// Specifies the order in which forwarding numbers ring. 'Sequentially' means that forwarding numbers are ringing one at a time, in order of priority. 'Simultaneously' means that forwarding numbers are ring all at the same time
        /// </summary>
        /// <value>Specifies the order in which forwarding numbers ring. 'Sequentially' means that forwarding numbers are ringing one at a time, in order of priority. 'Simultaneously' means that forwarding numbers are ring all at the same time</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RingingModeEnum {
            
            [EnumMember(Value = "Sequentially")]
            Sequentially,
            
            [EnumMember(Value = "Simultaneously")]
            Simultaneously
        }

    
        /// <summary>
        /// Specifies the order in which forwarding numbers ring. 'Sequentially' means that forwarding numbers are ringing one at a time, in order of priority. 'Simultaneously' means that forwarding numbers are ring all at the same time
        /// </summary>
        /// <value>Specifies the order in which forwarding numbers ring. 'Sequentially' means that forwarding numbers are ringing one at a time, in order of priority. 'Simultaneously' means that forwarding numbers are ring all at the same time</value>
        [DataMember(Name="ringingMode", EmitDefaultValue=false)]
        public RingingModeEnum? RingingMode { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardingInfo" /> class.
        /// Initializes a new instance of the <see cref="ForwardingInfo" />class.
        /// </summary>
        /// <param name="NotifyMySoftPhones">Specifies if the user&#39;s softphone(s) are notified before forwarding the incoming call to desk phones and forwarding numbers.</param>
        /// <param name="NotifyAdminSoftPhones">Specifies if the administrator&#39;s softphone is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is &#39;False&#39;.</param>
        /// <param name="SoftPhonesRingCount">Number of rings before forwarding starts.</param>
        /// <param name="RingingMode">Specifies the order in which forwarding numbers ring. &#39;Sequentially&#39; means that forwarding numbers are ringing one at a time, in order of priority. &#39;Simultaneously&#39; means that forwarding numbers are ring all at the same time.</param>
        /// <param name="Rules">Information on a call forwarding rule.</param>

        public ForwardingInfo(bool? NotifyMySoftPhones = null, bool? NotifyAdminSoftPhones = null, int? SoftPhonesRingCount = null, RingingModeEnum? RingingMode = null, List<RuleInfo> Rules = null)
        {
            this.NotifyMySoftPhones = NotifyMySoftPhones;
            this.NotifyAdminSoftPhones = NotifyAdminSoftPhones;
            this.SoftPhonesRingCount = SoftPhonesRingCount;
            this.RingingMode = RingingMode;
            this.Rules = Rules;
            
        }
        
    
        /// <summary>
        /// Specifies if the user&#39;s softphone(s) are notified before forwarding the incoming call to desk phones and forwarding numbers
        /// </summary>
        /// <value>Specifies if the user&#39;s softphone(s) are notified before forwarding the incoming call to desk phones and forwarding numbers</value>
        [DataMember(Name="notifyMySoftPhones", EmitDefaultValue=false)]
        public bool? NotifyMySoftPhones { get; set; }
    
        /// <summary>
        /// Specifies if the administrator&#39;s softphone is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is &#39;False&#39;
        /// </summary>
        /// <value>Specifies if the administrator&#39;s softphone is notified before forwarding the incoming call to desk phones and forwarding numbers. The default value is &#39;False&#39;</value>
        [DataMember(Name="notifyAdminSoftPhones", EmitDefaultValue=false)]
        public bool? NotifyAdminSoftPhones { get; set; }
    
        /// <summary>
        /// Number of rings before forwarding starts
        /// </summary>
        /// <value>Number of rings before forwarding starts</value>
        [DataMember(Name="softPhonesRingCount", EmitDefaultValue=false)]
        public int? SoftPhonesRingCount { get; set; }
    
        /// <summary>
        /// Information on a call forwarding rule
        /// </summary>
        /// <value>Information on a call forwarding rule</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<RuleInfo> Rules { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForwardingInfo {\n");
            sb.Append("  NotifyMySoftPhones: ").Append(NotifyMySoftPhones).Append("\n");
            sb.Append("  NotifyAdminSoftPhones: ").Append(NotifyAdminSoftPhones).Append("\n");
            sb.Append("  SoftPhonesRingCount: ").Append(SoftPhonesRingCount).Append("\n");
            sb.Append("  RingingMode: ").Append(RingingMode).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            
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
            return this.Equals(obj as ForwardingInfo);
        }

        /// <summary>
        /// Returns true if ForwardingInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ForwardingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForwardingInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NotifyMySoftPhones == other.NotifyMySoftPhones ||
                    this.NotifyMySoftPhones != null &&
                    this.NotifyMySoftPhones.Equals(other.NotifyMySoftPhones)
                ) && 
                (
                    this.NotifyAdminSoftPhones == other.NotifyAdminSoftPhones ||
                    this.NotifyAdminSoftPhones != null &&
                    this.NotifyAdminSoftPhones.Equals(other.NotifyAdminSoftPhones)
                ) && 
                (
                    this.SoftPhonesRingCount == other.SoftPhonesRingCount ||
                    this.SoftPhonesRingCount != null &&
                    this.SoftPhonesRingCount.Equals(other.SoftPhonesRingCount)
                ) && 
                (
                    this.RingingMode == other.RingingMode ||
                    this.RingingMode != null &&
                    this.RingingMode.Equals(other.RingingMode)
                ) && 
                (
                    this.Rules == other.Rules ||
                    this.Rules != null &&
                    this.Rules.SequenceEqual(other.Rules)
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
                
                if (this.NotifyMySoftPhones != null)
                    hash = hash * 59 + this.NotifyMySoftPhones.GetHashCode();
                
                if (this.NotifyAdminSoftPhones != null)
                    hash = hash * 59 + this.NotifyAdminSoftPhones.GetHashCode();
                
                if (this.SoftPhonesRingCount != null)
                    hash = hash * 59 + this.SoftPhonesRingCount.GetHashCode();
                
                if (this.RingingMode != null)
                    hash = hash * 59 + this.RingingMode.GetHashCode();
                
                if (this.Rules != null)
                    hash = hash * 59 + this.Rules.GetHashCode();
                
                return hash;
            }
        }

    }
}
