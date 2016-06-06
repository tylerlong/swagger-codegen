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
    public partial class Body6 :  IEquatable<Body6>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Body6" /> class.
        /// Initializes a new instance of the <see cref="Body6" />class.
        /// </summary>
        /// <param name="From">From.</param>
        /// <param name="To">To.</param>
        /// <param name="CallerId">CallerId.</param>
        /// <param name="PlayPrompt">The audio prompt that the calling party hears when the call is connected.</param>
        /// <param name="Country">Country.</param>

        public Body6(RingOutRequestFrom From = null, RingOutRequestTo To = null, RingOutRequestTo CallerId = null, bool? PlayPrompt = null, RingOutRequestCountryInfo Country = null)
        {
            this.From = From;
            this.To = To;
            this.CallerId = CallerId;
            this.PlayPrompt = PlayPrompt;
            this.Country = Country;
            
        }
        
    
        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public RingOutRequestFrom From { get; set; }
    
        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public RingOutRequestTo To { get; set; }
    
        /// <summary>
        /// Gets or Sets CallerId
        /// </summary>
        [DataMember(Name="callerId", EmitDefaultValue=false)]
        public RingOutRequestTo CallerId { get; set; }
    
        /// <summary>
        /// The audio prompt that the calling party hears when the call is connected
        /// </summary>
        /// <value>The audio prompt that the calling party hears when the call is connected</value>
        [DataMember(Name="playPrompt", EmitDefaultValue=false)]
        public bool? PlayPrompt { get; set; }
    
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public RingOutRequestCountryInfo Country { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body6 {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
            sb.Append("  PlayPrompt: ").Append(PlayPrompt).Append("\n");
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
            return this.Equals(obj as Body6);
        }

        /// <summary>
        /// Returns true if Body6 instances are equal
        /// </summary>
        /// <param name="other">Instance of Body6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body6 other)
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
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) && 
                (
                    this.CallerId == other.CallerId ||
                    this.CallerId != null &&
                    this.CallerId.Equals(other.CallerId)
                ) && 
                (
                    this.PlayPrompt == other.PlayPrompt ||
                    this.PlayPrompt != null &&
                    this.PlayPrompt.Equals(other.PlayPrompt)
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
                
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                
                if (this.CallerId != null)
                    hash = hash * 59 + this.CallerId.GetHashCode();
                
                if (this.PlayPrompt != null)
                    hash = hash * 59 + this.PlayPrompt.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                
                return hash;
            }
        }

    }
}
