/*
 * RhubarbVRApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"> (optional)</param>
        /// <param name="username"> (optional)</param>
        /// <param name="identifier"> (optional)</param>
        /// <param name="matchcase"> (optional)</param>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <returns>List&lt;PublicUser&gt;</returns>
        List<PublicUser> UsersFetchGet(string uuid = default(string), string username = default(string), int? identifier = default(int?), bool? matchcase = default(bool?), string authorization = default(string));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"> (optional)</param>
        /// <param name="username"> (optional)</param>
        /// <param name="identifier"> (optional)</param>
        /// <param name="matchcase"> (optional)</param>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <returns>ApiResponse of List&lt;PublicUser&gt;</returns>
        ApiResponse<List<PublicUser>> UsersFetchGetWithHttpInfo(string uuid = default(string), string username = default(string), int? identifier = default(int?), bool? matchcase = default(bool?), string authorization = default(string));
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <returns>PrivateUser</returns>
        PrivateUser UsersMeGet(string authorization = default(string));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <returns>ApiResponse of PrivateUser</returns>
        ApiResponse<PrivateUser> UsersMeGetWithHttpInfo(string authorization = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"> (optional)</param>
        /// <param name="username"> (optional)</param>
        /// <param name="identifier"> (optional)</param>
        /// <param name="matchcase"> (optional)</param>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PublicUser&gt;</returns>
        System.Threading.Tasks.Task<List<PublicUser>> UsersFetchGetAsync(string uuid = default(string), string username = default(string), int? identifier = default(int?), bool? matchcase = default(bool?), string authorization = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"> (optional)</param>
        /// <param name="username"> (optional)</param>
        /// <param name="identifier"> (optional)</param>
        /// <param name="matchcase"> (optional)</param>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PublicUser&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<PublicUser>>> UsersFetchGetWithHttpInfoAsync(string uuid = default(string), string username = default(string), int? identifier = default(int?), bool? matchcase = default(bool?), string authorization = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PrivateUser</returns>
        System.Threading.Tasks.Task<PrivateUser> UsersMeGetAsync(string authorization = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PrivateUser)</returns>
        System.Threading.Tasks.Task<ApiResponse<PrivateUser>> UsersMeGetWithHttpInfoAsync(string authorization = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi : IUsersApiSync, IUsersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsersApi : IUsersApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsersApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UsersApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
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
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"> (optional)</param>
        /// <param name="username"> (optional)</param>
        /// <param name="identifier"> (optional)</param>
        /// <param name="matchcase"> (optional)</param>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <returns>List&lt;PublicUser&gt;</returns>
        public List<PublicUser> UsersFetchGet(string uuid = default(string), string username = default(string), int? identifier = default(int?), bool? matchcase = default(bool?), string authorization = default(string))
        {
            Org.OpenAPITools.Client.ApiResponse<List<PublicUser>> localVarResponse = UsersFetchGetWithHttpInfo(uuid, username, identifier, matchcase, authorization);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"> (optional)</param>
        /// <param name="username"> (optional)</param>
        /// <param name="identifier"> (optional)</param>
        /// <param name="matchcase"> (optional)</param>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <returns>ApiResponse of List&lt;PublicUser&gt;</returns>
        public Org.OpenAPITools.Client.ApiResponse<List<PublicUser>> UsersFetchGetWithHttpInfo(string uuid = default(string), string username = default(string), int? identifier = default(int?), bool? matchcase = default(bool?), string authorization = default(string))
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (uuid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "uuid", uuid));
            }
            if (username != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "username", username));
            }
            if (identifier != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "identifier", identifier));
            }
            if (matchcase != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "matchcase", matchcase));
            }
            if (authorization != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", Org.OpenAPITools.Client.ClientUtils.ParameterToString(authorization)); // header parameter
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<PublicUser>>("/Users/fetch", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UsersFetchGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"> (optional)</param>
        /// <param name="username"> (optional)</param>
        /// <param name="identifier"> (optional)</param>
        /// <param name="matchcase"> (optional)</param>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;PublicUser&gt;</returns>
        public async System.Threading.Tasks.Task<List<PublicUser>> UsersFetchGetAsync(string uuid = default(string), string username = default(string), int? identifier = default(int?), bool? matchcase = default(bool?), string authorization = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<List<PublicUser>> localVarResponse = await UsersFetchGetWithHttpInfoAsync(uuid, username, identifier, matchcase, authorization, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="uuid"> (optional)</param>
        /// <param name="username"> (optional)</param>
        /// <param name="identifier"> (optional)</param>
        /// <param name="matchcase"> (optional)</param>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;PublicUser&gt;)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<List<PublicUser>>> UsersFetchGetWithHttpInfoAsync(string uuid = default(string), string username = default(string), int? identifier = default(int?), bool? matchcase = default(bool?), string authorization = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (uuid != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "uuid", uuid));
            }
            if (username != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "username", username));
            }
            if (identifier != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "identifier", identifier));
            }
            if (matchcase != null)
            {
                localVarRequestOptions.QueryParameters.Add(Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "matchcase", matchcase));
            }
            if (authorization != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", Org.OpenAPITools.Client.ClientUtils.ParameterToString(authorization)); // header parameter
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<PublicUser>>("/Users/fetch", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UsersFetchGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <returns>PrivateUser</returns>
        public PrivateUser UsersMeGet(string authorization = default(string))
        {
            Org.OpenAPITools.Client.ApiResponse<PrivateUser> localVarResponse = UsersMeGetWithHttpInfo(authorization);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <returns>ApiResponse of PrivateUser</returns>
        public Org.OpenAPITools.Client.ApiResponse<PrivateUser> UsersMeGetWithHttpInfo(string authorization = default(string))
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (authorization != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", Org.OpenAPITools.Client.ClientUtils.ParameterToString(authorization)); // header parameter
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<PrivateUser>("/Users/@me", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UsersMeGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PrivateUser</returns>
        public async System.Threading.Tasks.Task<PrivateUser> UsersMeGetAsync(string authorization = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<PrivateUser> localVarResponse = await UsersMeGetWithHttpInfoAsync(authorization, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">For Authenticating the user (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PrivateUser)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<PrivateUser>> UsersMeGetWithHttpInfoAsync(string authorization = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (authorization != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", Org.OpenAPITools.Client.ClientUtils.ParameterToString(authorization)); // header parameter
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PrivateUser>("/Users/@me", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("UsersMeGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
