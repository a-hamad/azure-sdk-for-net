// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityConnectorGitHubRepositoryProperties : IUtf8JsonSerializable, IJsonModel<SecurityConnectorGitHubRepositoryProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityConnectorGitHubRepositoryProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityConnectorGitHubRepositoryProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorGitHubRepositoryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityConnectorGitHubRepositoryProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningStatusMessage != null)
            {
                writer.WritePropertyName("provisioningStatusMessage"u8);
                writer.WriteStringValue(ProvisioningStatusMessage);
            }
            if (options.Format != "W" && ProvisioningStatusUpdateTimeUtc.HasValue)
            {
                writer.WritePropertyName("provisioningStatusUpdateTimeUtc"u8);
                writer.WriteStringValue(ProvisioningStatusUpdateTimeUtc.Value, "O");
            }
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && RepoId != null)
            {
                writer.WritePropertyName("repoId"u8);
                writer.WriteStringValue(RepoId);
            }
            if (options.Format != "W" && RepoName != null)
            {
                writer.WritePropertyName("repoName"u8);
                writer.WriteStringValue(RepoName);
            }
            if (options.Format != "W" && RepoFullName != null)
            {
                writer.WritePropertyName("repoFullName"u8);
                writer.WriteStringValue(RepoFullName);
            }
            if (OnboardingState.HasValue)
            {
                writer.WritePropertyName("onboardingState"u8);
                writer.WriteStringValue(OnboardingState.Value.ToString());
            }
            if (options.Format != "W" && RepoUri != null)
            {
                writer.WritePropertyName("repoUrl"u8);
                writer.WriteStringValue(RepoUri.AbsoluteUri);
            }
            if (ParentOwnerName != null)
            {
                writer.WritePropertyName("parentOwnerName"u8);
                writer.WriteStringValue(ParentOwnerName);
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

        SecurityConnectorGitHubRepositoryProperties IJsonModel<SecurityConnectorGitHubRepositoryProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorGitHubRepositoryProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityConnectorGitHubRepositoryProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityConnectorGitHubRepositoryProperties(document.RootElement, options);
        }

        internal static SecurityConnectorGitHubRepositoryProperties DeserializeSecurityConnectorGitHubRepositoryProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string provisioningStatusMessage = default;
            DateTimeOffset? provisioningStatusUpdateTimeUtc = default;
            DevOpsProvisioningState? provisioningState = default;
            string repoId = default;
            string repoName = default;
            string repoFullName = default;
            ResourceOnboardingState? onboardingState = default;
            Uri repoUrl = default;
            string parentOwnerName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningStatusMessage"u8))
                {
                    provisioningStatusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatusUpdateTimeUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatusUpdateTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DevOpsProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("repoId"u8))
                {
                    repoId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repoName"u8))
                {
                    repoName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repoFullName"u8))
                {
                    repoFullName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("onboardingState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onboardingState = new ResourceOnboardingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("repoUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repoUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parentOwnerName"u8))
                {
                    parentOwnerName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityConnectorGitHubRepositoryProperties(
                provisioningStatusMessage,
                provisioningStatusUpdateTimeUtc,
                provisioningState,
                repoId,
                repoName,
                repoFullName,
                onboardingState,
                repoUrl,
                parentOwnerName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityConnectorGitHubRepositoryProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorGitHubRepositoryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityConnectorGitHubRepositoryProperties)} does not support '{options.Format}' format.");
            }
        }

        SecurityConnectorGitHubRepositoryProperties IPersistableModel<SecurityConnectorGitHubRepositoryProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityConnectorGitHubRepositoryProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityConnectorGitHubRepositoryProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityConnectorGitHubRepositoryProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityConnectorGitHubRepositoryProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
