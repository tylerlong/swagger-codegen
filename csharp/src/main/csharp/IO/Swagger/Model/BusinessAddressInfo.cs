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
    public partial class BusinessAddressInfo :  IEquatable<BusinessAddressInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessAddressInfo" /> class.
        /// Initializes a new instance of the <see cref="BusinessAddressInfo" />class.
        /// </summary>
        /// <param name="Country">Name of a country.</param>
        /// <param name="State">Name of a state/province.</param>
        /// <param name="City">Name of a city.</param>
        /// <param name="Street">Street address.</param>
        /// <param name="Zip">Zip code.</param>

        public BusinessAddressInfo(string Country = null, string State = null, string City = null, string Street = null, string Zip = null)
        {
            this.Country = Country;
            this.State = State;
            this.City = City;
            this.Street = Street;
            this.Zip = Zip;
            
        }
        
    
        /// <summary>
        /// Name of a country
        /// </summary>
        /// <value>Name of a country</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
    
        /// <summary>
        /// Name of a state/province
        /// </summary>
        /// <value>Name of a state/province</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// Name of a city
        /// </summary>
        /// <value>Name of a city</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
    
        /// <summary>
        /// Street address
        /// </summary>
        /// <value>Street address</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }
    
        /// <summary>
        /// Zip code
        /// </summary>
        /// <value>Zip code</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessAddressInfo {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            
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
            return this.Equals(obj as BusinessAddressInfo);
        }

        /// <summary>
        /// Returns true if BusinessAddressInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessAddressInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessAddressInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) && 
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
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
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                
                if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();
                
                return hash;
            }
        }

    }
}
