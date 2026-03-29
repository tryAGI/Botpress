
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Usage type that can be used
    /// </summary>
    public enum AdminUsageType
    {
        /// <summary>
        /// 
        /// </summary>
        AiSpend,
        /// <summary>
        /// 
        /// </summary>
        AlwaysAlive,
        /// <summary>
        /// 
        /// </summary>
        BingSearchSpend,
        /// <summary>
        /// 
        /// </summary>
        BotCount,
        /// <summary>
        /// 
        /// </summary>
        FileMaxSizeBytes,
        /// <summary>
        /// 
        /// </summary>
        IndexedFileCount,
        /// <summary>
        /// 
        /// </summary>
        IntegrationsOwnedCount,
        /// <summary>
        /// 
        /// </summary>
        InvocationCalls,
        /// <summary>
        /// 
        /// </summary>
        InvocationTimeout,
        /// <summary>
        /// 
        /// </summary>
        KnowledgebaseVectorStorage,
        /// <summary>
        /// 
        /// </summary>
        OpenaiSpend,
        /// <summary>
        /// 
        /// </summary>
        StorageCount,
        /// <summary>
        /// 
        /// </summary>
        TableRowCount,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceMemberCount,
        /// <summary>
        /// 
        /// </summary>
        WorkspaceRatelimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminUsageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminUsageType value)
        {
            return value switch
            {
                AdminUsageType.AiSpend => "ai_spend",
                AdminUsageType.AlwaysAlive => "always_alive",
                AdminUsageType.BingSearchSpend => "bing_search_spend",
                AdminUsageType.BotCount => "bot_count",
                AdminUsageType.FileMaxSizeBytes => "file_max_size_bytes",
                AdminUsageType.IndexedFileCount => "indexed_file_count",
                AdminUsageType.IntegrationsOwnedCount => "integrations_owned_count",
                AdminUsageType.InvocationCalls => "invocation_calls",
                AdminUsageType.InvocationTimeout => "invocation_timeout",
                AdminUsageType.KnowledgebaseVectorStorage => "knowledgebase_vector_storage",
                AdminUsageType.OpenaiSpend => "openai_spend",
                AdminUsageType.StorageCount => "storage_count",
                AdminUsageType.TableRowCount => "table_row_count",
                AdminUsageType.WorkspaceMemberCount => "workspace_member_count",
                AdminUsageType.WorkspaceRatelimit => "workspace_ratelimit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminUsageType? ToEnum(string value)
        {
            return value switch
            {
                "ai_spend" => AdminUsageType.AiSpend,
                "always_alive" => AdminUsageType.AlwaysAlive,
                "bing_search_spend" => AdminUsageType.BingSearchSpend,
                "bot_count" => AdminUsageType.BotCount,
                "file_max_size_bytes" => AdminUsageType.FileMaxSizeBytes,
                "indexed_file_count" => AdminUsageType.IndexedFileCount,
                "integrations_owned_count" => AdminUsageType.IntegrationsOwnedCount,
                "invocation_calls" => AdminUsageType.InvocationCalls,
                "invocation_timeout" => AdminUsageType.InvocationTimeout,
                "knowledgebase_vector_storage" => AdminUsageType.KnowledgebaseVectorStorage,
                "openai_spend" => AdminUsageType.OpenaiSpend,
                "storage_count" => AdminUsageType.StorageCount,
                "table_row_count" => AdminUsageType.TableRowCount,
                "workspace_member_count" => AdminUsageType.WorkspaceMemberCount,
                "workspace_ratelimit" => AdminUsageType.WorkspaceRatelimit,
                _ => null,
            };
        }
    }
}