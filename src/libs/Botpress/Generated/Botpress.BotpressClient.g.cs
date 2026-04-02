
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Unified Botpress API covering Admin, Chat, Files, Runtime, and Tables APIs.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class BotpressClient : global::Botpress.IBotpressClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.botpress.cloud";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Botpress.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Botpress.JsonConverters.AdminBotIntegrationsStatusJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotIntegrationsStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotIntegrationsVisibilityJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotIntegrationsVisibilityNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotIntegrationsVerificationStatusJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotIntegrationsVerificationStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotIntegrationsLifecycleStatusJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotIntegrationsLifecycleStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotPluginsVisibilityJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotPluginsVisibilityNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotPluginsLifecycleStatusJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotPluginsLifecycleStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotStatesTypeJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotStatesTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotStatusJsonConverter(),
                    new global::Botpress.JsonConverters.AdminBotStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminIntegrationStatesTypeJsonConverter(),
                    new global::Botpress.JsonConverters.AdminIntegrationStatesTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminIntegrationVisibilityJsonConverter(),
                    new global::Botpress.JsonConverters.AdminIntegrationVisibilityNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminIntegrationVerificationStatusJsonConverter(),
                    new global::Botpress.JsonConverters.AdminIntegrationVerificationStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminIntegrationLifecycleStatusJsonConverter(),
                    new global::Botpress.JsonConverters.AdminIntegrationLifecycleStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminPluginStatesTypeJsonConverter(),
                    new global::Botpress.JsonConverters.AdminPluginStatesTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminPluginVisibilityJsonConverter(),
                    new global::Botpress.JsonConverters.AdminPluginVisibilityNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminPluginLifecycleStatusJsonConverter(),
                    new global::Botpress.JsonConverters.AdminPluginLifecycleStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminWorkspaceBillingVersionJsonConverter(),
                    new global::Botpress.JsonConverters.AdminWorkspaceBillingVersionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminWorkspacePlanJsonConverter(),
                    new global::Botpress.JsonConverters.AdminWorkspacePlanNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminWorkspaceMemberRoleJsonConverter(),
                    new global::Botpress.JsonConverters.AdminWorkspaceMemberRoleNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminUsageTypeJsonConverter(),
                    new global::Botpress.JsonConverters.AdminUsageTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminIssueCategoryJsonConverter(),
                    new global::Botpress.JsonConverters.AdminIssueCategoryNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminActivityCategoryJsonConverter(),
                    new global::Botpress.JsonConverters.AdminActivityCategoryNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant1TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant1TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant2ActionActionJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant2ActionActionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant2TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant2TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant3ItemActionActionJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant3ItemActionActionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant3TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant3TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant4TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant4TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant5TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant5TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant6TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant6TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant7TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant7TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant8TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant8TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant9TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant9TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant10TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant10TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant11TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatMessagePayloadVariant11TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.FilesFileAccessPolicieJsonConverter(),
                    new global::Botpress.JsonConverters.FilesFileAccessPolicieNullableJsonConverter(),
                    new global::Botpress.JsonConverters.FilesFileStatusJsonConverter(),
                    new global::Botpress.JsonConverters.FilesFileStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.FilesFileOwnerTypeJsonConverter(),
                    new global::Botpress.JsonConverters.FilesFileOwnerTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.FilesFileIndexingStackJsonConverter(),
                    new global::Botpress.JsonConverters.FilesFileIndexingStackNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeEventStatusJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeEventStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeMessageDirectionJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeMessageDirectionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeMessageOriginJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeMessageOriginNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeStateTypeJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeStateTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeWorkflowStatusJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeWorkflowStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.TablesTableSchemaPropertiesTypeJsonConverter(),
                    new global::Botpress.JsonConverters.TablesTableSchemaPropertiesTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.TablesTableSchemaPropertiesFormatJsonConverter(),
                    new global::Botpress.JsonConverters.TablesTableSchemaPropertiesFormatNullableJsonConverter(),
                    new global::Botpress.JsonConverters.TablesTableSchemaPropertiesItemsTypeJsonConverter(),
                    new global::Botpress.JsonConverters.TablesTableSchemaPropertiesItemsTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.TablesTableSchemaPropertiesPropertiesTypeJsonConverter(),
                    new global::Botpress.JsonConverters.TablesTableSchemaPropertiesPropertiesTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.TablesTableSchemaPropertiesXZuiComputedActionJsonConverter(),
                    new global::Botpress.JsonConverters.TablesTableSchemaPropertiesXZuiComputedActionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.TablesTableSchemaTypeJsonConverter(),
                    new global::Botpress.JsonConverters.TablesTableSchemaTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.TablesColumnTypeJsonConverter(),
                    new global::Botpress.JsonConverters.TablesColumnTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.TablesColumnComputedActionJsonConverter(),
                    new global::Botpress.JsonConverters.TablesColumnComputedActionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant1TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant1TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant2ActionActionJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant2ActionActionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant2TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant2TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant3ItemActionActionJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant3ItemActionActionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant3TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant3TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant4TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant4TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant5TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant5TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant6TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant6TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant7TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant7TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant8TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant8TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant9TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant9TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant10TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant10TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant11TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVariant11TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListPublicIntegrationsVerificationStatusJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListPublicIntegrationsVerificationStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListPublicIntegrationsSortByJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListPublicIntegrationsSortByNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListPublicIntegrationsDirectionJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListPublicIntegrationsDirectionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListBotsSortFieldJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListBotsSortFieldNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListBotsSortDirectionJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListBotsSortDirectionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListIntegrationsVerificationStatusJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListIntegrationsVerificationStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListIntegrationsSortByJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListIntegrationsSortByNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListIntegrationsDirectionJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListIntegrationsDirectionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListIntegrationsVisibilityJsonConverter(),
                    new global::Botpress.JsonConverters.AdminListIntegrationsVisibilityNullableJsonConverter(),
                    new global::Botpress.JsonConverters.FilesListFilesSortFieldJsonConverter(),
                    new global::Botpress.JsonConverters.FilesListFilesSortFieldNullableJsonConverter(),
                    new global::Botpress.JsonConverters.FilesListFilesSortDirectionJsonConverter(),
                    new global::Botpress.JsonConverters.FilesListFilesSortDirectionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListConversationsSortFieldJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListConversationsSortFieldNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListConversationsSortDirectionJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListConversationsSortDirectionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListEventsStatusJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListEventsStatusNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListUsersRangeFieldJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListUsersRangeFieldNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListUsersSortFieldJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListUsersSortFieldNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListUsersSortDirectionJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListUsersSortDirectionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeSetStateExpiryTypeJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeSetStateExpiryTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeGetStateTypeJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeGetStateTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeSetStateTypeJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeSetStateTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimePatchStateTypeJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimePatchStateTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeGetOrSetStateTypeJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeGetOrSetStateTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListTagValuesTypeJsonConverter(),
                    new global::Botpress.JsonConverters.RuntimeListTagValuesTypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant1TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant1TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2ActionActionJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2ActionActionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3ItemActionActionJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3ItemActionActionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant4TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant4TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant5TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant5TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant6TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant6TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant7TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant7TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant8TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant8TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant9TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant9TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant10TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant10TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant11TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant11TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant1Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant1Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2ActionAction2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2ActionAction2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant4Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant4Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant5Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant5Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant6Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant6Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant7Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant7Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant8Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant8Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant9Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant9Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant10Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant10Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant11Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant11Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant1TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant1TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2ActionActionJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2ActionActionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3ItemActionActionJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3ItemActionActionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant4TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant4TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant5TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant5TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant6TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant6TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant7TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant7TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant8TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant8TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant9TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant9TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant10TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant10TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant11TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant11TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant1Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant1Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2ActionAction2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2ActionAction2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant4Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant4Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant5Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant5Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant6Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant6Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant7Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant7Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant8Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant8Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant9Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant9Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant10Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant10Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant11Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant11Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant1TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant1TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2ActionActionJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2ActionActionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3ItemActionActionJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3ItemActionActionNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant4TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant4TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant5TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant5TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant6TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant6TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant7TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant7TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant8TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant8TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant9TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant9TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant10TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant10TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant11TypeJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant11TypeNullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant1Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant1Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2ActionAction2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2ActionAction2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant4Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant4Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant5Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant5Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant6Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant6Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant7Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant7Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant8Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant8Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant9Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant9Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant10Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant10Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant11Type2JsonConverter(),
                    new global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant11Type2NullableJsonConverter(),
                    new global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatMessagePayloadVariant1, global::Botpress.ChatMessagePayloadVariant2, global::Botpress.ChatMessagePayloadVariant3, global::Botpress.ChatMessagePayloadVariant4, global::Botpress.ChatMessagePayloadVariant5, global::Botpress.ChatMessagePayloadVariant6, global::Botpress.ChatMessagePayloadVariant7, global::Botpress.ChatMessagePayloadVariant8, global::Botpress.ChatMessagePayloadVariant9, global::Botpress.ChatMessagePayloadVariant10, global::Botpress.ChatMessagePayloadVariant11>(),
                    new global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatCreateMessageRequestPayloadVariant1, global::Botpress.ChatCreateMessageRequestPayloadVariant2, global::Botpress.ChatCreateMessageRequestPayloadVariant3, global::Botpress.ChatCreateMessageRequestPayloadVariant4, global::Botpress.ChatCreateMessageRequestPayloadVariant5, global::Botpress.ChatCreateMessageRequestPayloadVariant6, global::Botpress.ChatCreateMessageRequestPayloadVariant7, global::Botpress.ChatCreateMessageRequestPayloadVariant8, global::Botpress.ChatCreateMessageRequestPayloadVariant9, global::Botpress.ChatCreateMessageRequestPayloadVariant10, global::Botpress.ChatCreateMessageRequestPayloadVariant11>(),
                    new global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatListMessagesResponseMessagePayloadVariant1, global::Botpress.ChatListMessagesResponseMessagePayloadVariant2, global::Botpress.ChatListMessagesResponseMessagePayloadVariant3, global::Botpress.ChatListMessagesResponseMessagePayloadVariant4, global::Botpress.ChatListMessagesResponseMessagePayloadVariant5, global::Botpress.ChatListMessagesResponseMessagePayloadVariant6, global::Botpress.ChatListMessagesResponseMessagePayloadVariant7, global::Botpress.ChatListMessagesResponseMessagePayloadVariant8, global::Botpress.ChatListMessagesResponseMessagePayloadVariant9, global::Botpress.ChatListMessagesResponseMessagePayloadVariant10, global::Botpress.ChatListMessagesResponseMessagePayloadVariant11>(),
                    new global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatListMessagesResponseMessagePayloadVariant12, global::Botpress.ChatListMessagesResponseMessagePayloadVariant22, global::Botpress.ChatListMessagesResponseMessagePayloadVariant32, global::Botpress.ChatListMessagesResponseMessagePayloadVariant42, global::Botpress.ChatListMessagesResponseMessagePayloadVariant52, global::Botpress.ChatListMessagesResponseMessagePayloadVariant62, global::Botpress.ChatListMessagesResponseMessagePayloadVariant72, global::Botpress.ChatListMessagesResponseMessagePayloadVariant82, global::Botpress.ChatListMessagesResponseMessagePayloadVariant92, global::Botpress.ChatListMessagesResponseMessagePayloadVariant102, global::Botpress.ChatListMessagesResponseMessagePayloadVariant112>(),
                    new global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatGetMessageResponseMessagePayloadVariant1, global::Botpress.ChatGetMessageResponseMessagePayloadVariant2, global::Botpress.ChatGetMessageResponseMessagePayloadVariant3, global::Botpress.ChatGetMessageResponseMessagePayloadVariant4, global::Botpress.ChatGetMessageResponseMessagePayloadVariant5, global::Botpress.ChatGetMessageResponseMessagePayloadVariant6, global::Botpress.ChatGetMessageResponseMessagePayloadVariant7, global::Botpress.ChatGetMessageResponseMessagePayloadVariant8, global::Botpress.ChatGetMessageResponseMessagePayloadVariant9, global::Botpress.ChatGetMessageResponseMessagePayloadVariant10, global::Botpress.ChatGetMessageResponseMessagePayloadVariant11>(),
                    new global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatGetMessageResponseMessagePayloadVariant12, global::Botpress.ChatGetMessageResponseMessagePayloadVariant22, global::Botpress.ChatGetMessageResponseMessagePayloadVariant32, global::Botpress.ChatGetMessageResponseMessagePayloadVariant42, global::Botpress.ChatGetMessageResponseMessagePayloadVariant52, global::Botpress.ChatGetMessageResponseMessagePayloadVariant62, global::Botpress.ChatGetMessageResponseMessagePayloadVariant72, global::Botpress.ChatGetMessageResponseMessagePayloadVariant82, global::Botpress.ChatGetMessageResponseMessagePayloadVariant92, global::Botpress.ChatGetMessageResponseMessagePayloadVariant102, global::Botpress.ChatGetMessageResponseMessagePayloadVariant112>(),
                    new global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant1, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant4, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant6, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant7, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant8, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant9, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant10, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant11>(),
                    new global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant12, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant22, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant32, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant42, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant52, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant62, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant72, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant82, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant92, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant102, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant112>(),
                    new global::Botpress.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AdminClient Admin => new AdminClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RuntimeClient Runtime => new RuntimeClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TablesClient Tables => new TablesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the BotpressClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public BotpressClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Botpress.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Botpress.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}