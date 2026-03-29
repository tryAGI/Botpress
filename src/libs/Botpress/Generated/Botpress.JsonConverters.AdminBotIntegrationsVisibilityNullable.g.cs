#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class AdminBotIntegrationsVisibilityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.AdminBotIntegrationsVisibility?>
    {
        /// <inheritdoc />
        public override global::Botpress.AdminBotIntegrationsVisibility? Read(
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
                        return global::Botpress.AdminBotIntegrationsVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.AdminBotIntegrationsVisibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.AdminBotIntegrationsVisibility?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.AdminBotIntegrationsVisibility? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Botpress.AdminBotIntegrationsVisibilityExtensions.ToValueString(value.Value));
            }
        }
    }
}
