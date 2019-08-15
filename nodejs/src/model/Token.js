/**
 * MDES for Merchants
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously.  
 *
 * The version of the OpenAPI document: 1.2.7
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

import ApiClient from '../ApiClient';
import ProductConfig from './ProductConfig';
import TokenInfo from './TokenInfo';

/**
 * The Token model module.
 * @module model/Token
 * @version 1.2.7
 */
class Token {
    /**
     * Constructs a new <code>Token</code>.
     * @alias module:model/Token
     */
    constructor() { 
        
        Token.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>Token</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/Token} obj Optional instance to populate.
     * @return {module:model/Token} The populated <code>Token</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new Token();

            if (data.hasOwnProperty('tokenUniqueReference')) {
                obj['tokenUniqueReference'] = ApiClient.convertToType(data['tokenUniqueReference'], 'String');
            }
            if (data.hasOwnProperty('status')) {
                obj['status'] = ApiClient.convertToType(data['status'], 'String');
            }
            if (data.hasOwnProperty('suspendedBy')) {
                obj['suspendedBy'] = ApiClient.convertToType(data['suspendedBy'], ['String']);
            }
            if (data.hasOwnProperty('statusTimestamp')) {
                obj['statusTimestamp'] = ApiClient.convertToType(data['statusTimestamp'], 'String');
            }
            if (data.hasOwnProperty('productConfig')) {
                obj['productConfig'] = ProductConfig.constructFromObject(data['productConfig']);
            }
            if (data.hasOwnProperty('tokenInfo')) {
                obj['tokenInfo'] = TokenInfo.constructFromObject(data['tokenInfo']);
            }
        }
        return obj;
    }


}

/**
 * The unique reference allocated to the Token which is always present even if an error occurs. <br>      __Max Length:64__ 
 * @member {String} tokenUniqueReference
 */
Token.prototype['tokenUniqueReference'] = undefined;

/**
 * The current status of Token. Must be either:    * 'INACTIVE' (Token has not yet been activated)  * 'ACTIVE' (Token is active and ready to transact)  * 'SUSPENDED' (Token is suspended and unable to transact)  * 'DEACTIVATED' (Token has been permanently deactivated).<br>      __Max Length:32__ 
 * @member {String} status
 */
Token.prototype['status'] = undefined;

/**
 * (CONDITIONAL only supplied if status is SUSPENDED) Who or what caused the Token to be suspended One or more values of:     * ISSUER - Suspended by the Issuer.    * TOKEN_REQUESTOR - Suspended by the Token Requestor     * MOBILE_PIN_LOCKED - Suspended due to the Mobile PIN being locked    * CARDHOLDER - Suspended by the Cardholder <br>          __Max Length__: N/A     
 * @member {Array.<String>} suspendedBy
 */
Token.prototype['suspendedBy'] = undefined;

/**
 * The date and time the token status was last updated. Expressed in ISO 8601 extended format as one of the following:     * YYYY-MM-DDThh:mm:ss[.sss]Z    * YYYY-MM-DDThh:mm:ss[.sss]�hh:mm    * Where [.sss] is optional and can be 1 to 3 digits. <br>  __Max Length:29__   
 * @member {String} statusTimestamp
 */
Token.prototype['statusTimestamp'] = undefined;

/**
 * @member {module:model/ProductConfig} productConfig
 */
Token.prototype['productConfig'] = undefined;

/**
 * @member {module:model/TokenInfo} tokenInfo
 */
Token.prototype['tokenInfo'] = undefined;






export default Token;
