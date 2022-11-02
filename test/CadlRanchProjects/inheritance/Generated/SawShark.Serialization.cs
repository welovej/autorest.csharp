// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Models.Inheritance
{
    public partial class SawShark : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sharktype");
            writer.WriteStringValue(Sharktype);
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            writer.WritePropertyName("age");
            writer.WriteNumberValue(Age);
            writer.WriteEndObject();
        }

        internal static SawShark DeserializeSawShark(JsonElement element)
        {
            string sharktype = default;
            string kind = default;
            int age = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sharktype"))
                {
                    sharktype = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("age"))
                {
                    age = property.Value.GetInt32();
                    continue;
                }
            }
            return new SawShark(kind, age, sharktype);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal new static SawShark FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSawShark(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
