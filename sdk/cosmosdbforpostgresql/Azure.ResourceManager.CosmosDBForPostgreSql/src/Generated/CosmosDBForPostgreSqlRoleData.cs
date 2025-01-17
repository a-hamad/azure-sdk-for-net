// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDBForPostgreSql.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary>
    /// A class representing the CosmosDBForPostgreSqlRole data model.
    /// Represents a cluster role.
    /// </summary>
    public partial class CosmosDBForPostgreSqlRoleData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlRoleData"/>. </summary>
        /// <param name="password"> The password of the cluster role. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="password"/> is null. </exception>
        public CosmosDBForPostgreSqlRoleData(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            Password = password;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlRoleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="password"> The password of the cluster role. </param>
        /// <param name="provisioningState"> Provisioning state of the role. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBForPostgreSqlRoleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string password, CosmosDBForPostgreSqlProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Password = password;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlRoleData"/> for deserialization. </summary>
        internal CosmosDBForPostgreSqlRoleData()
        {
        }

        /// <summary> The password of the cluster role. </summary>
        public string Password { get; set; }
        /// <summary> Provisioning state of the role. </summary>
        public CosmosDBForPostgreSqlProvisioningState? ProvisioningState { get; }
    }
}
