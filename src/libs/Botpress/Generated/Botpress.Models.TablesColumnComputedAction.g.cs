
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum TablesColumnComputedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TablesColumnComputedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TablesColumnComputedAction value)
        {
            return value switch
            {
                TablesColumnComputedAction.Ai => "ai",
                TablesColumnComputedAction.Code => "code",
                TablesColumnComputedAction.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TablesColumnComputedAction? ToEnum(string value)
        {
            return value switch
            {
                "ai" => TablesColumnComputedAction.Ai,
                "code" => TablesColumnComputedAction.Code,
                "workflow" => TablesColumnComputedAction.Workflow,
                _ => null,
            };
        }
    }
}