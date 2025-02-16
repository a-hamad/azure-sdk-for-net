// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedServiceBaseProperties : IUtf8JsonSerializable, IJsonModel<ManagedServiceBaseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServiceBaseProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedServiceBaseProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceBaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServiceBaseProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PlacementConstraints != null)
            {
                writer.WritePropertyName("placementConstraints"u8);
                writer.WriteStringValue(PlacementConstraints);
            }
            if (!(CorrelationScheme is ChangeTrackingList<ManagedServiceCorrelation> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("correlationScheme"u8);
                writer.WriteStartArray();
                foreach (var item in CorrelationScheme)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ServiceLoadMetrics is ChangeTrackingList<ManagedServiceLoadMetric> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("serviceLoadMetrics"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceLoadMetrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ServicePlacementPolicies is ChangeTrackingList<ManagedServicePlacementPolicy> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("servicePlacementPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ServicePlacementPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultMoveCost.HasValue)
            {
                writer.WritePropertyName("defaultMoveCost"u8);
                writer.WriteStringValue(DefaultMoveCost.Value.ToString());
            }
            if (!(ScalingPolicies is ChangeTrackingList<ManagedServiceScalingPolicy> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("scalingPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ScalingPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ManagedServiceBaseProperties IJsonModel<ManagedServiceBaseProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceBaseProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServiceBaseProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServiceBaseProperties(document.RootElement, options);
        }

        internal static ManagedServiceBaseProperties DeserializeManagedServiceBaseProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string placementConstraints = default;
            IList<ManagedServiceCorrelation> correlationScheme = default;
            IList<ManagedServiceLoadMetric> serviceLoadMetrics = default;
            IList<ManagedServicePlacementPolicy> servicePlacementPolicies = default;
            ServiceFabricManagedServiceMoveCost? defaultMoveCost = default;
            IList<ManagedServiceScalingPolicy> scalingPolicies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("placementConstraints"u8))
                {
                    placementConstraints = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationScheme"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServiceCorrelation> array = new List<ManagedServiceCorrelation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServiceCorrelation.DeserializeManagedServiceCorrelation(item, options));
                    }
                    correlationScheme = array;
                    continue;
                }
                if (property.NameEquals("serviceLoadMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServiceLoadMetric> array = new List<ManagedServiceLoadMetric>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServiceLoadMetric.DeserializeManagedServiceLoadMetric(item, options));
                    }
                    serviceLoadMetrics = array;
                    continue;
                }
                if (property.NameEquals("servicePlacementPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServicePlacementPolicy> array = new List<ManagedServicePlacementPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicePlacementPolicy.DeserializeManagedServicePlacementPolicy(item, options));
                    }
                    servicePlacementPolicies = array;
                    continue;
                }
                if (property.NameEquals("defaultMoveCost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultMoveCost = new ServiceFabricManagedServiceMoveCost(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scalingPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServiceScalingPolicy> array = new List<ManagedServiceScalingPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServiceScalingPolicy.DeserializeManagedServiceScalingPolicy(item, options));
                    }
                    scalingPolicies = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedServiceBaseProperties(
                placementConstraints,
                correlationScheme ?? new ChangeTrackingList<ManagedServiceCorrelation>(),
                serviceLoadMetrics ?? new ChangeTrackingList<ManagedServiceLoadMetric>(),
                servicePlacementPolicies ?? new ChangeTrackingList<ManagedServicePlacementPolicy>(),
                defaultMoveCost,
                scalingPolicies ?? new ChangeTrackingList<ManagedServiceScalingPolicy>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedServiceBaseProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceBaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedServiceBaseProperties)} does not support '{options.Format}' format.");
            }
        }

        ManagedServiceBaseProperties IPersistableModel<ManagedServiceBaseProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServiceBaseProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedServiceBaseProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedServiceBaseProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedServiceBaseProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
