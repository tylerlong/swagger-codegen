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
    public partial class GroupInfo :  IEquatable<GroupInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupInfo" /> class.
        /// Initializes a new instance of the <see cref="GroupInfo" />class.
        /// </summary>
        /// <param name="Id">Internal identifier of a group.</param>
        /// <param name="Uri">Canonical URI of a group.</param>
        /// <param name="ContactsCount">Amount of contacts in a group.</param>
        /// <param name="GroupName">Name of a group.</param>
        /// <param name="Notes">Notes for a group.</param>

        public GroupInfo(string Id = null, string Uri = null, int? ContactsCount = null, string GroupName = null, string Notes = null)
        {
            this.Id = Id;
            this.Uri = Uri;
            this.ContactsCount = ContactsCount;
            this.GroupName = GroupName;
            this.Notes = Notes;
            
        }
        
    
        /// <summary>
        /// Internal identifier of a group
        /// </summary>
        /// <value>Internal identifier of a group</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Canonical URI of a group
        /// </summary>
        /// <value>Canonical URI of a group</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Amount of contacts in a group
        /// </summary>
        /// <value>Amount of contacts in a group</value>
        [DataMember(Name="contactsCount", EmitDefaultValue=false)]
        public int? ContactsCount { get; set; }
    
        /// <summary>
        /// Name of a group
        /// </summary>
        /// <value>Name of a group</value>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }
    
        /// <summary>
        /// Notes for a group
        /// </summary>
        /// <value>Notes for a group</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  ContactsCount: ").Append(ContactsCount).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
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
            return this.Equals(obj as GroupInfo);
        }

        /// <summary>
        /// Returns true if GroupInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupInfo other)
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
                    this.ContactsCount == other.ContactsCount ||
                    this.ContactsCount != null &&
                    this.ContactsCount.Equals(other.ContactsCount)
                ) && 
                (
                    this.GroupName == other.GroupName ||
                    this.GroupName != null &&
                    this.GroupName.Equals(other.GroupName)
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
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                if (this.ContactsCount != null)
                    hash = hash * 59 + this.ContactsCount.GetHashCode();
                
                if (this.GroupName != null)
                    hash = hash * 59 + this.GroupName.GetHashCode();
                
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                
                return hash;
            }
        }

    }
}
