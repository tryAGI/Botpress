#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCreateMessageRequestPayloadCarouselItemActionActionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.ChatCreateMessageRequestPayloadCarouselItemActionAction?>
    {
        /// <inheritdoc />
        public override global::Botpress.ChatCreateMessageRequestPayloadCarouselItemActionAction? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Botpress.ChatCreateMessageRequestPayloadCarouselItemActionActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.ChatCreateMessageRequestPayloadCarouselItemActionAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.ChatCreateMessageRequestPayloadCarouselItemActionAction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.ChatCreateMessageRequestPayloadCarouselItemActionAction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Botpress.ChatCreateMessageRequestPayloadCarouselItemActionActionExtensions.ToValueString(value.Value));
            }
        }
    }
}
