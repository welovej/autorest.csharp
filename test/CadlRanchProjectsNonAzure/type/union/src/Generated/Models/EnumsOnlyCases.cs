// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Union.Models
{
    /// <summary> The EnumsOnlyCases. </summary>
    public partial class EnumsOnlyCases
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

        /// <summary> Initializes a new instance of <see cref="EnumsOnlyCases"/>. </summary>
        /// <param name="lr"></param>
        /// <param name="ud"></param>
        public EnumsOnlyCases(EnumsOnlyCasesLr lr, EnumsOnlyCasesUd ud)
        {
            Lr = lr;
            Ud = ud;
        }

        /// <summary> Initializes a new instance of <see cref="EnumsOnlyCases"/>. </summary>
        /// <param name="lr"></param>
        /// <param name="ud"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EnumsOnlyCases(EnumsOnlyCasesLr lr, EnumsOnlyCasesUd ud, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Lr = lr;
            Ud = ud;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EnumsOnlyCases"/> for deserialization. </summary>
        internal EnumsOnlyCases()
        {
        }

        /// <summary> Gets or sets the lr. </summary>
        public EnumsOnlyCasesLr Lr { get; set; }
        /// <summary> Gets or sets the ud. </summary>
        public EnumsOnlyCasesUd Ud { get; set; }
    }
}
