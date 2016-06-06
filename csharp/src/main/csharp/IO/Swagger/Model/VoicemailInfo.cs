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
    public partial class VoicemailInfo :  IEquatable<VoicemailInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailInfo" /> class.
        /// Initializes a new instance of the <see cref="VoicemailInfo" />class.
        /// </summary>
        /// <param name="Enabled">If &#39;True&#39; then voicemails are allowed to be received.</param>
        /// <param name="Recipient">Recipient.</param>

        public VoicemailInfo(bool? Enabled = null, RecipientInfo Recipient = null)
        {
            this.Enabled = Enabled;
            this.Recipient = Recipient;
            
        }
        
    
        /// <summary>
        /// If &#39;True&#39; then voicemails are allowed to be received
        /// </summary>
        /// <value>If &#39;True&#39; then voicemails are allowed to be received</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public RecipientInfo Recipient { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicemailInfo {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            
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
            return this.Equals(obj as VoicemailInfo);
        }

        /// <summary>
        /// Returns true if VoicemailInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicemailInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicemailInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Recipient == other.Recipient ||
                    this.Recipient != null &&
                    this.Recipient.Equals(other.Recipient)
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
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.Recipient != null)
                    hash = hash * 59 + this.Recipient.GetHashCode();
                
                return hash;
            }
        }

    }
}
