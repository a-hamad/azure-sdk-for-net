// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Redis
{
    /// <summary>
    /// A class representing a collection of <see cref="RedisCacheAccessPolicyResource"/> and their operations.
    /// Each <see cref="RedisCacheAccessPolicyResource"/> in the collection will belong to the same instance of <see cref="RedisResource"/>.
    /// To get a <see cref="RedisCacheAccessPolicyCollection"/> instance call the GetRedisCacheAccessPolicies method from an instance of <see cref="RedisResource"/>.
    /// </summary>
    public partial class RedisCacheAccessPolicyCollection : ArmCollection, IEnumerable<RedisCacheAccessPolicyResource>, IAsyncEnumerable<RedisCacheAccessPolicyResource>
    {
        private readonly ClientDiagnostics _redisCacheAccessPolicyAccessPolicyClientDiagnostics;
        private readonly AccessPolicyRestOperations _redisCacheAccessPolicyAccessPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="RedisCacheAccessPolicyCollection"/> class for mocking. </summary>
        protected RedisCacheAccessPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RedisCacheAccessPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RedisCacheAccessPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _redisCacheAccessPolicyAccessPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Redis", RedisCacheAccessPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RedisCacheAccessPolicyResource.ResourceType, out string redisCacheAccessPolicyAccessPolicyApiVersion);
            _redisCacheAccessPolicyAccessPolicyRestClient = new AccessPolicyRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, redisCacheAccessPolicyAccessPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RedisResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RedisResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Adds an access policy to the redis cache
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicies/{accessPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicy_CreateUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accessPolicyName"> The name of the access policy that is being added to the Redis cache. </param>
        /// <param name="data"> Parameters supplied to the Create Update Access Policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accessPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accessPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RedisCacheAccessPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string accessPolicyName, RedisCacheAccessPolicyData data, CancellationToken cancellationToken = default)
        {
            if (accessPolicyName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyName));
            }
            if (accessPolicyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _redisCacheAccessPolicyAccessPolicyClientDiagnostics.CreateScope("RedisCacheAccessPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _redisCacheAccessPolicyAccessPolicyRestClient.CreateUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new RedisArmOperation<RedisCacheAccessPolicyResource>(new RedisCacheAccessPolicyOperationSource(Client), _redisCacheAccessPolicyAccessPolicyClientDiagnostics, Pipeline, _redisCacheAccessPolicyAccessPolicyRestClient.CreateCreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessPolicyName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Adds an access policy to the redis cache
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicies/{accessPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicy_CreateUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accessPolicyName"> The name of the access policy that is being added to the Redis cache. </param>
        /// <param name="data"> Parameters supplied to the Create Update Access Policy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accessPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accessPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RedisCacheAccessPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string accessPolicyName, RedisCacheAccessPolicyData data, CancellationToken cancellationToken = default)
        {
            if (accessPolicyName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyName));
            }
            if (accessPolicyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _redisCacheAccessPolicyAccessPolicyClientDiagnostics.CreateScope("RedisCacheAccessPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _redisCacheAccessPolicyAccessPolicyRestClient.CreateUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessPolicyName, data, cancellationToken);
                var operation = new RedisArmOperation<RedisCacheAccessPolicyResource>(new RedisCacheAccessPolicyOperationSource(Client), _redisCacheAccessPolicyAccessPolicyClientDiagnostics, Pipeline, _redisCacheAccessPolicyAccessPolicyRestClient.CreateCreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessPolicyName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the detailed information about an access policy of a redis cache
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicies/{accessPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accessPolicyName"> The name of the access policy that is being added to the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accessPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accessPolicyName"/> is null. </exception>
        public virtual async Task<Response<RedisCacheAccessPolicyResource>> GetAsync(string accessPolicyName, CancellationToken cancellationToken = default)
        {
            if (accessPolicyName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyName));
            }
            if (accessPolicyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyName));
            }

            using var scope = _redisCacheAccessPolicyAccessPolicyClientDiagnostics.CreateScope("RedisCacheAccessPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _redisCacheAccessPolicyAccessPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RedisCacheAccessPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the detailed information about an access policy of a redis cache
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicies/{accessPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accessPolicyName"> The name of the access policy that is being added to the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accessPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accessPolicyName"/> is null. </exception>
        public virtual Response<RedisCacheAccessPolicyResource> Get(string accessPolicyName, CancellationToken cancellationToken = default)
        {
            if (accessPolicyName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyName));
            }
            if (accessPolicyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyName));
            }

            using var scope = _redisCacheAccessPolicyAccessPolicyClientDiagnostics.CreateScope("RedisCacheAccessPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _redisCacheAccessPolicyAccessPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RedisCacheAccessPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of access policies associated with this redis cache
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicy_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RedisCacheAccessPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RedisCacheAccessPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _redisCacheAccessPolicyAccessPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _redisCacheAccessPolicyAccessPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RedisCacheAccessPolicyResource(Client, RedisCacheAccessPolicyData.DeserializeRedisCacheAccessPolicyData(e)), _redisCacheAccessPolicyAccessPolicyClientDiagnostics, Pipeline, "RedisCacheAccessPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of access policies associated with this redis cache
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicy_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RedisCacheAccessPolicyResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RedisCacheAccessPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _redisCacheAccessPolicyAccessPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _redisCacheAccessPolicyAccessPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RedisCacheAccessPolicyResource(Client, RedisCacheAccessPolicyData.DeserializeRedisCacheAccessPolicyData(e)), _redisCacheAccessPolicyAccessPolicyClientDiagnostics, Pipeline, "RedisCacheAccessPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicies/{accessPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accessPolicyName"> The name of the access policy that is being added to the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accessPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accessPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string accessPolicyName, CancellationToken cancellationToken = default)
        {
            if (accessPolicyName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyName));
            }
            if (accessPolicyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyName));
            }

            using var scope = _redisCacheAccessPolicyAccessPolicyClientDiagnostics.CreateScope("RedisCacheAccessPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _redisCacheAccessPolicyAccessPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicies/{accessPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accessPolicyName"> The name of the access policy that is being added to the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accessPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accessPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string accessPolicyName, CancellationToken cancellationToken = default)
        {
            if (accessPolicyName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyName));
            }
            if (accessPolicyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyName));
            }

            using var scope = _redisCacheAccessPolicyAccessPolicyClientDiagnostics.CreateScope("RedisCacheAccessPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _redisCacheAccessPolicyAccessPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicies/{accessPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accessPolicyName"> The name of the access policy that is being added to the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accessPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accessPolicyName"/> is null. </exception>
        public virtual async Task<NullableResponse<RedisCacheAccessPolicyResource>> GetIfExistsAsync(string accessPolicyName, CancellationToken cancellationToken = default)
        {
            if (accessPolicyName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyName));
            }
            if (accessPolicyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyName));
            }

            using var scope = _redisCacheAccessPolicyAccessPolicyClientDiagnostics.CreateScope("RedisCacheAccessPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _redisCacheAccessPolicyAccessPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RedisCacheAccessPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new RedisCacheAccessPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{cacheName}/accessPolicies/{accessPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AccessPolicy_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisCacheAccessPolicyResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="accessPolicyName"> The name of the access policy that is being added to the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accessPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accessPolicyName"/> is null. </exception>
        public virtual NullableResponse<RedisCacheAccessPolicyResource> GetIfExists(string accessPolicyName, CancellationToken cancellationToken = default)
        {
            if (accessPolicyName == null)
            {
                throw new ArgumentNullException(nameof(accessPolicyName));
            }
            if (accessPolicyName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accessPolicyName));
            }

            using var scope = _redisCacheAccessPolicyAccessPolicyClientDiagnostics.CreateScope("RedisCacheAccessPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _redisCacheAccessPolicyAccessPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, accessPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RedisCacheAccessPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new RedisCacheAccessPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RedisCacheAccessPolicyResource> IEnumerable<RedisCacheAccessPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RedisCacheAccessPolicyResource> IAsyncEnumerable<RedisCacheAccessPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
