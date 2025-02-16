// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Redis;

namespace Azure.ResourceManager.Redis.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableRedisResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableRedisResourceGroupResource"/> class for mocking. </summary>
        protected MockableRedisResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableRedisResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableRedisResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of RedisResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of RedisResources and their operations over a RedisResource. </returns>
        public virtual RedisCollection GetAllRedis()
        {
            return GetCachedClient(client => new RedisCollection(client, Id));
        }

        /// <summary>
        /// Gets a Redis cache (resource description).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Redis_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RedisResource>> GetRedisAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetAllRedis().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Redis cache (resource description).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Redis_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-08-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="RedisResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> The name of the Redis cache. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RedisResource> GetRedis(string name, CancellationToken cancellationToken = default)
        {
            return GetAllRedis().Get(name, cancellationToken);
        }
    }
}
