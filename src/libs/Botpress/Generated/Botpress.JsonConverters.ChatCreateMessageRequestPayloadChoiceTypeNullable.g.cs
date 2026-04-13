#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCreateMessageRequestPayloadChoiceTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.ChatCreateMessageRequestPayloadChoiceType?>
    {
        /// <inheritdoc />
        public override global::Botpress.ChatCreateMessageRequestPayloadChoiceType? Read(
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
                        return global::Botpress.ChatCreateMessageRequestPayloadChoiceTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.ChatCreateMessageRequestPayloadChoiceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.ChatCreateMessageRequestPayloadChoiceType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.ChatCreateMessageRequestPayloadChoiceType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Botpress.ChatCreateMessageRequestPayloadChoiceTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
