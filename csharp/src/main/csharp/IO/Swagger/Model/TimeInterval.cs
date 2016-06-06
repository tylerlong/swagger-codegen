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
    public partial class TimeInterval :  IEquatable<TimeInterval>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeInterval" /> class.
        /// Initializes a new instance of the <see cref="TimeInterval" />class.
        /// </summary>
        /// <param name="From">Time in format hh:mm.</param>
        /// <param name="To">Time in format hh:mm.</param>

        public TimeInterval(DateTime? From = null, DateTime? To = null)
        {
            this.From = From;
            this.To = To;
            
        }
        
    
        /// <summary>
        /// Time in format hh:mm
        /// </summary>
        /// <value>Time in format hh:mm</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public DateTime? From { get; set; }
    
        /// <summary>
        /// Time in format hh:mm
        /// </summary>
        /// <value>Time in format hh:mm</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public DateTime? To { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeInterval {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            
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
            return this.Equals(obj as TimeInterval);
        }

        /// <summary>
        /// Returns true if TimeInterval instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeInterval other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) && 
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
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
                
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                
                return hash;
            }
        }

    }
}
