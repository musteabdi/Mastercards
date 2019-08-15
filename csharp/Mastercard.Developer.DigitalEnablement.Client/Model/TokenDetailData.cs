/* 
 * MDES for Merchants
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously.  
 *
 * The version of the OpenAPI document: 1.2.7
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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
using OpenAPIDateConverter = Mastercard.Developer.DigitalEnablement.Client.Client.OpenAPIDateConverter;

namespace Mastercard.Developer.DigitalEnablement.Client.Model
{
    /// <summary>
    /// TokenDetailData
    /// </summary>
    [DataContract]
    public partial class TokenDetailData :  IEquatable<TokenDetailData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenDetailData" /> class.
        /// </summary>
        /// <param name="tokenNumber">Globally unique identifier for the Token, as assigned by MDES.     __Max Length:64__ .</param>
        /// <param name="expiryMonth">The expiry month for the account. .</param>
        /// <param name="expiryYear">The expiry year for the account. .</param>
        /// <param name="dataValidUntilTimestamp">\&quot;The date/time after which this CardInfoData object is considered invalid. If present, all systems must reject this CardInfoData object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following: YYYY-MM-DDThh:mm:ss[.sss]Z YYYY-MM-DDThh:mm:ss[.sss]�hh:mm Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. MasterCard recommends using a value of (Current Time + 30 minutes).\&quot; .</param>
        /// <param name="paymentAccountReference">\&quot;The unique account reference assigned to the PAN. Conditionally returned if the Token Requestor has opted to receive PAR and providing PAR is assigned by Mastercard or the Issuer provides PAR in the authorization message response.    __Max Length:__ - 29\&quot; .</param>
        public TokenDetailData(string tokenNumber = default(string), string expiryMonth = default(string), string expiryYear = default(string), string dataValidUntilTimestamp = default(string), string paymentAccountReference = default(string))
        {
            this.TokenNumber = tokenNumber;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            this.DataValidUntilTimestamp = dataValidUntilTimestamp;
            this.PaymentAccountReference = paymentAccountReference;
        }
        
        /// <summary>
        /// Globally unique identifier for the Token, as assigned by MDES.     __Max Length:64__ 
        /// </summary>
        /// <value>Globally unique identifier for the Token, as assigned by MDES.     __Max Length:64__ </value>
        [DataMember(Name="tokenNumber", EmitDefaultValue=false)]
        public string TokenNumber { get; set; }

        /// <summary>
        /// The expiry month for the account. 
        /// </summary>
        /// <value>The expiry month for the account. </value>
        [DataMember(Name="expiryMonth", EmitDefaultValue=false)]
        public string ExpiryMonth { get; set; }

        /// <summary>
        /// The expiry year for the account. 
        /// </summary>
        /// <value>The expiry year for the account. </value>
        [DataMember(Name="expiryYear", EmitDefaultValue=false)]
        public string ExpiryYear { get; set; }

        /// <summary>
        /// \&quot;The date/time after which this CardInfoData object is considered invalid. If present, all systems must reject this CardInfoData object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following: YYYY-MM-DDThh:mm:ss[.sss]Z YYYY-MM-DDThh:mm:ss[.sss]�hh:mm Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. MasterCard recommends using a value of (Current Time + 30 minutes).\&quot; 
        /// </summary>
        /// <value>\&quot;The date/time after which this CardInfoData object is considered invalid. If present, all systems must reject this CardInfoData object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following: YYYY-MM-DDThh:mm:ss[.sss]Z YYYY-MM-DDThh:mm:ss[.sss]�hh:mm Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. MasterCard recommends using a value of (Current Time + 30 minutes).\&quot; </value>
        [DataMember(Name="dataValidUntilTimestamp", EmitDefaultValue=false)]
        public string DataValidUntilTimestamp { get; set; }

        /// <summary>
        /// \&quot;The unique account reference assigned to the PAN. Conditionally returned if the Token Requestor has opted to receive PAR and providing PAR is assigned by Mastercard or the Issuer provides PAR in the authorization message response.    __Max Length:__ - 29\&quot; 
        /// </summary>
        /// <value>\&quot;The unique account reference assigned to the PAN. Conditionally returned if the Token Requestor has opted to receive PAR and providing PAR is assigned by Mastercard or the Issuer provides PAR in the authorization message response.    __Max Length:__ - 29\&quot; </value>
        [DataMember(Name="paymentAccountReference", EmitDefaultValue=false)]
        public string PaymentAccountReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenDetailData {\n");
            sb.Append("  TokenNumber: ").Append(TokenNumber).Append("\n");
            sb.Append("  ExpiryMonth: ").Append(ExpiryMonth).Append("\n");
            sb.Append("  ExpiryYear: ").Append(ExpiryYear).Append("\n");
            sb.Append("  DataValidUntilTimestamp: ").Append(DataValidUntilTimestamp).Append("\n");
            sb.Append("  PaymentAccountReference: ").Append(PaymentAccountReference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TokenDetailData);
        }

        /// <summary>
        /// Returns true if TokenDetailData instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenDetailData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenDetailData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenNumber == input.TokenNumber ||
                    (this.TokenNumber != null &&
                    this.TokenNumber.Equals(input.TokenNumber))
                ) && 
                (
                    this.ExpiryMonth == input.ExpiryMonth ||
                    (this.ExpiryMonth != null &&
                    this.ExpiryMonth.Equals(input.ExpiryMonth))
                ) && 
                (
                    this.ExpiryYear == input.ExpiryYear ||
                    (this.ExpiryYear != null &&
                    this.ExpiryYear.Equals(input.ExpiryYear))
                ) && 
                (
                    this.DataValidUntilTimestamp == input.DataValidUntilTimestamp ||
                    (this.DataValidUntilTimestamp != null &&
                    this.DataValidUntilTimestamp.Equals(input.DataValidUntilTimestamp))
                ) && 
                (
                    this.PaymentAccountReference == input.PaymentAccountReference ||
                    (this.PaymentAccountReference != null &&
                    this.PaymentAccountReference.Equals(input.PaymentAccountReference))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TokenNumber != null)
                    hashCode = hashCode * 59 + this.TokenNumber.GetHashCode();
                if (this.ExpiryMonth != null)
                    hashCode = hashCode * 59 + this.ExpiryMonth.GetHashCode();
                if (this.ExpiryYear != null)
                    hashCode = hashCode * 59 + this.ExpiryYear.GetHashCode();
                if (this.DataValidUntilTimestamp != null)
                    hashCode = hashCode * 59 + this.DataValidUntilTimestamp.GetHashCode();
                if (this.PaymentAccountReference != null)
                    hashCode = hashCode * 59 + this.PaymentAccountReference.GetHashCode();
                return hashCode;
            }
        }
    }

}