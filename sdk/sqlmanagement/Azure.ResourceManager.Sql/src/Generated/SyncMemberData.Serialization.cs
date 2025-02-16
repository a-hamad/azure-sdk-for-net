// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SyncMemberData : IUtf8JsonSerializable, IJsonModel<SyncMemberData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SyncMemberData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SyncMemberData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMemberData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncMemberData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (DatabaseType.HasValue)
            {
                writer.WritePropertyName("databaseType"u8);
                writer.WriteStringValue(DatabaseType.Value.ToString());
            }
            if (SyncAgentId != null)
            {
                writer.WritePropertyName("syncAgentId"u8);
                writer.WriteStringValue(SyncAgentId);
            }
            if (SqlServerDatabaseId.HasValue)
            {
                writer.WritePropertyName("sqlServerDatabaseId"u8);
                writer.WriteStringValue(SqlServerDatabaseId.Value);
            }
            if (SyncMemberAzureDatabaseResourceId != null)
            {
                writer.WritePropertyName("syncMemberAzureDatabaseResourceId"u8);
                writer.WriteStringValue(SyncMemberAzureDatabaseResourceId);
            }
            if (UsePrivateLinkConnection.HasValue)
            {
                writer.WritePropertyName("usePrivateLinkConnection"u8);
                writer.WriteBooleanValue(UsePrivateLinkConnection.Value);
            }
            if (options.Format != "W" && PrivateEndpointName != null)
            {
                writer.WritePropertyName("privateEndpointName"u8);
                writer.WriteStringValue(PrivateEndpointName);
            }
            if (ServerName != null)
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (DatabaseName != null)
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (UserName != null)
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (SyncDirection.HasValue)
            {
                writer.WritePropertyName("syncDirection"u8);
                writer.WriteStringValue(SyncDirection.Value.ToString());
            }
            if (options.Format != "W" && SyncState.HasValue)
            {
                writer.WritePropertyName("syncState"u8);
                writer.WriteStringValue(SyncState.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SyncMemberData IJsonModel<SyncMemberData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMemberData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SyncMemberData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncMemberData(document.RootElement, options);
        }

        internal static SyncMemberData DeserializeSyncMemberData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            SyncMemberDbType? databaseType = default;
            ResourceIdentifier syncAgentId = default;
            Guid? sqlServerDatabaseId = default;
            ResourceIdentifier syncMemberAzureDatabaseResourceId = default;
            bool? usePrivateLinkConnection = default;
            string privateEndpointName = default;
            string serverName = default;
            string databaseName = default;
            string userName = default;
            string password = default;
            SyncDirection? syncDirection = default;
            SyncMemberState? syncState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("databaseType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            databaseType = new SyncMemberDbType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("syncAgentId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncAgentId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sqlServerDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sqlServerDatabaseId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("syncMemberAzureDatabaseResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncMemberAzureDatabaseResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("usePrivateLinkConnection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePrivateLinkConnection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointName"u8))
                        {
                            privateEndpointName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("syncDirection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncDirection = new SyncDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("syncState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncState = new SyncMemberState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SyncMemberData(
                id,
                name,
                type,
                systemData,
                databaseType,
                syncAgentId,
                sqlServerDatabaseId,
                syncMemberAzureDatabaseResourceId,
                usePrivateLinkConnection,
                privateEndpointName,
                serverName,
                databaseName,
                userName,
                password,
                syncDirection,
                syncState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SyncMemberData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMemberData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SyncMemberData)} does not support '{options.Format}' format.");
            }
        }

        SyncMemberData IPersistableModel<SyncMemberData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SyncMemberData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSyncMemberData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SyncMemberData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SyncMemberData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
