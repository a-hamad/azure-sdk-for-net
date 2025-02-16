// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightApplicationProperties : IUtf8JsonSerializable, IJsonModel<HDInsightApplicationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightApplicationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightApplicationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightApplicationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightApplicationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ComputeProfile != null)
            {
                writer.WritePropertyName("computeProfile"u8);
                writer.WriteObjectValue(ComputeProfile);
            }
            if (!(InstallScriptActions is ChangeTrackingList<RuntimeScriptAction> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("installScriptActions"u8);
                writer.WriteStartArray();
                foreach (var item in InstallScriptActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(UninstallScriptActions is ChangeTrackingList<RuntimeScriptAction> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("uninstallScriptActions"u8);
                writer.WriteStartArray();
                foreach (var item in UninstallScriptActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(HttpsEndpoints is ChangeTrackingList<HDInsightApplicationHttpsEndpoint> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("httpsEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in HttpsEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(SshEndpoints is ChangeTrackingList<HDInsightApplicationEndpoint> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("sshEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in SshEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (ApplicationType != null)
            {
                writer.WritePropertyName("applicationType"u8);
                writer.WriteStringValue(ApplicationType);
            }
            if (options.Format != "W" && ApplicationState != null)
            {
                writer.WritePropertyName("applicationState"u8);
                writer.WriteStringValue(ApplicationState);
            }
            if (!(Errors is ChangeTrackingList<ResponseError> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && MarketplaceIdentifier != null)
            {
                writer.WritePropertyName("marketplaceIdentifier"u8);
                writer.WriteStringValue(MarketplaceIdentifier);
            }
            if (!(PrivateLinkConfigurations is ChangeTrackingList<HDInsightPrivateLinkConfiguration> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("privateLinkConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateLinkConfigurations)
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

        HDInsightApplicationProperties IJsonModel<HDInsightApplicationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightApplicationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightApplicationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightApplicationProperties(document.RootElement, options);
        }

        internal static HDInsightApplicationProperties DeserializeHDInsightApplicationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ComputeProfile computeProfile = default;
            IList<RuntimeScriptAction> installScriptActions = default;
            IList<RuntimeScriptAction> uninstallScriptActions = default;
            IList<HDInsightApplicationHttpsEndpoint> httpsEndpoints = default;
            IList<HDInsightApplicationEndpoint> sshEndpoints = default;
            string provisioningState = default;
            string applicationType = default;
            string applicationState = default;
            IList<ResponseError> errors = default;
            DateTimeOffset? createdDate = default;
            string marketplaceIdentifier = default;
            IList<HDInsightPrivateLinkConfiguration> privateLinkConfigurations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("computeProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeProfile = ComputeProfile.DeserializeComputeProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("installScriptActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RuntimeScriptAction> array = new List<RuntimeScriptAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RuntimeScriptAction.DeserializeRuntimeScriptAction(item, options));
                    }
                    installScriptActions = array;
                    continue;
                }
                if (property.NameEquals("uninstallScriptActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RuntimeScriptAction> array = new List<RuntimeScriptAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RuntimeScriptAction.DeserializeRuntimeScriptAction(item, options));
                    }
                    uninstallScriptActions = array;
                    continue;
                }
                if (property.NameEquals("httpsEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightApplicationHttpsEndpoint> array = new List<HDInsightApplicationHttpsEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightApplicationHttpsEndpoint.DeserializeHDInsightApplicationHttpsEndpoint(item, options));
                    }
                    httpsEndpoints = array;
                    continue;
                }
                if (property.NameEquals("sshEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightApplicationEndpoint> array = new List<HDInsightApplicationEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightApplicationEndpoint.DeserializeHDInsightApplicationEndpoint(item, options));
                    }
                    sshEndpoints = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationType"u8))
                {
                    applicationType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationState"u8))
                {
                    applicationState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResponseError> array = new List<ResponseError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<ResponseError>(item.GetRawText()));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("createdDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("marketplaceIdentifier"u8))
                {
                    marketplaceIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateLinkConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightPrivateLinkConfiguration> array = new List<HDInsightPrivateLinkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightPrivateLinkConfiguration.DeserializeHDInsightPrivateLinkConfiguration(item, options));
                    }
                    privateLinkConfigurations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightApplicationProperties(
                computeProfile,
                installScriptActions ?? new ChangeTrackingList<RuntimeScriptAction>(),
                uninstallScriptActions ?? new ChangeTrackingList<RuntimeScriptAction>(),
                httpsEndpoints ?? new ChangeTrackingList<HDInsightApplicationHttpsEndpoint>(),
                sshEndpoints ?? new ChangeTrackingList<HDInsightApplicationEndpoint>(),
                provisioningState,
                applicationType,
                applicationState,
                errors ?? new ChangeTrackingList<ResponseError>(),
                createdDate,
                marketplaceIdentifier,
                privateLinkConfigurations ?? new ChangeTrackingList<HDInsightPrivateLinkConfiguration>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightApplicationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightApplicationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightApplicationProperties)} does not support '{options.Format}' format.");
            }
        }

        HDInsightApplicationProperties IPersistableModel<HDInsightApplicationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightApplicationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightApplicationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightApplicationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightApplicationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
