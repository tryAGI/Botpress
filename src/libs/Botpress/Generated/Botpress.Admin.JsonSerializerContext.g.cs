
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListPublicIntegrationsVerificationStatus), TypeInfoPropertyName = "AdminListPublicIntegrationsVerificationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListPublicIntegrationsSortBy), TypeInfoPropertyName = "AdminListPublicIntegrationsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListPublicIntegrationsDirection), TypeInfoPropertyName = "AdminListPublicIntegrationsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListBotsSortField), TypeInfoPropertyName = "AdminListBotsSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListBotsSortDirection), TypeInfoPropertyName = "AdminListBotsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListIntegrationsVerificationStatus), TypeInfoPropertyName = "AdminListIntegrationsVerificationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListIntegrationsSortBy), TypeInfoPropertyName = "AdminListIntegrationsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListIntegrationsDirection), TypeInfoPropertyName = "AdminListIntegrationsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListIntegrationsVisibility), TypeInfoPropertyName = "AdminListIntegrationsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListPublicIntegrationsVerificationStatus?), TypeInfoPropertyName = "NullableAdminListPublicIntegrationsVerificationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListPublicIntegrationsSortBy?), TypeInfoPropertyName = "NullableAdminListPublicIntegrationsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListPublicIntegrationsDirection?), TypeInfoPropertyName = "NullableAdminListPublicIntegrationsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListBotsSortField?), TypeInfoPropertyName = "NullableAdminListBotsSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListBotsSortDirection?), TypeInfoPropertyName = "NullableAdminListBotsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListIntegrationsVerificationStatus?), TypeInfoPropertyName = "NullableAdminListIntegrationsVerificationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListIntegrationsSortBy?), TypeInfoPropertyName = "NullableAdminListIntegrationsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListIntegrationsDirection?), TypeInfoPropertyName = "NullableAdminListIntegrationsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListIntegrationsVisibility?), TypeInfoPropertyName = "NullableAdminListIntegrationsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    internal sealed partial class AdminSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AdminSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AdminSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AdminSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Botpress.AdminListPublicIntegrationsVerificationStatus)

                    || typeToConvert == typeof(global::Botpress.AdminListPublicIntegrationsVerificationStatus?)

                    || typeToConvert == typeof(global::Botpress.AdminListPublicIntegrationsSortBy)

                    || typeToConvert == typeof(global::Botpress.AdminListPublicIntegrationsSortBy?)

                    || typeToConvert == typeof(global::Botpress.AdminListPublicIntegrationsDirection)

                    || typeToConvert == typeof(global::Botpress.AdminListPublicIntegrationsDirection?)

                    || typeToConvert == typeof(global::Botpress.AdminListBotsSortField)

                    || typeToConvert == typeof(global::Botpress.AdminListBotsSortField?)

                    || typeToConvert == typeof(global::Botpress.AdminListBotsSortDirection)

                    || typeToConvert == typeof(global::Botpress.AdminListBotsSortDirection?)

                    || typeToConvert == typeof(global::Botpress.AdminListIntegrationsVerificationStatus)

                    || typeToConvert == typeof(global::Botpress.AdminListIntegrationsVerificationStatus?)

                    || typeToConvert == typeof(global::Botpress.AdminListIntegrationsSortBy)

                    || typeToConvert == typeof(global::Botpress.AdminListIntegrationsSortBy?)

                    || typeToConvert == typeof(global::Botpress.AdminListIntegrationsDirection)

                    || typeToConvert == typeof(global::Botpress.AdminListIntegrationsDirection?)

                    || typeToConvert == typeof(global::Botpress.AdminListIntegrationsVisibility)

                    || typeToConvert == typeof(global::Botpress.AdminListIntegrationsVisibility?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Botpress.AdminListPublicIntegrationsVerificationStatus))
                {
                    return new global::Botpress.JsonConverters.AdminListPublicIntegrationsVerificationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListPublicIntegrationsVerificationStatus?))
                {
                    return new global::Botpress.JsonConverters.AdminListPublicIntegrationsVerificationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListPublicIntegrationsSortBy))
                {
                    return new global::Botpress.JsonConverters.AdminListPublicIntegrationsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListPublicIntegrationsSortBy?))
                {
                    return new global::Botpress.JsonConverters.AdminListPublicIntegrationsSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListPublicIntegrationsDirection))
                {
                    return new global::Botpress.JsonConverters.AdminListPublicIntegrationsDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListPublicIntegrationsDirection?))
                {
                    return new global::Botpress.JsonConverters.AdminListPublicIntegrationsDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListBotsSortField))
                {
                    return new global::Botpress.JsonConverters.AdminListBotsSortFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListBotsSortField?))
                {
                    return new global::Botpress.JsonConverters.AdminListBotsSortFieldNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListBotsSortDirection))
                {
                    return new global::Botpress.JsonConverters.AdminListBotsSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListBotsSortDirection?))
                {
                    return new global::Botpress.JsonConverters.AdminListBotsSortDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListIntegrationsVerificationStatus))
                {
                    return new global::Botpress.JsonConverters.AdminListIntegrationsVerificationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListIntegrationsVerificationStatus?))
                {
                    return new global::Botpress.JsonConverters.AdminListIntegrationsVerificationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListIntegrationsSortBy))
                {
                    return new global::Botpress.JsonConverters.AdminListIntegrationsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListIntegrationsSortBy?))
                {
                    return new global::Botpress.JsonConverters.AdminListIntegrationsSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListIntegrationsDirection))
                {
                    return new global::Botpress.JsonConverters.AdminListIntegrationsDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListIntegrationsDirection?))
                {
                    return new global::Botpress.JsonConverters.AdminListIntegrationsDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListIntegrationsVisibility))
                {
                    return new global::Botpress.JsonConverters.AdminListIntegrationsVisibilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Botpress.AdminListIntegrationsVisibility?))
                {
                    return new global::Botpress.JsonConverters.AdminListIntegrationsVisibilityNullableJsonConverter();
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
                    0 => new AdminSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}