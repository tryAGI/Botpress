
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminListIntegrationsSortBy
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
    public static class AdminListIntegrationsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminListIntegrationsSortBy value)
        {
            return value switch
            {
                AdminListIntegrationsSortBy.CreatedAt => "createdAt",
                AdminListIntegrationsSortBy.InstallCount => "installCount",
                AdminListIntegrationsSortBy.Name => "name",
                AdminListIntegrationsSortBy.Popularity => "popularity",
                AdminListIntegrationsSortBy.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminListIntegrationsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => AdminListIntegrationsSortBy.CreatedAt,
                "installCount" => AdminListIntegrationsSortBy.InstallCount,
                "name" => AdminListIntegrationsSortBy.Name,
                "popularity" => AdminListIntegrationsSortBy.Popularity,
                "updatedAt" => AdminListIntegrationsSortBy.UpdatedAt,
                _ => null,
            };
        }
    }
}