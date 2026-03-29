#nullable enable

namespace Botpress.JsonConverters
{
    /// <inheritdoc />
    public sealed class FilesFileIndexingStackJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Botpress.FilesFileIndexingStack>
    {
        /// <inheritdoc />
        public override global::Botpress.FilesFileIndexingStack Read(
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
                        return global::Botpress.FilesFileIndexingStackExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Botpress.FilesFileIndexingStack)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Botpress.FilesFileIndexingStack);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Botpress.FilesFileIndexingStack value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Botpress.FilesFileIndexingStackExtensions.ToValueString(value));
        }
    }
}
