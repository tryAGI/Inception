
#nullable enable

namespace Inception
{
    /// <summary>
    /// Status of the summary.<br/>
    /// Default Value: unavailable
    /// </summary>
    public enum ReasoningSummaryStatus
    {
        /// <summary>
        ///
        /// </summary>
        Complete,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningSummaryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningSummaryStatus value)
        {
            return value switch
            {
                ReasoningSummaryStatus.Complete => "complete",
                ReasoningSummaryStatus.Skipped => "skipped",
                ReasoningSummaryStatus.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningSummaryStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => ReasoningSummaryStatus.Complete,
                "skipped" => ReasoningSummaryStatus.Skipped,
                "unavailable" => ReasoningSummaryStatus.Unavailable,
                _ => null,
            };
        }
    }
}