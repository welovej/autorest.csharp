// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Scm._Type.Union.Models
{
    public partial class MixedLiteralsCases : IJsonModel<MixedLiteralsCases>
    {
        void IJsonModel<MixedLiteralsCases>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MixedLiteralsCases>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MixedLiteralsCases)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("stringLiteral"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(StringLiteral);
#else
            using (JsonDocument document = JsonDocument.Parse(StringLiteral))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("intLiteral"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(IntLiteral);
#else
            using (JsonDocument document = JsonDocument.Parse(IntLiteral))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("floatLiteral"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(FloatLiteral);
#else
            using (JsonDocument document = JsonDocument.Parse(FloatLiteral))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            writer.WritePropertyName("booleanLiteral"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(BooleanLiteral);
#else
            using (JsonDocument document = JsonDocument.Parse(BooleanLiteral))
            {
                JsonSerializer.Serialize(writer, document.RootElement);
            }
#endif
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        MixedLiteralsCases IJsonModel<MixedLiteralsCases>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MixedLiteralsCases>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MixedLiteralsCases)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMixedLiteralsCases(document.RootElement, options);
        }

        internal static MixedLiteralsCases DeserializeMixedLiteralsCases(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BinaryData stringLiteral = default;
            BinaryData intLiteral = default;
            BinaryData floatLiteral = default;
            BinaryData booleanLiteral = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stringLiteral"u8))
                {
                    stringLiteral = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("intLiteral"u8))
                {
                    intLiteral = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("floatLiteral"u8))
                {
                    floatLiteral = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("booleanLiteral"u8))
                {
                    booleanLiteral = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MixedLiteralsCases(stringLiteral, intLiteral, floatLiteral, booleanLiteral, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MixedLiteralsCases>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MixedLiteralsCases>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MixedLiteralsCases)} does not support writing '{options.Format}' format.");
            }
        }

        MixedLiteralsCases IPersistableModel<MixedLiteralsCases>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MixedLiteralsCases>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMixedLiteralsCases(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MixedLiteralsCases)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MixedLiteralsCases>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static MixedLiteralsCases FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMixedLiteralsCases(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
