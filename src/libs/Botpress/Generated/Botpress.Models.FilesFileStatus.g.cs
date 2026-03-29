
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Status of the file. If the status is `upload_pending`, the file content has not been uploaded yet. The status will be set to `upload_completed` once the file content has been uploaded successfully.<br/>
    /// If the upload failed for any reason (e.g. exceeding the storage quota or the maximum file size limit) the status will be set to `upload_failed` and the reason for the failure will be available in the `failedStatusReason` field of the file.<br/>
    /// However, if the file has been uploaded and the `index` attribute was set to `true` on the file, the status will immediately transition to the `indexing_pending` status (the `upload_completed` status step will be skipped).<br/>
    /// Once the indexing is completed and the file is ready to be used for searching its status will be set to `indexing_completed`. If the indexing failed the status will be set to `indexing_failed` and the reason for the failure will be available in the `failedStatusReason` field.
    /// </summary>
    public enum FilesFileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        IndexingCompleted,
        /// <summary>
        /// 
        /// </summary>
        IndexingFailed,
        /// <summary>
        /// 
        /// </summary>
        IndexingPending,
        /// <summary>
        /// 
        /// </summary>
        UploadCompleted,
        /// <summary>
        /// 
        /// </summary>
        UploadFailed,
        /// <summary>
        /// 
        /// </summary>
        UploadPending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilesFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilesFileStatus value)
        {
            return value switch
            {
                FilesFileStatus.IndexingCompleted => "indexing_completed",
                FilesFileStatus.IndexingFailed => "indexing_failed",
                FilesFileStatus.IndexingPending => "indexing_pending",
                FilesFileStatus.UploadCompleted => "upload_completed",
                FilesFileStatus.UploadFailed => "upload_failed",
                FilesFileStatus.UploadPending => "upload_pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilesFileStatus? ToEnum(string value)
        {
            return value switch
            {
                "indexing_completed" => FilesFileStatus.IndexingCompleted,
                "indexing_failed" => FilesFileStatus.IndexingFailed,
                "indexing_pending" => FilesFileStatus.IndexingPending,
                "upload_completed" => FilesFileStatus.UploadCompleted,
                "upload_failed" => FilesFileStatus.UploadFailed,
                "upload_pending" => FilesFileStatus.UploadPending,
                _ => null,
            };
        }
    }
}