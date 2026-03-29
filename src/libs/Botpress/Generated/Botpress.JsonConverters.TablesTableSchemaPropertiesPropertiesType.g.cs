#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class TablesTableSchemaPropertiesPropertiesTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.TablesTableSchemaPropertiesPropertiesType>
    {
        /// <inheritdoc />
        public override global::Botpress.TablesTableSchemaPropertiesPropertiesType Read(
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
                        return global::Botpress.TablesTableSchemaPropertiesPropertiesTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.TablesTableSchemaPropertiesPropertiesType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.TablesTableSchemaPropertiesPropertiesType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.TablesTableSchemaPropertiesPropertiesType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Botpress.TablesTableSchemaPropertiesPropertiesTypeExtensions.ToValueString(value));
        }
    }
}
