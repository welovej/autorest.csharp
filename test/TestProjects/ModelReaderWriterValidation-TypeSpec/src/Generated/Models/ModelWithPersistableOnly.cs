// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace ModelReaderWriterValidationTypeSpec.Models
{
    /// <summary> The ModelWithPersistableOnly. </summary>
    public partial class ModelWithPersistableOnly
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

        /// <summary> Initializes a new instance of <see cref="ModelWithPersistableOnly"/>. </summary>
        public ModelWithPersistableOnly()
        {
            Fields = new ChangeTrackingList<string>();
            KeyValuePairs = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ModelWithPersistableOnly"/>. </summary>
        /// <param name="name"></param>
        /// <param name="fields"></param>
        /// <param name="nullProperty"></param>
        /// <param name="keyValuePairs"></param>
        /// <param name="xProperty"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ModelWithPersistableOnly(string name, IList<string> fields, int? nullProperty, IDictionary<string, string> keyValuePairs, int xProperty, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Fields = fields;
            NullProperty = nullProperty;
            KeyValuePairs = keyValuePairs;
            XProperty = xProperty;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets the fields. </summary>
        public IList<string> Fields { get; }
        /// <summary> Gets or sets the null property. </summary>
        public int? NullProperty { get; set; }
        /// <summary> Gets the key value pairs. </summary>
        public IDictionary<string, string> KeyValuePairs { get; }
        /// <summary> Gets the x property. </summary>
        public int XProperty { get; }
    }
}
