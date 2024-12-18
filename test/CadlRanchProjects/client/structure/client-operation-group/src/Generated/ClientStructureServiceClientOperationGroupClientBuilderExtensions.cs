// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using Client.Structure.Service.ClientOperationGroup;
using Client.Structure.Service.ClientOperationGroup.Models;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="FirstClient"/>, <see cref="SubNamespaceSecondClient"/> to client builder. </summary>
    public static partial class ClientStructureServiceClientOperationGroupClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="FirstClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="client"> The <see cref="ClientType"/> to use. </param>
        public static IAzureClientBuilder<FirstClient, ClientStructureServiceClientOperationGroupClientOptions> AddFirstClient<TBuilder>(this TBuilder builder, Uri endpoint, ClientType client)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<FirstClient, ClientStructureServiceClientOperationGroupClientOptions>((options) => new FirstClient(endpoint, client, options));
        }

        /// <summary> Registers a <see cref="SubNamespaceSecondClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="client"> The <see cref="ClientType"/> to use. </param>
        public static IAzureClientBuilder<SubNamespaceSecondClient, ClientStructureServiceClientOperationGroupClientOptions> AddSubNamespaceSecondClient<TBuilder>(this TBuilder builder, Uri endpoint, ClientType client)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<SubNamespaceSecondClient, ClientStructureServiceClientOperationGroupClientOptions>((options) => new SubNamespaceSecondClient(endpoint, client, options));
        }

        /// <summary> Registers a <see cref="FirstClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<FirstClient, ClientStructureServiceClientOperationGroupClientOptions> AddFirstClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<FirstClient, ClientStructureServiceClientOperationGroupClientOptions>(configuration);
        }
        /// <summary> Registers a <see cref="SubNamespaceSecondClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<SubNamespaceSecondClient, ClientStructureServiceClientOperationGroupClientOptions> AddSubNamespaceSecondClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<SubNamespaceSecondClient, ClientStructureServiceClientOperationGroupClientOptions>(configuration);
        }
    }
}
