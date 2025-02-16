// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Grafana.Models
{
    public partial class MarketplaceTrialQuota : IUtf8JsonSerializable, IJsonModel<MarketplaceTrialQuota>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MarketplaceTrialQuota>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MarketplaceTrialQuota>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceTrialQuota>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceTrialQuota)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (AvailablePromotion.HasValue)
            {
                writer.WritePropertyName("availablePromotion"u8);
                writer.WriteStringValue(AvailablePromotion.Value.ToString());
            }
            if (GrafanaResourceId != null)
            {
                writer.WritePropertyName("grafanaResourceId"u8);
                writer.WriteStringValue(GrafanaResourceId);
            }
            if (TrialStartOn.HasValue)
            {
                writer.WritePropertyName("trialStartAt"u8);
                writer.WriteStringValue(TrialStartOn.Value, "O");
            }
            if (TrialEndOn.HasValue)
            {
                writer.WritePropertyName("trialEndAt"u8);
                writer.WriteStringValue(TrialEndOn.Value, "O");
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

        MarketplaceTrialQuota IJsonModel<MarketplaceTrialQuota>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceTrialQuota>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MarketplaceTrialQuota)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMarketplaceTrialQuota(document.RootElement, options);
        }

        internal static MarketplaceTrialQuota DeserializeMarketplaceTrialQuota(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AvailablePromotion? availablePromotion = default;
            ResourceIdentifier grafanaResourceId = default;
            DateTimeOffset? trialStartAt = default;
            DateTimeOffset? trialEndAt = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availablePromotion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availablePromotion = new AvailablePromotion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("grafanaResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    grafanaResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("trialStartAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trialStartAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("trialEndAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trialEndAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MarketplaceTrialQuota(availablePromotion, grafanaResourceId, trialStartAt, trialEndAt, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MarketplaceTrialQuota>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceTrialQuota>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MarketplaceTrialQuota)} does not support '{options.Format}' format.");
            }
        }

        MarketplaceTrialQuota IPersistableModel<MarketplaceTrialQuota>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MarketplaceTrialQuota>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMarketplaceTrialQuota(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MarketplaceTrialQuota)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MarketplaceTrialQuota>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
