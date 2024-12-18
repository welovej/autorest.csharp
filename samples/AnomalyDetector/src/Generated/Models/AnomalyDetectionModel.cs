// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace AnomalyDetector.Models
{
    /// <summary> The AnomalyDetectionModel. </summary>
    public partial class AnomalyDetectionModel
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

        /// <summary> Initializes a new instance of <see cref="AnomalyDetectionModel"/>. </summary>
        /// <param name="createdTime"></param>
        /// <param name="lastUpdatedTime"></param>
        internal AnomalyDetectionModel(DateTimeOffset createdTime, DateTimeOffset lastUpdatedTime)
        {
            CreatedTime = createdTime;
            LastUpdatedTime = lastUpdatedTime;
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetectionModel"/>. </summary>
        /// <param name="modelId"></param>
        /// <param name="createdTime"></param>
        /// <param name="lastUpdatedTime"></param>
        /// <param name="modelInfo"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnomalyDetectionModel(Guid modelId, DateTimeOffset createdTime, DateTimeOffset lastUpdatedTime, ModelInfo modelInfo, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ModelId = modelId;
            CreatedTime = createdTime;
            LastUpdatedTime = lastUpdatedTime;
            ModelInfo = modelInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnomalyDetectionModel"/> for deserialization. </summary>
        internal AnomalyDetectionModel()
        {
        }

        /// <summary> Gets the model id. </summary>
        public Guid ModelId { get; }
        /// <summary> Gets the created time. </summary>
        public DateTimeOffset CreatedTime { get; }
        /// <summary> Gets the last updated time. </summary>
        public DateTimeOffset LastUpdatedTime { get; }
        /// <summary> Gets the model info. </summary>
        public ModelInfo ModelInfo { get; }
    }
}
