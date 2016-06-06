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
    public partial class InlineResponseDefault :  IEquatable<InlineResponseDefault>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponseDefault" /> class.
        /// Initializes a new instance of the <see cref="InlineResponseDefault" />class.
        /// </summary>
        /// <param name="State">This parameter will be included in response if it was specified in the client authorization request. The value will be copied from the one received from the client.</param>
        /// <param name="ExpiresIn">The remaining lifetime of the authorization code.</param>
        /// <param name="Code">The authorization code returned for your application.</param>

        public InlineResponseDefault(string State = null, int? ExpiresIn = null, string Code = null)
        {
            this.State = State;
            this.ExpiresIn = ExpiresIn;
            this.Code = Code;
            
        }
        
    
        /// <summary>
        /// This parameter will be included in response if it was specified in the client authorization request. The value will be copied from the one received from the client
        /// </summary>
        /// <value>This parameter will be included in response if it was specified in the client authorization request. The value will be copied from the one received from the client</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// The remaining lifetime of the authorization code
        /// </summary>
        /// <value>The remaining lifetime of the authorization code</value>
        [DataMember(Name="expires_in", EmitDefaultValue=false)]
        public int? ExpiresIn { get; set; }
    
        /// <summary>
        /// The authorization code returned for your application
        /// </summary>
        /// <value>The authorization code returned for your application</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefault {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            
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
            return this.Equals(obj as InlineResponseDefault);
        }

        /// <summary>
        /// Returns true if InlineResponseDefault instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefault to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefault other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.ExpiresIn == other.ExpiresIn ||
                    this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(other.ExpiresIn)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
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
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.ExpiresIn != null)
                    hash = hash * 59 + this.ExpiresIn.GetHashCode();
                
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                
                return hash;
            }
        }

    }
}
