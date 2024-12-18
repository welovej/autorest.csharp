// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Scm._Type._Array.Models;

namespace Scm._Type._Array
{
    // Data plane generated sub-client.
    /// <summary> The NullableModelValue sub-client. </summary>
    public partial class NullableModelValue
    {
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of NullableModelValue for mocking. </summary>
        protected NullableModelValue()
        {
        }

        /// <summary> Initializes a new instance of NullableModelValue. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        internal NullableModelValue(ClientPipeline pipeline, Uri endpoint)
        {
            _pipeline = pipeline;
            _endpoint = endpoint;
        }

        /// <summary> Get nullable model value. </summary>
        public virtual async Task<ClientResult<IReadOnlyList<InnerModel>>> GetNullableModelValueAsync()
        {
            ClientResult result = await GetNullableModelValueAsync(null).ConfigureAwait(false);
            IReadOnlyList<InnerModel> value = default;
            using var document = await JsonDocument.ParseAsync(result.GetRawResponse().ContentStream, default, default).ConfigureAwait(false);
            List<InnerModel> array = new List<InnerModel>();
            foreach (var item in document.RootElement.EnumerateArray())
            {
                array.Add(InnerModel.DeserializeInnerModel(item));
            }
            value = array;
            return ClientResult.FromValue(value, result.GetRawResponse());
        }

        /// <summary> Get nullable model value. </summary>
        public virtual ClientResult<IReadOnlyList<InnerModel>> GetNullableModelValue()
        {
            ClientResult result = GetNullableModelValue(null);
            IReadOnlyList<InnerModel> value = default;
            using var document = JsonDocument.Parse(result.GetRawResponse().ContentStream);
            List<InnerModel> array = new List<InnerModel>();
            foreach (var item in document.RootElement.EnumerateArray())
            {
                array.Add(InnerModel.DeserializeInnerModel(item));
            }
            value = array;
            return ClientResult.FromValue(value, result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Get nullable model value.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetNullableModelValueAsync()"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> GetNullableModelValueAsync(RequestOptions options)
        {
            using PipelineMessage message = CreateGetNullableModelValueRequest(options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Get nullable model value.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetNullableModelValue()"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult GetNullableModelValue(RequestOptions options)
        {
            using PipelineMessage message = CreateGetNullableModelValueRequest(options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        /// <summary> Put. </summary>
        /// <param name="body"> The <see cref="IEnumerable{T}"/> where <c>T</c> is of type <see cref="InnerModel"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual async Task<ClientResult> PutAsync(IEnumerable<InnerModel> body)
        {
            Argument.AssertNotNull(body, nameof(body));

            using BinaryContent content = BinaryContentHelper.FromEnumerable(body);
            ClientResult result = await PutAsync(content, null).ConfigureAwait(false);
            return result;
        }

        /// <summary> Put. </summary>
        /// <param name="body"> The <see cref="IEnumerable{T}"/> where <c>T</c> is of type <see cref="InnerModel"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual ClientResult Put(IEnumerable<InnerModel> body)
        {
            Argument.AssertNotNull(body, nameof(body));

            using BinaryContent content = BinaryContentHelper.FromEnumerable(body);
            ClientResult result = Put(content, null);
            return result;
        }

        /// <summary>
        /// [Protocol Method] Put.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="PutAsync(IEnumerable{InnerModel})"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> PutAsync(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreatePutRequest(content, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Put.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Put(IEnumerable{InnerModel})"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Put(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreatePutRequest(content, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        internal PipelineMessage CreateGetNullableModelValueRequest(RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "GET";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/type/array/nullable-model", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            message.Apply(options);
            return message;
        }

        internal PipelineMessage CreatePutRequest(BinaryContent content, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier204;
            var request = message.Request;
            request.Method = "PUT";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/type/array/nullable-model", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
        private static PipelineMessageClassifier _pipelineMessageClassifier204;
        private static PipelineMessageClassifier PipelineMessageClassifier204 => _pipelineMessageClassifier204 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 204 });
    }
}
