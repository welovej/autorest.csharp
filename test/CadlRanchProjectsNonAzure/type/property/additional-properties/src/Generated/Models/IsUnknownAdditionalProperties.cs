// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Property.AdditionalProperties.Models
{
    /// <summary> The IsUnknownAdditionalProperties. </summary>
    public partial class IsUnknownAdditionalProperties
    {
        /// <summary> Initializes a new instance of <see cref="IsUnknownAdditionalProperties"/>. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public IsUnknownAdditionalProperties(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="IsUnknownAdditionalProperties"/>. </summary>
        /// <param name="name"></param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IsUnknownAdditionalProperties(string name, IDictionary<string, BinaryData> additionalProperties)
        {
            Name = name;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="IsUnknownAdditionalProperties"/> for deserialization. </summary>
        internal IsUnknownAdditionalProperties()
        {
        }

        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary>
        /// Additional Properties
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
