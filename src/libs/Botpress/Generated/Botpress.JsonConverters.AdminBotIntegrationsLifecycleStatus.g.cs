#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class AdminBotIntegrationsLifecycleStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.AdminBotIntegrationsLifecycleStatus>
    {
        /// <inheritdoc />
        public override global::Botpress.AdminBotIntegrationsLifecycleStatus Read(
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
                        return global::Botpress.AdminBotIntegrationsLifecycleStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.AdminBotIntegrationsLifecycleStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.AdminBotIntegrationsLifecycleStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.AdminBotIntegrationsLifecycleStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Botpress.AdminBotIntegrationsLifecycleStatusExtensions.ToValueString(value));
        }
    }
}
