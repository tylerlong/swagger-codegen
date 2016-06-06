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
    public partial class RuleInfo :  IEquatable<RuleInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleInfo" /> class.
        /// Initializes a new instance of the <see cref="RuleInfo" />class.
        /// </summary>
        /// <param name="Index">Forwarding number (or group) ordinal.</param>
        /// <param name="RingCount">Number of rings for a forwarding number (or group).</param>
        /// <param name="ForwardingNumbers">Forwarding number (or group) data.</param>

        public RuleInfo(int? Index = null, int? RingCount = null, List<RuleInfoForwardingNumberInfo> ForwardingNumbers = null)
        {
            this.Index = Index;
            this.RingCount = RingCount;
            this.ForwardingNumbers = ForwardingNumbers;
            
        }
        
    
        /// <summary>
        /// Forwarding number (or group) ordinal
        /// </summary>
        /// <value>Forwarding number (or group) ordinal</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }
    
        /// <summary>
        /// Number of rings for a forwarding number (or group)
        /// </summary>
        /// <value>Number of rings for a forwarding number (or group)</value>
        [DataMember(Name="ringCount", EmitDefaultValue=false)]
        public int? RingCount { get; set; }
    
        /// <summary>
        /// Forwarding number (or group) data
        /// </summary>
        /// <value>Forwarding number (or group) data</value>
        [DataMember(Name="forwardingNumbers", EmitDefaultValue=false)]
        public List<RuleInfoForwardingNumberInfo> ForwardingNumbers { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleInfo {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  RingCount: ").Append(RingCount).Append("\n");
            sb.Append("  ForwardingNumbers: ").Append(ForwardingNumbers).Append("\n");
            
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
            return this.Equals(obj as RuleInfo);
        }

        /// <summary>
        /// Returns true if RuleInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of RuleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Index == other.Index ||
                    this.Index != null &&
                    this.Index.Equals(other.Index)
                ) && 
                (
                    this.RingCount == other.RingCount ||
                    this.RingCount != null &&
                    this.RingCount.Equals(other.RingCount)
                ) && 
                (
                    this.ForwardingNumbers == other.ForwardingNumbers ||
                    this.ForwardingNumbers != null &&
                    this.ForwardingNumbers.SequenceEqual(other.ForwardingNumbers)
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
                
                if (this.Index != null)
                    hash = hash * 59 + this.Index.GetHashCode();
                
                if (this.RingCount != null)
                    hash = hash * 59 + this.RingCount.GetHashCode();
                
                if (this.ForwardingNumbers != null)
                    hash = hash * 59 + this.ForwardingNumbers.GetHashCode();
                
                return hash;
            }
        }

    }
}
