// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> The UnknownBaseResourceProperties. </summary>
    internal partial class UnknownBaseResourceProperties : BaseResourceProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownBaseResourceProperties"/>. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownBaseResourceProperties(ResourcePropertiesObjectType objectType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(objectType, serializedAdditionalRawData)
        {
            ObjectType = objectType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownBaseResourceProperties"/> for deserialization. </summary>
        internal UnknownBaseResourceProperties()
        {
        }
    }
}
