// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Table Access Policy Properties Object. </summary>
    public partial class StorageTableAccessPolicy
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

        /// <summary> Initializes a new instance of <see cref="StorageTableAccessPolicy"/>. </summary>
        /// <param name="permission"> Required. List of abbreviated permissions. Supported permission values include 'r','a','u','d'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="permission"/> is null. </exception>
        public StorageTableAccessPolicy(string permission)
        {
            if (permission == null)
            {
                throw new ArgumentNullException(nameof(permission));
            }

            Permission = permission;
        }

        /// <summary> Initializes a new instance of <see cref="StorageTableAccessPolicy"/>. </summary>
        /// <param name="startOn"> Start time of the access policy. </param>
        /// <param name="expireOn"> Expiry time of the access policy. </param>
        /// <param name="permission"> Required. List of abbreviated permissions. Supported permission values include 'r','a','u','d'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageTableAccessPolicy(DateTimeOffset? startOn, DateTimeOffset? expireOn, string permission, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartOn = startOn;
            ExpireOn = expireOn;
            Permission = permission;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageTableAccessPolicy"/> for deserialization. </summary>
        internal StorageTableAccessPolicy()
        {
        }

        /// <summary> Start time of the access policy. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> Expiry time of the access policy. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> Required. List of abbreviated permissions. Supported permission values include 'r','a','u','d'. </summary>
        public string Permission { get; set; }
    }
}
