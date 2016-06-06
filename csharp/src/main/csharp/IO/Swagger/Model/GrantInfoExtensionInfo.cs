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
    public partial class GrantInfoExtensionInfo :  IEquatable<GrantInfoExtensionInfo>
    { 
    
        /// <summary>
        /// Extension type
        /// </summary>
        /// <value>Extension type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "User")]
            User,
            
            [EnumMember(Value = "Fax User")]
            FaxUser,
            
            [EnumMember(Value = "VirtualUser")]
            Virtualuser,
            
            [EnumMember(Value = "DigitalUser")]
            Digitaluser,
            
            [EnumMember(Value = "Department")]
            Department,
            
            [EnumMember(Value = "Announcement")]
            Announcement,
            
            [EnumMember(Value = "Voicemail")]
            Voicemail,
            
            [EnumMember(Value = "SharedLinesGroup")]
            Sharedlinesgroup,
            
            [EnumMember(Value = "PagingOnly")]
            Pagingonly,
            
            [EnumMember(Value = "IvrMenu")]
            Ivrmenu,
            
            [EnumMember(Value = "ApplicationExtension")]
            Applicationextension,
            
            [EnumMember(Value = "Park Location")]
            ParkLocation
        }

    
        /// <summary>
        /// Extension type
        /// </summary>
        /// <value>Extension type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantInfoExtensionInfo" /> class.
        /// Initializes a new instance of the <see cref="GrantInfoExtensionInfo" />class.
        /// </summary>
        /// <param name="Id">Internal identifier of an extension.</param>
        /// <param name="Uri">Canonical URI of an extension.</param>
        /// <param name="ExtensionNumber">Extension short number (usually 3 or 4 digits).</param>
        /// <param name="Type">Extension type.</param>

        public GrantInfoExtensionInfo(string Id = null, string Uri = null, string ExtensionNumber = null, TypeEnum? Type = null)
        {
            this.Id = Id;
            this.Uri = Uri;
            this.ExtensionNumber = ExtensionNumber;
            this.Type = Type;
            
        }
        
    
        /// <summary>
        /// Internal identifier of an extension
        /// </summary>
        /// <value>Internal identifier of an extension</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Canonical URI of an extension
        /// </summary>
        /// <value>Canonical URI of an extension</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Extension short number (usually 3 or 4 digits)
        /// </summary>
        /// <value>Extension short number (usually 3 or 4 digits)</value>
        [DataMember(Name="extensionNumber", EmitDefaultValue=false)]
        public string ExtensionNumber { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantInfoExtensionInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ExtensionNumber: ").Append(ExtensionNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            
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
            return this.Equals(obj as GrantInfoExtensionInfo);
        }

        /// <summary>
        /// Returns true if GrantInfoExtensionInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of GrantInfoExtensionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrantInfoExtensionInfo other)
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
                    this.ExtensionNumber == other.ExtensionNumber ||
                    this.ExtensionNumber != null &&
                    this.ExtensionNumber.Equals(other.ExtensionNumber)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.ExtensionNumber != null)
                    hash = hash * 59 + this.ExtensionNumber.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }

    }
}
