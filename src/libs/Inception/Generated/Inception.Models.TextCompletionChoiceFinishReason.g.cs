
#nullable enable

namespace Inception
{
    /// <summary>
    /// The reason the model stopped generating tokens.
    /// </summary>
    public enum TextCompletionChoiceFinishReason
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
    public static class TextCompletionChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextCompletionChoiceFinishReason value)
        {
            return value switch
            {
                TextCompletionChoiceFinishReason.ContentFilter => "content_filter",
                TextCompletionChoiceFinishReason.Length => "length",
                TextCompletionChoiceFinishReason.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextCompletionChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => TextCompletionChoiceFinishReason.ContentFilter,
                "length" => TextCompletionChoiceFinishReason.Length,
                "stop" => TextCompletionChoiceFinishReason.Stop,
                _ => null,
            };
        }
    }
}