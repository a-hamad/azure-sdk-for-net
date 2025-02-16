// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers
{
    internal partial class PhoneNumberPurchaseRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (SearchId != null)
            {
                writer.WritePropertyName("searchId"u8);
                writer.WriteStringValue(SearchId);
            }
            writer.WriteEndObject();
        }
    }
}
