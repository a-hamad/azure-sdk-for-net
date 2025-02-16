// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureTableParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ConnectionString != null)
            {
                if (ConnectionString != null)
                {
                    writer.WritePropertyName("connectionString"u8);
                    writer.WriteStringValue(ConnectionString);
                }
                else
                {
                    writer.WriteNull("connectionString");
                }
            }
            if (Table != null)
            {
                writer.WritePropertyName("table"u8);
                writer.WriteStringValue(Table);
            }
            else
            {
                writer.WriteNull("table");
            }
            if (Query != null)
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            else
            {
                writer.WriteNull("query");
            }
            writer.WriteEndObject();
        }

        internal static AzureTableParameter DeserializeAzureTableParameter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string connectionString = default;
            string table = default;
            string query = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionString"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        connectionString = null;
                        continue;
                    }
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("table"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        table = null;
                        continue;
                    }
                    table = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("query"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        query = null;
                        continue;
                    }
                    query = property.Value.GetString();
                    continue;
                }
            }
            return new AzureTableParameter(connectionString, table, query);
        }
    }
}
