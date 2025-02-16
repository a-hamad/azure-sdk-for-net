// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PrivateDns.Models
{
    public partial class PrivateDnsMXRecordInfo : IUtf8JsonSerializable, IJsonModel<PrivateDnsMXRecordInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateDnsMXRecordInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PrivateDnsMXRecordInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsMXRecordInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateDnsMXRecordInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Preference.HasValue)
            {
                writer.WritePropertyName("preference"u8);
                writer.WriteNumberValue(Preference.Value);
            }
            if (Exchange != null)
            {
                writer.WritePropertyName("exchange"u8);
                writer.WriteStringValue(Exchange);
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

        PrivateDnsMXRecordInfo IJsonModel<PrivateDnsMXRecordInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsMXRecordInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateDnsMXRecordInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateDnsMXRecordInfo(document.RootElement, options);
        }

        internal static PrivateDnsMXRecordInfo DeserializePrivateDnsMXRecordInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? preference = default;
            string exchange = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preference = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exchange"u8))
                {
                    exchange = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PrivateDnsMXRecordInfo(preference, exchange, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PrivateDnsMXRecordInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsMXRecordInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PrivateDnsMXRecordInfo)} does not support '{options.Format}' format.");
            }
        }

        PrivateDnsMXRecordInfo IPersistableModel<PrivateDnsMXRecordInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsMXRecordInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateDnsMXRecordInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateDnsMXRecordInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateDnsMXRecordInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
