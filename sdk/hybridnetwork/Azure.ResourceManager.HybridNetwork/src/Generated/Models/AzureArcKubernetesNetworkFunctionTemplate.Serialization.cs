// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureArcKubernetesNetworkFunctionTemplate : IUtf8JsonSerializable, IJsonModel<AzureArcKubernetesNetworkFunctionTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureArcKubernetesNetworkFunctionTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureArcKubernetesNetworkFunctionTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureArcKubernetesNetworkFunctionTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(NetworkFunctionApplications is ChangeTrackingList<AzureArcKubernetesNetworkFunctionApplication> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("networkFunctionApplications"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkFunctionApplications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("nfviType"u8);
            writer.WriteStringValue(NfviType.ToString());
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

        AzureArcKubernetesNetworkFunctionTemplate IJsonModel<AzureArcKubernetesNetworkFunctionTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureArcKubernetesNetworkFunctionTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureArcKubernetesNetworkFunctionTemplate(document.RootElement, options);
        }

        internal static AzureArcKubernetesNetworkFunctionTemplate DeserializeAzureArcKubernetesNetworkFunctionTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AzureArcKubernetesNetworkFunctionApplication> networkFunctionApplications = default;
            ContainerizedNetworkFunctionNfviType nfviType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkFunctionApplications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureArcKubernetesNetworkFunctionApplication> array = new List<AzureArcKubernetesNetworkFunctionApplication>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureArcKubernetesNetworkFunctionApplication.DeserializeAzureArcKubernetesNetworkFunctionApplication(item, options));
                    }
                    networkFunctionApplications = array;
                    continue;
                }
                if (property.NameEquals("nfviType"u8))
                {
                    nfviType = new ContainerizedNetworkFunctionNfviType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureArcKubernetesNetworkFunctionTemplate(nfviType, serializedAdditionalRawData, networkFunctionApplications ?? new ChangeTrackingList<AzureArcKubernetesNetworkFunctionApplication>());
        }

        BinaryData IPersistableModel<AzureArcKubernetesNetworkFunctionTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureArcKubernetesNetworkFunctionTemplate)} does not support '{options.Format}' format.");
            }
        }

        AzureArcKubernetesNetworkFunctionTemplate IPersistableModel<AzureArcKubernetesNetworkFunctionTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureArcKubernetesNetworkFunctionTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureArcKubernetesNetworkFunctionTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureArcKubernetesNetworkFunctionTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
