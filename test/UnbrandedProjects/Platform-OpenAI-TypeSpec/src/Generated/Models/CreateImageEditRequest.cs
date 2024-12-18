// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;

namespace OpenAI.Models
{
    /// <summary> The CreateImageEditRequest. </summary>
    public partial class CreateImageEditRequest
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
        /// <summary> Initializes a new instance of <see cref="CreateImageEditRequest"/>. </summary>
        /// <param name="prompt"></param>
        /// <param name="image"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="prompt"/> or <paramref name="image"/> is null. </exception>
        public CreateImageEditRequest(string prompt, Stream image)
        {
            Argument.AssertNotNull(prompt, nameof(prompt));
            Argument.AssertNotNull(image, nameof(image));

            Prompt = prompt;
            Image = image;
        }

        /// <summary> Initializes a new instance of <see cref="CreateImageEditRequest"/>. </summary>
        /// <param name="prompt"></param>
        /// <param name="image"></param>
        /// <param name="mask"></param>
        /// <param name="n"></param>
        /// <param name="size"></param>
        /// <param name="responseFormat"></param>
        /// <param name="user"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateImageEditRequest(string prompt, Stream image, Stream mask, long? n, CreateImageRequestSize? size, CreateImageRequestResponseFormat? responseFormat, string user, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Prompt = prompt;
            Image = image;
            Mask = mask;
            N = n;
            Size = size;
            ResponseFormat = responseFormat;
            User = user;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateImageEditRequest"/> for deserialization. </summary>
        internal CreateImageEditRequest()
        {
        }

        /// <summary> Gets the prompt. </summary>
        public string Prompt { get; }
        /// <summary> Gets the image. </summary>
        public Stream Image { get; }
        /// <summary> Gets or sets the mask. </summary>
        public Stream Mask { get; set; }
        /// <summary> Gets or sets the n. </summary>
        public long? N { get; set; }
        /// <summary> Gets or sets the size. </summary>
        public CreateImageRequestSize? Size { get; set; }
        /// <summary> Gets or sets the response format. </summary>
        public CreateImageRequestResponseFormat? ResponseFormat { get; set; }
        /// <summary> Gets or sets the user. </summary>
        public string User { get; set; }
    }
}
