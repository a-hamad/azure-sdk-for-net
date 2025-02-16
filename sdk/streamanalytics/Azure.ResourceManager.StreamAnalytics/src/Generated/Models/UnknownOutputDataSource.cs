// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The UnknownOutputDataSource. </summary>
    internal partial class UnknownOutputDataSource : StreamingJobOutputDataSource
    {
        /// <summary> Initializes a new instance of <see cref="UnknownOutputDataSource"/>. </summary>
        /// <param name="outputDataSourceType"> Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownOutputDataSource(string outputDataSourceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(outputDataSourceType, serializedAdditionalRawData)
        {
            OutputDataSourceType = outputDataSourceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownOutputDataSource"/> for deserialization. </summary>
        internal UnknownOutputDataSource()
        {
        }
    }
}
