
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilesFile
    {
        /// <summary>
        /// File ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the bot the file belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("botId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BotId { get; set; }

        /// <summary>
        /// Unique key for the file. Must be unique across the bot (and the integration, when applicable).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// URL to retrieve the file content. This URL will be ready to use once the file is uploaded.<br/>
        /// If the file has a `public_content` policy, this will contain the permanent public URL to retrieve the file, otherwise this will contain a temporary pre-signed URL to download the file which should be used shortly after retrieving and should not be stored long-term as the URL will expire after a short timeframe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// File size in bytes. Non-null if file upload status is "COMPLETE".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public double? Size { get; set; }

        /// <summary>
        /// MIME type of the file's content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// The tags of the file as an object of key/value pairs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Metadata of the file as an object of key/value pairs. The values can be of any type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Metadata { get; set; }

        /// <summary>
        /// File creation timestamp in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// File last update timestamp in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Access policies configured for the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessPolicies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Botpress.FilesFileAccessPolicie> AccessPolicies { get; set; }

        /// <summary>
        /// Whether the file was requested to be indexed for search or not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Index { get; set; }

        /// <summary>
        /// Status of the file. If the status is `upload_pending`, the file content has not been uploaded yet. The status will be set to `upload_completed` once the file content has been uploaded successfully.<br/>
        /// If the upload failed for any reason (e.g. exceeding the storage quota or the maximum file size limit) the status will be set to `upload_failed` and the reason for the failure will be available in the `failedStatusReason` field of the file.<br/>
        /// However, if the file has been uploaded and the `index` attribute was set to `true` on the file, the status will immediately transition to the `indexing_pending` status (the `upload_completed` status step will be skipped).<br/>
        /// Once the indexing is completed and the file is ready to be used for searching its status will be set to `indexing_completed`. If the indexing failed the status will be set to `indexing_failed` and the reason for the failure will be available in the `failedStatusReason` field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.FilesFileStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.FilesFileStatus Status { get; set; }

        /// <summary>
        /// If the file status is `upload_failed` or `indexing_failed` this will contain the reason of the failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedStatusReason")]
        public string? FailedStatusReason { get; set; }

        /// <summary>
        /// File expiry timestamp in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Botpress.FilesFileOwner Owner { get; set; }

        /// <summary>
        /// Indicates the indexing stack used to index this file. Present only when file has been successfully indexed. A value of "v2" denotes the latest stack, "v1" denotes the legacy stack.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexingStack")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Botpress.JsonConverters.FilesFileIndexingStackJsonConverter))]
        public global::Botpress.FilesFileIndexingStack? IndexingStack { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFile" /> class.
        /// </summary>
        /// <param name="id">
        /// File ID
        /// </param>
        /// <param name="botId">
        /// The ID of the bot the file belongs to
        /// </param>
        /// <param name="key">
        /// Unique key for the file. Must be unique across the bot (and the integration, when applicable).
        /// </param>
        /// <param name="url">
        /// URL to retrieve the file content. This URL will be ready to use once the file is uploaded.<br/>
        /// If the file has a `public_content` policy, this will contain the permanent public URL to retrieve the file, otherwise this will contain a temporary pre-signed URL to download the file which should be used shortly after retrieving and should not be stored long-term as the URL will expire after a short timeframe.
        /// </param>
        /// <param name="contentType">
        /// MIME type of the file's content
        /// </param>
        /// <param name="tags">
        /// The tags of the file as an object of key/value pairs
        /// </param>
        /// <param name="metadata">
        /// Metadata of the file as an object of key/value pairs. The values can be of any type.
        /// </param>
        /// <param name="createdAt">
        /// File creation timestamp in ISO 8601 format
        /// </param>
        /// <param name="updatedAt">
        /// File last update timestamp in ISO 8601 format
        /// </param>
        /// <param name="accessPolicies">
        /// Access policies configured for the file.
        /// </param>
        /// <param name="index">
        /// Whether the file was requested to be indexed for search or not.
        /// </param>
        /// <param name="status">
        /// Status of the file. If the status is `upload_pending`, the file content has not been uploaded yet. The status will be set to `upload_completed` once the file content has been uploaded successfully.<br/>
        /// If the upload failed for any reason (e.g. exceeding the storage quota or the maximum file size limit) the status will be set to `upload_failed` and the reason for the failure will be available in the `failedStatusReason` field of the file.<br/>
        /// However, if the file has been uploaded and the `index` attribute was set to `true` on the file, the status will immediately transition to the `indexing_pending` status (the `upload_completed` status step will be skipped).<br/>
        /// Once the indexing is completed and the file is ready to be used for searching its status will be set to `indexing_completed`. If the indexing failed the status will be set to `indexing_failed` and the reason for the failure will be available in the `failedStatusReason` field.
        /// </param>
        /// <param name="owner"></param>
        /// <param name="size">
        /// File size in bytes. Non-null if file upload status is "COMPLETE".
        /// </param>
        /// <param name="failedStatusReason">
        /// If the file status is `upload_failed` or `indexing_failed` this will contain the reason of the failure.
        /// </param>
        /// <param name="expiresAt">
        /// File expiry timestamp in ISO 8601 format
        /// </param>
        /// <param name="indexingStack">
        /// Indicates the indexing stack used to index this file. Present only when file has been successfully indexed. A value of "v2" denotes the latest stack, "v1" denotes the legacy stack.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilesFile(
            string id,
            string botId,
            string key,
            string url,
            string contentType,
            global::System.Collections.Generic.Dictionary<string, string> tags,
            global::System.Collections.Generic.Dictionary<string, object?> metadata,
            string createdAt,
            string updatedAt,
            global::System.Collections.Generic.IList<global::Botpress.FilesFileAccessPolicie> accessPolicies,
            bool index,
            global::Botpress.FilesFileStatus status,
            global::Botpress.FilesFileOwner owner,
            double? size,
            string? failedStatusReason,
            string? expiresAt,
            global::Botpress.FilesFileIndexingStack? indexingStack)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BotId = botId ?? throw new global::System.ArgumentNullException(nameof(botId));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Size = size;
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.AccessPolicies = accessPolicies ?? throw new global::System.ArgumentNullException(nameof(accessPolicies));
            this.Index = index;
            this.Status = status;
            this.FailedStatusReason = failedStatusReason;
            this.ExpiresAt = expiresAt;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.IndexingStack = indexingStack;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilesFile" /> class.
        /// </summary>
        public FilesFile()
        {
        }
    }
}