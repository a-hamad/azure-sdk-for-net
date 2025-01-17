// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    internal partial class UpdateChatThreadRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Topic != null)
            {
                writer.WritePropertyName("topic"u8);
                writer.WriteStringValue(Topic);
            }
            writer.WriteEndObject();
        }
    }
}
