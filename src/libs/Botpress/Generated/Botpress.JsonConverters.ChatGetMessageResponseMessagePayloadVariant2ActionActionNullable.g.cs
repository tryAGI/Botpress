#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatGetMessageResponseMessagePayloadVariant2ActionActionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.ChatGetMessageResponseMessagePayloadVariant2ActionAction?>
    {
        /// <inheritdoc />
        public override global::Botpress.ChatGetMessageResponseMessagePayloadVariant2ActionAction? Read(
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
                        return global::Botpress.ChatGetMessageResponseMessagePayloadVariant2ActionActionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.ChatGetMessageResponseMessagePayloadVariant2ActionAction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.ChatGetMessageResponseMessagePayloadVariant2ActionAction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.ChatGetMessageResponseMessagePayloadVariant2ActionAction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Botpress.ChatGetMessageResponseMessagePayloadVariant2ActionActionExtensions.ToValueString(value.Value));
            }
        }
    }
}
