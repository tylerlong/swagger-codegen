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
    public partial class AnsweringRuleInfoCallerInfo :  IEquatable<AnsweringRuleInfoCallerInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnsweringRuleInfoCallerInfo" /> class.
        /// Initializes a new instance of the <see cref="AnsweringRuleInfoCallerInfo" />class.
        /// </summary>
        /// <param name="CallerId">Phone number of a caller.</param>
        /// <param name="Name">Contact name of a caller.</param>

        public AnsweringRuleInfoCallerInfo(string CallerId = null, string Name = null)
        {
            this.CallerId = CallerId;
            this.Name = Name;
            
        }
        
    
        /// <summary>
        /// Phone number of a caller
        /// </summary>
        /// <value>Phone number of a caller</value>
        [DataMember(Name="callerId", EmitDefaultValue=false)]
        public string CallerId { get; set; }
    
        /// <summary>
        /// Contact name of a caller
        /// </summary>
        /// <value>Contact name of a caller</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnsweringRuleInfoCallerInfo {\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            
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
            return this.Equals(obj as AnsweringRuleInfoCallerInfo);
        }

        /// <summary>
        /// Returns true if AnsweringRuleInfoCallerInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of AnsweringRuleInfoCallerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnsweringRuleInfoCallerInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CallerId == other.CallerId ||
                    this.CallerId != null &&
                    this.CallerId.Equals(other.CallerId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.CallerId != null)
                    hash = hash * 59 + this.CallerId.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }
}
