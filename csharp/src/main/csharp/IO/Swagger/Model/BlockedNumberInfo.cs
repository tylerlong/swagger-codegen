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
    public partial class BlockedNumberInfo :  IEquatable<BlockedNumberInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedNumberInfo" /> class.
        /// Initializes a new instance of the <see cref="BlockedNumberInfo" />class.
        /// </summary>
        /// <param name="Id">Standard resource properties ID and canonical URI, see the section called \u201CResource Identification Properties\u201D.</param>
        /// <param name="Uri">Canonical URI of a blocked number resource.</param>
        /// <param name="Name">Name assigned by a user to a blocked phone number.</param>
        /// <param name="PhoneNumber">Phone number to be blocked.</param>

        public BlockedNumberInfo(string Id = null, string Uri = null, string Name = null, string PhoneNumber = null)
        {
            this.Id = Id;
            this.Uri = Uri;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            
        }
        
    
        /// <summary>
        /// Standard resource properties ID and canonical URI, see the section called \u201CResource Identification Properties\u201D
        /// </summary>
        /// <value>Standard resource properties ID and canonical URI, see the section called \u201CResource Identification Properties\u201D</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Canonical URI of a blocked number resource
        /// </summary>
        /// <value>Canonical URI of a blocked number resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Name assigned by a user to a blocked phone number
        /// </summary>
        /// <value>Name assigned by a user to a blocked phone number</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Phone number to be blocked
        /// </summary>
        /// <value>Phone number to be blocked</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlockedNumberInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            
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
            return this.Equals(obj as BlockedNumberInfo);
        }

        /// <summary>
        /// Returns true if BlockedNumberInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of BlockedNumberInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockedNumberInfo other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                
                return hash;
            }
        }

    }
}
