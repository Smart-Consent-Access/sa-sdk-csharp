/*
 * @ao/ah-api
 *
 * Telia Smart Access API
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using SmartAccess.Client;
using SmartAccess.Model;

namespace SmartAccess.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServiceProvidersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Fetch information about the given service provider
        /// </remarks>
        /// <exception cref="SmartAccess.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The service provider id in UUID format</param>
        /// <returns>ServiceProviderDTO</returns>
        ServiceProviderDTO GetServiceProvider(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Fetch information about the given service provider
        /// </remarks>
        /// <exception cref="SmartAccess.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The service provider id in UUID format</param>
        /// <returns>ApiResponse of ServiceProviderDTO</returns>
        ApiResponse<ServiceProviderDTO> GetServiceProviderWithHttpInfo(string id);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServiceProvidersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Fetch information about the given service provider
        /// </remarks>
        /// <exception cref="SmartAccess.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The service provider id in UUID format</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ServiceProviderDTO</returns>
        System.Threading.Tasks.Task<ServiceProviderDTO> GetServiceProviderAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Fetch information about the given service provider
        /// </remarks>
        /// <exception cref="SmartAccess.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The service provider id in UUID format</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ServiceProviderDTO)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceProviderDTO>> GetServiceProviderWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServiceProvidersApi : IServiceProvidersApiSync, IServiceProvidersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ServiceProvidersApi : IServiceProvidersApi
    {
        private SmartAccess.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProvidersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServiceProvidersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProvidersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServiceProvidersApi(string basePath)
        {
            this.Configuration = SmartAccess.Client.Configuration.MergeConfigurations(
                SmartAccess.Client.GlobalConfiguration.Instance,
                new SmartAccess.Client.Configuration { BasePath = basePath }
            );
            this.Client = new SmartAccess.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new SmartAccess.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = SmartAccess.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProvidersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ServiceProvidersApi(SmartAccess.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = SmartAccess.Client.Configuration.MergeConfigurations(
                SmartAccess.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new SmartAccess.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new SmartAccess.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = SmartAccess.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProvidersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ServiceProvidersApi(SmartAccess.Client.ISynchronousClient client, SmartAccess.Client.IAsynchronousClient asyncClient, SmartAccess.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = SmartAccess.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public SmartAccess.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public SmartAccess.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public SmartAccess.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SmartAccess.Client.ExceptionFactory ExceptionFactory
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
        ///  Fetch information about the given service provider
        /// </summary>
        /// <exception cref="SmartAccess.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The service provider id in UUID format</param>
        /// <returns>ServiceProviderDTO</returns>
        public ServiceProviderDTO GetServiceProvider(string id)
        {
            SmartAccess.Client.ApiResponse<ServiceProviderDTO> localVarResponse = GetServiceProviderWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Fetch information about the given service provider
        /// </summary>
        /// <exception cref="SmartAccess.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The service provider id in UUID format</param>
        /// <returns>ApiResponse of ServiceProviderDTO</returns>
        public SmartAccess.Client.ApiResponse<ServiceProviderDTO> GetServiceProviderWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new SmartAccess.Client.ApiException(400, "Missing required parameter 'id' when calling ServiceProvidersApi->GetServiceProvider");

            SmartAccess.Client.RequestOptions localVarRequestOptions = new SmartAccess.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = SmartAccess.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SmartAccess.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", SmartAccess.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (jwt) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ServiceProviderDTO>("/serviceproviders/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetServiceProvider", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Fetch information about the given service provider
        /// </summary>
        /// <exception cref="SmartAccess.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The service provider id in UUID format</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ServiceProviderDTO</returns>
        public async System.Threading.Tasks.Task<ServiceProviderDTO> GetServiceProviderAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            SmartAccess.Client.ApiResponse<ServiceProviderDTO> localVarResponse = await GetServiceProviderWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Fetch information about the given service provider
        /// </summary>
        /// <exception cref="SmartAccess.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The service provider id in UUID format</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ServiceProviderDTO)</returns>
        public async System.Threading.Tasks.Task<SmartAccess.Client.ApiResponse<ServiceProviderDTO>> GetServiceProviderWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new SmartAccess.Client.ApiException(400, "Missing required parameter 'id' when calling ServiceProvidersApi->GetServiceProvider");


            SmartAccess.Client.RequestOptions localVarRequestOptions = new SmartAccess.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = SmartAccess.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SmartAccess.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", SmartAccess.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (jwt) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ServiceProviderDTO>("/serviceproviders/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetServiceProvider", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
