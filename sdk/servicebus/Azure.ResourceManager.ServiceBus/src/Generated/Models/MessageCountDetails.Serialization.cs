// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class MessageCountDetails : IUtf8JsonSerializable, IJsonModel<MessageCountDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MessageCountDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MessageCountDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageCountDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageCountDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ActiveMessageCount.HasValue)
            {
                writer.WritePropertyName("activeMessageCount"u8);
                writer.WriteNumberValue(ActiveMessageCount.Value);
            }
            if (options.Format != "W" && DeadLetterMessageCount.HasValue)
            {
                writer.WritePropertyName("deadLetterMessageCount"u8);
                writer.WriteNumberValue(DeadLetterMessageCount.Value);
            }
            if (options.Format != "W" && ScheduledMessageCount.HasValue)
            {
                writer.WritePropertyName("scheduledMessageCount"u8);
                writer.WriteNumberValue(ScheduledMessageCount.Value);
            }
            if (options.Format != "W" && TransferMessageCount.HasValue)
            {
                writer.WritePropertyName("transferMessageCount"u8);
                writer.WriteNumberValue(TransferMessageCount.Value);
            }
            if (options.Format != "W" && TransferDeadLetterMessageCount.HasValue)
            {
                writer.WritePropertyName("transferDeadLetterMessageCount"u8);
                writer.WriteNumberValue(TransferDeadLetterMessageCount.Value);
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

        MessageCountDetails IJsonModel<MessageCountDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageCountDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageCountDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMessageCountDetails(document.RootElement, options);
        }

        internal static MessageCountDetails DeserializeMessageCountDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? activeMessageCount = default;
            long? deadLetterMessageCount = default;
            long? scheduledMessageCount = default;
            long? transferMessageCount = default;
            long? transferDeadLetterMessageCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activeMessageCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("deadLetterMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deadLetterMessageCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("scheduledMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledMessageCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transferMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferMessageCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("transferDeadLetterMessageCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transferDeadLetterMessageCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MessageCountDetails(
                activeMessageCount,
                deadLetterMessageCount,
                scheduledMessageCount,
                transferMessageCount,
                transferDeadLetterMessageCount,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MessageCountDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageCountDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MessageCountDetails)} does not support '{options.Format}' format.");
            }
        }

        MessageCountDetails IPersistableModel<MessageCountDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageCountDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMessageCountDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MessageCountDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MessageCountDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
