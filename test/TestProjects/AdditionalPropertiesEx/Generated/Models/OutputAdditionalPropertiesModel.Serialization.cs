// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace AdditionalPropertiesEx.Models
{
    public partial class OutputAdditionalPropertiesModel : IUtf8JsonSerializable, IJsonModel<OutputAdditionalPropertiesModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OutputAdditionalPropertiesModel>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OutputAdditionalPropertiesModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OutputAdditionalPropertiesModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OutputAdditionalPropertiesModel)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("id"u8);
            writer.WriteNumberValue(Id);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
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

        OutputAdditionalPropertiesModel IJsonModel<OutputAdditionalPropertiesModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OutputAdditionalPropertiesModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OutputAdditionalPropertiesModel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOutputAdditionalPropertiesModel(document.RootElement, options);
        }

        internal static OutputAdditionalPropertiesModel DeserializeOutputAdditionalPropertiesModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int id = default;
            IReadOnlyDictionary<string, string> additionalProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, string> additionalPropertiesDictionary = new Dictionary<string, string>();
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetInt32();
                    continue;
                }
                if (property.Value.ValueKind == JsonValueKind.String || property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            serializedAdditionalRawData = rawDataDictionary;
            return new OutputAdditionalPropertiesModel(id, additionalProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OutputAdditionalPropertiesModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OutputAdditionalPropertiesModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OutputAdditionalPropertiesModel)} does not support writing '{options.Format}' format.");
            }
        }

        OutputAdditionalPropertiesModel IPersistableModel<OutputAdditionalPropertiesModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OutputAdditionalPropertiesModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOutputAdditionalPropertiesModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OutputAdditionalPropertiesModel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OutputAdditionalPropertiesModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static OutputAdditionalPropertiesModel FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOutputAdditionalPropertiesModel(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
