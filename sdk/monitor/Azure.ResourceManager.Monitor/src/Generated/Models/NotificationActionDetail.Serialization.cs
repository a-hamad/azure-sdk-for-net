// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class NotificationActionDetail : IUtf8JsonSerializable, IJsonModel<NotificationActionDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationActionDetail>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NotificationActionDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationActionDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationActionDetail)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MechanismType != null)
            {
                writer.WritePropertyName("MechanismType"u8);
                writer.WriteStringValue(MechanismType);
            }
            if (Name != null)
            {
                writer.WritePropertyName("Name"u8);
                writer.WriteStringValue(Name);
            }
            if (Status != null)
            {
                writer.WritePropertyName("Status"u8);
                writer.WriteStringValue(Status);
            }
            if (SubState != null)
            {
                writer.WritePropertyName("SubState"u8);
                writer.WriteStringValue(SubState);
            }
            if (SendOn.HasValue)
            {
                writer.WritePropertyName("SendTime"u8);
                writer.WriteStringValue(SendOn.Value, "O");
            }
            if (Detail != null)
            {
                writer.WritePropertyName("Detail"u8);
                writer.WriteStringValue(Detail);
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

        NotificationActionDetail IJsonModel<NotificationActionDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationActionDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationActionDetail)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationActionDetail(document.RootElement, options);
        }

        internal static NotificationActionDetail DeserializeNotificationActionDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string mechanismType = default;
            string name = default;
            string status = default;
            string subState = default;
            DateTimeOffset? sendTime = default;
            string detail = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("MechanismType"u8))
                {
                    mechanismType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("SubState"u8))
                {
                    subState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("SendTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("Detail"u8))
                {
                    detail = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NotificationActionDetail(
                mechanismType,
                name,
                status,
                subState,
                sendTime,
                detail,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NotificationActionDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationActionDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NotificationActionDetail)} does not support '{options.Format}' format.");
            }
        }

        NotificationActionDetail IPersistableModel<NotificationActionDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationActionDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNotificationActionDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NotificationActionDetail)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NotificationActionDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
