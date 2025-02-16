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
    public partial class ThresholdRuleCondition : IUtf8JsonSerializable, IJsonModel<ThresholdRuleCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThresholdRuleCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ThresholdRuleCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThresholdRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThresholdRuleCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(Operator.ToSerialString());
            writer.WritePropertyName("threshold"u8);
            writer.WriteNumberValue(Threshold);
            if (WindowSize.HasValue)
            {
                writer.WritePropertyName("windowSize"u8);
                writer.WriteStringValue(WindowSize.Value, "P");
            }
            if (TimeAggregation.HasValue)
            {
                writer.WritePropertyName("timeAggregation"u8);
                writer.WriteStringValue(TimeAggregation.Value.ToSerialString());
            }
            writer.WritePropertyName("odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (DataSource != null)
            {
                writer.WritePropertyName("dataSource"u8);
                writer.WriteObjectValue(DataSource);
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

        ThresholdRuleCondition IJsonModel<ThresholdRuleCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThresholdRuleCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThresholdRuleCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThresholdRuleCondition(document.RootElement, options);
        }

        internal static ThresholdRuleCondition DeserializeThresholdRuleCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitorConditionOperator @operator = default;
            double threshold = default;
            TimeSpan? windowSize = default;
            ThresholdRuleConditionTimeAggregationType? timeAggregation = default;
            string odataType = default;
            RuleDataSource dataSource = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operator"u8))
                {
                    @operator = property.Value.GetString().ToMonitorConditionOperator();
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    threshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("windowSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("timeAggregation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeAggregation = property.Value.GetString().ToThresholdRuleConditionTimeAggregationType();
                    continue;
                }
                if (property.NameEquals("odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSource = RuleDataSource.DeserializeRuleDataSource(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ThresholdRuleCondition(
                odataType,
                dataSource,
                serializedAdditionalRawData,
                @operator,
                threshold,
                windowSize,
                timeAggregation);
        }

        BinaryData IPersistableModel<ThresholdRuleCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThresholdRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ThresholdRuleCondition)} does not support '{options.Format}' format.");
            }
        }

        ThresholdRuleCondition IPersistableModel<ThresholdRuleCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThresholdRuleCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeThresholdRuleCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThresholdRuleCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThresholdRuleCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
