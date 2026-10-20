
#nullable enable

namespace Inception
{
    /// <summary>
    /// The reason the model stopped generating tokens.
    /// </summary>
    public enum ChunkChoiceFinishReason
    {
        /// <summary>
        ///
        /// </summary>
        ContentFilter,
        /// <summary>
        ///
        /// </summary>
        Length,
        /// <summary>
        ///
        /// </summary>
        Stop,
        /// <summary>
        ///
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChunkChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkChoiceFinishReason value)
        {
            return value switch
            {
                ChunkChoiceFinishReason.ContentFilter => "content_filter",
                ChunkChoiceFinishReason.Length => "length",
                ChunkChoiceFinishReason.Stop => "stop",
                ChunkChoiceFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => ChunkChoiceFinishReason.ContentFilter,
                "length" => ChunkChoiceFinishReason.Length,
                "stop" => ChunkChoiceFinishReason.Stop,
                "tool_calls" => ChunkChoiceFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}