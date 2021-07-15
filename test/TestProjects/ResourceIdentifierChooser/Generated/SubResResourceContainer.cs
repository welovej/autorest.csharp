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
    /// <summary> A class representing collection of SubResResource and their operations over a Subscription. </summary>
    public partial class SubResResourceContainer : ResourceContainerBase<SubscriptionResourceIdentifier, SubResResource, SubResResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="SubResResourceContainer"/> class for mocking. </summary>
        protected SubResResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of SubResResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SubResResourceContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private SubResResourcesRestOperations _restClient => new SubResResourcesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new SubscriptionResourceIdentifier Id => base.Id as SubscriptionResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SubscriptionOperations.ResourceType;

        // Container level operations.

        /// <param name="subResResourcesName"> The String to use. </param>
        /// <param name="parameters"> The SubResResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subResResourcesName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<SubResResource> CreateOrUpdate(string subResResourcesName, SubResResourceData parameters, CancellationToken cancellationToken = default)
        {
            if (subResResourcesName == null)
            {
                throw new ArgumentNullException(nameof(subResResourcesName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubResResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(subResResourcesName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="subResResourcesName"> The String to use. </param>
        /// <param name="parameters"> The SubResResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subResResourcesName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<SubResResource>> CreateOrUpdateAsync(string subResResourcesName, SubResResourceData parameters, CancellationToken cancellationToken = default)
        {
            if (subResResourcesName == null)
            {
                throw new ArgumentNullException(nameof(subResResourcesName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubResResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(subResResourcesName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="subResResourcesName"> The String to use. </param>
        /// <param name="parameters"> The SubResResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subResResourcesName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SubResResourcesPutOperation StartCreateOrUpdate(string subResResourcesName, SubResResourceData parameters, CancellationToken cancellationToken = default)
        {
            if (subResResourcesName == null)
            {
                throw new ArgumentNullException(nameof(subResResourcesName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubResResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Put(Id.Name, subResResourcesName, parameters, cancellationToken);
                return new SubResResourcesPutOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="subResResourcesName"> The String to use. </param>
        /// <param name="parameters"> The SubResResource to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subResResourcesName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SubResResourcesPutOperation> StartCreateOrUpdateAsync(string subResResourcesName, SubResResourceData parameters, CancellationToken cancellationToken = default)
        {
            if (subResResourcesName == null)
            {
                throw new ArgumentNullException(nameof(subResResourcesName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubResResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.PutAsync(Id.Name, subResResourcesName, parameters, cancellationToken).ConfigureAwait(false);
                return new SubResResourcesPutOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="subResResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<SubResResource> Get(string subResResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResResourceContainer.Get");
            scope.Start();
            try
            {
                if (subResResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subResResourcesName));
                }

                var response = _restClient.Get(Id.Name, subResResourcesName, cancellationToken: cancellationToken);
                return Response.FromValue(new SubResResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="subResResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<SubResResource>> GetAsync(string subResResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResResourceContainer.Get");
            scope.Start();
            try
            {
                if (subResResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subResResourcesName));
                }

                var response = await _restClient.GetAsync(Id.Name, subResResourcesName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SubResResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subResResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual SubResResource TryGet(string subResResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResResourceContainer.TryGet");
            scope.Start();
            try
            {
                if (subResResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subResResourcesName));
                }

                return Get(subResResourcesName, cancellationToken: cancellationToken).Value;
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
        /// <param name="subResResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<SubResResource> TryGetAsync(string subResResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResResourceContainer.TryGet");
            scope.Start();
            try
            {
                if (subResResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subResResourcesName));
                }

                return await GetAsync(subResResourcesName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="subResResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string subResResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResResourceContainer.DoesExist");
            scope.Start();
            try
            {
                if (subResResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subResResourcesName));
                }

                return TryGet(subResResourcesName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subResResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string subResResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResResourceContainer.DoesExist");
            scope.Start();
            try
            {
                if (subResResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(subResResourcesName));
                }

                return await TryGetAsync(subResResourcesName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of SubResResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubResResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of SubResResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubResResourceOperations.ResourceType);
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
        // public ArmBuilder<SubscriptionResourceIdentifier, SubResResource, SubResResourceData> Construct() { }
    }
}
