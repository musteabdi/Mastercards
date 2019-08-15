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


import ApiClient from "../ApiClient";
import ErrorsResponse from '../model/ErrorsResponse';
import GetTaskStatusRequestSchema from '../model/GetTaskStatusRequestSchema';
import GetTaskStatusResponseSchema from '../model/GetTaskStatusResponseSchema';

/**
* GetTaskStatus service.
* @module api/GetTaskStatusApi
* @version 1.2.7
*/
export default class GetTaskStatusApi {

    /**
    * Constructs a new GetTaskStatusApi. 
    * @alias module:api/GetTaskStatusApi
    * @class
    * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
    * default to {@link module:ApiClient#instance} if unspecified.
    */
    constructor(apiClient) {
        this.apiClient = apiClient || ApiClient.instance;
    }


    /**
     * Callback function to receive the result of the getTaskStatus operation.
     * @callback module:api/GetTaskStatusApi~getTaskStatusCallback
     * @param {String} error Error message, if any.
     * @param {module:model/GetTaskStatusResponseSchema} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Used to check the status of any asynchronous task that was previously requested.
     * Used to check the status of any asynchronous task that was previously requested. 
     * @param {Object} opts Optional parameters
     * @param {module:model/GetTaskStatusRequestSchema} opts.getTaskStatusRequestSchema Contains the details of the request message. 
     * @param {module:api/GetTaskStatusApi~getTaskStatusCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/GetTaskStatusResponseSchema}
     */
    getTaskStatus(opts, callback) {
      opts = opts || {};
      let postBody = opts['getTaskStatusRequestSchema'];

      let pathParams = {
      };
      let queryParams = {
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = [];
      let contentTypes = ['application/json'];
      let accepts = ['application/json'];
      let returnType = GetTaskStatusResponseSchema;
      return this.apiClient.callApi(
        '/digitization/static/1/0/getTaskStatus', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }


}