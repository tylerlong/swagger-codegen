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
    public partial class ProfileImageInfo :  IEquatable<ProfileImageInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileImageInfo" /> class.
        /// Initializes a new instance of the <see cref="ProfileImageInfo" />class.
        /// </summary>
        /// <param name="Uri">Link to a profile image. If an image is not uploaded for an extension, only uri is returned.</param>
        /// <param name="Etag">Identifier of an image.</param>
        /// <param name="LastModified">The datetime when an image was last updated in ISO 8601 format, for example 2016-03-10T18:07:52.534Z.</param>
        /// <param name="ContentType">The type of an image.</param>
        /// <param name="Scales">List of URIs to profile images in different dimensions.</param>

        public ProfileImageInfo(string Uri = null, string Etag = null, DateTime? LastModified = null, string ContentType = null, List<string> Scales = null)
        {
            this.Uri = Uri;
            this.Etag = Etag;
            this.LastModified = LastModified;
            this.ContentType = ContentType;
            this.Scales = Scales;
            
        }
        
    
        /// <summary>
        /// Link to a profile image. If an image is not uploaded for an extension, only uri is returned
        /// </summary>
        /// <value>Link to a profile image. If an image is not uploaded for an extension, only uri is returned</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Identifier of an image
        /// </summary>
        /// <value>Identifier of an image</value>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }
    
        /// <summary>
        /// The datetime when an image was last updated in ISO 8601 format, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>The datetime when an image was last updated in ISO 8601 format, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public DateTime? LastModified { get; set; }
    
        /// <summary>
        /// The type of an image
        /// </summary>
        /// <value>The type of an image</value>
        [DataMember(Name="contentType", EmitDefaultValue=false)]
        public string ContentType { get; set; }
    
        /// <summary>
        /// List of URIs to profile images in different dimensions
        /// </summary>
        /// <value>List of URIs to profile images in different dimensions</value>
        [DataMember(Name="scales", EmitDefaultValue=false)]
        public List<string> Scales { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileImageInfo {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Scales: ").Append(Scales).Append("\n");
            
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
            return this.Equals(obj as ProfileImageInfo);
        }

        /// <summary>
        /// Returns true if ProfileImageInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ProfileImageInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileImageInfo other)
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
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) && 
                (
                    this.LastModified == other.LastModified ||
                    this.LastModified != null &&
                    this.LastModified.Equals(other.LastModified)
                ) && 
                (
                    this.ContentType == other.ContentType ||
                    this.ContentType != null &&
                    this.ContentType.Equals(other.ContentType)
                ) && 
                (
                    this.Scales == other.Scales ||
                    this.Scales != null &&
                    this.Scales.SequenceEqual(other.Scales)
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
                
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                
                if (this.LastModified != null)
                    hash = hash * 59 + this.LastModified.GetHashCode();
                
                if (this.ContentType != null)
                    hash = hash * 59 + this.ContentType.GetHashCode();
                
                if (this.Scales != null)
                    hash = hash * 59 + this.Scales.GetHashCode();
                
                return hash;
            }
        }

    }
}
