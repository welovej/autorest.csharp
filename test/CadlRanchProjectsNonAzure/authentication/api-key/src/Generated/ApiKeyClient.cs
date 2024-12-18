// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Threading.Tasks;

namespace Scm.Authentication.ApiKey
{
    // Data plane generated client.
    /// <summary> The ApiKey service client. </summary>
    public partial class ApiKeyClient
    {
        private const string AuthorizationHeader = "x-ms-api-key";
        private readonly ApiKeyCredential _keyCredential;
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ApiKeyClient for mocking. </summary>
        protected ApiKeyClient()
        {
        }

        /// <summary> Initializes a new instance of ApiKeyClient. </summary>
        /// <param name="credential"> A credential used to authenticate to the service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public ApiKeyClient(ApiKeyCredential credential) : this(new Uri("http://localhost:3000"), credential, new ApiKeyClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ApiKeyClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="credential"> A credential used to authenticate to the service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public ApiKeyClient(Uri endpoint, ApiKeyCredential credential, ApiKeyClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new ApiKeyClientOptions();

            _keyCredential = credential;
            _pipeline = ClientPipeline.Create(options, Array.Empty<PipelinePolicy>(), new PipelinePolicy[] { ApiKeyAuthenticationPolicy.CreateHeaderApiKeyPolicy(_keyCredential, AuthorizationHeader) }, Array.Empty<PipelinePolicy>());
            _endpoint = endpoint;
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Valid.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> ValidAsync(RequestOptions options = null)
        {
            using PipelineMessage message = CreateValidRequest(options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Valid.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Valid(RequestOptions options = null)
        {
            using PipelineMessage message = CreateValidRequest(options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Invalid.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> InvalidAsync(RequestOptions options = null)
        {
            using PipelineMessage message = CreateInvalidRequest(options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Invalid.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Invalid(RequestOptions options = null)
        {
            using PipelineMessage message = CreateInvalidRequest(options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        internal PipelineMessage CreateValidRequest(RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier204;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/authentication/api-key/valid", false);
            request.Uri = uri.ToUri();
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreateInvalidRequest(RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier204;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/authentication/api-key/invalid", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier204;
        private static PipelineMessageClassifier PipelineMessageClassifier204 => _pipelineMessageClassifier204 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 204 });
    }
}
