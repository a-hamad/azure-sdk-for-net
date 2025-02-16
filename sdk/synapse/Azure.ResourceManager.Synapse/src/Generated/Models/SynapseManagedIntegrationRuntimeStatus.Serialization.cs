// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseManagedIntegrationRuntimeStatus : IUtf8JsonSerializable, IJsonModel<SynapseManagedIntegrationRuntimeStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseManagedIntegrationRuntimeStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseManagedIntegrationRuntimeStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RuntimeType.ToString());
            if (options.Format != "W" && DataFactoryName != null)
            {
                writer.WritePropertyName("dataFactoryName"u8);
                writer.WriteStringValue(DataFactoryName);
            }
            if (options.Format != "W" && State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && CreateOn.HasValue)
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteStringValue(CreateOn.Value, "O");
            }
            if (options.Format != "W" && !(Nodes is ChangeTrackingList<SynapseManagedIntegrationRuntimeNode> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("nodes"u8);
                writer.WriteStartArray();
                foreach (var item in Nodes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(OtherErrors is ChangeTrackingList<SynapseManagedIntegrationRuntimeError> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("otherErrors"u8);
                writer.WriteStartArray();
                foreach (var item in OtherErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && LastOperation != null)
            {
                writer.WritePropertyName("lastOperation"u8);
                writer.WriteObjectValue(LastOperation);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SynapseManagedIntegrationRuntimeStatus IJsonModel<SynapseManagedIntegrationRuntimeStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseManagedIntegrationRuntimeStatus(document.RootElement, options);
        }

        internal static SynapseManagedIntegrationRuntimeStatus DeserializeSynapseManagedIntegrationRuntimeStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            string dataFactoryName = default;
            SynapseIntegrationRuntimeState? state = default;
            DateTimeOffset? createTime = default;
            IReadOnlyList<SynapseManagedIntegrationRuntimeNode> nodes = default;
            IReadOnlyList<SynapseManagedIntegrationRuntimeError> otherErrors = default;
            SynapseManagedIntegrationRuntimeOperationResult lastOperation = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFactoryName"u8))
                {
                    dataFactoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SynapseIntegrationRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("nodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SynapseManagedIntegrationRuntimeNode> array = new List<SynapseManagedIntegrationRuntimeNode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SynapseManagedIntegrationRuntimeNode.DeserializeSynapseManagedIntegrationRuntimeNode(item, options));
                            }
                            nodes = array;
                            continue;
                        }
                        if (property0.NameEquals("otherErrors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SynapseManagedIntegrationRuntimeError> array = new List<SynapseManagedIntegrationRuntimeError>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SynapseManagedIntegrationRuntimeError.DeserializeSynapseManagedIntegrationRuntimeError(item, options));
                            }
                            otherErrors = array;
                            continue;
                        }
                        if (property0.NameEquals("lastOperation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastOperation = SynapseManagedIntegrationRuntimeOperationResult.DeserializeSynapseManagedIntegrationRuntimeOperationResult(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseManagedIntegrationRuntimeStatus(
                type,
                dataFactoryName,
                state,
                additionalProperties,
                createTime,
                nodes ?? new ChangeTrackingList<SynapseManagedIntegrationRuntimeNode>(),
                otherErrors ?? new ChangeTrackingList<SynapseManagedIntegrationRuntimeError>(),
                lastOperation);
        }

        BinaryData IPersistableModel<SynapseManagedIntegrationRuntimeStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeStatus)} does not support '{options.Format}' format.");
            }
        }

        SynapseManagedIntegrationRuntimeStatus IPersistableModel<SynapseManagedIntegrationRuntimeStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseManagedIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseManagedIntegrationRuntimeStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseManagedIntegrationRuntimeStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseManagedIntegrationRuntimeStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
