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
    public partial class RecordingInfo :  IEquatable<RecordingInfo>
    { 
    
        /// <summary>
        /// Indicates recording mode used
        /// </summary>
        /// <value>Indicates recording mode used</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "Automatic")]
            Automatic,
            
            [EnumMember(Value = "OnDemand")]
            Ondemand
        }

    
        /// <summary>
        /// Indicates recording mode used
        /// </summary>
        /// <value>Indicates recording mode used</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingInfo" /> class.
        /// Initializes a new instance of the <see cref="RecordingInfo" />class.
        /// </summary>
        /// <param name="Id">Internal identifier of the call recording.</param>
        /// <param name="Uri">Link to the call recording metadata resource.</param>
        /// <param name="Type">Indicates recording mode used.</param>
        /// <param name="ContentUri">Link to the call recording binary content.</param>

        public RecordingInfo(int? Id = null, string Uri = null, TypeEnum? Type = null, string ContentUri = null)
        {
            this.Id = Id;
            this.Uri = Uri;
            this.Type = Type;
            this.ContentUri = ContentUri;
            
        }
        
    
        /// <summary>
        /// Internal identifier of the call recording
        /// </summary>
        /// <value>Internal identifier of the call recording</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Link to the call recording metadata resource
        /// </summary>
        /// <value>Link to the call recording metadata resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Link to the call recording binary content
        /// </summary>
        /// <value>Link to the call recording binary content</value>
        [DataMember(Name="contentUri", EmitDefaultValue=false)]
        public string ContentUri { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordingInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ContentUri: ").Append(ContentUri).Append("\n");
            
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
            return this.Equals(obj as RecordingInfo);
        }

        /// <summary>
        /// Returns true if RecordingInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of RecordingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingInfo other)
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
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.ContentUri == other.ContentUri ||
                    this.ContentUri != null &&
                    this.ContentUri.Equals(other.ContentUri)
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
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.ContentUri != null)
                    hash = hash * 59 + this.ContentUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
