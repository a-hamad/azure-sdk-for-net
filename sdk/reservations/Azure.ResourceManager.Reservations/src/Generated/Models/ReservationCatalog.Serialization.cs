// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationCatalog : IUtf8JsonSerializable, IJsonModel<ReservationCatalog>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationCatalog>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReservationCatalog>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationCatalog>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationCatalog)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && AppliedResourceType != null)
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(AppliedResourceType);
            }
            if (options.Format != "W" && SkuName != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(SkuName);
            }
            if (!(BillingPlans is ChangeTrackingDictionary<string, IList<ReservationBillingPlan>> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("billingPlans"u8);
                writer.WriteStartObject();
                foreach (var item in BillingPlans)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteStringValue(item0.ToString());
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && !(Terms is ChangeTrackingList<ReservationTerm> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("terms"u8);
                writer.WriteStartArray();
                foreach (var item in Terms)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(Locations is ChangeTrackingList<AzureLocation> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(SkuProperties is ChangeTrackingList<SkuProperty> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("skuProperties"u8);
                writer.WriteStartArray();
                foreach (var item in SkuProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Msrp != null)
            {
                writer.WritePropertyName("msrp"u8);
                writer.WriteObjectValue(Msrp);
            }
            if (options.Format != "W" && !(Restrictions is ChangeTrackingList<SkuRestriction> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("restrictions"u8);
                writer.WriteStartArray();
                foreach (var item in Restrictions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Tier != null)
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (options.Format != "W" && Size != null)
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            if (options.Format != "W" && !(Capabilities is ChangeTrackingList<SkuCapability> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
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

        ReservationCatalog IJsonModel<ReservationCatalog>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationCatalog>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationCatalog)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationCatalog(document.RootElement, options);
        }

        internal static ReservationCatalog DeserializeReservationCatalog(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceType = default;
            string name = default;
            IReadOnlyDictionary<string, IList<ReservationBillingPlan>> billingPlans = default;
            IReadOnlyList<ReservationTerm> terms = default;
            IReadOnlyList<AzureLocation> locations = default;
            IReadOnlyList<SkuProperty> skuProperties = default;
            ReservationCatalogMsrp msrp = default;
            IReadOnlyList<SkuRestriction> restrictions = default;
            string tier = default;
            string size = default;
            IReadOnlyList<SkuCapability> capabilities = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingPlans"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<ReservationBillingPlan>> dictionary = new Dictionary<string, IList<ReservationBillingPlan>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<ReservationBillingPlan> array = new List<ReservationBillingPlan>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ReservationBillingPlan(item.GetString()));
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    billingPlans = dictionary;
                    continue;
                }
                if (property.NameEquals("terms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReservationTerm> array = new List<ReservationTerm>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ReservationTerm(item.GetString()));
                    }
                    terms = array;
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("skuProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SkuProperty> array = new List<SkuProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SkuProperty.DeserializeSkuProperty(item, options));
                    }
                    skuProperties = array;
                    continue;
                }
                if (property.NameEquals("msrp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    msrp = ReservationCatalogMsrp.DeserializeReservationCatalogMsrp(property.Value, options);
                    continue;
                }
                if (property.NameEquals("restrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SkuRestriction> array = new List<SkuRestriction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SkuRestriction.DeserializeSkuRestriction(item, options));
                    }
                    restrictions = array;
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SkuCapability> array = new List<SkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SkuCapability.DeserializeSkuCapability(item, options));
                    }
                    capabilities = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReservationCatalog(
                resourceType,
                name,
                billingPlans ?? new ChangeTrackingDictionary<string, IList<ReservationBillingPlan>>(),
                terms ?? new ChangeTrackingList<ReservationTerm>(),
                locations ?? new ChangeTrackingList<AzureLocation>(),
                skuProperties ?? new ChangeTrackingList<SkuProperty>(),
                msrp,
                restrictions ?? new ChangeTrackingList<SkuRestriction>(),
                tier,
                size,
                capabilities ?? new ChangeTrackingList<SkuCapability>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationCatalog>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationCatalog>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationCatalog)} does not support '{options.Format}' format.");
            }
        }

        ReservationCatalog IPersistableModel<ReservationCatalog>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationCatalog>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationCatalog(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationCatalog)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationCatalog>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
