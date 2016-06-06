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
    public partial class PhoneLinesInfo :  IEquatable<PhoneLinesInfo>
    { 
    
        /// <summary>
        /// Type of phone line
        /// </summary>
        /// <value>Type of phone line</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineTypeEnum {
            
            [EnumMember(Value = "Standalone")]
            Standalone,
            
            [EnumMember(Value = "StandaloneFree")]
            Standalonefree,
            
            [EnumMember(Value = "BlaPrimary")]
            Blaprimary,
            
            [EnumMember(Value = "BlaSecondary")]
            Blasecondary
        }

    
        /// <summary>
        /// Type of phone line
        /// </summary>
        /// <value>Type of phone line</value>
        [DataMember(Name="lineType", EmitDefaultValue=false)]
        public LineTypeEnum? LineType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneLinesInfo" /> class.
        /// Initializes a new instance of the <see cref="PhoneLinesInfo" />class.
        /// </summary>
        /// <param name="LineType">Type of phone line.</param>
        /// <param name="PhoneInfo">PhoneInfo.</param>

        public PhoneLinesInfo(LineTypeEnum? LineType = null, PhoneLinesInfoPhoneNumberInfo PhoneInfo = null)
        {
            this.LineType = LineType;
            this.PhoneInfo = PhoneInfo;
            
        }
        
    
        /// <summary>
        /// Gets or Sets PhoneInfo
        /// </summary>
        [DataMember(Name="phoneInfo", EmitDefaultValue=false)]
        public PhoneLinesInfoPhoneNumberInfo PhoneInfo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneLinesInfo {\n");
            sb.Append("  LineType: ").Append(LineType).Append("\n");
            sb.Append("  PhoneInfo: ").Append(PhoneInfo).Append("\n");
            
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
            return this.Equals(obj as PhoneLinesInfo);
        }

        /// <summary>
        /// Returns true if PhoneLinesInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneLinesInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneLinesInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LineType == other.LineType ||
                    this.LineType != null &&
                    this.LineType.Equals(other.LineType)
                ) && 
                (
                    this.PhoneInfo == other.PhoneInfo ||
                    this.PhoneInfo != null &&
                    this.PhoneInfo.Equals(other.PhoneInfo)
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
                
                if (this.LineType != null)
                    hash = hash * 59 + this.LineType.GetHashCode();
                
                if (this.PhoneInfo != null)
                    hash = hash * 59 + this.PhoneInfo.GetHashCode();
                
                return hash;
            }
        }

    }
}
