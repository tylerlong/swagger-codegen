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
    public partial class Body9 :  IEquatable<Body9>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Body9" /> class.
        /// Initializes a new instance of the <see cref="Body9" />class.
        /// </summary>
        /// <param name="EventFilters">Collection of URIs to API resources (see Event Types). Mandatory field.</param>

        public Body9(List<string> EventFilters = null)
        {
            this.EventFilters = EventFilters;
            
        }
        
    
        /// <summary>
        /// Collection of URIs to API resources (see Event Types). Mandatory field
        /// </summary>
        /// <value>Collection of URIs to API resources (see Event Types). Mandatory field</value>
        [DataMember(Name="eventFilters", EmitDefaultValue=false)]
        public List<string> EventFilters { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body9 {\n");
            sb.Append("  EventFilters: ").Append(EventFilters).Append("\n");
            
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
            return this.Equals(obj as Body9);
        }

        /// <summary>
        /// Returns true if Body9 instances are equal
        /// </summary>
        /// <param name="other">Instance of Body9 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body9 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EventFilters == other.EventFilters ||
                    this.EventFilters != null &&
                    this.EventFilters.SequenceEqual(other.EventFilters)
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
                
                if (this.EventFilters != null)
                    hash = hash * 59 + this.EventFilters.GetHashCode();
                
                return hash;
            }
        }

    }
}
