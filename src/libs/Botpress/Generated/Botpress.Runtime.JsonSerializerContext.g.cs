
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Botpress
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListConversationsSortField), TypeInfoPropertyName = "RuntimeListConversationsSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListConversationsSortDirection), TypeInfoPropertyName = "RuntimeListConversationsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListEventsStatus), TypeInfoPropertyName = "RuntimeListEventsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListUsersRangeField), TypeInfoPropertyName = "RuntimeListUsersRangeField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListUsersSortField), TypeInfoPropertyName = "RuntimeListUsersSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListUsersSortDirection), TypeInfoPropertyName = "RuntimeListUsersSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeSetStateExpiryType), TypeInfoPropertyName = "RuntimeSetStateExpiryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeGetStateType), TypeInfoPropertyName = "RuntimeGetStateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeSetStateType), TypeInfoPropertyName = "RuntimeSetStateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimePatchStateType), TypeInfoPropertyName = "RuntimePatchStateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeGetOrSetStateType), TypeInfoPropertyName = "RuntimeGetOrSetStateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListTagValuesType), TypeInfoPropertyName = "RuntimeListTagValuesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListConversationsSortField?), TypeInfoPropertyName = "NullableRuntimeListConversationsSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListConversationsSortDirection?), TypeInfoPropertyName = "NullableRuntimeListConversationsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListEventsStatus?), TypeInfoPropertyName = "NullableRuntimeListEventsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListUsersRangeField?), TypeInfoPropertyName = "NullableRuntimeListUsersRangeField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListUsersSortField?), TypeInfoPropertyName = "NullableRuntimeListUsersSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListUsersSortDirection?), TypeInfoPropertyName = "NullableRuntimeListUsersSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeSetStateExpiryType?), TypeInfoPropertyName = "NullableRuntimeSetStateExpiryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeGetStateType?), TypeInfoPropertyName = "NullableRuntimeGetStateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeSetStateType?), TypeInfoPropertyName = "NullableRuntimeSetStateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimePatchStateType?), TypeInfoPropertyName = "NullableRuntimePatchStateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeGetOrSetStateType?), TypeInfoPropertyName = "NullableRuntimeGetOrSetStateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeListTagValuesType?), TypeInfoPropertyName = "NullableRuntimeListTagValuesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class RuntimeSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RuntimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RuntimeSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RuntimeSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Botpress.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Botpress.RuntimeListConversationsSortField)

                    || typeToConvert == typeof(global::Botpress.RuntimeListConversationsSortField?)

                    || typeToConvert == typeof(global::Botpress.RuntimeListConversationsSortDirection)

                    || typeToConvert == typeof(global::Botpress.RuntimeListConversationsSortDirection?)

                    || typeToConvert == typeof(global::Botpress.RuntimeListEventsStatus)

                    || typeToConvert == typeof(global::Botpress.RuntimeListEventsStatus?)

                    || typeToConvert == typeof(global::Botpress.RuntimeListUsersRangeField)

                    || typeToConvert == typeof(global::Botpress.RuntimeListUsersRangeField?)

                    || typeToConvert == typeof(global::Botpress.RuntimeListUsersSortField)

                    || typeToConvert == typeof(global::Botpress.RuntimeListUsersSortField?)

                    || typeToConvert == typeof(global::Botpress.RuntimeListUsersSortDirection)

                    || typeToConvert == typeof(global::Botpress.RuntimeListUsersSortDirection?)

                    || typeToConvert == typeof(global::Botpress.RuntimeSetStateExpiryType)

                    || typeToConvert == typeof(global::Botpress.RuntimeSetStateExpiryType?)

                    || typeToConvert == typeof(global::Botpress.RuntimeGetStateType)

                    || typeToConvert == typeof(global::Botpress.RuntimeGetStateType?)

                    || typeToConvert == typeof(global::Botpress.RuntimeSetStateType)

                    || typeToConvert == typeof(global::Botpress.RuntimeSetStateType?)

                    || typeToConvert == typeof(global::Botpress.RuntimePatchStateType)

                    || typeToConvert == typeof(global::Botpress.RuntimePatchStateType?)

                    || typeToConvert == typeof(global::Botpress.RuntimeGetOrSetStateType)

                    || typeToConvert == typeof(global::Botpress.RuntimeGetOrSetStateType?)

                    || typeToConvert == typeof(global::Botpress.RuntimeListTagValuesType)

                    || typeToConvert == typeof(global::Botpress.RuntimeListTagValuesType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Botpress.RuntimeListConversationsSortField))
                {
                    return new global::Botpress.JsonConverters.RuntimeListConversationsSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListConversationsSortField?))
                {
                    return new global::Botpress.JsonConverters.RuntimeListConversationsSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListConversationsSortDirection))
                {
                    return new global::Botpress.JsonConverters.RuntimeListConversationsSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListConversationsSortDirection?))
                {
                    return new global::Botpress.JsonConverters.RuntimeListConversationsSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListEventsStatus))
                {
                    return new global::Botpress.JsonConverters.RuntimeListEventsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListEventsStatus?))
                {
                    return new global::Botpress.JsonConverters.RuntimeListEventsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListUsersRangeField))
                {
                    return new global::Botpress.JsonConverters.RuntimeListUsersRangeFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListUsersRangeField?))
                {
                    return new global::Botpress.JsonConverters.RuntimeListUsersRangeFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListUsersSortField))
                {
                    return new global::Botpress.JsonConverters.RuntimeListUsersSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListUsersSortField?))
                {
                    return new global::Botpress.JsonConverters.RuntimeListUsersSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListUsersSortDirection))
                {
                    return new global::Botpress.JsonConverters.RuntimeListUsersSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListUsersSortDirection?))
                {
                    return new global::Botpress.JsonConverters.RuntimeListUsersSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeSetStateExpiryType))
                {
                    return new global::Botpress.JsonConverters.RuntimeSetStateExpiryTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeSetStateExpiryType?))
                {
                    return new global::Botpress.JsonConverters.RuntimeSetStateExpiryTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeGetStateType))
                {
                    return new global::Botpress.JsonConverters.RuntimeGetStateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeGetStateType?))
                {
                    return new global::Botpress.JsonConverters.RuntimeGetStateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeSetStateType))
                {
                    return new global::Botpress.JsonConverters.RuntimeSetStateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeSetStateType?))
                {
                    return new global::Botpress.JsonConverters.RuntimeSetStateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimePatchStateType))
                {
                    return new global::Botpress.JsonConverters.RuntimePatchStateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimePatchStateType?))
                {
                    return new global::Botpress.JsonConverters.RuntimePatchStateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeGetOrSetStateType))
                {
                    return new global::Botpress.JsonConverters.RuntimeGetOrSetStateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeGetOrSetStateType?))
                {
                    return new global::Botpress.JsonConverters.RuntimeGetOrSetStateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListTagValuesType))
                {
                    return new global::Botpress.JsonConverters.RuntimeListTagValuesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.RuntimeListTagValuesType?))
                {
                    return new global::Botpress.JsonConverters.RuntimeListTagValuesTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new RuntimeSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}