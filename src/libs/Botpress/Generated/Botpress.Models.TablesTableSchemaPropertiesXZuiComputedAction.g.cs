
#nullable enable

namespace Botpress
{
    /// <summary>
    /// 
    /// </summary>
    public enum TablesTableSchemaPropertiesXZuiComputedAction
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
    public static class TablesTableSchemaPropertiesXZuiComputedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TablesTableSchemaPropertiesXZuiComputedAction value)
        {
            return value switch
            {
                TablesTableSchemaPropertiesXZuiComputedAction.Ai => "ai",
                TablesTableSchemaPropertiesXZuiComputedAction.Code => "code",
                TablesTableSchemaPropertiesXZuiComputedAction.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TablesTableSchemaPropertiesXZuiComputedAction? ToEnum(string value)
        {
            return value switch
            {
                "ai" => TablesTableSchemaPropertiesXZuiComputedAction.Ai,
                "code" => TablesTableSchemaPropertiesXZuiComputedAction.Code,
                "workflow" => TablesTableSchemaPropertiesXZuiComputedAction.Workflow,
                _ => null,
            };
        }
    }
}