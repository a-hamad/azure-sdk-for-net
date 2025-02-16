// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class ShingleTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (MaxShingleSize.HasValue)
            {
                writer.WritePropertyName("maxShingleSize"u8);
                writer.WriteNumberValue(MaxShingleSize.Value);
            }
            if (MinShingleSize.HasValue)
            {
                writer.WritePropertyName("minShingleSize"u8);
                writer.WriteNumberValue(MinShingleSize.Value);
            }
            if (OutputUnigrams.HasValue)
            {
                writer.WritePropertyName("outputUnigrams"u8);
                writer.WriteBooleanValue(OutputUnigrams.Value);
            }
            if (OutputUnigramsIfNoShingles.HasValue)
            {
                writer.WritePropertyName("outputUnigramsIfNoShingles"u8);
                writer.WriteBooleanValue(OutputUnigramsIfNoShingles.Value);
            }
            if (TokenSeparator != null)
            {
                writer.WritePropertyName("tokenSeparator"u8);
                writer.WriteStringValue(TokenSeparator);
            }
            if (FilterToken != null)
            {
                writer.WritePropertyName("filterToken"u8);
                writer.WriteStringValue(FilterToken);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static ShingleTokenFilter DeserializeShingleTokenFilter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? maxShingleSize = default;
            int? minShingleSize = default;
            bool? outputUnigrams = default;
            bool? outputUnigramsIfNoShingles = default;
            string tokenSeparator = default;
            string filterToken = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxShingleSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxShingleSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minShingleSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minShingleSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("outputUnigrams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputUnigrams = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("outputUnigramsIfNoShingles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputUnigramsIfNoShingles = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tokenSeparator"u8))
                {
                    tokenSeparator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filterToken"u8))
                {
                    filterToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new ShingleTokenFilter(
                odataType,
                name,
                maxShingleSize,
                minShingleSize,
                outputUnigrams,
                outputUnigramsIfNoShingles,
                tokenSeparator,
                filterToken);
        }
    }
}
