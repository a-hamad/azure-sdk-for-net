// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class StartStopManagedInstanceScheduleListResult : IUtf8JsonSerializable, IJsonModel<StartStopManagedInstanceScheduleListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StartStopManagedInstanceScheduleListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StartStopManagedInstanceScheduleListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StartStopManagedInstanceScheduleListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StartStopManagedInstanceScheduleListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(Value is ChangeTrackingList<ManagedInstanceStartStopScheduleData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && NextLink != null)
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        StartStopManagedInstanceScheduleListResult IJsonModel<StartStopManagedInstanceScheduleListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StartStopManagedInstanceScheduleListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StartStopManagedInstanceScheduleListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStartStopManagedInstanceScheduleListResult(document.RootElement, options);
        }

        internal static StartStopManagedInstanceScheduleListResult DeserializeStartStopManagedInstanceScheduleListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ManagedInstanceStartStopScheduleData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedInstanceStartStopScheduleData> array = new List<ManagedInstanceStartStopScheduleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstanceStartStopScheduleData.DeserializeManagedInstanceStartStopScheduleData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StartStopManagedInstanceScheduleListResult(value ?? new ChangeTrackingList<ManagedInstanceStartStopScheduleData>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StartStopManagedInstanceScheduleListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StartStopManagedInstanceScheduleListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StartStopManagedInstanceScheduleListResult)} does not support '{options.Format}' format.");
            }
        }

        StartStopManagedInstanceScheduleListResult IPersistableModel<StartStopManagedInstanceScheduleListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StartStopManagedInstanceScheduleListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStartStopManagedInstanceScheduleListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StartStopManagedInstanceScheduleListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StartStopManagedInstanceScheduleListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
