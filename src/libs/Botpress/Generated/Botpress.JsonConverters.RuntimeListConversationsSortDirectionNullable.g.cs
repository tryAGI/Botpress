#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class RuntimeListConversationsSortDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.RuntimeListConversationsSortDirection?>
    {
        /// <inheritdoc />
        public override global::Botpress.RuntimeListConversationsSortDirection? Read(
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
                        return global::Botpress.RuntimeListConversationsSortDirectionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.RuntimeListConversationsSortDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.RuntimeListConversationsSortDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.RuntimeListConversationsSortDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Botpress.RuntimeListConversationsSortDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
