// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ConfidentLevelsInTsp.Models
{
    public partial class IndirectSelfReferenceModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("something"u8);
            writer.WriteStringValue(Something);
            if (Optional.IsDefined(Reference))
            {
                writer.WritePropertyName("reference"u8);
                writer.WriteObjectValue(Reference);
            }
            writer.WritePropertyName("unionProperty"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UnionProperty);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(UnionProperty.ToString()).RootElement);
#endif
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
