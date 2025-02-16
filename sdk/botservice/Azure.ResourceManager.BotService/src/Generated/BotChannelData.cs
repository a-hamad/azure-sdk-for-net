// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.BotService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.BotService
{
    /// <summary>
    /// A class representing the BotChannel data model.
    /// Bot channel resource definition
    /// </summary>
    public partial class BotChannelData : TrackedResourceData
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BotChannelData"/>. </summary>
        /// <param name="location"> The location. </param>
        public BotChannelData(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="BotChannelData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties">
        /// The set of properties specific to bot channel resource
        /// Please note <see cref="BotChannelProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AcsChatChannel"/>, <see cref="AlexaChannel"/>, <see cref="DirectLineChannel"/>, <see cref="DirectLineSpeechChannel"/>, <see cref="EmailChannel"/>, <see cref="FacebookChannel"/>, <see cref="KikChannel"/>, <see cref="LineChannel"/>, <see cref="M365Extensions"/>, <see cref="MsTeamsChannel"/>, <see cref="Omnichannel"/>, <see cref="OutlookChannel"/>, <see cref="SearchAssistant"/>, <see cref="SkypeChannel"/>, <see cref="SlackChannel"/>, <see cref="SmsChannel"/>, <see cref="TelegramChannel"/>, <see cref="TelephonyChannel"/> and <see cref="WebChatChannel"/>.
        /// </param>
        /// <param name="sku"> Gets or sets the SKU of the resource. </param>
        /// <param name="kind"> Required. Gets or sets the Kind of the resource. </param>
        /// <param name="etag"> Entity Tag. </param>
        /// <param name="zones"> Entity zones. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BotChannelData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, BotChannelProperties properties, BotServiceSku sku, BotServiceKind? kind, ETag? etag, IReadOnlyList<string> zones, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            Sku = sku;
            Kind = kind;
            ETag = etag;
            Zones = zones;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BotChannelData"/> for deserialization. </summary>
        internal BotChannelData()
        {
        }

        /// <summary>
        /// The set of properties specific to bot channel resource
        /// Please note <see cref="BotChannelProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AcsChatChannel"/>, <see cref="AlexaChannel"/>, <see cref="DirectLineChannel"/>, <see cref="DirectLineSpeechChannel"/>, <see cref="EmailChannel"/>, <see cref="FacebookChannel"/>, <see cref="KikChannel"/>, <see cref="LineChannel"/>, <see cref="M365Extensions"/>, <see cref="MsTeamsChannel"/>, <see cref="Omnichannel"/>, <see cref="OutlookChannel"/>, <see cref="SearchAssistant"/>, <see cref="SkypeChannel"/>, <see cref="SlackChannel"/>, <see cref="SmsChannel"/>, <see cref="TelegramChannel"/>, <see cref="TelephonyChannel"/> and <see cref="WebChatChannel"/>.
        /// </summary>
        public BotChannelProperties Properties { get; set; }
        /// <summary> Gets or sets the SKU of the resource. </summary>
        public BotServiceSku Sku { get; set; }
        /// <summary> Required. Gets or sets the Kind of the resource. </summary>
        public BotServiceKind? Kind { get; set; }
        /// <summary> Entity Tag. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Entity zones. </summary>
        public IReadOnlyList<string> Zones { get; }
    }
}
