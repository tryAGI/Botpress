#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatGetMessageResponseMessagePayloadVariant4TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Type>
    {
        /// <inheritdoc />
        public override global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Type Read(
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
                        return global::Botpress.ChatGetMessageResponseMessagePayloadVariant4TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Botpress.ChatGetMessageResponseMessagePayloadVariant4TypeExtensions.ToValueString(value));
        }
    }
}
