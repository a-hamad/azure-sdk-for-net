// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing the CdnWebApplicationFirewallPolicy data model.
    /// Defines web application firewall policy for Azure CDN.
    /// </summary>
    public partial class CdnWebApplicationFirewallPolicyData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CdnWebApplicationFirewallPolicyData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public CdnWebApplicationFirewallPolicyData(AzureLocation location, CdnSku sku) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
            EndpointLinks = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="CdnWebApplicationFirewallPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> Gets a unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="sku"> The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy. </param>
        /// <param name="policySettings"> Describes  policySettings for policy. </param>
        /// <param name="rateLimitSettings"> Describes rate limit rules inside the policy. </param>
        /// <param name="customSettings"> Describes custom rules inside the policy. </param>
        /// <param name="managedRules"> Describes managed rules inside the policy. </param>
        /// <param name="endpointLinks"> Describes Azure CDN endpoints associated with this Web Application Firewall policy. </param>
        /// <param name="provisioningState"> Provisioning state of the WebApplicationFirewallPolicy. </param>
        /// <param name="resourceState"> Resource status of the policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CdnWebApplicationFirewallPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, CdnSku sku, WafPolicySettings policySettings, RateLimitRuleList rateLimitSettings, CustomRuleList customSettings, ManagedRuleSetList managedRules, IReadOnlyList<SubResource> endpointLinks, WebApplicationFirewallPolicyProvisioningState? provisioningState, PolicyResourceState? resourceState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            Sku = sku;
            PolicySettings = policySettings;
            RateLimitSettings = rateLimitSettings;
            CustomSettings = customSettings;
            ManagedRules = managedRules;
            EndpointLinks = endpointLinks;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CdnWebApplicationFirewallPolicyData"/> for deserialization. </summary>
        internal CdnWebApplicationFirewallPolicyData()
        {
        }

        /// <summary> Gets a unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; set; }
        /// <summary> The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy. </summary>
        internal CdnSku Sku { get; set; }
        /// <summary> Name of the pricing tier. </summary>
        public CdnSkuName? SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set
            {
                if (Sku is null)
                    Sku = new CdnSku();
                Sku.Name = value;
            }
        }

        /// <summary> Describes  policySettings for policy. </summary>
        public WafPolicySettings PolicySettings { get; set; }
        /// <summary> Describes rate limit rules inside the policy. </summary>
        internal RateLimitRuleList RateLimitSettings { get; set; }
        /// <summary> List of rules. </summary>
        public IList<RateLimitRule> RateLimitRules
        {
            get
            {
                if (RateLimitSettings is null)
                    RateLimitSettings = new RateLimitRuleList();
                return RateLimitSettings.Rules;
            }
        }

        /// <summary> Describes custom rules inside the policy. </summary>
        internal CustomRuleList CustomSettings { get; set; }
        /// <summary> List of rules. </summary>
        public IList<CustomRule> CustomRules
        {
            get
            {
                if (CustomSettings is null)
                    CustomSettings = new CustomRuleList();
                return CustomSettings.Rules;
            }
        }

        /// <summary> Describes managed rules inside the policy. </summary>
        internal ManagedRuleSetList ManagedRules { get; set; }
        /// <summary> List of rule sets. </summary>
        public IList<WafPolicyManagedRuleSet> ManagedRuleSets
        {
            get
            {
                if (ManagedRules is null)
                    ManagedRules = new ManagedRuleSetList();
                return ManagedRules.ManagedRuleSets;
            }
        }

        /// <summary> Describes Azure CDN endpoints associated with this Web Application Firewall policy. </summary>
        public IReadOnlyList<SubResource> EndpointLinks { get; }
        /// <summary> Provisioning state of the WebApplicationFirewallPolicy. </summary>
        public WebApplicationFirewallPolicyProvisioningState? ProvisioningState { get; }
        /// <summary> Resource status of the policy. </summary>
        public PolicyResourceState? ResourceState { get; }
    }
}
