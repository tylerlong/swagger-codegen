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
    public partial class Body3 :  IEquatable<Body3>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Body3" /> class.
        /// Initializes a new instance of the <see cref="Body3" />class.
        /// </summary>
        /// <param name="From">From.</param>
        /// <param name="ReplyOn">Internal identifier of a message this message replies to.</param>
        /// <param name="Text">Text of a pager message. Max length is 1024 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 512 symbols.</param>
        /// <param name="To">Optional if replyOn parameter is specified. Receiver of a pager message. The extensionNumber property must be filled.</param>

        public Body3(CallerInfo From = null, int? ReplyOn = null, string Text = null, List<CallerInfo> To = null)
        {
            this.From = From;
            this.ReplyOn = ReplyOn;
            this.Text = Text;
            this.To = To;
            
        }
        
    
        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public CallerInfo From { get; set; }
    
        /// <summary>
        /// Internal identifier of a message this message replies to
        /// </summary>
        /// <value>Internal identifier of a message this message replies to</value>
        [DataMember(Name="replyOn", EmitDefaultValue=false)]
        public int? ReplyOn { get; set; }
    
        /// <summary>
        /// Text of a pager message. Max length is 1024 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 512 symbols
        /// </summary>
        /// <value>Text of a pager message. Max length is 1024 symbols (2-byte UTF-16 encoded). If a character is encoded in 4 bytes in UTF-16 it is treated as 2 characters, thus restricting the maximum message length to 512 symbols</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
    
        /// <summary>
        /// Optional if replyOn parameter is specified. Receiver of a pager message. The extensionNumber property must be filled
        /// </summary>
        /// <value>Optional if replyOn parameter is specified. Receiver of a pager message. The extensionNumber property must be filled</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<CallerInfo> To { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body3 {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  ReplyOn: ").Append(ReplyOn).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as Body3);
        }

        /// <summary>
        /// Returns true if Body3 instances are equal
        /// </summary>
        /// <param name="other">Instance of Body3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body3 other)
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
                    this.ReplyOn == other.ReplyOn ||
                    this.ReplyOn != null &&
                    this.ReplyOn.Equals(other.ReplyOn)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) && 
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.SequenceEqual(other.To)
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
                
                if (this.ReplyOn != null)
                    hash = hash * 59 + this.ReplyOn.GetHashCode();
                
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                
                return hash;
            }
        }

    }
}
