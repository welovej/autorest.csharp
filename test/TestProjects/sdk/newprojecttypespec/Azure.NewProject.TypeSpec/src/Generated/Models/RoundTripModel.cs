// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.NewProject.TypeSpec.Models
{
    /// <summary> The RoundTripModel. </summary>
    public partial class RoundTripModel
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

        /// <summary> Initializes a new instance of <see cref="RoundTripModel"/>. </summary>
        /// <param name="requiredString"></param>
        /// <param name="requiredInt"></param>
        /// <param name="requiredCollection"></param>
        /// <param name="requiredDictionary"></param>
        /// <param name="requiredModel"></param>
        /// <param name="requiredUnknown"></param>
        /// <param name="requiredRecordUnknown"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredString"/>, <paramref name="requiredCollection"/>, <paramref name="requiredDictionary"/>, <paramref name="requiredModel"/>, <paramref name="requiredUnknown"/> or <paramref name="requiredRecordUnknown"/> is null. </exception>
        public RoundTripModel(string requiredString, int requiredInt, IEnumerable<StringFixedEnum> requiredCollection, IDictionary<string, StringExtensibleEnum> requiredDictionary, Thing requiredModel, BinaryData requiredUnknown, IDictionary<string, BinaryData> requiredRecordUnknown)
        {
            Argument.AssertNotNull(requiredString, nameof(requiredString));
            Argument.AssertNotNull(requiredCollection, nameof(requiredCollection));
            Argument.AssertNotNull(requiredDictionary, nameof(requiredDictionary));
            Argument.AssertNotNull(requiredModel, nameof(requiredModel));
            Argument.AssertNotNull(requiredUnknown, nameof(requiredUnknown));
            Argument.AssertNotNull(requiredRecordUnknown, nameof(requiredRecordUnknown));

            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredCollection = requiredCollection.ToList();
            RequiredDictionary = requiredDictionary;
            RequiredModel = requiredModel;
            IntExtensibleEnumCollection = new ChangeTrackingList<IntExtensibleEnum>();
            FloatExtensibleEnumCollection = new ChangeTrackingList<FloatExtensibleEnum>();
            FloatFixedEnumCollection = new ChangeTrackingList<FloatFixedEnum>();
            IntFixedEnumCollection = new ChangeTrackingList<IntFixedEnum>();
            RequiredUnknown = requiredUnknown;
            RequiredRecordUnknown = requiredRecordUnknown;
            OptionalRecordUnknown = new ChangeTrackingDictionary<string, BinaryData>();
            ReadOnlyRequiredRecordUnknown = new ChangeTrackingDictionary<string, BinaryData>();
            ReadOnlyOptionalRecordUnknown = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="RoundTripModel"/>. </summary>
        /// <param name="requiredString"></param>
        /// <param name="requiredInt"></param>
        /// <param name="requiredCollection"></param>
        /// <param name="requiredDictionary"></param>
        /// <param name="requiredModel"></param>
        /// <param name="intExtensibleEnum"></param>
        /// <param name="intExtensibleEnumCollection"></param>
        /// <param name="floatExtensibleEnum"></param>
        /// <param name="floatExtensibleEnumCollection"></param>
        /// <param name="floatFixedEnum"></param>
        /// <param name="floatFixedEnumCollection"></param>
        /// <param name="intFixedEnum"></param>
        /// <param name="intFixedEnumCollection"></param>
        /// <param name="stringFixedEnum"></param>
        /// <param name="requiredUnknown"></param>
        /// <param name="optionalUnknown"></param>
        /// <param name="requiredRecordUnknown"></param>
        /// <param name="optionalRecordUnknown"></param>
        /// <param name="readOnlyRequiredRecordUnknown"></param>
        /// <param name="readOnlyOptionalRecordUnknown"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoundTripModel(string requiredString, int requiredInt, IList<StringFixedEnum> requiredCollection, IDictionary<string, StringExtensibleEnum> requiredDictionary, Thing requiredModel, IntExtensibleEnum? intExtensibleEnum, IList<IntExtensibleEnum> intExtensibleEnumCollection, FloatExtensibleEnum? floatExtensibleEnum, IList<FloatExtensibleEnum> floatExtensibleEnumCollection, FloatFixedEnum? floatFixedEnum, IList<FloatFixedEnum> floatFixedEnumCollection, IntFixedEnum? intFixedEnum, IList<IntFixedEnum> intFixedEnumCollection, StringFixedEnum? stringFixedEnum, BinaryData requiredUnknown, BinaryData optionalUnknown, IDictionary<string, BinaryData> requiredRecordUnknown, IDictionary<string, BinaryData> optionalRecordUnknown, IReadOnlyDictionary<string, BinaryData> readOnlyRequiredRecordUnknown, IReadOnlyDictionary<string, BinaryData> readOnlyOptionalRecordUnknown, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredCollection = requiredCollection;
            RequiredDictionary = requiredDictionary;
            RequiredModel = requiredModel;
            IntExtensibleEnum = intExtensibleEnum;
            IntExtensibleEnumCollection = intExtensibleEnumCollection;
            FloatExtensibleEnum = floatExtensibleEnum;
            FloatExtensibleEnumCollection = floatExtensibleEnumCollection;
            FloatFixedEnum = floatFixedEnum;
            FloatFixedEnumCollection = floatFixedEnumCollection;
            IntFixedEnum = intFixedEnum;
            IntFixedEnumCollection = intFixedEnumCollection;
            StringFixedEnum = stringFixedEnum;
            RequiredUnknown = requiredUnknown;
            OptionalUnknown = optionalUnknown;
            RequiredRecordUnknown = requiredRecordUnknown;
            OptionalRecordUnknown = optionalRecordUnknown;
            ReadOnlyRequiredRecordUnknown = readOnlyRequiredRecordUnknown;
            ReadOnlyOptionalRecordUnknown = readOnlyOptionalRecordUnknown;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RoundTripModel"/> for deserialization. </summary>
        internal RoundTripModel()
        {
        }

        /// <summary> Gets or sets the required string. </summary>
        public string RequiredString { get; set; }
        /// <summary> Gets or sets the required int. </summary>
        public int RequiredInt { get; set; }
        /// <summary> Gets the required collection. </summary>
        public IList<StringFixedEnum> RequiredCollection { get; }
        /// <summary> Gets the required dictionary. </summary>
        public IDictionary<string, StringExtensibleEnum> RequiredDictionary { get; }
        /// <summary> Gets or sets the required model. </summary>
        public Thing RequiredModel { get; set; }
        /// <summary> Gets or sets the int extensible enum. </summary>
        public IntExtensibleEnum? IntExtensibleEnum { get; set; }
        /// <summary> Gets the int extensible enum collection. </summary>
        public IList<IntExtensibleEnum> IntExtensibleEnumCollection { get; }
        /// <summary> Gets or sets the float extensible enum. </summary>
        public FloatExtensibleEnum? FloatExtensibleEnum { get; set; }
        /// <summary> Gets the float extensible enum collection. </summary>
        public IList<FloatExtensibleEnum> FloatExtensibleEnumCollection { get; }
        /// <summary> Gets or sets the float fixed enum. </summary>
        public FloatFixedEnum? FloatFixedEnum { get; set; }
        /// <summary> Gets the float fixed enum collection. </summary>
        public IList<FloatFixedEnum> FloatFixedEnumCollection { get; }
        /// <summary> Gets or sets the int fixed enum. </summary>
        public IntFixedEnum? IntFixedEnum { get; set; }
        /// <summary> Gets the int fixed enum collection. </summary>
        public IList<IntFixedEnum> IntFixedEnumCollection { get; }
        /// <summary> Gets or sets the string fixed enum. </summary>
        public StringFixedEnum? StringFixedEnum { get; set; }
        /// <summary>
        /// Gets or sets the required unknown
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData RequiredUnknown { get; set; }
        /// <summary>
        /// Gets or sets the optional unknown
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData OptionalUnknown { get; set; }
        /// <summary>
        /// Gets the required record unknown
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
        public IDictionary<string, BinaryData> RequiredRecordUnknown { get; }
        /// <summary>
        /// Gets the optional record unknown
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
        public IDictionary<string, BinaryData> OptionalRecordUnknown { get; }
        /// <summary>
        /// Gets the read only required record unknown
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
        public IReadOnlyDictionary<string, BinaryData> ReadOnlyRequiredRecordUnknown { get; }
        /// <summary>
        /// Gets the read only optional record unknown
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
        public IReadOnlyDictionary<string, BinaryData> ReadOnlyOptionalRecordUnknown { get; }
    }
}
