// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Threading;

namespace Scm.Serialization.EncodedName.Json
{
    // Data plane generated client.
    /// <summary> The Json service client. </summary>
    public partial class JsonClient
    {
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of JsonClient. </summary>
        public JsonClient() : this(new Uri("http://localhost:3000"), new JsonClientOptions())
        {
        }

        /// <summary> Initializes a new instance of JsonClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public JsonClient(Uri endpoint, JsonClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new JsonClientOptions();

            _pipeline = ClientPipeline.Create(options, Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>());
            _endpoint = endpoint;
        }

        private Property _cachedProperty;

        /// <summary> Initializes a new instance of Property. </summary>
        public virtual Property GetPropertyClient()
        {
            return Volatile.Read(ref _cachedProperty) ?? Interlocked.CompareExchange(ref _cachedProperty, new Property(_pipeline, _endpoint), null) ?? _cachedProperty;
        }
    }
}
