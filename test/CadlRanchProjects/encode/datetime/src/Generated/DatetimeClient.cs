// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Encode.Datetime
{
    // Data plane generated client.
    /// <summary> The Datetime service client. </summary>
    public partial class DatetimeClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of DatetimeClient. </summary>
        public DatetimeClient() : this(new Uri("http://localhost:3000"), new DatetimeClientOptions())
        {
        }

        /// <summary> Initializes a new instance of DatetimeClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public DatetimeClient(Uri endpoint, DatetimeClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new DatetimeClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
        }

        private Query _cachedQuery;
        private Property _cachedProperty;
        private Header _cachedHeader;
        private ResponseHeader _cachedResponseHeader;

        /// <summary> Initializes a new instance of Query. </summary>
        public virtual Query GetQueryClient()
        {
            return Volatile.Read(ref _cachedQuery) ?? Interlocked.CompareExchange(ref _cachedQuery, new Query(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedQuery;
        }

        /// <summary> Initializes a new instance of Property. </summary>
        public virtual Property GetPropertyClient()
        {
            return Volatile.Read(ref _cachedProperty) ?? Interlocked.CompareExchange(ref _cachedProperty, new Property(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedProperty;
        }

        /// <summary> Initializes a new instance of Header. </summary>
        public virtual Header GetHeaderClient()
        {
            return Volatile.Read(ref _cachedHeader) ?? Interlocked.CompareExchange(ref _cachedHeader, new Header(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedHeader;
        }

        /// <summary> Initializes a new instance of ResponseHeader. </summary>
        public virtual ResponseHeader GetResponseHeaderClient()
        {
            return Volatile.Read(ref _cachedResponseHeader) ?? Interlocked.CompareExchange(ref _cachedResponseHeader, new ResponseHeader(ClientDiagnostics, _pipeline, _endpoint), null) ?? _cachedResponseHeader;
        }
    }
}
