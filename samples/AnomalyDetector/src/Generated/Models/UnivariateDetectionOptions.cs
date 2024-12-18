// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace AnomalyDetector.Models
{
    /// <summary> The UnivariateDetectionOptions. </summary>
    public partial class UnivariateDetectionOptions
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

        /// <summary> Initializes a new instance of <see cref="UnivariateDetectionOptions"/>. </summary>
        /// <param name="series"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="series"/> is null. </exception>
        public UnivariateDetectionOptions(IEnumerable<TimeSeriesPoint> series)
        {
            Argument.AssertNotNull(series, nameof(series));

            Series = series.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="UnivariateDetectionOptions"/>. </summary>
        /// <param name="series"></param>
        /// <param name="granularity"></param>
        /// <param name="customInterval"></param>
        /// <param name="period"></param>
        /// <param name="maxAnomalyRatio"></param>
        /// <param name="sensitivity"></param>
        /// <param name="imputeMode"></param>
        /// <param name="imputeFixedValue"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnivariateDetectionOptions(IList<TimeSeriesPoint> series, TimeGranularity? granularity, int? customInterval, int? period, float? maxAnomalyRatio, int? sensitivity, ImputeMode? imputeMode, float? imputeFixedValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Series = series;
            Granularity = granularity;
            CustomInterval = customInterval;
            Period = period;
            MaxAnomalyRatio = maxAnomalyRatio;
            Sensitivity = sensitivity;
            ImputeMode = imputeMode;
            ImputeFixedValue = imputeFixedValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UnivariateDetectionOptions"/> for deserialization. </summary>
        internal UnivariateDetectionOptions()
        {
        }

        /// <summary> Gets the series. </summary>
        public IList<TimeSeriesPoint> Series { get; }
        /// <summary> Gets or sets the granularity. </summary>
        public TimeGranularity? Granularity { get; set; }
        /// <summary> Gets or sets the custom interval. </summary>
        public int? CustomInterval { get; set; }
        /// <summary> Gets or sets the period. </summary>
        public int? Period { get; set; }
        /// <summary> Gets or sets the max anomaly ratio. </summary>
        public float? MaxAnomalyRatio { get; set; }
        /// <summary> Gets or sets the sensitivity. </summary>
        public int? Sensitivity { get; set; }
        /// <summary> Gets or sets the impute mode. </summary>
        public ImputeMode? ImputeMode { get; set; }
        /// <summary> Gets or sets the impute fixed value. </summary>
        public float? ImputeFixedValue { get; set; }
    }
}
