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
    public partial class CallLogInfo :  IEquatable<CallLogInfo>
    { 
    
        /// <summary>
        /// Call type
        /// </summary>
        /// <value>Call type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "Voice")]
            Voice,
            
            [EnumMember(Value = "Fax")]
            Fax
        }

    
        /// <summary>
        /// Call direction
        /// </summary>
        /// <value>Call direction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum {
            
            [EnumMember(Value = "Inbound")]
            Inbound,
            
            [EnumMember(Value = "Outbound")]
            Outbound
        }

    
        /// <summary>
        /// Action description of the call operation
        /// </summary>
        /// <value>Action description of the call operation</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum {
            
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            [EnumMember(Value = "Phone Call")]
            PhoneCall,
            
            [EnumMember(Value = "Phone Login")]
            PhoneLogin,
            
            [EnumMember(Value = "Incoming Fax")]
            IncomingFax,
            
            [EnumMember(Value = "Accept Call")]
            AcceptCall,
            
            [EnumMember(Value = "FindMe")]
            Findme,
            
            [EnumMember(Value = "FollowMe")]
            Followme,
            
            [EnumMember(Value = "Outgoing Fax")]
            OutgoingFax,
            
            [EnumMember(Value = "Call Return")]
            CallReturn,
            
            [EnumMember(Value = "Calling Card")]
            CallingCard,
            
            [EnumMember(Value = "Ring Directly")]
            RingDirectly,
            
            [EnumMember(Value = "RingOut Web")]
            RingoutWeb,
            
            [EnumMember(Value = "VoIP Call")]
            VoipCall,
            
            [EnumMember(Value = "RingOut PC")]
            RingoutPc,
            
            [EnumMember(Value = "RingMe")]
            Ringme,
            
            [EnumMember(Value = "Transfer")]
            Transfer,
            
            [EnumMember(Value = "411 Info")]
            _411Info,
            
            [EnumMember(Value = "Emergency")]
            Emergency,
            
            [EnumMember(Value = "E911 Update")]
            E911Update,
            
            [EnumMember(Value = "Support")]
            Support,
            
            [EnumMember(Value = "RingOut Mobile")]
            RingoutMobile
        }

    
        /// <summary>
        /// Status description of the call operation
        /// </summary>
        /// <value>Status description of the call operation</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultEnum {
            
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            [EnumMember(Value = "ResultInProgress")]
            Resultinprogress,
            
            [EnumMember(Value = "Missed")]
            Missed,
            
            [EnumMember(Value = "Call accepted")]
            CallAccepted,
            
            [EnumMember(Value = "Voicemail")]
            Voicemail,
            
            [EnumMember(Value = "Rejected")]
            Rejected,
            
            [EnumMember(Value = "Reply")]
            Reply,
            
            [EnumMember(Value = "Received")]
            Received,
            
            [EnumMember(Value = "Receive Error")]
            ReceiveError,
            
            [EnumMember(Value = "Fax on Demand")]
            FaxOnDemand,
            
            [EnumMember(Value = "Partial Receive")]
            PartialReceive,
            
            [EnumMember(Value = "Blocked")]
            Blocked,
            
            [EnumMember(Value = "Call connected")]
            CallConnected,
            
            [EnumMember(Value = "No Answer")]
            NoAnswer,
            
            [EnumMember(Value = "International Disabled")]
            InternationalDisabled,
            
            [EnumMember(Value = "Busy")]
            Busy,
            
            [EnumMember(Value = "Send Error")]
            SendError,
            
            [EnumMember(Value = "Sent")]
            Sent,
            
            [EnumMember(Value = "No fax machine")]
            NoFaxMachine,
            
            [EnumMember(Value = "ResultEmpty")]
            Resultempty,
            
            [EnumMember(Value = "Account")]
            Account,
            
            [EnumMember(Value = "Suspended")]
            Suspended,
            
            [EnumMember(Value = "Call Failed")]
            CallFailed,
            
            [EnumMember(Value = "Call Failure")]
            CallFailure,
            
            [EnumMember(Value = "Internal Error")]
            InternalError,
            
            [EnumMember(Value = "IP Phone offline")]
            IpPhoneOffline,
            
            [EnumMember(Value = "Restricted Number")]
            RestrictedNumber,
            
            [EnumMember(Value = "Wrong Number")]
            WrongNumber,
            
            [EnumMember(Value = "Stopped")]
            Stopped,
            
            [EnumMember(Value = "Hang up")]
            HangUp,
            
            [EnumMember(Value = "Poor Line Quality")]
            PoorLineQuality,
            
            [EnumMember(Value = "Partially Sent")]
            PartiallySent,
            
            [EnumMember(Value = "International Restriction")]
            InternationalRestriction,
            
            [EnumMember(Value = "Abandoned")]
            Abandoned,
            
            [EnumMember(Value = "Declined")]
            Declined,
            
            [EnumMember(Value = "Fax Receipt Error")]
            FaxReceiptError,
            
            [EnumMember(Value = "Fax Send Error")]
            FaxSendError
        }

    
        /// <summary>
        /// Call type
        /// </summary>
        /// <value>Call type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Call direction
        /// </summary>
        /// <value>Call direction</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
    
        /// <summary>
        /// Action description of the call operation
        /// </summary>
        /// <value>Action description of the call operation</value>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
    
        /// <summary>
        /// Status description of the call operation
        /// </summary>
        /// <value>Status description of the call operation</value>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public ResultEnum? Result { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CallLogInfo" /> class.
        /// Initializes a new instance of the <see cref="CallLogInfo" />class.
        /// </summary>
        /// <param name="Id">Internal identifier of a cal log record.</param>
        /// <param name="Uri">Canonical URI of a call log record.</param>
        /// <param name="SessionId">Internal identifier of a call session.</param>
        /// <param name="From">From.</param>
        /// <param name="To">To.</param>
        /// <param name="Type">Call type.</param>
        /// <param name="Direction">Call direction.</param>
        /// <param name="Action">Action description of the call operation.</param>
        /// <param name="Result">Status description of the call operation.</param>
        /// <param name="StartTime">The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z.</param>
        /// <param name="Duration">Call duration in seconds.</param>
        /// <param name="Recording">Recording.</param>

        public CallLogInfo(string Id = null, string Uri = null, string SessionId = null, CallerInfo From = null, CallerInfo To = null, TypeEnum? Type = null, DirectionEnum? Direction = null, ActionEnum? Action = null, ResultEnum? Result = null, DateTime? StartTime = null, int? Duration = null, RecordingInfo Recording = null)
        {
            this.Id = Id;
            this.Uri = Uri;
            this.SessionId = SessionId;
            this.From = From;
            this.To = To;
            this.Type = Type;
            this.Direction = Direction;
            this.Action = Action;
            this.Result = Result;
            this.StartTime = StartTime;
            this.Duration = Duration;
            this.Recording = Recording;
            
        }
        
    
        /// <summary>
        /// Internal identifier of a cal log record
        /// </summary>
        /// <value>Internal identifier of a cal log record</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Canonical URI of a call log record
        /// </summary>
        /// <value>Canonical URI of a call log record</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Internal identifier of a call session
        /// </summary>
        /// <value>Internal identifier of a call session</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }
    
        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public CallerInfo From { get; set; }
    
        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public CallerInfo To { get; set; }
    
        /// <summary>
        /// The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>The call start datetime in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }
    
        /// <summary>
        /// Call duration in seconds
        /// </summary>
        /// <value>Call duration in seconds</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
    
        /// <summary>
        /// Gets or Sets Recording
        /// </summary>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public RecordingInfo Recording { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallLogInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Recording: ").Append(Recording).Append("\n");
            
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
            return this.Equals(obj as CallLogInfo);
        }

        /// <summary>
        /// Returns true if CallLogInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of CallLogInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallLogInfo other)
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
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) && 
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) && 
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.Recording == other.Recording ||
                    this.Recording != null &&
                    this.Recording.Equals(other.Recording)
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
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();
                
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
                
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                
                if (this.Recording != null)
                    hash = hash * 59 + this.Recording.GetHashCode();
                
                return hash;
            }
        }

    }
}
