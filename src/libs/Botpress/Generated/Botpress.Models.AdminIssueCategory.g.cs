
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum AdminIssueCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Configuration,
        /// <summary>
        /// 
        /// </summary>
        Limits,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        UserCode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdminIssueCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdminIssueCategory value)
        {
            return value switch
            {
                AdminIssueCategory.Configuration => "configuration",
                AdminIssueCategory.Limits => "limits",
                AdminIssueCategory.Other => "other",
                AdminIssueCategory.UserCode => "user_code",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdminIssueCategory? ToEnum(string value)
        {
            return value switch
            {
                "configuration" => AdminIssueCategory.Configuration,
                "limits" => AdminIssueCategory.Limits,
                "other" => AdminIssueCategory.Other,
                "user_code" => AdminIssueCategory.UserCode,
                _ => null,
            };
        }
    }
}