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
    public partial class InlineResponseDefault3 :  IEquatable<InlineResponseDefault3>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponseDefault3" /> class.
        /// Initializes a new instance of the <see cref="InlineResponseDefault3" />class.
        /// </summary>
        /// <param name="Email">Company business email address.</param>
        /// <param name="Company">Company business name.</param>
        /// <param name="Uri">Canonical URI of the business address resource.</param>
        /// <param name="BusinessAddress">BusinessAddress.</param>

        public InlineResponseDefault3(string Email = null, string Company = null, string Uri = null, BusinessAddressInfo BusinessAddress = null)
        {
            this.Email = Email;
            this.Company = Company;
            this.Uri = Uri;
            this.BusinessAddress = BusinessAddress;
            
        }
        
    
        /// <summary>
        /// Company business email address
        /// </summary>
        /// <value>Company business email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Company business name
        /// </summary>
        /// <value>Company business name</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }
    
        /// <summary>
        /// Canonical URI of the business address resource
        /// </summary>
        /// <value>Canonical URI of the business address resource</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Gets or Sets BusinessAddress
        /// </summary>
        [DataMember(Name="businessAddress", EmitDefaultValue=false)]
        public BusinessAddressInfo BusinessAddress { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefault3 {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  BusinessAddress: ").Append(BusinessAddress).Append("\n");
            
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
            return this.Equals(obj as InlineResponseDefault3);
        }

        /// <summary>
        /// Returns true if InlineResponseDefault3 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefault3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefault3 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.BusinessAddress == other.BusinessAddress ||
                    this.BusinessAddress != null &&
                    this.BusinessAddress.Equals(other.BusinessAddress)
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
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                if (this.BusinessAddress != null)
                    hash = hash * 59 + this.BusinessAddress.GetHashCode();
                
                return hash;
            }
        }

    }
}
