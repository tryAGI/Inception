
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionQuestionDiscriminatorType
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
    public static class DecisionQuestionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionQuestionDiscriminatorType value)
        {
            return value switch
            {
                DecisionQuestionDiscriminatorType.Choice => "choice",
                DecisionQuestionDiscriminatorType.Noul => "noul",
                DecisionQuestionDiscriminatorType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionQuestionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => DecisionQuestionDiscriminatorType.Choice,
                "noul" => DecisionQuestionDiscriminatorType.Noul,
                "score" => DecisionQuestionDiscriminatorType.Score,
                _ => null,
            };
        }
    }
}