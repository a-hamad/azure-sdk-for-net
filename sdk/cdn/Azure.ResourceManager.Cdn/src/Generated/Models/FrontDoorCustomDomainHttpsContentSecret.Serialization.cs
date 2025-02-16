// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class FrontDoorCustomDomainHttpsContentSecret : IUtf8JsonSerializable, IJsonModel<FrontDoorCustomDomainHttpsContentSecret>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FrontDoorCustomDomainHttpsContentSecret>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FrontDoorCustomDomainHttpsContentSecret>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorCustomDomainHttpsContentSecret>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorCustomDomainHttpsContentSecret)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
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

        FrontDoorCustomDomainHttpsContentSecret IJsonModel<FrontDoorCustomDomainHttpsContentSecret>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorCustomDomainHttpsContentSecret>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FrontDoorCustomDomainHttpsContentSecret)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFrontDoorCustomDomainHttpsContentSecret(document.RootElement, options);
        }

        internal static FrontDoorCustomDomainHttpsContentSecret DeserializeFrontDoorCustomDomainHttpsContentSecret(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FrontDoorCustomDomainHttpsContentSecret(id, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FrontDoorCustomDomainHttpsContentSecret>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorCustomDomainHttpsContentSecret>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FrontDoorCustomDomainHttpsContentSecret)} does not support '{options.Format}' format.");
            }
        }

        FrontDoorCustomDomainHttpsContentSecret IPersistableModel<FrontDoorCustomDomainHttpsContentSecret>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FrontDoorCustomDomainHttpsContentSecret>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFrontDoorCustomDomainHttpsContentSecret(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FrontDoorCustomDomainHttpsContentSecret)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FrontDoorCustomDomainHttpsContentSecret>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
