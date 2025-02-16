// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class VaultPropertiesEncryption : IUtf8JsonSerializable, IJsonModel<VaultPropertiesEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VaultPropertiesEncryption>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VaultPropertiesEncryption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultPropertiesEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VaultPropertiesEncryption)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (KeyVaultProperties != null)
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                writer.WriteObjectValue(KeyVaultProperties);
            }
            if (KekIdentity != null)
            {
                writer.WritePropertyName("kekIdentity"u8);
                writer.WriteObjectValue(KekIdentity);
            }
            if (InfrastructureEncryption.HasValue)
            {
                writer.WritePropertyName("infrastructureEncryption"u8);
                writer.WriteStringValue(InfrastructureEncryption.Value.ToString());
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

        VaultPropertiesEncryption IJsonModel<VaultPropertiesEncryption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultPropertiesEncryption>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VaultPropertiesEncryption)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVaultPropertiesEncryption(document.RootElement, options);
        }

        internal static VaultPropertiesEncryption DeserializeVaultPropertiesEncryption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CmkKeyVaultProperties keyVaultProperties = default;
            CmkKekIdentity kekIdentity = default;
            InfrastructureEncryptionState? infrastructureEncryption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultProperties = CmkKeyVaultProperties.DeserializeCmkKeyVaultProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kekIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kekIdentity = CmkKekIdentity.DeserializeCmkKekIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("infrastructureEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureEncryption = new InfrastructureEncryptionState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VaultPropertiesEncryption(keyVaultProperties, kekIdentity, infrastructureEncryption, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VaultPropertiesEncryption>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultPropertiesEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VaultPropertiesEncryption)} does not support '{options.Format}' format.");
            }
        }

        VaultPropertiesEncryption IPersistableModel<VaultPropertiesEncryption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VaultPropertiesEncryption>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVaultPropertiesEncryption(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VaultPropertiesEncryption)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VaultPropertiesEncryption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
