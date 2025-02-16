// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryPrivateEndpointProperties : IUtf8JsonSerializable, IJsonModel<DataFactoryPrivateEndpointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryPrivateEndpointProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryPrivateEndpointProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryPrivateEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryPrivateEndpointProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ConnectionState != null)
            {
                writer.WritePropertyName("connectionState"u8);
                writer.WriteObjectValue(ConnectionState);
            }
            if (!(Fqdns is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("fqdns"u8);
                writer.WriteStartArray();
                foreach (var item in Fqdns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (GroupId != null)
            {
                writer.WritePropertyName("groupId"u8);
                writer.WriteStringValue(GroupId);
            }
            if (options.Format != "W" && IsReserved.HasValue)
            {
                writer.WritePropertyName("isReserved"u8);
                writer.WriteBooleanValue(IsReserved.Value);
            }
            if (PrivateLinkResourceId != null)
            {
                writer.WritePropertyName("privateLinkResourceId"u8);
                writer.WriteStringValue(PrivateLinkResourceId);
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DataFactoryPrivateEndpointProperties IJsonModel<DataFactoryPrivateEndpointProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryPrivateEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryPrivateEndpointProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryPrivateEndpointProperties(document.RootElement, options);
        }

        internal static DataFactoryPrivateEndpointProperties DeserializeDataFactoryPrivateEndpointProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ConnectionStateProperties connectionState = default;
            IList<string> fqdns = default;
            string groupId = default;
            bool? isReserved = default;
            ResourceIdentifier privateLinkResourceId = default;
            string provisioningState = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionState = ConnectionStateProperties.DeserializeConnectionStateProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("fqdns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fqdns = array;
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isReserved"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isReserved = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("privateLinkResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryPrivateEndpointProperties(
                connectionState,
                fqdns ?? new ChangeTrackingList<string>(),
                groupId,
                isReserved,
                privateLinkResourceId,
                provisioningState,
                additionalProperties);
        }

        BinaryData IPersistableModel<DataFactoryPrivateEndpointProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryPrivateEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryPrivateEndpointProperties)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryPrivateEndpointProperties IPersistableModel<DataFactoryPrivateEndpointProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryPrivateEndpointProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryPrivateEndpointProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryPrivateEndpointProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryPrivateEndpointProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
