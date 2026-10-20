
#nullable enable

namespace Inception
{
    /// <summary>
    /// The reason the model stopped generating tokens.
    /// </summary>
    public enum EditChoiceFinishReason
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
    public static class EditChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditChoiceFinishReason value)
        {
            return value switch
            {
                EditChoiceFinishReason.ContentFilter => "content_filter",
                EditChoiceFinishReason.Length => "length",
                EditChoiceFinishReason.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditChoiceFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => EditChoiceFinishReason.ContentFilter,
                "length" => EditChoiceFinishReason.Length,
                "stop" => EditChoiceFinishReason.Stop,
                _ => null,
            };
        }
    }
}