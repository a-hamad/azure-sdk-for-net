// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownDatastoreCredentials. </summary>
    internal partial class UnknownDatastoreCredentials : MachineLearningDatastoreCredentials
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDatastoreCredentials"/>. </summary>
        /// <param name="credentialsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownDatastoreCredentials(CredentialsType credentialsType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(credentialsType, serializedAdditionalRawData)
        {
            CredentialsType = credentialsType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownDatastoreCredentials"/> for deserialization. </summary>
        internal UnknownDatastoreCredentials()
        {
        }
    }
}
