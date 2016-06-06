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
    public partial class RuleInfoForwardingNumberInfo :  IEquatable<RuleInfoForwardingNumberInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleInfoForwardingNumberInfo" /> class.
        /// Initializes a new instance of the <see cref="RuleInfoForwardingNumberInfo" />class.
        /// </summary>
        /// <param name="Uri">Link to a forwarding number resource.</param>
        /// <param name="Id">Internal identifier of a forwarding number.</param>
        /// <param name="PhoneNumber">Phone number to which the call is forwarded.</param>
        /// <param name="Label">Title of a forwarding number.</param>

        public RuleInfoForwardingNumberInfo(string Uri = null, string Id = null, string PhoneNumber = null, string Label = null)
        {
            this.Uri = Uri;
            this.Id = Id;
            this.PhoneNumber = PhoneNumber;
            this.Label = Label;
            
        }
        
    
        /// <summary>
        /// Link to a forwarding number resource
        /// </summary>
        /// <value>Link to a forwarding number resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Internal identifier of a forwarding number
        /// </summary>
        /// <value>Internal identifier of a forwarding number</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Phone number to which the call is forwarded
        /// </summary>
        /// <value>Phone number to which the call is forwarded</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Title of a forwarding number
        /// </summary>
        /// <value>Title of a forwarding number</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleInfoForwardingNumberInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            
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
            return this.Equals(obj as RuleInfoForwardingNumberInfo);
        }

        /// <summary>
        /// Returns true if RuleInfoForwardingNumberInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of RuleInfoForwardingNumberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleInfoForwardingNumberInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
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
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                
                return hash;
            }
        }

    }
}
