#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class TablesTableSchemaPropertiesFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.TablesTableSchemaPropertiesFormat?>
    {
        /// <inheritdoc />
        public override global::Botpress.TablesTableSchemaPropertiesFormat? Read(
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
                        return global::Botpress.TablesTableSchemaPropertiesFormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.TablesTableSchemaPropertiesFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.TablesTableSchemaPropertiesFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.TablesTableSchemaPropertiesFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Botpress.TablesTableSchemaPropertiesFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
