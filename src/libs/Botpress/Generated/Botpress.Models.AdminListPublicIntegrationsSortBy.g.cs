
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminListPublicIntegrationsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        InstallCount,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Popularity,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminListPublicIntegrationsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminListPublicIntegrationsSortBy value)
        {
            return value switch
            {
                AdminListPublicIntegrationsSortBy.CreatedAt => "createdAt",
                AdminListPublicIntegrationsSortBy.InstallCount => "installCount",
                AdminListPublicIntegrationsSortBy.Name => "name",
                AdminListPublicIntegrationsSortBy.Popularity => "popularity",
                AdminListPublicIntegrationsSortBy.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminListPublicIntegrationsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => AdminListPublicIntegrationsSortBy.CreatedAt,
                "installCount" => AdminListPublicIntegrationsSortBy.InstallCount,
                "name" => AdminListPublicIntegrationsSortBy.Name,
                "popularity" => AdminListPublicIntegrationsSortBy.Popularity,
                "updatedAt" => AdminListPublicIntegrationsSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}