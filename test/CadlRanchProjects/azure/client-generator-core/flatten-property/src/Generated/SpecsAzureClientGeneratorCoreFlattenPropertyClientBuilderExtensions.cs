// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using _Specs_.Azure.ClientGenerator.Core.FlattenProperty;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="FlattenPropertyClient"/> to client builder. </summary>
    public static partial class SpecsAzureClientGeneratorCoreFlattenPropertyClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="FlattenPropertyClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        public static IAzureClientBuilder<FlattenPropertyClient, FlattenPropertyClientOptions> AddFlattenPropertyClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<FlattenPropertyClient, FlattenPropertyClientOptions>((options) => new FlattenPropertyClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="FlattenPropertyClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<FlattenPropertyClient, FlattenPropertyClientOptions> AddFlattenPropertyClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<FlattenPropertyClient, FlattenPropertyClientOptions>(configuration);
        }
    }
}
