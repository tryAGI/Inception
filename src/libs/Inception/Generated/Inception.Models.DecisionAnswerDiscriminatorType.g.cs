
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionAnswerDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
        /// <summary>
        ///
        /// </summary>
        Noul,
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionAnswerDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionAnswerDiscriminatorType value)
        {
            return value switch
            {
                DecisionAnswerDiscriminatorType.Choice => "choice",
                DecisionAnswerDiscriminatorType.Noul => "noul",
                DecisionAnswerDiscriminatorType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionAnswerDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => DecisionAnswerDiscriminatorType.Choice,
                "noul" => DecisionAnswerDiscriminatorType.Noul,
                "score" => DecisionAnswerDiscriminatorType.Score,
                _ => null,
            };
        }
    }
}