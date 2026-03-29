
#nullable enable

namespace Botpress
{
    /// <summary>
    /// Origin of the message (`synthetic`).
    /// </summary>
    public enum RuntimeMessageOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        Synthetic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RuntimeMessageOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RuntimeMessageOrigin value)
        {
            return value switch
            {
                RuntimeMessageOrigin.Synthetic => "synthetic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RuntimeMessageOrigin? ToEnum(string value)
        {
            return value switch
            {
                "synthetic" => RuntimeMessageOrigin.Synthetic,
                _ => null,
            };
        }
    }
}