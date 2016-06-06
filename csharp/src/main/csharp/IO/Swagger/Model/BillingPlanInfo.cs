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
    public partial class BillingPlanInfo :  IEquatable<BillingPlanInfo>
    { 
    
        /// <summary>
        /// Duration period
        /// </summary>
        /// <value>Duration period</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DurationUnitEnum {
            
            [EnumMember(Value = "Month")]
            Month,
            
            [EnumMember(Value = "Day")]
            Day
        }

    
        /// <summary>
        /// Billing plan type
        /// </summary>
        /// <value>Billing plan type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "Initial")]
            Initial,
            
            [EnumMember(Value = "Regular")]
            Regular,
            
            [EnumMember(Value = "Suspended")]
            Suspended,
            
            [EnumMember(Value = "Trial")]
            Trial,
            
            [EnumMember(Value = "TrialNoCC")]
            Trialnocc,
            
            [EnumMember(Value = "Free")]
            Free
        }

    
        /// <summary>
        /// Duration period
        /// </summary>
        /// <value>Duration period</value>
        [DataMember(Name="durationUnit", EmitDefaultValue=false)]
        public DurationUnitEnum? DurationUnit { get; set; }
    
        /// <summary>
        /// Billing plan type
        /// </summary>
        /// <value>Billing plan type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlanInfo" /> class.
        /// Initializes a new instance of the <see cref="BillingPlanInfo" />class.
        /// </summary>
        /// <param name="Id">Internal identifier of a billing plan.</param>
        /// <param name="Name">Billing plan name.</param>
        /// <param name="DurationUnit">Duration period.</param>
        /// <param name="Duration">Number of duration units.</param>
        /// <param name="Type">Billing plan type.</param>

        public BillingPlanInfo(string Id = null, string Name = null, DurationUnitEnum? DurationUnit = null, string Duration = null, TypeEnum? Type = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.DurationUnit = DurationUnit;
            this.Duration = Duration;
            this.Type = Type;
            
        }
        
    
        /// <summary>
        /// Internal identifier of a billing plan
        /// </summary>
        /// <value>Internal identifier of a billing plan</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Billing plan name
        /// </summary>
        /// <value>Billing plan name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Number of duration units
        /// </summary>
        /// <value>Number of duration units</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public string Duration { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingPlanInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DurationUnit: ").Append(DurationUnit).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            
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
            return this.Equals(obj as BillingPlanInfo);
        }

        /// <summary>
        /// Returns true if BillingPlanInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingPlanInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingPlanInfo other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.DurationUnit == other.DurationUnit ||
                    this.DurationUnit != null &&
                    this.DurationUnit.Equals(other.DurationUnit)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.DurationUnit != null)
                    hash = hash * 59 + this.DurationUnit.GetHashCode();
                
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }

    }
}
