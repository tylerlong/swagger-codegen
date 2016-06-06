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
    public partial class ShippingInfo :  IEquatable<ShippingInfo>
    { 
    
        /// <summary>
        /// Shipping status of the order item. It is set to 'Initial' when the order is submitted. Then it is changed to 'Accepted' when a distributor starts processing the order. Finally it is changed to Shipped which means that distributor has shipped the device.
        /// </summary>
        /// <value>Shipping status of the order item. It is set to 'Initial' when the order is submitted. Then it is changed to 'Accepted' when a distributor starts processing the order. Finally it is changed to Shipped which means that distributor has shipped the device.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "Initial")]
            Initial,
            
            [EnumMember(Value = "Accepted")]
            Accepted,
            
            [EnumMember(Value = "Shipped")]
            Shipped
        }

    
        /// <summary>
        /// Shipping status of the order item. It is set to 'Initial' when the order is submitted. Then it is changed to 'Accepted' when a distributor starts processing the order. Finally it is changed to Shipped which means that distributor has shipped the device.
        /// </summary>
        /// <value>Shipping status of the order item. It is set to 'Initial' when the order is submitted. Then it is changed to 'Accepted' when a distributor starts processing the order. Finally it is changed to Shipped which means that distributor has shipped the device.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingInfo" /> class.
        /// Initializes a new instance of the <see cref="ShippingInfo" />class.
        /// </summary>
        /// <param name="Status">Shipping status of the order item. It is set to &#39;Initial&#39; when the order is submitted. Then it is changed to &#39;Accepted&#39; when a distributor starts processing the order. Finally it is changed to Shipped which means that distributor has shipped the device..</param>
        /// <param name="Carrier">Shipping carrier name. Appears only if the device status is \&quot;Shipped\&quot;.</param>
        /// <param name="TrackingNumber">Carrier-specific tracking number. Appears only if the device status is \&quot;Shipped\&quot;.</param>
        /// <param name="Method">Shipping method information.</param>
        /// <param name="Address">Shipping address for the order. If it coincides with the Emergency Service Address, then can be omitted. By default the same value as the emergencyServiceAddress. Multiple addresses can be specified; in case an order contains several devices, they can be delivered to different addresses.</param>

        public ShippingInfo(StatusEnum? Status = null, string Carrier = null, string TrackingNumber = null, List<ShippingMethod> Method = null, List<ShippingAddress> Address = null)
        {
            this.Status = Status;
            this.Carrier = Carrier;
            this.TrackingNumber = TrackingNumber;
            this.Method = Method;
            this.Address = Address;
            
        }
        
    
        /// <summary>
        /// Shipping carrier name. Appears only if the device status is \&quot;Shipped\&quot;
        /// </summary>
        /// <value>Shipping carrier name. Appears only if the device status is \&quot;Shipped\&quot;</value>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }
    
        /// <summary>
        /// Carrier-specific tracking number. Appears only if the device status is \&quot;Shipped\&quot;
        /// </summary>
        /// <value>Carrier-specific tracking number. Appears only if the device status is \&quot;Shipped\&quot;</value>
        [DataMember(Name="trackingNumber", EmitDefaultValue=false)]
        public string TrackingNumber { get; set; }
    
        /// <summary>
        /// Shipping method information
        /// </summary>
        /// <value>Shipping method information</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public List<ShippingMethod> Method { get; set; }
    
        /// <summary>
        /// Shipping address for the order. If it coincides with the Emergency Service Address, then can be omitted. By default the same value as the emergencyServiceAddress. Multiple addresses can be specified; in case an order contains several devices, they can be delivered to different addresses
        /// </summary>
        /// <value>Shipping address for the order. If it coincides with the Emergency Service Address, then can be omitted. By default the same value as the emergencyServiceAddress. Multiple addresses can be specified; in case an order contains several devices, they can be delivered to different addresses</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public List<ShippingAddress> Address { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingInfo {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            
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
            return this.Equals(obj as ShippingInfo);
        }

        /// <summary>
        /// Returns true if ShippingInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ShippingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Carrier == other.Carrier ||
                    this.Carrier != null &&
                    this.Carrier.Equals(other.Carrier)
                ) && 
                (
                    this.TrackingNumber == other.TrackingNumber ||
                    this.TrackingNumber != null &&
                    this.TrackingNumber.Equals(other.TrackingNumber)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.SequenceEqual(other.Method)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.SequenceEqual(other.Address)
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
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.Carrier != null)
                    hash = hash * 59 + this.Carrier.GetHashCode();
                
                if (this.TrackingNumber != null)
                    hash = hash * 59 + this.TrackingNumber.GetHashCode();
                
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                
                return hash;
            }
        }

    }
}
