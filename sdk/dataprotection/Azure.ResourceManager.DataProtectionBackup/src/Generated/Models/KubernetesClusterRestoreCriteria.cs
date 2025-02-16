// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> kubernetes Cluster Backup target info for restore operation. </summary>
    public partial class KubernetesClusterRestoreCriteria : ItemLevelRestoreCriteria
    {
        /// <summary> Initializes a new instance of <see cref="KubernetesClusterRestoreCriteria"/>. </summary>
        /// <param name="isClusterScopeResourcesIncluded"> Gets or sets the include cluster resources property. This property if enabled will include cluster scope resources during restore. </param>
        public KubernetesClusterRestoreCriteria(bool isClusterScopeResourcesIncluded)
        {
            IsClusterScopeResourcesIncluded = isClusterScopeResourcesIncluded;
            IncludedNamespaces = new ChangeTrackingList<string>();
            ExcludedNamespaces = new ChangeTrackingList<string>();
            IncludedResourceTypes = new ChangeTrackingList<string>();
            ExcludedResourceTypes = new ChangeTrackingList<string>();
            LabelSelectors = new ChangeTrackingList<string>();
            NamespaceMappings = new ChangeTrackingDictionary<string, string>();
            RestoreHookReferences = new ChangeTrackingList<NamespacedName>();
            ObjectType = "KubernetesClusterRestoreCriteria";
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesClusterRestoreCriteria"/>. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="isClusterScopeResourcesIncluded"> Gets or sets the include cluster resources property. This property if enabled will include cluster scope resources during restore. </param>
        /// <param name="includedNamespaces"> Gets or sets the include namespaces property. This property sets the namespaces to be included during restore. </param>
        /// <param name="excludedNamespaces"> Gets or sets the exclude namespaces property. This property sets the namespaces to be excluded during restore. </param>
        /// <param name="includedResourceTypes"> Gets or sets the include resource types property. This property sets the resource types to be included during restore. </param>
        /// <param name="excludedResourceTypes"> Gets or sets the exclude resource types property. This property sets the resource types to be excluded during restore. </param>
        /// <param name="labelSelectors"> Gets or sets the LabelSelectors property. This property sets the resource with such label selectors to be included during restore. </param>
        /// <param name="persistentVolumeRestoreMode"> Gets or sets the PV (Persistent Volume) Restore Mode property. This property sets whether volumes needs to be restored. </param>
        /// <param name="conflictPolicy"> Gets or sets the Conflict Policy property. This property sets policy during conflict of resources during restore. </param>
        /// <param name="namespaceMappings"> Gets or sets the Namespace Mappings property. This property sets if namespace needs to be change during restore. </param>
        /// <param name="restoreHookReferences"> Gets or sets the restore hook references. This property sets the hook reference to be executed during restore. </param>
        internal KubernetesClusterRestoreCriteria(string objectType, IDictionary<string, BinaryData> serializedAdditionalRawData, bool isClusterScopeResourcesIncluded, IList<string> includedNamespaces, IList<string> excludedNamespaces, IList<string> includedResourceTypes, IList<string> excludedResourceTypes, IList<string> labelSelectors, PersistentVolumeRestoreMode? persistentVolumeRestoreMode, KubernetesClusterRestoreExistingResourcePolicy? conflictPolicy, IDictionary<string, string> namespaceMappings, IList<NamespacedName> restoreHookReferences) : base(objectType, serializedAdditionalRawData)
        {
            IsClusterScopeResourcesIncluded = isClusterScopeResourcesIncluded;
            IncludedNamespaces = includedNamespaces;
            ExcludedNamespaces = excludedNamespaces;
            IncludedResourceTypes = includedResourceTypes;
            ExcludedResourceTypes = excludedResourceTypes;
            LabelSelectors = labelSelectors;
            PersistentVolumeRestoreMode = persistentVolumeRestoreMode;
            ConflictPolicy = conflictPolicy;
            NamespaceMappings = namespaceMappings;
            RestoreHookReferences = restoreHookReferences;
            ObjectType = objectType ?? "KubernetesClusterRestoreCriteria";
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesClusterRestoreCriteria"/> for deserialization. </summary>
        internal KubernetesClusterRestoreCriteria()
        {
        }

        /// <summary> Gets or sets the include cluster resources property. This property if enabled will include cluster scope resources during restore. </summary>
        public bool IsClusterScopeResourcesIncluded { get; }
        /// <summary> Gets or sets the include namespaces property. This property sets the namespaces to be included during restore. </summary>
        public IList<string> IncludedNamespaces { get; }
        /// <summary> Gets or sets the exclude namespaces property. This property sets the namespaces to be excluded during restore. </summary>
        public IList<string> ExcludedNamespaces { get; }
        /// <summary> Gets or sets the include resource types property. This property sets the resource types to be included during restore. </summary>
        public IList<string> IncludedResourceTypes { get; }
        /// <summary> Gets or sets the exclude resource types property. This property sets the resource types to be excluded during restore. </summary>
        public IList<string> ExcludedResourceTypes { get; }
        /// <summary> Gets or sets the LabelSelectors property. This property sets the resource with such label selectors to be included during restore. </summary>
        public IList<string> LabelSelectors { get; }
        /// <summary> Gets or sets the PV (Persistent Volume) Restore Mode property. This property sets whether volumes needs to be restored. </summary>
        public PersistentVolumeRestoreMode? PersistentVolumeRestoreMode { get; set; }
        /// <summary> Gets or sets the Conflict Policy property. This property sets policy during conflict of resources during restore. </summary>
        public KubernetesClusterRestoreExistingResourcePolicy? ConflictPolicy { get; set; }
        /// <summary> Gets or sets the Namespace Mappings property. This property sets if namespace needs to be change during restore. </summary>
        public IDictionary<string, string> NamespaceMappings { get; }
        /// <summary> Gets or sets the restore hook references. This property sets the hook reference to be executed during restore. </summary>
        public IList<NamespacedName> RestoreHookReferences { get; }
    }
}
