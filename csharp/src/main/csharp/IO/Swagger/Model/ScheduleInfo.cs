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
    public partial class ScheduleInfo :  IEquatable<ScheduleInfo>
    { 
    
        /// <summary>
        /// The user's schedule specified for business hours or after hours; it can also be set/retrieved calling the corresponding method
        /// </summary>
        /// <value>The user's schedule specified for business hours or after hours; it can also be set/retrieved calling the corresponding method</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum _RefEnum {
            
            [EnumMember(Value = "BusinessHours")]
            Businesshours,
            
            [EnumMember(Value = "AfterHours")]
            Afterhours
        }

    
        /// <summary>
        /// The user's schedule specified for business hours or after hours; it can also be set/retrieved calling the corresponding method
        /// </summary>
        /// <value>The user's schedule specified for business hours or after hours; it can also be set/retrieved calling the corresponding method</value>
        [DataMember(Name="ref", EmitDefaultValue=false)]
        public _RefEnum? _Ref { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleInfo" /> class.
        /// Initializes a new instance of the <see cref="ScheduleInfo" />class.
        /// </summary>
        /// <param name="WeeklyRanges">WeeklyRanges.</param>
        /// <param name="Ranges">Ranges.</param>
        /// <param name="_Ref">The user&#39;s schedule specified for business hours or after hours; it can also be set/retrieved calling the corresponding method.</param>

        public ScheduleInfo(WeeklyScheduleInfo WeeklyRanges = null, RangesInfo Ranges = null, _RefEnum? _Ref = null)
        {
            this.WeeklyRanges = WeeklyRanges;
            this.Ranges = Ranges;
            this._Ref = _Ref;
            
        }
        
    
        /// <summary>
        /// Gets or Sets WeeklyRanges
        /// </summary>
        [DataMember(Name="weeklyRanges", EmitDefaultValue=false)]
        public WeeklyScheduleInfo WeeklyRanges { get; set; }
    
        /// <summary>
        /// Gets or Sets Ranges
        /// </summary>
        [DataMember(Name="ranges", EmitDefaultValue=false)]
        public RangesInfo Ranges { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleInfo {\n");
            sb.Append("  WeeklyRanges: ").Append(WeeklyRanges).Append("\n");
            sb.Append("  Ranges: ").Append(Ranges).Append("\n");
            sb.Append("  _Ref: ").Append(_Ref).Append("\n");
            
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
            return this.Equals(obj as ScheduleInfo);
        }

        /// <summary>
        /// Returns true if ScheduleInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WeeklyRanges == other.WeeklyRanges ||
                    this.WeeklyRanges != null &&
                    this.WeeklyRanges.Equals(other.WeeklyRanges)
                ) && 
                (
                    this.Ranges == other.Ranges ||
                    this.Ranges != null &&
                    this.Ranges.Equals(other.Ranges)
                ) && 
                (
                    this._Ref == other._Ref ||
                    this._Ref != null &&
                    this._Ref.Equals(other._Ref)
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
                
                if (this.Ranges != null)
                    hash = hash * 59 + this.Ranges.GetHashCode();
                
                if (this._Ref != null)
                    hash = hash * 59 + this._Ref.GetHashCode();
                
                return hash;
            }
        }

    }
}
