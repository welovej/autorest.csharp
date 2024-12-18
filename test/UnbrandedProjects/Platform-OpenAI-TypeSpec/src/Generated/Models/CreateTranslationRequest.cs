// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;

namespace OpenAI.Models
{
    /// <summary> The CreateTranslationRequest. </summary>
    public partial class CreateTranslationRequest
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
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        /// <summary> Initializes a new instance of <see cref="CreateTranslationRequest"/>. </summary>
        /// <param name="file"></param>
        /// <param name="model"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="file"/> is null. </exception>
        public CreateTranslationRequest(Stream file, CreateTranslationRequestModel model)
        {
            Argument.AssertNotNull(file, nameof(file));

            File = file;
            Model = model;
        }

        /// <summary> Initializes a new instance of <see cref="CreateTranslationRequest"/>. </summary>
        /// <param name="file"></param>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="responseFormat"></param>
        /// <param name="temperature"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateTranslationRequest(Stream file, CreateTranslationRequestModel model, string prompt, CreateTranslationRequestResponseFormat? responseFormat, double? temperature, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            File = file;
            Model = model;
            Prompt = prompt;
            ResponseFormat = responseFormat;
            Temperature = temperature;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateTranslationRequest"/> for deserialization. </summary>
        internal CreateTranslationRequest()
        {
        }

        /// <summary> Gets the file. </summary>
        public Stream File { get; }
        /// <summary> Gets the model. </summary>
        public CreateTranslationRequestModel Model { get; }
        /// <summary> Gets or sets the prompt. </summary>
        public string Prompt { get; set; }
        /// <summary> Gets or sets the response format. </summary>
        public CreateTranslationRequestResponseFormat? ResponseFormat { get; set; }
        /// <summary> Gets or sets the temperature. </summary>
        public double? Temperature { get; set; }
    }
}
