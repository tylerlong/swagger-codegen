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
    public partial class BusinessHourScheduleInfo :  IEquatable<BusinessHourScheduleInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessHourScheduleInfo" /> class.
        /// Initializes a new instance of the <see cref="BusinessHourScheduleInfo" />class.
        /// </summary>
        /// <param name="WeeklyRanges">WeeklyRanges.</param>

        public BusinessHourScheduleInfo(WeeklyScheduleInfo WeeklyRanges = null)
        {
            this.WeeklyRanges = WeeklyRanges;
            
        }
        
    
        /// <summary>
        /// Gets or Sets WeeklyRanges
        /// </summary>
        [DataMember(Name="weeklyRanges", EmitDefaultValue=false)]
        public WeeklyScheduleInfo WeeklyRanges { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessHourScheduleInfo {\n");
            sb.Append("  WeeklyRanges: ").Append(WeeklyRanges).Append("\n");
            
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
            return this.Equals(obj as BusinessHourScheduleInfo);
        }

        /// <summary>
        /// Returns true if BusinessHourScheduleInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessHourScheduleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessHourScheduleInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WeeklyRanges == other.WeeklyRanges ||
                    this.WeeklyRanges != null &&
                    this.WeeklyRanges.Equals(other.WeeklyRanges)
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
                
                if (this.WeeklyRanges != null)
                    hash = hash * 59 + this.WeeklyRanges.GetHashCode();
                
                return hash;
            }
        }

    }
}
