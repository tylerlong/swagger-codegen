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
    public partial class WeeklyScheduleInfo :  IEquatable<WeeklyScheduleInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WeeklyScheduleInfo" /> class.
        /// Initializes a new instance of the <see cref="WeeklyScheduleInfo" />class.
        /// </summary>
        /// <param name="Monday">Time intervals for a particular day.</param>
        /// <param name="Tuesday">Time intervals for a particular day.</param>
        /// <param name="Wednesday">Time intervals for a particular day.</param>
        /// <param name="Thursday">Time intervals for a particular day.</param>
        /// <param name="Friday">Time intervals for a particular day.</param>
        /// <param name="Saturday">Time intervals for a particular day.</param>
        /// <param name="Sunday">Time intervals for a particular day.</param>

        public WeeklyScheduleInfo(List<TimeInterval> Monday = null, List<TimeInterval> Tuesday = null, List<TimeInterval> Wednesday = null, List<TimeInterval> Thursday = null, List<TimeInterval> Friday = null, List<TimeInterval> Saturday = null, List<TimeInterval> Sunday = null)
        {
            this.Monday = Monday;
            this.Tuesday = Tuesday;
            this.Wednesday = Wednesday;
            this.Thursday = Thursday;
            this.Friday = Friday;
            this.Saturday = Saturday;
            this.Sunday = Sunday;
            
        }
        
    
        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        /// <value>Time intervals for a particular day</value>
        [DataMember(Name="monday", EmitDefaultValue=false)]
        public List<TimeInterval> Monday { get; set; }
    
        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        /// <value>Time intervals for a particular day</value>
        [DataMember(Name="tuesday", EmitDefaultValue=false)]
        public List<TimeInterval> Tuesday { get; set; }
    
        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        /// <value>Time intervals for a particular day</value>
        [DataMember(Name="wednesday", EmitDefaultValue=false)]
        public List<TimeInterval> Wednesday { get; set; }
    
        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        /// <value>Time intervals for a particular day</value>
        [DataMember(Name="thursday", EmitDefaultValue=false)]
        public List<TimeInterval> Thursday { get; set; }
    
        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        /// <value>Time intervals for a particular day</value>
        [DataMember(Name="friday", EmitDefaultValue=false)]
        public List<TimeInterval> Friday { get; set; }
    
        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        /// <value>Time intervals for a particular day</value>
        [DataMember(Name="saturday", EmitDefaultValue=false)]
        public List<TimeInterval> Saturday { get; set; }
    
        /// <summary>
        /// Time intervals for a particular day
        /// </summary>
        /// <value>Time intervals for a particular day</value>
        [DataMember(Name="sunday", EmitDefaultValue=false)]
        public List<TimeInterval> Sunday { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WeeklyScheduleInfo {\n");
            sb.Append("  Monday: ").Append(Monday).Append("\n");
            sb.Append("  Tuesday: ").Append(Tuesday).Append("\n");
            sb.Append("  Wednesday: ").Append(Wednesday).Append("\n");
            sb.Append("  Thursday: ").Append(Thursday).Append("\n");
            sb.Append("  Friday: ").Append(Friday).Append("\n");
            sb.Append("  Saturday: ").Append(Saturday).Append("\n");
            sb.Append("  Sunday: ").Append(Sunday).Append("\n");
            
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
            return this.Equals(obj as WeeklyScheduleInfo);
        }

        /// <summary>
        /// Returns true if WeeklyScheduleInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of WeeklyScheduleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WeeklyScheduleInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Monday == other.Monday ||
                    this.Monday != null &&
                    this.Monday.SequenceEqual(other.Monday)
                ) && 
                (
                    this.Tuesday == other.Tuesday ||
                    this.Tuesday != null &&
                    this.Tuesday.SequenceEqual(other.Tuesday)
                ) && 
                (
                    this.Wednesday == other.Wednesday ||
                    this.Wednesday != null &&
                    this.Wednesday.SequenceEqual(other.Wednesday)
                ) && 
                (
                    this.Thursday == other.Thursday ||
                    this.Thursday != null &&
                    this.Thursday.SequenceEqual(other.Thursday)
                ) && 
                (
                    this.Friday == other.Friday ||
                    this.Friday != null &&
                    this.Friday.SequenceEqual(other.Friday)
                ) && 
                (
                    this.Saturday == other.Saturday ||
                    this.Saturday != null &&
                    this.Saturday.SequenceEqual(other.Saturday)
                ) && 
                (
                    this.Sunday == other.Sunday ||
                    this.Sunday != null &&
                    this.Sunday.SequenceEqual(other.Sunday)
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
                
                if (this.Monday != null)
                    hash = hash * 59 + this.Monday.GetHashCode();
                
                if (this.Tuesday != null)
                    hash = hash * 59 + this.Tuesday.GetHashCode();
                
                if (this.Wednesday != null)
                    hash = hash * 59 + this.Wednesday.GetHashCode();
                
                if (this.Thursday != null)
                    hash = hash * 59 + this.Thursday.GetHashCode();
                
                if (this.Friday != null)
                    hash = hash * 59 + this.Friday.GetHashCode();
                
                if (this.Saturday != null)
                    hash = hash * 59 + this.Saturday.GetHashCode();
                
                if (this.Sunday != null)
                    hash = hash * 59 + this.Sunday.GetHashCode();
                
                return hash;
            }
        }

    }
}
