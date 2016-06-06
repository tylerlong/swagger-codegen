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
    public partial class InlineResponseDefault4 :  IEquatable<InlineResponseDefault4>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponseDefault4" /> class.
        /// Initializes a new instance of the <see cref="InlineResponseDefault4" />class.
        /// </summary>
        /// <param name="Navigation">Navigation.</param>
        /// <param name="Records">List of extensions with extension information.</param>
        /// <param name="Paging">Paging.</param>

        public InlineResponseDefault4(NavigationInfo Navigation = null, List<ExtensionInfo> Records = null, PagingInfo Paging = null)
        {
            this.Navigation = Navigation;
            this.Records = Records;
            this.Paging = Paging;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Navigation
        /// </summary>
        [DataMember(Name="navigation", EmitDefaultValue=false)]
        public NavigationInfo Navigation { get; set; }
    
        /// <summary>
        /// List of extensions with extension information
        /// </summary>
        /// <value>List of extensions with extension information</value>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public List<ExtensionInfo> Records { get; set; }
    
        /// <summary>
        /// Gets or Sets Paging
        /// </summary>
        [DataMember(Name="paging", EmitDefaultValue=false)]
        public PagingInfo Paging { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefault4 {\n");
            sb.Append("  Navigation: ").Append(Navigation).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  Paging: ").Append(Paging).Append("\n");
            
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
            return this.Equals(obj as InlineResponseDefault4);
        }

        /// <summary>
        /// Returns true if InlineResponseDefault4 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefault4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefault4 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Navigation == other.Navigation ||
                    this.Navigation != null &&
                    this.Navigation.Equals(other.Navigation)
                ) && 
                (
                    this.Records == other.Records ||
                    this.Records != null &&
                    this.Records.SequenceEqual(other.Records)
                ) && 
                (
                    this.Paging == other.Paging ||
                    this.Paging != null &&
                    this.Paging.Equals(other.Paging)
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
                
                if (this.Navigation != null)
                    hash = hash * 59 + this.Navigation.GetHashCode();
                
                if (this.Records != null)
                    hash = hash * 59 + this.Records.GetHashCode();
                
                if (this.Paging != null)
                    hash = hash * 59 + this.Paging.GetHashCode();
                
                return hash;
            }
        }

    }
}
