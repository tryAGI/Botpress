#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class AdminIntegrationLifecycleStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.AdminIntegrationLifecycleStatus?>
    {
        /// <inheritdoc />
        public override global::Botpress.AdminIntegrationLifecycleStatus? Read(
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
                        return global::Botpress.AdminIntegrationLifecycleStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.AdminIntegrationLifecycleStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.AdminIntegrationLifecycleStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.AdminIntegrationLifecycleStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Botpress.AdminIntegrationLifecycleStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
