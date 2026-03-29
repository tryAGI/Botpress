#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatGetMessageResponseMessagePayloadVariant9TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.ChatGetMessageResponseMessagePayloadVariant9Type?>
    {
        /// <inheritdoc />
        public override global::Botpress.ChatGetMessageResponseMessagePayloadVariant9Type? Read(
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
                        return global::Botpress.ChatGetMessageResponseMessagePayloadVariant9TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.ChatGetMessageResponseMessagePayloadVariant9Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.ChatGetMessageResponseMessagePayloadVariant9Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.ChatGetMessageResponseMessagePayloadVariant9Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Botpress.ChatGetMessageResponseMessagePayloadVariant9TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
