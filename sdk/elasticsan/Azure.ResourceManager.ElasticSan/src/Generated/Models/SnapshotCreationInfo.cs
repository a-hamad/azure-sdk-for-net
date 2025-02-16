// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Data used when creating a volume snapshot. </summary>
    public partial class SnapshotCreationInfo
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

        /// <summary> Initializes a new instance of <see cref="SnapshotCreationInfo"/>. </summary>
        /// <param name="sourceId"> Fully qualified resource ID of the volume. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/volumes/{volumeName}". </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceId"/> is null. </exception>
        public SnapshotCreationInfo(ResourceIdentifier sourceId)
        {
            if (sourceId == null)
            {
                throw new ArgumentNullException(nameof(sourceId));
            }

            SourceId = sourceId;
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotCreationInfo"/>. </summary>
        /// <param name="sourceId"> Fully qualified resource ID of the volume. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/volumes/{volumeName}". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotCreationInfo(ResourceIdentifier sourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceId = sourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotCreationInfo"/> for deserialization. </summary>
        internal SnapshotCreationInfo()
        {
        }

        /// <summary> Fully qualified resource ID of the volume. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ElasticSan/elasticSans/{elasticSanName}/volumegroups/{volumeGroupName}/volumes/{volumeName}". </summary>
        public ResourceIdentifier SourceId { get; set; }
    }
}
