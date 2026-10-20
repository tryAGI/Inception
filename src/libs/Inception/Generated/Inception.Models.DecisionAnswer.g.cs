#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DecisionAnswer : global::System.IEquatable<DecisionAnswer>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionAnswerDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inception.NoulAnswer? Noul { get; init; }
#else
        public global::Inception.NoulAnswer? Noul { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Noul))]
#endif
        public bool IsNoul => Noul != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNoul(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inception.NoulAnswer? value)
        {
            value = Noul;
            return IsNoul;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inception.NoulAnswer PickNoul() => Noul is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Noul' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inception.ChoiceAnswer? Choice { get; init; }
#else
        public global::Inception.ChoiceAnswer? Choice { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Choice))]
#endif
        public bool IsChoice => Choice != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inception.ChoiceAnswer? value)
        {
            value = Choice;
            return IsChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChoiceAnswer PickChoice() => Choice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Choice' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inception.ScoreAnswer? Score { get; init; }
#else
        public global::Inception.ScoreAnswer? Score { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Score))]
#endif
        public bool IsScore => Score != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScore(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inception.ScoreAnswer? value)
        {
            value = Score;
            return IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inception.ScoreAnswer PickScore() => Score is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Score' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionAnswer(global::Inception.NoulAnswer value) => new DecisionAnswer((global::Inception.NoulAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inception.NoulAnswer?(DecisionAnswer @this) => @this.Noul;

        /// <summary>
        ///
        /// </summary>
        public DecisionAnswer(global::Inception.NoulAnswer? value)
        {
            Noul = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionAnswer FromNoul(global::Inception.NoulAnswer? value) => new DecisionAnswer(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionAnswer(global::Inception.ChoiceAnswer value) => new DecisionAnswer((global::Inception.ChoiceAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inception.ChoiceAnswer?(DecisionAnswer @this) => @this.Choice;

        /// <summary>
        ///
        /// </summary>
        public DecisionAnswer(global::Inception.ChoiceAnswer? value)
        {
            Choice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionAnswer FromChoice(global::Inception.ChoiceAnswer? value) => new DecisionAnswer(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionAnswer(global::Inception.ScoreAnswer value) => new DecisionAnswer((global::Inception.ScoreAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inception.ScoreAnswer?(DecisionAnswer @this) => @this.Score;

        /// <summary>
        ///
        /// </summary>
        public DecisionAnswer(global::Inception.ScoreAnswer? value)
        {
            Score = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionAnswer FromScore(global::Inception.ScoreAnswer? value) => new DecisionAnswer(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionAnswer(
            global::Inception.DecisionAnswerDiscriminatorType? type,
            global::Inception.NoulAnswer? noul,
            global::Inception.ChoiceAnswer? choice,
            global::Inception.ScoreAnswer? score
            )
        {
            Type = type;

            Noul = noul;
            Choice = choice;
            Score = score;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Score as object ??
            Choice as object ??
            Noul as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Noul?.ToString() ??
            Choice?.ToString() ??
            Score?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNoul && !IsChoice && !IsScore || !IsNoul && IsChoice && !IsScore || !IsNoul && !IsChoice && IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Inception.NoulAnswer, TResult>? noul = null,
            global::System.Func<global::Inception.ChoiceAnswer, TResult>? choice = null,
            global::System.Func<global::Inception.ScoreAnswer, TResult>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Noul is { } __value0 && noul != null)
            {
                return noul(__value0);
            }
            else if (Choice is { } __value1 && choice != null)
            {
                return choice(__value1);
            }
            else if (Score is { } __value2 && score != null)
            {
                return score(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Inception.NoulAnswer>? noul = null,

            global::System.Action<global::Inception.ChoiceAnswer>? choice = null,

            global::System.Action<global::Inception.ScoreAnswer>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Noul is { } __value0)
            {
                noul?.Invoke(__value0);
            }
            else if (Choice is { } __value1)
            {
                choice?.Invoke(__value1);
            }
            else if (Score is { } __value2)
            {
                score?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Inception.NoulAnswer>? noul = null,
            global::System.Action<global::Inception.ChoiceAnswer>? choice = null,
            global::System.Action<global::Inception.ScoreAnswer>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Noul is { } __value0)
            {
                noul?.Invoke(__value0);
            }
            else if (Choice is { } __value1)
            {
                choice?.Invoke(__value1);
            }
            else if (Score is { } __value2)
            {
                score?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Noul,
                typeof(global::Inception.NoulAnswer),
                Choice,
                typeof(global::Inception.ChoiceAnswer),
                Score,
                typeof(global::Inception.ScoreAnswer),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(DecisionAnswer other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Inception.NoulAnswer?>.Default.Equals(Noul, other.Noul) &&
                global::System.Collections.Generic.EqualityComparer<global::Inception.ChoiceAnswer?>.Default.Equals(Choice, other.Choice) &&
                global::System.Collections.Generic.EqualityComparer<global::Inception.ScoreAnswer?>.Default.Equals(Score, other.Score)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionAnswer obj1, DecisionAnswer obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionAnswer>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionAnswer obj1, DecisionAnswer obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionAnswer o && Equals(o);
        }
    }
}
