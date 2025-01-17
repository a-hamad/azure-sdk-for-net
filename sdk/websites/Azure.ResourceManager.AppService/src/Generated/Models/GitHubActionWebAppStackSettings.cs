// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> GitHub Actions Web App stack settings. </summary>
    public partial class GitHubActionWebAppStackSettings
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

        /// <summary> Initializes a new instance of <see cref="GitHubActionWebAppStackSettings"/>. </summary>
        internal GitHubActionWebAppStackSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubActionWebAppStackSettings"/>. </summary>
        /// <param name="isSupported"> &lt;code&gt;true&lt;/code&gt; if GitHub Actions is supported for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="supportedVersion"> The minor version that is supported for GitHub Actions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GitHubActionWebAppStackSettings(bool? isSupported, string supportedVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsSupported = isSupported;
            SupportedVersion = supportedVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> &lt;code&gt;true&lt;/code&gt; if GitHub Actions is supported for the stack; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsSupported { get; }
        /// <summary> The minor version that is supported for GitHub Actions. </summary>
        public string SupportedVersion { get; }
    }
}
