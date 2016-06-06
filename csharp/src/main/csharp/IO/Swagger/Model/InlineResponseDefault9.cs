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
    public partial class InlineResponseDefault9 :  IEquatable<InlineResponseDefault9>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponseDefault9" /> class.
        /// Initializes a new instance of the <see cref="InlineResponseDefault9" />class.
        /// </summary>
        /// <param name="Id">Internal identifier of the call recording.</param>
        /// <param name="Duration">Recorded call duration.</param>
        /// <param name="ContentUri">Link to the call recording binary content.</param>
        /// <param name="ContentType">Call recording file format. Supported format is audio/x-wav.</param>

        public InlineResponseDefault9(int? Id = null, int? Duration = null, string ContentUri = null, string ContentType = null)
        {
            this.Id = Id;
            this.Duration = Duration;
            this.ContentUri = ContentUri;
            this.ContentType = ContentType;
            
        }
        
    
        /// <summary>
        /// Internal identifier of the call recording
        /// </summary>
        /// <value>Internal identifier of the call recording</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Recorded call duration
        /// </summary>
        /// <value>Recorded call duration</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }
    
        /// <summary>
        /// Link to the call recording binary content
        /// </summary>
        /// <value>Link to the call recording binary content</value>
        [DataMember(Name="contentUri", EmitDefaultValue=false)]
        public string ContentUri { get; set; }
    
        /// <summary>
        /// Call recording file format. Supported format is audio/x-wav
        /// </summary>
        /// <value>Call recording file format. Supported format is audio/x-wav</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefault9 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
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
            return this.Equals(obj as InlineResponseDefault9);
        }

        /// <summary>
        /// Returns true if InlineResponseDefault9 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefault9 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefault9 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.ContentUri == other.ContentUri ||
                    this.ContentUri != null &&
                    this.ContentUri.Equals(other.ContentUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                
                if (this.ContentUri != null)
                    hash = hash * 59 + this.ContentUri.GetHashCode();
                
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                
                return hash;
            }
        }

    }
}
