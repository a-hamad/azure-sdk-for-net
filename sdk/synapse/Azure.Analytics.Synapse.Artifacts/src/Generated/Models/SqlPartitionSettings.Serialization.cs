// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SqlPartitionSettingsConverter))]
    public partial class SqlPartitionSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PartitionColumnName != null)
            {
                writer.WritePropertyName("partitionColumnName"u8);
                writer.WriteObjectValue(PartitionColumnName);
            }
            if (PartitionUpperBound != null)
            {
                writer.WritePropertyName("partitionUpperBound"u8);
                writer.WriteObjectValue(PartitionUpperBound);
            }
            if (PartitionLowerBound != null)
            {
                writer.WritePropertyName("partitionLowerBound"u8);
                writer.WriteObjectValue(PartitionLowerBound);
            }
            writer.WriteEndObject();
        }

        internal static SqlPartitionSettings DeserializeSqlPartitionSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            object partitionColumnName = default;
            object partitionUpperBound = default;
            object partitionLowerBound = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionColumnName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionColumnName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionUpperBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionUpperBound = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionLowerBound"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionLowerBound = property.Value.GetObject();
                    continue;
                }
            }
            return new SqlPartitionSettings(partitionColumnName, partitionUpperBound, partitionLowerBound);
        }

        internal partial class SqlPartitionSettingsConverter : JsonConverter<SqlPartitionSettings>
        {
            public override void Write(Utf8JsonWriter writer, SqlPartitionSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SqlPartitionSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSqlPartitionSettings(document.RootElement);
            }
        }
    }
}
