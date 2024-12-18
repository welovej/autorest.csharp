// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Property.AdditionalProperties.Models
{
    /// <summary> The DifferentSpreadStringRecord. </summary>
    public partial class DifferentSpreadStringRecord
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DifferentSpreadStringRecord"/>. </summary>
        /// <param name="id"></param>
        public DifferentSpreadStringRecord(float id)
        {
            Id = id;
            AdditionalProperties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DifferentSpreadStringRecord"/>. </summary>
        /// <param name="id"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DifferentSpreadStringRecord(float id, IDictionary<string, string> additionalProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            AdditionalProperties = additionalProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DifferentSpreadStringRecord"/> for deserialization. </summary>
        internal DifferentSpreadStringRecord()
        {
        }

        /// <summary> Gets or sets the id. </summary>
        public float Id { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, string> AdditionalProperties { get; }
    }
}
