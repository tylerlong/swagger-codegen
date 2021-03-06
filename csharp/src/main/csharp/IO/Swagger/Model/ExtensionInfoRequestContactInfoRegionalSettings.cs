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
    public partial class ExtensionInfoRequestContactInfoRegionalSettings :  IEquatable<ExtensionInfoRequestContactInfoRegionalSettings>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestContactInfoRegionalSettings" /> class.
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestContactInfoRegionalSettings" />class.
        /// </summary>
        /// <param name="Timezone">Timezone.</param>
        /// <param name="Language">Language.</param>
        /// <param name="GreetingLanguage">GreetingLanguage.</param>
        /// <param name="FormattingLocale">FormattingLocale.</param>

        public ExtensionInfoRequestContactInfoRegionalSettings(ExtensionInfoRequestContactInfoRegionalSettingsTimezone Timezone = null, ExtensionInfoRequestContactInfoRegionalSettingsLanguage Language = null, ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage GreetingLanguage = null, ExtensionInfoRequestContactInfoRegionalSettingsFormattingLocale FormattingLocale = null)
        {
            this.Timezone = Timezone;
            this.Language = Language;
            this.GreetingLanguage = GreetingLanguage;
            this.FormattingLocale = FormattingLocale;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public ExtensionInfoRequestContactInfoRegionalSettingsTimezone Timezone { get; set; }
    
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public ExtensionInfoRequestContactInfoRegionalSettingsLanguage Language { get; set; }
    
        /// <summary>
        /// Gets or Sets GreetingLanguage
        /// </summary>
        [DataMember(Name="greetingLanguage", EmitDefaultValue=false)]
        public ExtensionInfoRequestContactInfoRegionalSettingsGreetingLanguage GreetingLanguage { get; set; }
    
        /// <summary>
        /// Gets or Sets FormattingLocale
        /// </summary>
        [DataMember(Name="formattingLocale", EmitDefaultValue=false)]
        public ExtensionInfoRequestContactInfoRegionalSettingsFormattingLocale FormattingLocale { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionInfoRequestContactInfoRegionalSettings {\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  GreetingLanguage: ").Append(GreetingLanguage).Append("\n");
            sb.Append("  FormattingLocale: ").Append(FormattingLocale).Append("\n");
            
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
            return this.Equals(obj as ExtensionInfoRequestContactInfoRegionalSettings);
        }

        /// <summary>
        /// Returns true if ExtensionInfoRequestContactInfoRegionalSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtensionInfoRequestContactInfoRegionalSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionInfoRequestContactInfoRegionalSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.GreetingLanguage == other.GreetingLanguage ||
                    this.GreetingLanguage != null &&
                    this.GreetingLanguage.Equals(other.GreetingLanguage)
                ) && 
                (
                    this.FormattingLocale == other.FormattingLocale ||
                    this.FormattingLocale != null &&
                    this.FormattingLocale.Equals(other.FormattingLocale)
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
                
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                
                if (this.GreetingLanguage != null)
                    hash = hash * 59 + this.GreetingLanguage.GetHashCode();
                
                if (this.FormattingLocale != null)
                    hash = hash * 59 + this.FormattingLocale.GetHashCode();
                
                return hash;
            }
        }

    }
}
