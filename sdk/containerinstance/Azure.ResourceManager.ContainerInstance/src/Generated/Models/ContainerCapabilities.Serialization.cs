// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerCapabilities : IUtf8JsonSerializable, IJsonModel<ContainerCapabilities>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerCapabilities>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerCapabilities>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerCapabilities)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ResourceType != null)
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && OSType != null)
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (options.Format != "W" && Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && IPAddressType != null)
            {
                writer.WritePropertyName("ipAddressType"u8);
                writer.WriteStringValue(IPAddressType);
            }
            if (options.Format != "W" && Gpu != null)
            {
                writer.WritePropertyName("gpu"u8);
                writer.WriteStringValue(Gpu);
            }
            if (options.Format != "W" && Capabilities != null)
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteObjectValue(Capabilities);
            }
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

        ContainerCapabilities IJsonModel<ContainerCapabilities>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerCapabilities)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerCapabilities(document.RootElement, options);
        }

        internal static ContainerCapabilities DeserializeContainerCapabilities(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceType = default;
            string osType = default;
            AzureLocation? location = default;
            string ipAddressType = default;
            string gpu = default;
            ContainerSupportedCapabilities capabilities = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipAddressType"u8))
                {
                    ipAddressType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gpu"u8))
                {
                    gpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capabilities = ContainerSupportedCapabilities.DeserializeContainerSupportedCapabilities(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerCapabilities(
                resourceType,
                osType,
                location,
                ipAddressType,
                gpu,
                capabilities,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerCapabilities>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerCapabilities)} does not support '{options.Format}' format.");
            }
        }

        ContainerCapabilities IPersistableModel<ContainerCapabilities>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerCapabilities(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerCapabilities)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerCapabilities>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
