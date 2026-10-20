
#nullable enable

namespace Inception
{
    /// <summary>
    /// The reason the model stopped generating tokens.
    /// </summary>
    public enum TextChunkChoiceFinishReason
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextChunkChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextChunkChoiceFinishReason value)
        {
            return value switch
            {
                TextChunkChoiceFinishReason.ContentFilter => "content_filter",
                TextChunkChoiceFinishReason.Length => "length",
                TextChunkChoiceFinishReason.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextChunkChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => TextChunkChoiceFinishReason.ContentFilter,
                "length" => TextChunkChoiceFinishReason.Length,
                "stop" => TextChunkChoiceFinishReason.Stop,
                _ => null,
            };
        }
    }
}