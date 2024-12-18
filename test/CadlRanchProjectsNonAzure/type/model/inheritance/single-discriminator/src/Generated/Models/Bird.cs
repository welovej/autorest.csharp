// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Scm._Type.Model.Inheritance.SingleDiscriminator.Models
{
    /// <summary>
    /// The Bird.
    /// Please note <see cref="Bird"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="Eagle"/>, <see cref="Goose"/>, <see cref="SeaGull"/> and <see cref="Sparrow"/>.
    /// </summary>
    public abstract partial class Bird
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

        /// <summary> Initializes a new instance of <see cref="Bird"/>. </summary>
        /// <param name="wingspan"></param>
        protected Bird(int wingspan)
        {
            Wingspan = wingspan;
        }

        /// <summary> Initializes a new instance of <see cref="Bird"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="wingspan"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Bird(string kind, int wingspan, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Wingspan = wingspan;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Bird"/> for deserialization. </summary>
        internal Bird()
        {
        }

        /// <summary> Gets or sets the kind. </summary>
        internal string Kind { get; set; }
        /// <summary> Gets or sets the wingspan. </summary>
        public int Wingspan { get; set; }
    }
}
