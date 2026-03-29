
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Direction of the message (`incoming` or `outgoing`).
    /// </summary>
    public enum RuntimeMessageDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Incoming,
        /// <summary>
        /// 
        /// </summary>
        Outgoing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuntimeMessageDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeMessageDirection value)
        {
            return value switch
            {
                RuntimeMessageDirection.Incoming => "incoming",
                RuntimeMessageDirection.Outgoing => "outgoing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeMessageDirection? ToEnum(string value)
        {
            return value switch
            {
                "incoming" => RuntimeMessageDirection.Incoming,
                "outgoing" => RuntimeMessageDirection.Outgoing,
                _ => null,
            };
        }
    }
}