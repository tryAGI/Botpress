#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class TablesTableSchemaPropertiesItemsTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.TablesTableSchemaPropertiesItemsType?>
    {
        /// <inheritdoc />
        public override global::Botpress.TablesTableSchemaPropertiesItemsType? Read(
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
                        return global::Botpress.TablesTableSchemaPropertiesItemsTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.TablesTableSchemaPropertiesItemsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.TablesTableSchemaPropertiesItemsType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.TablesTableSchemaPropertiesItemsType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Botpress.TablesTableSchemaPropertiesItemsTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
