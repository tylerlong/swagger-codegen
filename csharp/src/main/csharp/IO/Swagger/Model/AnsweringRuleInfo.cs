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
    public partial class AnsweringRuleInfo :  IEquatable<AnsweringRuleInfo>
    { 
    
        /// <summary>
        /// Type of an answering rule
        /// </summary>
        /// <value>Type of an answering rule</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "BusinessHours")]
            Businesshours,
            
            [EnumMember(Value = "AfterHours")]
            Afterhours,
            
            [EnumMember(Value = "Custom")]
            Custom
        }

    
        /// <summary>
        /// Specifies how incoming calls are forwarded
        /// </summary>
        /// <value>Specifies how incoming calls are forwarded</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CallHandlingActionEnum {
            
            [EnumMember(Value = "ForwardCalls")]
            Forwardcalls,
            
            [EnumMember(Value = "TakeMessagesOnly")]
            Takemessagesonly,
            
            [EnumMember(Value = "PlayAnnouncementOnly")]
            Playannouncementonly,
            
            [EnumMember(Value = "UnconditionalForwarding")]
            Unconditionalforwarding
        }

    
        /// <summary>
        /// Type of an answering rule
        /// </summary>
        /// <value>Type of an answering rule</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Specifies how incoming calls are forwarded
        /// </summary>
        /// <value>Specifies how incoming calls are forwarded</value>
        [DataMember(Name="callHandlingAction", EmitDefaultValue=false)]
        public CallHandlingActionEnum? CallHandlingAction { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnsweringRuleInfo" /> class.
        /// Initializes a new instance of the <see cref="AnsweringRuleInfo" />class.
        /// </summary>
        /// <param name="Uri">Canonical URI to the answering rule resource.</param>
        /// <param name="Id">Internal identifier of an asnwering rule.</param>
        /// <param name="Type">Type of an answering rule.</param>
        /// <param name="Name">Name of an answering rule specified by user.</param>
        /// <param name="Enabled">Specifies if an answering rule is active or inactive.</param>
        /// <param name="Schedule">Schedule.</param>
        /// <param name="CalledNumbers">Answering rules are applied when calling to selected number(s).</param>
        /// <param name="Callers">Answering rules are applied when calls are received from specified caller(s).</param>
        /// <param name="CallHandlingAction">Specifies how incoming calls are forwarded.</param>
        /// <param name="Forwarding">Forwarding.</param>
        /// <param name="UnconditionalForwarding">UnconditionalForwarding.</param>
        /// <param name="Voicemail">Voicemail.</param>

        public AnsweringRuleInfo(string Uri = null, string Id = null, TypeEnum? Type = null, string Name = null, bool? Enabled = null, ScheduleInfo Schedule = null, List<AnsweringRuleInfoCalleeInfo> CalledNumbers = null, List<AnsweringRuleInfoCallerInfo> Callers = null, CallHandlingActionEnum? CallHandlingAction = null, ForwardingInfo Forwarding = null, UnconditionalForwardingInfo UnconditionalForwarding = null, VoicemailInfo Voicemail = null)
        {
            this.Uri = Uri;
            this.Id = Id;
            this.Type = Type;
            this.Name = Name;
            this.Enabled = Enabled;
            this.Schedule = Schedule;
            this.CalledNumbers = CalledNumbers;
            this.Callers = Callers;
            this.CallHandlingAction = CallHandlingAction;
            this.Forwarding = Forwarding;
            this.UnconditionalForwarding = UnconditionalForwarding;
            this.Voicemail = Voicemail;
            
        }
        
    
        /// <summary>
        /// Canonical URI to the answering rule resource
        /// </summary>
        /// <value>Canonical URI to the answering rule resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Internal identifier of an asnwering rule
        /// </summary>
        /// <value>Internal identifier of an asnwering rule</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Name of an answering rule specified by user
        /// </summary>
        /// <value>Name of an answering rule specified by user</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Specifies if an answering rule is active or inactive
        /// </summary>
        /// <value>Specifies if an answering rule is active or inactive</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public ScheduleInfo Schedule { get; set; }
    
        /// <summary>
        /// Answering rules are applied when calling to selected number(s)
        /// </summary>
        /// <value>Answering rules are applied when calling to selected number(s)</value>
        [DataMember(Name="calledNumbers", EmitDefaultValue=false)]
        public List<AnsweringRuleInfoCalleeInfo> CalledNumbers { get; set; }
    
        /// <summary>
        /// Answering rules are applied when calls are received from specified caller(s)
        /// </summary>
        /// <value>Answering rules are applied when calls are received from specified caller(s)</value>
        [DataMember(Name="callers", EmitDefaultValue=false)]
        public List<AnsweringRuleInfoCallerInfo> Callers { get; set; }
    
        /// <summary>
        /// Gets or Sets Forwarding
        /// </summary>
        [DataMember(Name="forwarding", EmitDefaultValue=false)]
        public ForwardingInfo Forwarding { get; set; }
    
        /// <summary>
        /// Gets or Sets UnconditionalForwarding
        /// </summary>
        [DataMember(Name="unconditionalForwarding", EmitDefaultValue=false)]
        public UnconditionalForwardingInfo UnconditionalForwarding { get; set; }
    
        /// <summary>
        /// Gets or Sets Voicemail
        /// </summary>
        [DataMember(Name="voicemail", EmitDefaultValue=false)]
        public VoicemailInfo Voicemail { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnsweringRuleInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  CalledNumbers: ").Append(CalledNumbers).Append("\n");
            sb.Append("  Callers: ").Append(Callers).Append("\n");
            sb.Append("  CallHandlingAction: ").Append(CallHandlingAction).Append("\n");
            sb.Append("  Forwarding: ").Append(Forwarding).Append("\n");
            sb.Append("  UnconditionalForwarding: ").Append(UnconditionalForwarding).Append("\n");
            sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
            
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
            return this.Equals(obj as AnsweringRuleInfo);
        }

        /// <summary>
        /// Returns true if AnsweringRuleInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of AnsweringRuleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnsweringRuleInfo other)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) && 
                (
                    this.CalledNumbers == other.CalledNumbers ||
                    this.CalledNumbers != null &&
                    this.CalledNumbers.SequenceEqual(other.CalledNumbers)
                ) && 
                (
                    this.Callers == other.Callers ||
                    this.Callers != null &&
                    this.Callers.SequenceEqual(other.Callers)
                ) && 
                (
                    this.CallHandlingAction == other.CallHandlingAction ||
                    this.CallHandlingAction != null &&
                    this.CallHandlingAction.Equals(other.CallHandlingAction)
                ) && 
                (
                    this.Forwarding == other.Forwarding ||
                    this.Forwarding != null &&
                    this.Forwarding.Equals(other.Forwarding)
                ) && 
                (
                    this.UnconditionalForwarding == other.UnconditionalForwarding ||
                    this.UnconditionalForwarding != null &&
                    this.UnconditionalForwarding.Equals(other.UnconditionalForwarding)
                ) && 
                (
                    this.Voicemail == other.Voicemail ||
                    this.Voicemail != null &&
                    this.Voicemail.Equals(other.Voicemail)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();
                
                if (this.CalledNumbers != null)
                    hash = hash * 59 + this.CalledNumbers.GetHashCode();
                
                if (this.Callers != null)
                    hash = hash * 59 + this.Callers.GetHashCode();
                
                if (this.CallHandlingAction != null)
                    hash = hash * 59 + this.CallHandlingAction.GetHashCode();
                
                if (this.Forwarding != null)
                    hash = hash * 59 + this.Forwarding.GetHashCode();
                
                if (this.UnconditionalForwarding != null)
                    hash = hash * 59 + this.UnconditionalForwarding.GetHashCode();
                
                if (this.Voicemail != null)
                    hash = hash * 59 + this.Voicemail.GetHashCode();
                
                return hash;
            }
        }

    }
}
