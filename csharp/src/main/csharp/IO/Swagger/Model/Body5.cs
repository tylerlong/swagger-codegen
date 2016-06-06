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
    public partial class Body5 :  IEquatable<Body5>
    { 
    
        /// <summary>
        /// Read status of a message to be changed. Multiple values are accepted
        /// </summary>
        /// <value>Read status of a message to be changed. Multiple values are accepted</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReadStatusEnum {
            
            [EnumMember(Value = "Read")]
            Read,
            
            [EnumMember(Value = "Unread")]
            Unread
        }

    
        /// <summary>
        /// Read status of a message to be changed. Multiple values are accepted
        /// </summary>
        /// <value>Read status of a message to be changed. Multiple values are accepted</value>
        [DataMember(Name="readStatus", EmitDefaultValue=false)]
        public ReadStatusEnum? ReadStatus { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Body5" /> class.
        /// Initializes a new instance of the <see cref="Body5" />class.
        /// </summary>
        /// <param name="ReadStatus">Read status of a message to be changed. Multiple values are accepted.</param>

        public Body5(ReadStatusEnum? ReadStatus = null)
        {
            this.ReadStatus = ReadStatus;
            
        }
        
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body5 {\n");
            sb.Append("  ReadStatus: ").Append(ReadStatus).Append("\n");
            
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
            return this.Equals(obj as Body5);
        }

        /// <summary>
        /// Returns true if Body5 instances are equal
        /// </summary>
        /// <param name="other">Instance of Body5 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body5 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReadStatus == other.ReadStatus ||
                    this.ReadStatus != null &&
                    this.ReadStatus.Equals(other.ReadStatus)
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
                
                if (this.ReadStatus != null)
                    hash = hash * 59 + this.ReadStatus.GetHashCode();
                
                return hash;
            }
        }

    }
}
