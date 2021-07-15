// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> A class representing collection of ResourceLevel and their operations over a ResourceGroup. </summary>
    public partial class ResourceLevelContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, ResourceLevel, ResourceLevelData>
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceLevelContainer"/> class for mocking. </summary>
        protected ResourceLevelContainer()
        {
        }

        /// <summary> Initializes a new instance of ResourceLevelContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ResourceLevelContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private ResourceLevelsRestOperations _restClient => new ResourceLevelsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="parameters"> The ResourceLevel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceLevelsName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<ResourceLevel> CreateOrUpdate(string resourceLevelsName, ResourceLevelData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceLevelsName == null)
            {
                throw new ArgumentNullException(nameof(resourceLevelsName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(resourceLevelsName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="parameters"> The ResourceLevel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceLevelsName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<ResourceLevel>> CreateOrUpdateAsync(string resourceLevelsName, ResourceLevelData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceLevelsName == null)
            {
                throw new ArgumentNullException(nameof(resourceLevelsName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(resourceLevelsName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="parameters"> The ResourceLevel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceLevelsName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ResourceLevelsPutOperation StartCreateOrUpdate(string resourceLevelsName, ResourceLevelData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceLevelsName == null)
            {
                throw new ArgumentNullException(nameof(resourceLevelsName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Put(Id.ResourceGroupName, resourceLevelsName, parameters, cancellationToken);
                return new ResourceLevelsPutOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="parameters"> The ResourceLevel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceLevelsName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ResourceLevelsPutOperation> StartCreateOrUpdateAsync(string resourceLevelsName, ResourceLevelData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceLevelsName == null)
            {
                throw new ArgumentNullException(nameof(resourceLevelsName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.PutAsync(Id.ResourceGroupName, resourceLevelsName, parameters, cancellationToken).ConfigureAwait(false);
                return new ResourceLevelsPutOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<ResourceLevel> Get(string resourceLevelsName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.Get");
            scope.Start();
            try
            {
                if (resourceLevelsName == null)
                {
                    throw new ArgumentNullException(nameof(resourceLevelsName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, resourceLevelsName, cancellationToken: cancellationToken);
                return Response.FromValue(new ResourceLevel(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<ResourceLevel>> GetAsync(string resourceLevelsName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.Get");
            scope.Start();
            try
            {
                if (resourceLevelsName == null)
                {
                    throw new ArgumentNullException(nameof(resourceLevelsName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, resourceLevelsName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceLevel(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual ResourceLevel TryGet(string resourceLevelsName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.TryGet");
            scope.Start();
            try
            {
                if (resourceLevelsName == null)
                {
                    throw new ArgumentNullException(nameof(resourceLevelsName));
                }

                return Get(resourceLevelsName, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<ResourceLevel> TryGetAsync(string resourceLevelsName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.TryGet");
            scope.Start();
            try
            {
                if (resourceLevelsName == null)
                {
                    throw new ArgumentNullException(nameof(resourceLevelsName));
                }

                return await GetAsync(resourceLevelsName, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string resourceLevelsName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.DoesExist");
            scope.Start();
            try
            {
                if (resourceLevelsName == null)
                {
                    throw new ArgumentNullException(nameof(resourceLevelsName));
                }

                return TryGet(resourceLevelsName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="resourceLevelsName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string resourceLevelsName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.DoesExist");
            scope.Start();
            try
            {
                if (resourceLevelsName == null)
                {
                    throw new ArgumentNullException(nameof(resourceLevelsName));
                }

                return await TryGetAsync(resourceLevelsName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of ResourceLevel for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ResourceLevelOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of ResourceLevel for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLevelContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ResourceLevelOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, ResourceLevel, ResourceLevelData> Construct() { }
    }
}
