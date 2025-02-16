// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class LivePipelineProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (TopologyName != null)
            {
                writer.WritePropertyName("topologyName"u8);
                writer.WriteStringValue(TopologyName);
            }
            if (!(Parameters is ChangeTrackingList<ParameterDefinition> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static LivePipelineProperties DeserializeLivePipelineProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string description = default;
            string topologyName = default;
            IList<ParameterDefinition> parameters = default;
            LivePipelineState? state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("topologyName"u8))
                {
                    topologyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ParameterDefinition> array = new List<ParameterDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ParameterDefinition.DeserializeParameterDefinition(item));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new LivePipelineState(property.Value.GetString());
                    continue;
                }
            }
            return new LivePipelineProperties(description, topologyName, parameters ?? new ChangeTrackingList<ParameterDefinition>(), state);
        }
    }
}
