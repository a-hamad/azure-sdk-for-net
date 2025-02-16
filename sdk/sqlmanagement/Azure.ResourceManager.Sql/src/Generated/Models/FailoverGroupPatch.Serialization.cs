// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class FailoverGroupPatch : IUtf8JsonSerializable, IJsonModel<FailoverGroupPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FailoverGroupPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FailoverGroupPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverGroupPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ReadWriteEndpoint != null)
            {
                writer.WritePropertyName("readWriteEndpoint"u8);
                writer.WriteObjectValue(ReadWriteEndpoint);
            }
            if (ReadOnlyEndpoint != null)
            {
                writer.WritePropertyName("readOnlyEndpoint"u8);
                writer.WriteObjectValue(ReadOnlyEndpoint);
            }
            if (!(FailoverDatabases is ChangeTrackingList<ResourceIdentifier> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("databases"u8);
                writer.WriteStartArray();
                foreach (var item in FailoverDatabases)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(PartnerServers is ChangeTrackingList<PartnerServerInfo> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("partnerServers"u8);
                writer.WriteStartArray();
                foreach (var item in PartnerServers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        FailoverGroupPatch IJsonModel<FailoverGroupPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverGroupPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverGroupPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFailoverGroupPatch(document.RootElement, options);
        }

        internal static FailoverGroupPatch DeserializeFailoverGroupPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            FailoverGroupReadWriteEndpoint readWriteEndpoint = default;
            FailoverGroupReadOnlyEndpoint readOnlyEndpoint = default;
            IList<ResourceIdentifier> databases = default;
            IList<PartnerServerInfo> partnerServers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("readWriteEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readWriteEndpoint = FailoverGroupReadWriteEndpoint.DeserializeFailoverGroupReadWriteEndpoint(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("readOnlyEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readOnlyEndpoint = FailoverGroupReadOnlyEndpoint.DeserializeFailoverGroupReadOnlyEndpoint(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("databases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            databases = array;
                            continue;
                        }
                        if (property0.NameEquals("partnerServers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PartnerServerInfo> array = new List<PartnerServerInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PartnerServerInfo.DeserializePartnerServerInfo(item, options));
                            }
                            partnerServers = array;
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
            return new FailoverGroupPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                readWriteEndpoint,
                readOnlyEndpoint,
                databases ?? new ChangeTrackingList<ResourceIdentifier>(),
                partnerServers ?? new ChangeTrackingList<PartnerServerInfo>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FailoverGroupPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FailoverGroupPatch)} does not support '{options.Format}' format.");
            }
        }

        FailoverGroupPatch IPersistableModel<FailoverGroupPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverGroupPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFailoverGroupPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FailoverGroupPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FailoverGroupPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
