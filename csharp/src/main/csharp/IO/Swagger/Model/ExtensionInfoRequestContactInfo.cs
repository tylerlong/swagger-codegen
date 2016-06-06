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
    public partial class ExtensionInfoRequestContactInfo :  IEquatable<ExtensionInfoRequestContactInfo>
    { 
    
        /// <summary>
        /// Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'
        /// </summary>
        /// <value>Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SetupWizardStateEnum {
            
            [EnumMember(Value = "NotStarted")]
            Notstarted,
            
            [EnumMember(Value = "Incomplete")]
            Incomplete,
            
            [EnumMember(Value = "Completed")]
            Completed
        }

    
        /// <summary>
        /// Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'
        /// </summary>
        /// <value>Specifies extension configuration wizard state (web service setup). The default value is 'NotStarted'</value>
        [DataMember(Name="setupWizardState", EmitDefaultValue=false)]
        public SetupWizardStateEnum? SetupWizardState { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestContactInfo" /> class.
        /// Initializes a new instance of the <see cref="ExtensionInfoRequestContactInfo" />class.
        /// </summary>
        /// <param name="Contact">Contact.</param>
        /// <param name="RegionalSettings">RegionalSettings.</param>
        /// <param name="SetupWizardState">Specifies extension configuration wizard state (web service setup). The default value is &#39;NotStarted&#39;.</param>
        /// <param name="Department">Extension user department.</param>

        public ExtensionInfoRequestContactInfo(ContactInfo Contact = null, ExtensionInfoRequestContactInfoRegionalSettings RegionalSettings = null, SetupWizardStateEnum? SetupWizardState = null, string Department = null)
        {
            this.Contact = Contact;
            this.RegionalSettings = RegionalSettings;
            this.SetupWizardState = SetupWizardState;
            this.Department = Department;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public ContactInfo Contact { get; set; }
    
        /// <summary>
        /// Gets or Sets RegionalSettings
        /// </summary>
        [DataMember(Name="regionalSettings", EmitDefaultValue=false)]
        public ExtensionInfoRequestContactInfoRegionalSettings RegionalSettings { get; set; }
    
        /// <summary>
        /// Extension user department
        /// </summary>
        /// <value>Extension user department</value>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionInfoRequestContactInfo {\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  RegionalSettings: ").Append(RegionalSettings).Append("\n");
            sb.Append("  SetupWizardState: ").Append(SetupWizardState).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            
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
            return this.Equals(obj as ExtensionInfoRequestContactInfo);
        }

        /// <summary>
        /// Returns true if ExtensionInfoRequestContactInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtensionInfoRequestContactInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionInfoRequestContactInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.RegionalSettings == other.RegionalSettings ||
                    this.RegionalSettings != null &&
                    this.RegionalSettings.Equals(other.RegionalSettings)
                ) && 
                (
                    this.SetupWizardState == other.SetupWizardState ||
                    this.SetupWizardState != null &&
                    this.SetupWizardState.Equals(other.SetupWizardState)
                ) && 
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
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
                
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                
                if (this.RegionalSettings != null)
                    hash = hash * 59 + this.RegionalSettings.GetHashCode();
                
                if (this.SetupWizardState != null)
                    hash = hash * 59 + this.SetupWizardState.GetHashCode();
                
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                
                return hash;
            }
        }

    }
}
