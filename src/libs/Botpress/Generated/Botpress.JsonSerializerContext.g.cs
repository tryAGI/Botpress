
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
            typeof(global::Botpress.JsonConverters.AdminBotIntegrationsStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotIntegrationsStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotIntegrationsVisibilityJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotIntegrationsVisibilityNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotIntegrationsVerificationStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotIntegrationsVerificationStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotIntegrationsLifecycleStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotIntegrationsLifecycleStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotPluginsVisibilityJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotPluginsVisibilityNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotPluginsLifecycleStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotPluginsLifecycleStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotStatesTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotStatesTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminBotStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminIntegrationStatesTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminIntegrationStatesTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminIntegrationVisibilityJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminIntegrationVisibilityNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminIntegrationVerificationStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminIntegrationVerificationStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminIntegrationLifecycleStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminIntegrationLifecycleStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminPluginStatesTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminPluginStatesTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminPluginVisibilityJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminPluginVisibilityNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminPluginLifecycleStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminPluginLifecycleStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminWorkspaceBillingVersionJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminWorkspaceBillingVersionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminWorkspacePlanJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminWorkspacePlanNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminWorkspaceMemberRoleJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminWorkspaceMemberRoleNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminUsageTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminUsageTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminIssueCategoryJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminIssueCategoryNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminActivityCategoryJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminActivityCategoryNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant1TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant1TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant2ActionActionJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant2ActionActionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant2TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant2TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant3ItemActionActionJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant3ItemActionActionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant3TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant3TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant4TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant4TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant5TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant5TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant6TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant6TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant7TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant7TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant8TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant8TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant9TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant9TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant10TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant10TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant11TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatMessagePayloadVariant11TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.FilesFileAccessPolicieJsonConverter),

            typeof(global::Botpress.JsonConverters.FilesFileAccessPolicieNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.FilesFileStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.FilesFileStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.FilesFileOwnerTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.FilesFileOwnerTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.FilesFileIndexingStackJsonConverter),

            typeof(global::Botpress.JsonConverters.FilesFileIndexingStackNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeEventStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeEventStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeMessageDirectionJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeMessageDirectionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeMessageOriginJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeMessageOriginNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeStateTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeStateTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeWorkflowStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeWorkflowStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesFormatJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesFormatNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesItemsTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesItemsTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesPropertiesTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesPropertiesTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesXZuiComputedActionJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesTableSchemaPropertiesXZuiComputedActionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesTableSchemaTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesTableSchemaTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesColumnTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesColumnTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesColumnComputedActionJsonConverter),

            typeof(global::Botpress.JsonConverters.TablesColumnComputedActionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadAudioTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadAudioTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadCardActionActionJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadCardActionActionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadCardTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadCardTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadCarouselItemActionActionJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadCarouselItemActionActionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadCarouselTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadCarouselTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadChoiceTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadChoiceTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadDropdownTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadDropdownTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadFileTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadFileTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadImageTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadImageTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadLocationTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadLocationTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadMarkdownTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadMarkdownTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadTextTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadTextTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVideoTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageRequestPayloadVideoTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListPublicIntegrationsVerificationStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListPublicIntegrationsVerificationStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListPublicIntegrationsSortByJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListPublicIntegrationsSortByNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListPublicIntegrationsDirectionJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListPublicIntegrationsDirectionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListBotsSortFieldJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListBotsSortFieldNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListBotsSortDirectionJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListBotsSortDirectionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListIntegrationsVerificationStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListIntegrationsVerificationStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListIntegrationsSortByJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListIntegrationsSortByNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListIntegrationsDirectionJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListIntegrationsDirectionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListIntegrationsVisibilityJsonConverter),

            typeof(global::Botpress.JsonConverters.AdminListIntegrationsVisibilityNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.FilesListFilesSortFieldJsonConverter),

            typeof(global::Botpress.JsonConverters.FilesListFilesSortFieldNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.FilesListFilesSortDirectionJsonConverter),

            typeof(global::Botpress.JsonConverters.FilesListFilesSortDirectionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListConversationsSortFieldJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListConversationsSortFieldNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListConversationsSortDirectionJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListConversationsSortDirectionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListEventsStatusJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListEventsStatusNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListUsersRangeFieldJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListUsersRangeFieldNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListUsersSortFieldJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListUsersSortFieldNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListUsersSortDirectionJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListUsersSortDirectionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeSetStateExpiryTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeSetStateExpiryTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeGetStateTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeGetStateTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeSetStateTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeSetStateTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimePatchStateTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimePatchStateTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeGetOrSetStateTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeGetOrSetStateTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListTagValuesTypeJsonConverter),

            typeof(global::Botpress.JsonConverters.RuntimeListTagValuesTypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant1TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant1TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2ActionActionJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2ActionActionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3ItemActionActionJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3ItemActionActionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant4TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant4TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant5TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant5TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant6TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant6TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant7TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant7TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant8TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant8TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant9TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant9TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant10TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant10TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant11TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant11TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant1Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant1Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2ActionAction2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2ActionAction2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant2Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant3Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant4Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant4Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant5Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant5Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant6Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant6Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant7Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant7Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant8Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant8Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant9Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant9Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant10Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant10Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant11Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatListMessagesResponseMessagePayloadVariant11Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant1TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant1TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2ActionActionJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2ActionActionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3ItemActionActionJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3ItemActionActionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant4TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant4TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant5TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant5TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant6TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant6TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant7TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant7TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant8TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant8TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant9TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant9TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant10TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant10TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant11TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant11TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant1Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant1Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2ActionAction2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2ActionAction2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant2Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant3Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant4Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant4Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant5Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant5Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant6Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant6Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant7Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant7Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant8Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant8Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant9Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant9Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant10Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant10Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant11Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatGetMessageResponseMessagePayloadVariant11Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant1TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant1TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2ActionActionJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2ActionActionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3ItemActionActionJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3ItemActionActionNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant4TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant4TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant5TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant5TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant6TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant6TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant7TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant7TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant8TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant8TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant9TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant9TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant10TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant10TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant11TypeJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant11TypeNullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant1Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant1Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2ActionAction2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2ActionAction2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant2Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant3Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant4Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant4Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant5Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant5Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant6Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant6Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant7Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant7Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant8Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant8Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant9Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant9Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant10Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant10Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant11Type2JsonConverter),

            typeof(global::Botpress.JsonConverters.ChatCreateMessageResponseMessagePayloadVariant11Type2NullableJsonConverter),

            typeof(global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatMessagePayloadVariant1, global::Botpress.ChatMessagePayloadVariant2, global::Botpress.ChatMessagePayloadVariant3, global::Botpress.ChatMessagePayloadVariant4, global::Botpress.ChatMessagePayloadVariant5, global::Botpress.ChatMessagePayloadVariant6, global::Botpress.ChatMessagePayloadVariant7, global::Botpress.ChatMessagePayloadVariant8, global::Botpress.ChatMessagePayloadVariant9, global::Botpress.ChatMessagePayloadVariant10, global::Botpress.ChatMessagePayloadVariant11>),

            typeof(global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatCreateMessageRequestPayloadAudio, global::Botpress.ChatCreateMessageRequestPayloadCard, global::Botpress.ChatCreateMessageRequestPayloadCarousel, global::Botpress.ChatCreateMessageRequestPayloadChoice, global::Botpress.ChatCreateMessageRequestPayloadDropdown, global::Botpress.ChatCreateMessageRequestPayloadFile, global::Botpress.ChatCreateMessageRequestPayloadImage, global::Botpress.ChatCreateMessageRequestPayloadLocation, global::Botpress.ChatCreateMessageRequestPayloadMarkdown, global::Botpress.ChatCreateMessageRequestPayloadText, global::Botpress.ChatCreateMessageRequestPayloadVideo>),

            typeof(global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatListMessagesResponseMessagePayloadVariant1, global::Botpress.ChatListMessagesResponseMessagePayloadVariant2, global::Botpress.ChatListMessagesResponseMessagePayloadVariant3, global::Botpress.ChatListMessagesResponseMessagePayloadVariant4, global::Botpress.ChatListMessagesResponseMessagePayloadVariant5, global::Botpress.ChatListMessagesResponseMessagePayloadVariant6, global::Botpress.ChatListMessagesResponseMessagePayloadVariant7, global::Botpress.ChatListMessagesResponseMessagePayloadVariant8, global::Botpress.ChatListMessagesResponseMessagePayloadVariant9, global::Botpress.ChatListMessagesResponseMessagePayloadVariant10, global::Botpress.ChatListMessagesResponseMessagePayloadVariant11>),

            typeof(global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatListMessagesResponseMessagePayloadVariant12, global::Botpress.ChatListMessagesResponseMessagePayloadVariant22, global::Botpress.ChatListMessagesResponseMessagePayloadVariant32, global::Botpress.ChatListMessagesResponseMessagePayloadVariant42, global::Botpress.ChatListMessagesResponseMessagePayloadVariant52, global::Botpress.ChatListMessagesResponseMessagePayloadVariant62, global::Botpress.ChatListMessagesResponseMessagePayloadVariant72, global::Botpress.ChatListMessagesResponseMessagePayloadVariant82, global::Botpress.ChatListMessagesResponseMessagePayloadVariant92, global::Botpress.ChatListMessagesResponseMessagePayloadVariant102, global::Botpress.ChatListMessagesResponseMessagePayloadVariant112>),

            typeof(global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatGetMessageResponseMessagePayloadVariant1, global::Botpress.ChatGetMessageResponseMessagePayloadVariant2, global::Botpress.ChatGetMessageResponseMessagePayloadVariant3, global::Botpress.ChatGetMessageResponseMessagePayloadVariant4, global::Botpress.ChatGetMessageResponseMessagePayloadVariant5, global::Botpress.ChatGetMessageResponseMessagePayloadVariant6, global::Botpress.ChatGetMessageResponseMessagePayloadVariant7, global::Botpress.ChatGetMessageResponseMessagePayloadVariant8, global::Botpress.ChatGetMessageResponseMessagePayloadVariant9, global::Botpress.ChatGetMessageResponseMessagePayloadVariant10, global::Botpress.ChatGetMessageResponseMessagePayloadVariant11>),

            typeof(global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatGetMessageResponseMessagePayloadVariant12, global::Botpress.ChatGetMessageResponseMessagePayloadVariant22, global::Botpress.ChatGetMessageResponseMessagePayloadVariant32, global::Botpress.ChatGetMessageResponseMessagePayloadVariant42, global::Botpress.ChatGetMessageResponseMessagePayloadVariant52, global::Botpress.ChatGetMessageResponseMessagePayloadVariant62, global::Botpress.ChatGetMessageResponseMessagePayloadVariant72, global::Botpress.ChatGetMessageResponseMessagePayloadVariant82, global::Botpress.ChatGetMessageResponseMessagePayloadVariant92, global::Botpress.ChatGetMessageResponseMessagePayloadVariant102, global::Botpress.ChatGetMessageResponseMessagePayloadVariant112>),

            typeof(global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant1, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant4, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant6, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant7, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant8, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant9, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant10, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant11>),

            typeof(global::Botpress.JsonConverters.OneOfJsonConverter<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant12, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant22, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant32, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant42, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant52, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant62, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant72, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant82, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant92, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant102, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant112>),

            typeof(global::Botpress.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotIntegrations2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotIntegrations2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotIntegrationsStatus), TypeInfoPropertyName = "AdminBotIntegrationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotIntegrationsVisibility), TypeInfoPropertyName = "AdminBotIntegrationsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotIntegrationsVerificationStatus), TypeInfoPropertyName = "AdminBotIntegrationsVerificationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotIntegrationsLifecycleStatus), TypeInfoPropertyName = "AdminBotIntegrationsLifecycleStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotPlugins2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotPlugins2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotPluginsInterfaces2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotPluginsInterfaces2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotPluginsIntegrations2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotPluginsIntegrations2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotPluginsVisibility), TypeInfoPropertyName = "AdminBotPluginsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotPluginsLifecycleStatus), TypeInfoPropertyName = "AdminBotPluginsLifecycleStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotUserTags2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotUserTags2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotConversationTags2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotConversationTags2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotMessageTags2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotMessageTags2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotStates2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotStates2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotStatesType), TypeInfoPropertyName = "AdminBotStatesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotEvents2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotEvents2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotRecurringEvents2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotRecurringEvents2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotRecurringEventsSchedule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotSubscriptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotSubscriptionsEvents2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotSubscriptionsEvents2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminBotActions2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotActions2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotActionsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotActionsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotStatus), TypeInfoPropertyName = "AdminBotStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.AdminBotMedia>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminBotMedia))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationSandbox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfaces2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationInterfaces2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfacesEntities2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationInterfacesEntities2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfacesActions2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationInterfacesActions2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfacesEvents2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationInterfacesEvents2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationInterfacesChannels2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationInterfacesChannels2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationConfigurationIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationConfigurations2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationConfigurations2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationConfigurationsIdentifier))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationChannels2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationChannels2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationChannelsMessages2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationChannelsMessages2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationChannelsConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationChannelsConversationTags2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationChannelsConversationTags2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationChannelsConversationCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationChannelsMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationChannelsMessageTags2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationChannelsMessageTags2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationStates2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationStates2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationStatesType), TypeInfoPropertyName = "AdminIntegrationStatesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationEvents2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationEvents2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationActions2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationActions2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationActionsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationActionsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationUserTags2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationUserTags2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationUserCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIntegrationEntities2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationEntities2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationVisibility), TypeInfoPropertyName = "AdminIntegrationVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationVerificationStatus), TypeInfoPropertyName = "AdminIntegrationVerificationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIntegrationLifecycleStatus), TypeInfoPropertyName = "AdminIntegrationLifecycleStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminInterface))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceEntities2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminInterfaceEntities2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceEvents2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminInterfaceEvents2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceActions2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminInterfaceActions2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminInterfaceActionsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminInterfaceActionsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceChannels2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminInterfaceChannels2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminInterfaceChannelsMessages2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminInterfaceChannelsMessages2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminInterfaceNameTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPlugin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginStates2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginStates2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginStatesType), TypeInfoPropertyName = "AdminPluginStatesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginEvents2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginEvents2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginActions2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginActions2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginActionsInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginActionsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginDependencies))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginDependenciesInterfaces2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginDependenciesInterfaces2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginDependenciesIntegrations2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginDependenciesIntegrations2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginUserTags2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginUserTags2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginConversationTags2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginConversationTags2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminPluginMessageTags2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginMessageTags2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginVisibility), TypeInfoPropertyName = "AdminPluginVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminPluginLifecycleStatus), TypeInfoPropertyName = "AdminPluginLifecycleStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminWorkspace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminWorkspaceBillingVersion), TypeInfoPropertyName = "AdminWorkspaceBillingVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminWorkspacePlan), TypeInfoPropertyName = "AdminWorkspacePlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminWorkspaceMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminWorkspaceMemberRole), TypeInfoPropertyName = "AdminWorkspaceMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminUsageType), TypeInfoPropertyName = "AdminUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIssueGroupedData2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIssueGroupedData2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIssueCategory), TypeInfoPropertyName = "AdminIssueCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIssueEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.AdminIssueEventData2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminIssueEventData2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminActivityCategory), TypeInfoPropertyName = "AdminActivityCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.OneOf<global::Botpress.ChatMessagePayloadVariant1, global::Botpress.ChatMessagePayloadVariant2, global::Botpress.ChatMessagePayloadVariant3, global::Botpress.ChatMessagePayloadVariant4, global::Botpress.ChatMessagePayloadVariant5, global::Botpress.ChatMessagePayloadVariant6, global::Botpress.ChatMessagePayloadVariant7, global::Botpress.ChatMessagePayloadVariant8, global::Botpress.ChatMessagePayloadVariant9, global::Botpress.ChatMessagePayloadVariant10, global::Botpress.ChatMessagePayloadVariant11>), TypeInfoPropertyName = "ChatMessagePayloadVariant11_30375077cfc0820a")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant1Type), TypeInfoPropertyName = "ChatMessagePayloadVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatMessagePayloadVariant2Action>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant2Action))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant2ActionAction), TypeInfoPropertyName = "ChatMessagePayloadVariant2ActionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant2Type), TypeInfoPropertyName = "ChatMessagePayloadVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatMessagePayloadVariant3Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant3Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatMessagePayloadVariant3ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant3ItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant3ItemActionAction), TypeInfoPropertyName = "ChatMessagePayloadVariant3ItemActionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant3Type), TypeInfoPropertyName = "ChatMessagePayloadVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatMessagePayloadVariant4Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant4Option))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant4Type), TypeInfoPropertyName = "ChatMessagePayloadVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatMessagePayloadVariant5Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant5Option))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant5Type), TypeInfoPropertyName = "ChatMessagePayloadVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant6Type), TypeInfoPropertyName = "ChatMessagePayloadVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant7Type), TypeInfoPropertyName = "ChatMessagePayloadVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant8Type), TypeInfoPropertyName = "ChatMessagePayloadVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant9Type), TypeInfoPropertyName = "ChatMessagePayloadVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant10Type), TypeInfoPropertyName = "ChatMessagePayloadVariant10Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatMessagePayloadVariant11Type), TypeInfoPropertyName = "ChatMessagePayloadVariant11Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.FilesFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.FilesFileAccessPolicie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.FilesFileAccessPolicie), TypeInfoPropertyName = "FilesFileAccessPolicie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.FilesFileStatus), TypeInfoPropertyName = "FilesFileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.FilesFileOwner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.FilesFileOwnerType), TypeInfoPropertyName = "FilesFileOwnerType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.FilesFileIndexingStack), TypeInfoPropertyName = "FilesFileIndexingStack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeEventStatus), TypeInfoPropertyName = "RuntimeEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeMessageDirection), TypeInfoPropertyName = "RuntimeMessageDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeMessageOrigin), TypeInfoPropertyName = "RuntimeMessageOrigin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeStateType), TypeInfoPropertyName = "RuntimeStateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.RuntimeWorkflowStatus), TypeInfoPropertyName = "RuntimeWorkflowStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTableSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.TablesTableSchemaProperties2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTableSchemaProperties2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTableSchemaPropertiesType), TypeInfoPropertyName = "TablesTableSchemaPropertiesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTableSchemaPropertiesFormat), TypeInfoPropertyName = "TablesTableSchemaPropertiesFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTableSchemaPropertiesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTableSchemaPropertiesItemsType), TypeInfoPropertyName = "TablesTableSchemaPropertiesItemsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.TablesTableSchemaPropertiesProperties2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTableSchemaPropertiesProperties2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTableSchemaPropertiesPropertiesType), TypeInfoPropertyName = "TablesTableSchemaPropertiesPropertiesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTableSchemaPropertiesXZui))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTableSchemaPropertiesXZuiComputed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTableSchemaPropertiesXZuiComputedAction), TypeInfoPropertyName = "TablesTableSchemaPropertiesXZuiComputedAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesTableSchemaType), TypeInfoPropertyName = "TablesTableSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesColumnType), TypeInfoPropertyName = "TablesColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesColumnComputed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesColumnComputedAction), TypeInfoPropertyName = "TablesColumnComputedAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Botpress.TablesRowComputed2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.TablesRowComputed2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateConversationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetOrCreateConversationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatAddParticipantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.OneOf<global::Botpress.ChatCreateMessageRequestPayloadAudio, global::Botpress.ChatCreateMessageRequestPayloadCard, global::Botpress.ChatCreateMessageRequestPayloadCarousel, global::Botpress.ChatCreateMessageRequestPayloadChoice, global::Botpress.ChatCreateMessageRequestPayloadDropdown, global::Botpress.ChatCreateMessageRequestPayloadFile, global::Botpress.ChatCreateMessageRequestPayloadImage, global::Botpress.ChatCreateMessageRequestPayloadLocation, global::Botpress.ChatCreateMessageRequestPayloadMarkdown, global::Botpress.ChatCreateMessageRequestPayloadText, global::Botpress.ChatCreateMessageRequestPayloadVideo>), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadVideo_0e04a788e38dc6c9")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadAudioType), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadCard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageRequestPayloadCardAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadCardAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadCardActionAction), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadCardActionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadCardType), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadCardType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadCarousel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageRequestPayloadCarouselItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadCarouselItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageRequestPayloadCarouselItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadCarouselItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadCarouselItemActionAction), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadCarouselItemActionAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadCarouselType), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadCarouselType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageRequestPayloadChoiceOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadChoiceOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadChoiceType), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadDropdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageRequestPayloadDropdownOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadDropdownOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadDropdownType), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadDropdownType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadFileType), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadImageType), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadLocationType), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadLocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadMarkdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadMarkdownType), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadMarkdownType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadTextType), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageRequestPayloadVideoType), TypeInfoPropertyName = "ChatCreateMessageRequestPayloadVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatUpdateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetOrCreateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateEventRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListPublicIntegrationsVerificationStatus), TypeInfoPropertyName = "AdminListPublicIntegrationsVerificationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListPublicIntegrationsSortBy), TypeInfoPropertyName = "AdminListPublicIntegrationsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListPublicIntegrationsDirection), TypeInfoPropertyName = "AdminListPublicIntegrationsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListBotsSortField), TypeInfoPropertyName = "AdminListBotsSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListBotsSortDirection), TypeInfoPropertyName = "AdminListBotsSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListIntegrationsVerificationStatus), TypeInfoPropertyName = "AdminListIntegrationsVerificationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListIntegrationsSortBy), TypeInfoPropertyName = "AdminListIntegrationsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListIntegrationsDirection), TypeInfoPropertyName = "AdminListIntegrationsDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.AdminListIntegrationsVisibility), TypeInfoPropertyName = "AdminListIntegrationsVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.FilesListFilesSortField), TypeInfoPropertyName = "FilesListFilesSortField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.FilesListFilesSortDirection), TypeInfoPropertyName = "FilesListFilesSortDirection2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetConversationResponseConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetConversationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetConversationResponseConversation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatDeleteConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatDeleteConversationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateConversationResponseConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateConversationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateConversationResponseConversation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListConversationsResponseConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListConversationsResponseConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListConversationsResponseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListConversationsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListConversationsResponseConversation2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListConversationsResponseConversation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListConversationsResponseMeta2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetOrCreateConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetOrCreateConversationResponseConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetOrCreateConversationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetOrCreateConversationResponseConversation2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListenConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListenConversationResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.OneOf<global::Botpress.ChatListMessagesResponseMessagePayloadVariant1, global::Botpress.ChatListMessagesResponseMessagePayloadVariant2, global::Botpress.ChatListMessagesResponseMessagePayloadVariant3, global::Botpress.ChatListMessagesResponseMessagePayloadVariant4, global::Botpress.ChatListMessagesResponseMessagePayloadVariant5, global::Botpress.ChatListMessagesResponseMessagePayloadVariant6, global::Botpress.ChatListMessagesResponseMessagePayloadVariant7, global::Botpress.ChatListMessagesResponseMessagePayloadVariant8, global::Botpress.ChatListMessagesResponseMessagePayloadVariant9, global::Botpress.ChatListMessagesResponseMessagePayloadVariant10, global::Botpress.ChatListMessagesResponseMessagePayloadVariant11>), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant11_a0e602ddc29f7a9b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant1Type), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant1Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant2Action>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant2Action))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant2ActionAction), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant2ActionAction2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant2Type), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant2Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant3Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant3Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant3ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant3ItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant3ItemActionAction), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant3Type), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant3Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant4Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant4Option))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant4Type), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant4Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant5Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant5Option))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant5Type), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant5Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant6Type), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant6Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant7Type), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant7Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant8Type), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant8Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant9Type), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant9Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant10Type), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant10Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant11Type), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant11Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessage2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.OneOf<global::Botpress.ChatListMessagesResponseMessagePayloadVariant12, global::Botpress.ChatListMessagesResponseMessagePayloadVariant22, global::Botpress.ChatListMessagesResponseMessagePayloadVariant32, global::Botpress.ChatListMessagesResponseMessagePayloadVariant42, global::Botpress.ChatListMessagesResponseMessagePayloadVariant52, global::Botpress.ChatListMessagesResponseMessagePayloadVariant62, global::Botpress.ChatListMessagesResponseMessagePayloadVariant72, global::Botpress.ChatListMessagesResponseMessagePayloadVariant82, global::Botpress.ChatListMessagesResponseMessagePayloadVariant92, global::Botpress.ChatListMessagesResponseMessagePayloadVariant102, global::Botpress.ChatListMessagesResponseMessagePayloadVariant112>), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant112_fbc5a859c12866df")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant1Type2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant1Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant2Action2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant2Action2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant2ActionAction2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant2ActionAction22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant2Type2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant2Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant3Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant3Item2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant3ItemAction2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant3ItemAction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant3ItemActionAction2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant3ItemActionAction22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant3Type2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant3Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant4Option2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant4Option2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant4Type2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant4Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant52))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListMessagesResponseMessagePayloadVariant5Option2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant5Option2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant5Type2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant5Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant62))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant6Type2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant6Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant72))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant7Type2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant7Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant82))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant8Type2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant8Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant92))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant9Type2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant9Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant102))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant10Type2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant10Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant112))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMessagePayloadVariant11Type2), TypeInfoPropertyName = "ChatListMessagesResponseMessagePayloadVariant11Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListMessagesResponseMeta2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatAddParticipantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatAddParticipantResponseParticipant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatAddParticipantResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatAddParticipantResponseParticipant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListParticipantsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListParticipantsResponseParticipant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListParticipantsResponseParticipant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListParticipantsResponseMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListParticipantsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatListParticipantsResponseParticipant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListParticipantsResponseParticipant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatListParticipantsResponseMeta2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatRemoveParticipantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatRemoveParticipantResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetParticipantResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetParticipantResponseParticipant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetParticipantResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetParticipantResponseParticipant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.OneOf<global::Botpress.ChatGetMessageResponseMessagePayloadVariant1, global::Botpress.ChatGetMessageResponseMessagePayloadVariant2, global::Botpress.ChatGetMessageResponseMessagePayloadVariant3, global::Botpress.ChatGetMessageResponseMessagePayloadVariant4, global::Botpress.ChatGetMessageResponseMessagePayloadVariant5, global::Botpress.ChatGetMessageResponseMessagePayloadVariant6, global::Botpress.ChatGetMessageResponseMessagePayloadVariant7, global::Botpress.ChatGetMessageResponseMessagePayloadVariant8, global::Botpress.ChatGetMessageResponseMessagePayloadVariant9, global::Botpress.ChatGetMessageResponseMessagePayloadVariant10, global::Botpress.ChatGetMessageResponseMessagePayloadVariant11>), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant11_6555f8326b55cfad")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant1Type), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant1Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatGetMessageResponseMessagePayloadVariant2Action>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant2Action))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant2ActionAction), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant2ActionAction2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant2Type), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant2Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatGetMessageResponseMessagePayloadVariant3Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant3Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatGetMessageResponseMessagePayloadVariant3ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant3ItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant3ItemActionAction), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant3Type), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant3Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Option))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Type), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant4Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatGetMessageResponseMessagePayloadVariant5Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant5Option))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant5Type), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant5Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant6Type), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant6Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant7Type), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant7Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant8Type), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant8Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant9Type), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant9Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant10Type), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant10Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant11Type), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant11Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessage2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.OneOf<global::Botpress.ChatGetMessageResponseMessagePayloadVariant12, global::Botpress.ChatGetMessageResponseMessagePayloadVariant22, global::Botpress.ChatGetMessageResponseMessagePayloadVariant32, global::Botpress.ChatGetMessageResponseMessagePayloadVariant42, global::Botpress.ChatGetMessageResponseMessagePayloadVariant52, global::Botpress.ChatGetMessageResponseMessagePayloadVariant62, global::Botpress.ChatGetMessageResponseMessagePayloadVariant72, global::Botpress.ChatGetMessageResponseMessagePayloadVariant82, global::Botpress.ChatGetMessageResponseMessagePayloadVariant92, global::Botpress.ChatGetMessageResponseMessagePayloadVariant102, global::Botpress.ChatGetMessageResponseMessagePayloadVariant112>), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant112_4f90c00d751ae5f5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant1Type2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant1Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatGetMessageResponseMessagePayloadVariant2Action2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant2Action2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant2ActionAction2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant2ActionAction22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant2Type2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant2Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatGetMessageResponseMessagePayloadVariant3Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant3Item2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatGetMessageResponseMessagePayloadVariant3ItemAction2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant3ItemAction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant3ItemActionAction2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant3ItemActionAction22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant3Type2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant3Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Option2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Option2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Type2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant4Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant52))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatGetMessageResponseMessagePayloadVariant5Option2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant5Option2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant5Type2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant5Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant62))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant6Type2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant6Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant72))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant7Type2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant7Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant82))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant8Type2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant8Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant92))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant9Type2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant9Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant102))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant10Type2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant10Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant112))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetMessageResponseMessagePayloadVariant11Type2), TypeInfoPropertyName = "ChatGetMessageResponseMessagePayloadVariant11Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatDeleteMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatDeleteMessageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.OneOf<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant1, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant4, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant6, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant7, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant8, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant9, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant10, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant11>), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant11_bb7acc1a28a0e3f0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant1Type), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant1Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2Action>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2Action))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2ActionAction), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant2ActionAction2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2Type), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant2Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3ItemAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3Type), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant3Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant4Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant4Option))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant4Type), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant4Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5Option))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5Type), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant5Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant6Type), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant6Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant7Type), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant7Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant8Type), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant8Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant9Type), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant9Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant10Type), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant10Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant11Type), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant11Type2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessage2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.OneOf<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant12, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant22, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant32, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant42, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant52, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant62, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant72, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant82, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant92, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant102, global::Botpress.ChatCreateMessageResponseMessagePayloadVariant112>), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant112_7859003751ea8545")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant1Type2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant1Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2Action2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2Action2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2ActionAction2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant2ActionAction22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2Type2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant2Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3Item2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3ItemAction2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3ItemAction2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant3ItemActionAction22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3Type2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant3Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant4Option2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant4Option2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant4Type2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant4Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant52))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5Option2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5Option2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5Type2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant5Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant62))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant6Type2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant6Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant72))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant7Type2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant7Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant82))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant8Type2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant8Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant92))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant9Type2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant9Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant102))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant10Type2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant10Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant112))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateMessageResponseMessagePayloadVariant11Type2), TypeInfoPropertyName = "ChatCreateMessageResponseMessagePayloadVariant11Type22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetUserResponseUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetUserResponseUser2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatUpdateUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatUpdateUserResponseUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatUpdateUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatUpdateUserResponseUser2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatDeleteUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatDeleteUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateUserResponseUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateUserResponseUser2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetOrCreateUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetOrCreateUserResponseUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetOrCreateUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetOrCreateUserResponseUser2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetEventResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetEventResponseEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetEventResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatGetEventResponseEvent2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateEventResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateEventResponseEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateEventResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Botpress.ChatCreateEventResponseEvent2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.AdminBotMedia>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatMessagePayloadVariant2Action>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatMessagePayloadVariant3Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatMessagePayloadVariant3ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatMessagePayloadVariant4Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatMessagePayloadVariant5Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.FilesFileAccessPolicie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageRequestPayloadCardAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageRequestPayloadCarouselItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageRequestPayloadCarouselItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageRequestPayloadChoiceOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageRequestPayloadDropdownOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListConversationsResponseConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListConversationsResponseConversation2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListMessagesResponseMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListMessagesResponseMessagePayloadVariant2Action>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListMessagesResponseMessagePayloadVariant3Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListMessagesResponseMessagePayloadVariant3ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListMessagesResponseMessagePayloadVariant4Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListMessagesResponseMessagePayloadVariant5Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListMessagesResponseMessage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListMessagesResponseMessagePayloadVariant2Action2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListMessagesResponseMessagePayloadVariant3Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListMessagesResponseMessagePayloadVariant3ItemAction2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListMessagesResponseMessagePayloadVariant4Option2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListMessagesResponseMessagePayloadVariant5Option2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListParticipantsResponseParticipant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatListParticipantsResponseParticipant2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatGetMessageResponseMessagePayloadVariant2Action>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatGetMessageResponseMessagePayloadVariant3Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatGetMessageResponseMessagePayloadVariant3ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatGetMessageResponseMessagePayloadVariant5Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatGetMessageResponseMessagePayloadVariant2Action2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatGetMessageResponseMessagePayloadVariant3Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatGetMessageResponseMessagePayloadVariant3ItemAction2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatGetMessageResponseMessagePayloadVariant4Option2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatGetMessageResponseMessagePayloadVariant5Option2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2Action>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3ItemAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant4Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5Option>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant2Action2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3Item2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant3ItemAction2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant4Option2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Botpress.ChatCreateMessageResponseMessagePayloadVariant5Option2>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}