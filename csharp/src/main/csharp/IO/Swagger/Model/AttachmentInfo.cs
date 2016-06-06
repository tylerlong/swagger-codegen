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
    public partial class AttachmentInfo :  IEquatable<AttachmentInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentInfo" /> class.
        /// Initializes a new instance of the <see cref="AttachmentInfo" />class.
        /// </summary>
        /// <param name="Uri">Link to custom data attachment.</param>
        /// <param name="ContentType">Type of custom data attachment, see also MIME Types.</param>

        public AttachmentInfo(string Uri = null, string ContentType = null)
        {
            this.Uri = Uri;
            this.ContentType = ContentType;
            
        }
        
    
        /// <summary>
        /// Link to custom data attachment
        /// </summary>
        /// <value>Link to custom data attachment</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Type of custom data attachment, see also MIME Types
        /// </summary>
        /// <value>Type of custom data attachment, see also MIME Types</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            
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
            return this.Equals(obj as AttachmentInfo);
        }

        /// <summary>
        /// Returns true if AttachmentInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of AttachmentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentInfo other)
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
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
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
                
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                
                return hash;
            }
        }

    }
}
