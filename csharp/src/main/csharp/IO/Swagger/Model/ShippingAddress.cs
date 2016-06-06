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
    public partial class ShippingAddress :  IEquatable<ShippingAddress>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingAddress" /> class.
        /// Initializes a new instance of the <see cref="ShippingAddress" />class.
        /// </summary>
        /// <param name="CustomerName">Name of a receiver.</param>
        /// <param name="Street">Street address, line 1 - street address, P.O. box, company name, c/o.</param>
        /// <param name="Street2">Street address, line 2 - apartment, suite, unit, building, floor, etc..</param>
        /// <param name="City">City name.</param>
        /// <param name="State">State/province name.</param>
        /// <param name="Zip">Zip code.</param>
        /// <param name="Country">Country name.</param>

        public ShippingAddress(string CustomerName = null, string Street = null, string Street2 = null, string City = null, string State = null, string Zip = null, string Country = null)
        {
            this.CustomerName = CustomerName;
            this.Street = Street;
            this.Street2 = Street2;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.Country = Country;
            
        }
        
    
        /// <summary>
        /// Name of a receiver
        /// </summary>
        /// <value>Name of a receiver</value>
        [DataMember(Name="customerName", EmitDefaultValue=false)]
        public string CustomerName { get; set; }
    
        /// <summary>
        /// Street address, line 1 - street address, P.O. box, company name, c/o
        /// </summary>
        /// <value>Street address, line 1 - street address, P.O. box, company name, c/o</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }
    
        /// <summary>
        /// Street address, line 2 - apartment, suite, unit, building, floor, etc.
        /// </summary>
        /// <value>Street address, line 2 - apartment, suite, unit, building, floor, etc.</value>
        [DataMember(Name="street2", EmitDefaultValue=false)]
        public string Street2 { get; set; }
    
        /// <summary>
        /// City name
        /// </summary>
        /// <value>City name</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
    
        /// <summary>
        /// State/province name
        /// </summary>
        /// <value>State/province name</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// Zip code
        /// </summary>
        /// <value>Zip code</value>
        [DataMember(Name="zip", EmitDefaultValue=false)]
        public string Zip { get; set; }
    
        /// <summary>
        /// Country name
        /// </summary>
        /// <value>Country name</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingAddress {\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            
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
            return this.Equals(obj as ShippingAddress);
        }

        /// <summary>
        /// Returns true if ShippingAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of ShippingAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomerName == other.CustomerName ||
                    this.CustomerName != null &&
                    this.CustomerName.Equals(other.CustomerName)
                ) && 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) && 
                (
                    this.Street2 == other.Street2 ||
                    this.Street2 != null &&
                    this.Street2.Equals(other.Street2)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Zip == other.Zip ||
                    this.Zip != null &&
                    this.Zip.Equals(other.Zip)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                
                if (this.CustomerName != null)
                    hash = hash * 59 + this.CustomerName.GetHashCode();
                
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                
                if (this.Street2 != null)
                    hash = hash * 59 + this.Street2.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Zip != null)
                    hash = hash * 59 + this.Zip.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                return hash;
            }
        }

    }
}
