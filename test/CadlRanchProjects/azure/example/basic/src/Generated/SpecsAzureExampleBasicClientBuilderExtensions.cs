// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using _Specs_.Azure.Example.Basic;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="AzureExampleClient"/> to client builder. </summary>
    public static partial class SpecsAzureExampleBasicClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="AzureExampleClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        public static IAzureClientBuilder<AzureExampleClient, AzureExampleClientOptions> AddAzureExampleClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<AzureExampleClient, AzureExampleClientOptions>((options) => new AzureExampleClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="AzureExampleClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<AzureExampleClient, AzureExampleClientOptions> AddAzureExampleClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<AzureExampleClient, AzureExampleClientOptions>(configuration);
        }
    }
}
