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
    public partial class StatusInfo :  IEquatable<StatusInfo>
    { 
    
        /// <summary>
        /// Type of suspension
        /// </summary>
        /// <value>Type of suspension</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum {
            
            [EnumMember(Value = "Voluntarily")]
            Voluntarily,
            
            [EnumMember(Value = "Involuntarily")]
            Involuntarily
        }

    
        /// <summary>
        /// Type of suspension
        /// </summary>
        /// <value>Type of suspension</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusInfo" /> class.
        /// Initializes a new instance of the <see cref="StatusInfo" />class.
        /// </summary>
        /// <param name="Comment">A free-form user comment, describing the status change reason.</param>
        /// <param name="Reason">Type of suspension.</param>

        public StatusInfo(string Comment = null, ReasonEnum? Reason = null)
        {
            this.Comment = Comment;
            this.Reason = Reason;
            
        }
        
    
        /// <summary>
        /// A free-form user comment, describing the status change reason
        /// </summary>
        /// <value>A free-form user comment, describing the status change reason</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusInfo {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            
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
            return this.Equals(obj as StatusInfo);
        }

        /// <summary>
        /// Returns true if StatusInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                
                return hash;
            }
        }

    }
}
