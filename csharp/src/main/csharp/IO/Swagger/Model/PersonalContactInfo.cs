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
    public partial class PersonalContactInfo :  IEquatable<PersonalContactInfo>
    { 
    
        /// <summary>
        /// This property has a special meaning only on Address Book Sync (e.g. a contact can be 'Deleted'). For simple contact list reading it has always the default value - 'Alive'
        /// </summary>
        /// <value>This property has a special meaning only on Address Book Sync (e.g. a contact can be 'Deleted'). For simple contact list reading it has always the default value - 'Alive'</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailabilityEnum {
            
            [EnumMember(Value = "Alive")]
            Alive,
            
            [EnumMember(Value = "Deleted")]
            Deleted,
            
            [EnumMember(Value = "Purged")]
            Purged
        }

    
        /// <summary>
        /// This property has a special meaning only on Address Book Sync (e.g. a contact can be 'Deleted'). For simple contact list reading it has always the default value - 'Alive'
        /// </summary>
        /// <value>This property has a special meaning only on Address Book Sync (e.g. a contact can be 'Deleted'). For simple contact list reading it has always the default value - 'Alive'</value>
        [DataMember(Name="availability", EmitDefaultValue=false)]
        public AvailabilityEnum? Availability { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalContactInfo" /> class.
        /// Initializes a new instance of the <see cref="PersonalContactInfo" />class.
        /// </summary>
        /// <param name="Id">Standard resource properties ID.</param>
        /// <param name="Url">Canonical URI.</param>
        /// <param name="Availability">This property has a special meaning only on Address Book Sync (e.g. a contact can be &#39;Deleted&#39;). For simple contact list reading it has always the default value - &#39;Alive&#39;.</param>
        /// <param name="FirstName">First name of a personal contact.</param>
        /// <param name="LastName">Last name of a personal contact.</param>
        /// <param name="MiddleName">Middle name of a personal contact.</param>
        /// <param name="NickName">Nick name of a personal contact.</param>
        /// <param name="Company">Company name of a personal contact.</param>
        /// <param name="JobTitle">Job title of a personal contact.</param>
        /// <param name="HomePhone">Home phone of a personal contact.</param>
        /// <param name="HomePhone2">The 2-d home phone of a personal contact.</param>
        /// <param name="BusinessPhone">Business phone of a personal contact.</param>
        /// <param name="BusinessPhone2">The 2-d business phone of a personal contact.</param>
        /// <param name="MobilePhone">Mobile phone of a personal contact.</param>
        /// <param name="BusinessFax">Business fax of a personal contact.</param>
        /// <param name="CompanyPhone">Company phone of a personal contact.</param>
        /// <param name="AssistantPhone">Assistant phone of a personal contact.</param>
        /// <param name="CarPhone">Car phone of a personal contact.</param>
        /// <param name="OtherPhone">Other phone of a personal contact.</param>
        /// <param name="OtherFax">Other fax of a personal contact.</param>
        /// <param name="CallbackPhone">Callback phone of a personal contact.</param>
        /// <param name="Email">Email of a personal contact.</param>
        /// <param name="Email2">The 2-d email of a personal contact.</param>
        /// <param name="Email3">The 3-d email of a personal contact.</param>
        /// <param name="HomeAddress">HomeAddress.</param>
        /// <param name="BusinessAddress">BusinessAddress.</param>
        /// <param name="OtherAddress">OtherAddress.</param>
        /// <param name="Birthday">Date of birth of a personal contact in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z.</param>
        /// <param name="WebPage">Web page of a personal contact.</param>
        /// <param name="Notes">Notes of a personal contact.</param>

        public PersonalContactInfo(int? Id = null, string Url = null, AvailabilityEnum? Availability = null, string FirstName = null, string LastName = null, string MiddleName = null, string NickName = null, string Company = null, string JobTitle = null, string HomePhone = null, string HomePhone2 = null, string BusinessPhone = null, string BusinessPhone2 = null, string MobilePhone = null, string BusinessFax = null, string CompanyPhone = null, string AssistantPhone = null, string CarPhone = null, string OtherPhone = null, string OtherFax = null, string CallbackPhone = null, string Email = null, string Email2 = null, string Email3 = null, ContactAddressInfo HomeAddress = null, ContactAddressInfo BusinessAddress = null, ContactAddressInfo OtherAddress = null, DateTime? Birthday = null, string WebPage = null, string Notes = null)
        {
            this.Id = Id;
            this.Url = Url;
            this.Availability = Availability;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MiddleName = MiddleName;
            this.NickName = NickName;
            this.Company = Company;
            this.JobTitle = JobTitle;
            this.HomePhone = HomePhone;
            this.HomePhone2 = HomePhone2;
            this.BusinessPhone = BusinessPhone;
            this.BusinessPhone2 = BusinessPhone2;
            this.MobilePhone = MobilePhone;
            this.BusinessFax = BusinessFax;
            this.CompanyPhone = CompanyPhone;
            this.AssistantPhone = AssistantPhone;
            this.CarPhone = CarPhone;
            this.OtherPhone = OtherPhone;
            this.OtherFax = OtherFax;
            this.CallbackPhone = CallbackPhone;
            this.Email = Email;
            this.Email2 = Email2;
            this.Email3 = Email3;
            this.HomeAddress = HomeAddress;
            this.BusinessAddress = BusinessAddress;
            this.OtherAddress = OtherAddress;
            this.Birthday = Birthday;
            this.WebPage = WebPage;
            this.Notes = Notes;
            
        }
        
    
        /// <summary>
        /// Standard resource properties ID
        /// </summary>
        /// <value>Standard resource properties ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
    
        /// <summary>
        /// Canonical URI
        /// </summary>
        /// <value>Canonical URI</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
    
        /// <summary>
        /// First name of a personal contact
        /// </summary>
        /// <value>First name of a personal contact</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
    
        /// <summary>
        /// Last name of a personal contact
        /// </summary>
        /// <value>Last name of a personal contact</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
    
        /// <summary>
        /// Middle name of a personal contact
        /// </summary>
        /// <value>Middle name of a personal contact</value>
        [DataMember(Name="middleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }
    
        /// <summary>
        /// Nick name of a personal contact
        /// </summary>
        /// <value>Nick name of a personal contact</value>
        [DataMember(Name="nickName", EmitDefaultValue=false)]
        public string NickName { get; set; }
    
        /// <summary>
        /// Company name of a personal contact
        /// </summary>
        /// <value>Company name of a personal contact</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }
    
        /// <summary>
        /// Job title of a personal contact
        /// </summary>
        /// <value>Job title of a personal contact</value>
        [DataMember(Name="jobTitle", EmitDefaultValue=false)]
        public string JobTitle { get; set; }
    
        /// <summary>
        /// Home phone of a personal contact
        /// </summary>
        /// <value>Home phone of a personal contact</value>
        [DataMember(Name="homePhone", EmitDefaultValue=false)]
        public string HomePhone { get; set; }
    
        /// <summary>
        /// The 2-d home phone of a personal contact
        /// </summary>
        /// <value>The 2-d home phone of a personal contact</value>
        [DataMember(Name="homePhone2", EmitDefaultValue=false)]
        public string HomePhone2 { get; set; }
    
        /// <summary>
        /// Business phone of a personal contact
        /// </summary>
        /// <value>Business phone of a personal contact</value>
        [DataMember(Name="businessPhone", EmitDefaultValue=false)]
        public string BusinessPhone { get; set; }
    
        /// <summary>
        /// The 2-d business phone of a personal contact
        /// </summary>
        /// <value>The 2-d business phone of a personal contact</value>
        [DataMember(Name="businessPhone2", EmitDefaultValue=false)]
        public string BusinessPhone2 { get; set; }
    
        /// <summary>
        /// Mobile phone of a personal contact
        /// </summary>
        /// <value>Mobile phone of a personal contact</value>
        [DataMember(Name="mobilePhone", EmitDefaultValue=false)]
        public string MobilePhone { get; set; }
    
        /// <summary>
        /// Business fax of a personal contact
        /// </summary>
        /// <value>Business fax of a personal contact</value>
        [DataMember(Name="businessFax", EmitDefaultValue=false)]
        public string BusinessFax { get; set; }
    
        /// <summary>
        /// Company phone of a personal contact
        /// </summary>
        /// <value>Company phone of a personal contact</value>
        [DataMember(Name="companyPhone", EmitDefaultValue=false)]
        public string CompanyPhone { get; set; }
    
        /// <summary>
        /// Assistant phone of a personal contact
        /// </summary>
        /// <value>Assistant phone of a personal contact</value>
        [DataMember(Name="assistantPhone", EmitDefaultValue=false)]
        public string AssistantPhone { get; set; }
    
        /// <summary>
        /// Car phone of a personal contact
        /// </summary>
        /// <value>Car phone of a personal contact</value>
        [DataMember(Name="carPhone", EmitDefaultValue=false)]
        public string CarPhone { get; set; }
    
        /// <summary>
        /// Other phone of a personal contact
        /// </summary>
        /// <value>Other phone of a personal contact</value>
        [DataMember(Name="otherPhone", EmitDefaultValue=false)]
        public string OtherPhone { get; set; }
    
        /// <summary>
        /// Other fax of a personal contact
        /// </summary>
        /// <value>Other fax of a personal contact</value>
        [DataMember(Name="otherFax", EmitDefaultValue=false)]
        public string OtherFax { get; set; }
    
        /// <summary>
        /// Callback phone of a personal contact
        /// </summary>
        /// <value>Callback phone of a personal contact</value>
        [DataMember(Name="callbackPhone", EmitDefaultValue=false)]
        public string CallbackPhone { get; set; }
    
        /// <summary>
        /// Email of a personal contact
        /// </summary>
        /// <value>Email of a personal contact</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// The 2-d email of a personal contact
        /// </summary>
        /// <value>The 2-d email of a personal contact</value>
        [DataMember(Name="email2", EmitDefaultValue=false)]
        public string Email2 { get; set; }
    
        /// <summary>
        /// The 3-d email of a personal contact
        /// </summary>
        /// <value>The 3-d email of a personal contact</value>
        [DataMember(Name="email3", EmitDefaultValue=false)]
        public string Email3 { get; set; }
    
        /// <summary>
        /// Gets or Sets HomeAddress
        /// </summary>
        [DataMember(Name="homeAddress", EmitDefaultValue=false)]
        public ContactAddressInfo HomeAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets BusinessAddress
        /// </summary>
        [DataMember(Name="businessAddress", EmitDefaultValue=false)]
        public ContactAddressInfo BusinessAddress { get; set; }
    
        /// <summary>
        /// Gets or Sets OtherAddress
        /// </summary>
        [DataMember(Name="otherAddress", EmitDefaultValue=false)]
        public ContactAddressInfo OtherAddress { get; set; }
    
        /// <summary>
        /// Date of birth of a personal contact in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z
        /// </summary>
        /// <value>Date of birth of a personal contact in ISO 8601 format including timezone, for example 2016-03-10T18:07:52.534Z</value>
        [DataMember(Name="birthday", EmitDefaultValue=false)]
        public DateTime? Birthday { get; set; }
    
        /// <summary>
        /// Web page of a personal contact
        /// </summary>
        /// <value>Web page of a personal contact</value>
        [DataMember(Name="webPage", EmitDefaultValue=false)]
        public string WebPage { get; set; }
    
        /// <summary>
        /// Notes of a personal contact
        /// </summary>
        /// <value>Notes of a personal contact</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalContactInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  HomePhone: ").Append(HomePhone).Append("\n");
            sb.Append("  HomePhone2: ").Append(HomePhone2).Append("\n");
            sb.Append("  BusinessPhone: ").Append(BusinessPhone).Append("\n");
            sb.Append("  BusinessPhone2: ").Append(BusinessPhone2).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  BusinessFax: ").Append(BusinessFax).Append("\n");
            sb.Append("  CompanyPhone: ").Append(CompanyPhone).Append("\n");
            sb.Append("  AssistantPhone: ").Append(AssistantPhone).Append("\n");
            sb.Append("  CarPhone: ").Append(CarPhone).Append("\n");
            sb.Append("  OtherPhone: ").Append(OtherPhone).Append("\n");
            sb.Append("  OtherFax: ").Append(OtherFax).Append("\n");
            sb.Append("  CallbackPhone: ").Append(CallbackPhone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Email2: ").Append(Email2).Append("\n");
            sb.Append("  Email3: ").Append(Email3).Append("\n");
            sb.Append("  HomeAddress: ").Append(HomeAddress).Append("\n");
            sb.Append("  BusinessAddress: ").Append(BusinessAddress).Append("\n");
            sb.Append("  OtherAddress: ").Append(OtherAddress).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  WebPage: ").Append(WebPage).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            
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
            return this.Equals(obj as PersonalContactInfo);
        }

        /// <summary>
        /// Returns true if PersonalContactInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of PersonalContactInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalContactInfo other)
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
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Availability == other.Availability ||
                    this.Availability != null &&
                    this.Availability.Equals(other.Availability)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.MiddleName == other.MiddleName ||
                    this.MiddleName != null &&
                    this.MiddleName.Equals(other.MiddleName)
                ) && 
                (
                    this.NickName == other.NickName ||
                    this.NickName != null &&
                    this.NickName.Equals(other.NickName)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.JobTitle == other.JobTitle ||
                    this.JobTitle != null &&
                    this.JobTitle.Equals(other.JobTitle)
                ) && 
                (
                    this.HomePhone == other.HomePhone ||
                    this.HomePhone != null &&
                    this.HomePhone.Equals(other.HomePhone)
                ) && 
                (
                    this.HomePhone2 == other.HomePhone2 ||
                    this.HomePhone2 != null &&
                    this.HomePhone2.Equals(other.HomePhone2)
                ) && 
                (
                    this.BusinessPhone == other.BusinessPhone ||
                    this.BusinessPhone != null &&
                    this.BusinessPhone.Equals(other.BusinessPhone)
                ) && 
                (
                    this.BusinessPhone2 == other.BusinessPhone2 ||
                    this.BusinessPhone2 != null &&
                    this.BusinessPhone2.Equals(other.BusinessPhone2)
                ) && 
                (
                    this.MobilePhone == other.MobilePhone ||
                    this.MobilePhone != null &&
                    this.MobilePhone.Equals(other.MobilePhone)
                ) && 
                (
                    this.BusinessFax == other.BusinessFax ||
                    this.BusinessFax != null &&
                    this.BusinessFax.Equals(other.BusinessFax)
                ) && 
                (
                    this.CompanyPhone == other.CompanyPhone ||
                    this.CompanyPhone != null &&
                    this.CompanyPhone.Equals(other.CompanyPhone)
                ) && 
                (
                    this.AssistantPhone == other.AssistantPhone ||
                    this.AssistantPhone != null &&
                    this.AssistantPhone.Equals(other.AssistantPhone)
                ) && 
                (
                    this.CarPhone == other.CarPhone ||
                    this.CarPhone != null &&
                    this.CarPhone.Equals(other.CarPhone)
                ) && 
                (
                    this.OtherPhone == other.OtherPhone ||
                    this.OtherPhone != null &&
                    this.OtherPhone.Equals(other.OtherPhone)
                ) && 
                (
                    this.OtherFax == other.OtherFax ||
                    this.OtherFax != null &&
                    this.OtherFax.Equals(other.OtherFax)
                ) && 
                (
                    this.CallbackPhone == other.CallbackPhone ||
                    this.CallbackPhone != null &&
                    this.CallbackPhone.Equals(other.CallbackPhone)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Email2 == other.Email2 ||
                    this.Email2 != null &&
                    this.Email2.Equals(other.Email2)
                ) && 
                (
                    this.Email3 == other.Email3 ||
                    this.Email3 != null &&
                    this.Email3.Equals(other.Email3)
                ) && 
                (
                    this.HomeAddress == other.HomeAddress ||
                    this.HomeAddress != null &&
                    this.HomeAddress.Equals(other.HomeAddress)
                ) && 
                (
                    this.BusinessAddress == other.BusinessAddress ||
                    this.BusinessAddress != null &&
                    this.BusinessAddress.Equals(other.BusinessAddress)
                ) && 
                (
                    this.OtherAddress == other.OtherAddress ||
                    this.OtherAddress != null &&
                    this.OtherAddress.Equals(other.OtherAddress)
                ) && 
                (
                    this.Birthday == other.Birthday ||
                    this.Birthday != null &&
                    this.Birthday.Equals(other.Birthday)
                ) && 
                (
                    this.WebPage == other.WebPage ||
                    this.WebPage != null &&
                    this.WebPage.Equals(other.WebPage)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
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
                
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                
                if (this.Availability != null)
                    hash = hash * 59 + this.Availability.GetHashCode();
                
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                
                if (this.MiddleName != null)
                    hash = hash * 59 + this.MiddleName.GetHashCode();
                
                if (this.NickName != null)
                    hash = hash * 59 + this.NickName.GetHashCode();
                
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                
                if (this.JobTitle != null)
                    hash = hash * 59 + this.JobTitle.GetHashCode();
                
                if (this.HomePhone != null)
                    hash = hash * 59 + this.HomePhone.GetHashCode();
                
                if (this.HomePhone2 != null)
                    hash = hash * 59 + this.HomePhone2.GetHashCode();
                
                if (this.BusinessPhone != null)
                    hash = hash * 59 + this.BusinessPhone.GetHashCode();
                
                if (this.BusinessPhone2 != null)
                    hash = hash * 59 + this.BusinessPhone2.GetHashCode();
                
                if (this.MobilePhone != null)
                    hash = hash * 59 + this.MobilePhone.GetHashCode();
                
                if (this.BusinessFax != null)
                    hash = hash * 59 + this.BusinessFax.GetHashCode();
                
                if (this.CompanyPhone != null)
                    hash = hash * 59 + this.CompanyPhone.GetHashCode();
                
                if (this.AssistantPhone != null)
                    hash = hash * 59 + this.AssistantPhone.GetHashCode();
                
                if (this.CarPhone != null)
                    hash = hash * 59 + this.CarPhone.GetHashCode();
                
                if (this.OtherPhone != null)
                    hash = hash * 59 + this.OtherPhone.GetHashCode();
                
                if (this.OtherFax != null)
                    hash = hash * 59 + this.OtherFax.GetHashCode();
                
                if (this.CallbackPhone != null)
                    hash = hash * 59 + this.CallbackPhone.GetHashCode();
                
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                
                if (this.Email2 != null)
                    hash = hash * 59 + this.Email2.GetHashCode();
                
                if (this.Email3 != null)
                    hash = hash * 59 + this.Email3.GetHashCode();
                
                if (this.HomeAddress != null)
                    hash = hash * 59 + this.HomeAddress.GetHashCode();
                
                if (this.BusinessAddress != null)
                    hash = hash * 59 + this.BusinessAddress.GetHashCode();
                
                if (this.OtherAddress != null)
                    hash = hash * 59 + this.OtherAddress.GetHashCode();
                
                if (this.Birthday != null)
                    hash = hash * 59 + this.Birthday.GetHashCode();
                
                if (this.WebPage != null)
                    hash = hash * 59 + this.WebPage.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                return hash;
            }
        }

    }
}
