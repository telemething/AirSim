//*****************************************************************************
//* Project: Firefly (Microsoft Hackaton 2020)
//* Description: AOLUSS REST Client
//* Author: Mark West (mark.west@microsoft.com)
//*****************************************************************************

/* 
 * NASA AOLUSS Operator interface
 *
 * this OAS document describes the operator interface for the AOLUSS.
 *
 * OpenAPI spec version: 2.1.8
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using AolussClientLib.Client;
using AolussClientLib.Model;

namespace AolussClientLib.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface ITokenApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a JWT token for accessing the operator API.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AolussClientLib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>JsonWebToken</returns>
        JsonWebToken GetOperatorToken ();

        /// <summary>
        /// Get a JWT token for accessing the operator API.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AolussClientLib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of JsonWebToken</returns>
        ApiResponse<JsonWebToken> GetOperatorTokenWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a JWT token for accessing the operator API.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AolussClientLib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of JsonWebToken</returns>
        System.Threading.Tasks.Task<JsonWebToken> GetOperatorTokenAsync ();

        /// <summary>
        /// Get a JWT token for accessing the operator API.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="AolussClientLib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (JsonWebToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<JsonWebToken>> GetOperatorTokenAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class TokenApi : ITokenApi
    {
        private AolussClientLib.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokenApi(String basePath)
        {
            this.Configuration = new AolussClientLib.Client.Configuration { BasePath = basePath };

            ExceptionFactory = AolussClientLib.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class
        /// </summary>
        /// <returns></returns>
        public TokenApi()
        {
            this.Configuration = AolussClientLib.Client.Configuration.Default;

            ExceptionFactory = AolussClientLib.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TokenApi(AolussClientLib.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = AolussClientLib.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = AolussClientLib.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AolussClientLib.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AolussClientLib.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get a JWT token for accessing the operator API. 
        /// </summary>
        /// <exception cref="AolussClientLib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>JsonWebToken</returns>
        public JsonWebToken GetOperatorToken ()
        {
             ApiResponse<JsonWebToken> localVarResponse = GetOperatorTokenWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a JWT token for accessing the operator API. 
        /// </summary>
        /// <exception cref="AolussClientLib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of JsonWebToken</returns>
        public ApiResponse< JsonWebToken > GetOperatorTokenWithHttpInfo ()
        {

            var localVarPath = "/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOperatorToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<JsonWebToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (JsonWebToken) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonWebToken)));
        }

        /// <summary>
        /// Get a JWT token for accessing the operator API. 
        /// </summary>
        /// <exception cref="AolussClientLib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of JsonWebToken</returns>
        public async System.Threading.Tasks.Task<JsonWebToken> GetOperatorTokenAsync ()
        {
             ApiResponse<JsonWebToken> localVarResponse = await GetOperatorTokenAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a JWT token for accessing the operator API. 
        /// </summary>
        /// <exception cref="AolussClientLib.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (JsonWebToken)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JsonWebToken>> GetOperatorTokenAsyncWithHttpInfo ()
        {

            var localVarPath = "/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (basicAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password);
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOperatorToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<JsonWebToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (JsonWebToken) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(JsonWebToken)));
        }

    }
}
