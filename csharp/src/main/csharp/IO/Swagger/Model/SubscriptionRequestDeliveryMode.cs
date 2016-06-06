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
    public partial class SubscriptionRequestDeliveryMode :  IEquatable<SubscriptionRequestDeliveryMode>
    { 
    
        /// <summary>
        /// Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)
        /// </summary>
        /// <value>Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransportTypeEnum {
            
            [EnumMember(Value = "PubNub")]
            Pubnub,
            
            [EnumMember(Value = "APNS")]
            Apns,
            
            [EnumMember(Value = "PubNub/APNS/VoIP")]
            Pubnubapnsvoip
        }

    
        /// <summary>
        /// Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)
        /// </summary>
        /// <value>Notifications transportation provider name. 'APNS' (Apple Push Notifications Service)</value>
        [DataMember(Name="transportType", EmitDefaultValue=false)]
        public TransportTypeEnum? TransportType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionRequestDeliveryMode" /> class.
        /// Initializes a new instance of the <see cref="SubscriptionRequestDeliveryMode" />class.
        /// </summary>
        /// <param name="TransportType">Notifications transportation provider name. &#39;APNS&#39; (Apple Push Notifications Service).</param>
        /// <param name="Encryption">Optional parameter. Specifies if the message will be encrypted or not. If request contains any presence event filter the value by default is &#39;True&#39; (even if specified as &#39;false&#39;). If request contains only message event filters the value by default is &#39;False&#39;.</param>

        public SubscriptionRequestDeliveryMode(TransportTypeEnum? TransportType = null, bool? Encryption = null)
        {
            this.TransportType = TransportType;
            this.Encryption = Encryption;
            
        }
        
    
        /// <summary>
        /// Optional parameter. Specifies if the message will be encrypted or not. If request contains any presence event filter the value by default is &#39;True&#39; (even if specified as &#39;false&#39;). If request contains only message event filters the value by default is &#39;False&#39;
        /// </summary>
        /// <value>Optional parameter. Specifies if the message will be encrypted or not. If request contains any presence event filter the value by default is &#39;True&#39; (even if specified as &#39;false&#39;). If request contains only message event filters the value by default is &#39;False&#39;</value>
        [DataMember(Name="encryption", EmitDefaultValue=false)]
        public bool? Encryption { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionRequestDeliveryMode {\n");
            sb.Append("  TransportType: ").Append(TransportType).Append("\n");
            sb.Append("  Encryption: ").Append(Encryption).Append("\n");
            
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
            return this.Equals(obj as SubscriptionRequestDeliveryMode);
        }

        /// <summary>
        /// Returns true if SubscriptionRequestDeliveryMode instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionRequestDeliveryMode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionRequestDeliveryMode other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransportType == other.TransportType ||
                    this.TransportType != null &&
                    this.TransportType.Equals(other.TransportType)
                ) && 
                (
                    this.Encryption == other.Encryption ||
                    this.Encryption != null &&
                    this.Encryption.Equals(other.Encryption)
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
                
                if (this.TransportType != null)
                    hash = hash * 59 + this.TransportType.GetHashCode();
                
                if (this.Encryption != null)
                    hash = hash * 59 + this.Encryption.GetHashCode();
                
                return hash;
            }
        }

    }
}
