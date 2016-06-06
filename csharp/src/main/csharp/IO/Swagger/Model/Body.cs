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
    public partial class Body :  IEquatable<Body>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Body" /> class.
        /// Initializes a new instance of the <see cref="Body" />class.
        /// </summary>
        /// <param name="ResponseType">Must be set to code.</param>
        /// <param name="ClientId">Required. Enter your application key (Production or Sandbox) here.</param>
        /// <param name="RedirectUri">Required. This is a callback URI which determines where the response will be sent to. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration. This URI can be HTTP/HTTPS address for web applications or custom scheme URI for mobile or desktop applications..</param>
        /// <param name="State">Optional, recommended. An opaque value used by the client to maintain state between the request and callback. The authorization server includes this value when redirecting the user-agent back to the client. The parameter should be used for preventing cross-site request forgery.</param>

        public Body(string ResponseType = null, string ClientId = null, string RedirectUri = null, string State = null)
        {
            this.ResponseType = ResponseType;
            this.ClientId = ClientId;
            this.RedirectUri = RedirectUri;
            this.State = State;
            
        }
        
    
        /// <summary>
        /// Must be set to code
        /// </summary>
        /// <value>Must be set to code</value>
        [DataMember(Name="response_type", EmitDefaultValue=false)]
        public string ResponseType { get; set; }
    
        /// <summary>
        /// Required. Enter your application key (Production or Sandbox) here
        /// </summary>
        /// <value>Required. Enter your application key (Production or Sandbox) here</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }
    
        /// <summary>
        /// Required. This is a callback URI which determines where the response will be sent to. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration. This URI can be HTTP/HTTPS address for web applications or custom scheme URI for mobile or desktop applications.
        /// </summary>
        /// <value>Required. This is a callback URI which determines where the response will be sent to. The value of this parameter must exactly match one of the URIs you have provided for your app upon registration. This URI can be HTTP/HTTPS address for web applications or custom scheme URI for mobile or desktop applications.</value>
        [DataMember(Name="redirect_uri", EmitDefaultValue=false)]
        public string RedirectUri { get; set; }
    
        /// <summary>
        /// Optional, recommended. An opaque value used by the client to maintain state between the request and callback. The authorization server includes this value when redirecting the user-agent back to the client. The parameter should be used for preventing cross-site request forgery
        /// </summary>
        /// <value>Optional, recommended. An opaque value used by the client to maintain state between the request and callback. The authorization server includes this value when redirecting the user-agent back to the client. The parameter should be used for preventing cross-site request forgery</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body {\n");
            sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            
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
            return this.Equals(obj as Body);
        }

        /// <summary>
        /// Returns true if Body instances are equal
        /// </summary>
        /// <param name="other">Instance of Body to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ResponseType == other.ResponseType ||
                    this.ResponseType != null &&
                    this.ResponseType.Equals(other.ResponseType)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.RedirectUri == other.RedirectUri ||
                    this.RedirectUri != null &&
                    this.RedirectUri.Equals(other.RedirectUri)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                
                if (this.ResponseType != null)
                    hash = hash * 59 + this.ResponseType.GetHashCode();
                
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                
                if (this.RedirectUri != null)
                    hash = hash * 59 + this.RedirectUri.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                return hash;
            }
        }

    }
}
