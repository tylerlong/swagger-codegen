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
    public partial class FormattingLocaleInfo :  IEquatable<FormattingLocaleInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FormattingLocaleInfo" /> class.
        /// Initializes a new instance of the <see cref="FormattingLocaleInfo" />class.
        /// </summary>
        /// <param name="Id">Internal identifier of a formatting language.</param>
        /// <param name="LocaleCode">Localization code of a formatting language.</param>
        /// <param name="Name">Official name of a formatting language.</param>

        public FormattingLocaleInfo(string Id = null, string LocaleCode = null, string Name = null)
        {
            this.Id = Id;
            this.LocaleCode = LocaleCode;
            this.Name = Name;
            
        }
        
    
        /// <summary>
        /// Internal identifier of a formatting language
        /// </summary>
        /// <value>Internal identifier of a formatting language</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Localization code of a formatting language
        /// </summary>
        /// <value>Localization code of a formatting language</value>
        [DataMember(Name="localeCode", EmitDefaultValue=false)]
        public string LocaleCode { get; set; }
    
        /// <summary>
        /// Official name of a formatting language
        /// </summary>
        /// <value>Official name of a formatting language</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormattingLocaleInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocaleCode: ").Append(LocaleCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            
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
            return this.Equals(obj as FormattingLocaleInfo);
        }

        /// <summary>
        /// Returns true if FormattingLocaleInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of FormattingLocaleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormattingLocaleInfo other)
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
                    this.LocaleCode == other.LocaleCode ||
                    this.LocaleCode != null &&
                    this.LocaleCode.Equals(other.LocaleCode)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.LocaleCode != null)
                    hash = hash * 59 + this.LocaleCode.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }
}
