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
    public partial class AccountInfo :  IEquatable<AccountInfo>
    { 
    
        /// <summary>
        /// Specifies account configuration wizard state (web service setup). The default value is 'NotStarted'
        /// </summary>
        /// <value>Specifies account configuration wizard state (web service setup). The default value is 'NotStarted'</value>
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
        /// Status of the current account
        /// </summary>
        /// <value>Status of the current account</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "Confirmed")]
            Confirmed,
            
            [EnumMember(Value = "Disabled")]
            Disabled
        }

    
        /// <summary>
        /// Specifies account configuration wizard state (web service setup). The default value is 'NotStarted'
        /// </summary>
        /// <value>Specifies account configuration wizard state (web service setup). The default value is 'NotStarted'</value>
        [DataMember(Name="setupWizardState", EmitDefaultValue=false)]
        public SetupWizardStateEnum? SetupWizardState { get; set; }
    
        /// <summary>
        /// Status of the current account
        /// </summary>
        /// <value>Status of the current account</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountInfo" /> class.
        /// Initializes a new instance of the <see cref="AccountInfo" />class.
        /// </summary>
        /// <param name="Id">Internal identifier of an account.</param>
        /// <param name="Uri">Canonical URI of an account.</param>
        /// <param name="MainNumber">Main phone number of the current account.</param>
        /// <param name="_Operator">_Operator.</param>
        /// <param name="PartnerId">Additional account identifier, developed and applied by the client.</param>
        /// <param name="ServiceInfo">ServiceInfo.</param>
        /// <param name="SetupWizardState">Specifies account configuration wizard state (web service setup). The default value is &#39;NotStarted&#39;.</param>
        /// <param name="Status">Status of the current account.</param>
        /// <param name="StatusInfo">StatusInfo.</param>

        public AccountInfo(string Id = null, string Uri = null, string MainNumber = null, ExtensionInfo _Operator = null, string PartnerId = null, ServiceInfo ServiceInfo = null, SetupWizardStateEnum? SetupWizardState = null, StatusEnum? Status = null, StatusInfo StatusInfo = null)
        {
            this.Id = Id;
            this.Uri = Uri;
            this.MainNumber = MainNumber;
            this._Operator = _Operator;
            this.PartnerId = PartnerId;
            this.ServiceInfo = ServiceInfo;
            this.SetupWizardState = SetupWizardState;
            this.Status = Status;
            this.StatusInfo = StatusInfo;
            
        }
        
    
        /// <summary>
        /// Internal identifier of an account
        /// </summary>
        /// <value>Internal identifier of an account</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Canonical URI of an account
        /// </summary>
        /// <value>Canonical URI of an account</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Main phone number of the current account
        /// </summary>
        /// <value>Main phone number of the current account</value>
        [DataMember(Name="mainNumber", EmitDefaultValue=false)]
        public string MainNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public ExtensionInfo _Operator { get; set; }
    
        /// <summary>
        /// Additional account identifier, developed and applied by the client
        /// </summary>
        /// <value>Additional account identifier, developed and applied by the client</value>
        [DataMember(Name="partnerId", EmitDefaultValue=false)]
        public string PartnerId { get; set; }
    
        /// <summary>
        /// Gets or Sets ServiceInfo
        /// </summary>
        [DataMember(Name="serviceInfo", EmitDefaultValue=false)]
        public ServiceInfo ServiceInfo { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusInfo
        /// </summary>
        [DataMember(Name="statusInfo", EmitDefaultValue=false)]
        public StatusInfo StatusInfo { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  MainNumber: ").Append(MainNumber).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  ServiceInfo: ").Append(ServiceInfo).Append("\n");
            sb.Append("  SetupWizardState: ").Append(SetupWizardState).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusInfo: ").Append(StatusInfo).Append("\n");
            
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
            return this.Equals(obj as AccountInfo);
        }

        /// <summary>
        /// Returns true if AccountInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountInfo other)
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
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.MainNumber == other.MainNumber ||
                    this.MainNumber != null &&
                    this.MainNumber.Equals(other.MainNumber)
                ) && 
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) && 
                (
                    this.PartnerId == other.PartnerId ||
                    this.PartnerId != null &&
                    this.PartnerId.Equals(other.PartnerId)
                ) && 
                (
                    this.ServiceInfo == other.ServiceInfo ||
                    this.ServiceInfo != null &&
                    this.ServiceInfo.Equals(other.ServiceInfo)
                ) && 
                (
                    this.SetupWizardState == other.SetupWizardState ||
                    this.SetupWizardState != null &&
                    this.SetupWizardState.Equals(other.SetupWizardState)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusInfo == other.StatusInfo ||
                    this.StatusInfo != null &&
                    this.StatusInfo.Equals(other.StatusInfo)
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
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                if (this.MainNumber != null)
                    hash = hash * 59 + this.MainNumber.GetHashCode();
                
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                
                if (this.PartnerId != null)
                    hash = hash * 59 + this.PartnerId.GetHashCode();
                
                if (this.ServiceInfo != null)
                    hash = hash * 59 + this.ServiceInfo.GetHashCode();
                
                if (this.SetupWizardState != null)
                    hash = hash * 59 + this.SetupWizardState.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.StatusInfo != null)
                    hash = hash * 59 + this.StatusInfo.GetHashCode();
                
                return hash;
            }
        }

    }
}
