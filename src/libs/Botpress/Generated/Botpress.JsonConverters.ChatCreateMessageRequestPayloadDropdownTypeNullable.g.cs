#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCreateMessageRequestPayloadDropdownTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.ChatCreateMessageRequestPayloadDropdownType?>
    {
        /// <inheritdoc />
        public override global::Botpress.ChatCreateMessageRequestPayloadDropdownType? Read(
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
                        return global::Botpress.ChatCreateMessageRequestPayloadDropdownTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.ChatCreateMessageRequestPayloadDropdownType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.ChatCreateMessageRequestPayloadDropdownType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.ChatCreateMessageRequestPayloadDropdownType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Botpress.ChatCreateMessageRequestPayloadDropdownTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
