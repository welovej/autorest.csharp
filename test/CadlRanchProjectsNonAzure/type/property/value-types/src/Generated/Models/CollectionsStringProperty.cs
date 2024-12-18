// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Scm._Type.Property.ValueTypes.Models
{
    /// <summary> The CollectionsStringProperty. </summary>
    public partial class CollectionsStringProperty
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

        /// <summary> Initializes a new instance of <see cref="CollectionsStringProperty"/>. </summary>
        /// <param name="property"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="property"/> is null. </exception>
        public CollectionsStringProperty(IEnumerable<string> property)
        {
            Argument.AssertNotNull(property, nameof(property));

            Property = property.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CollectionsStringProperty"/>. </summary>
        /// <param name="property"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CollectionsStringProperty(IList<string> property, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Property = property;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CollectionsStringProperty"/> for deserialization. </summary>
        internal CollectionsStringProperty()
        {
        }

        /// <summary> Gets the property. </summary>
        public IList<string> Property { get; }
    }
}
