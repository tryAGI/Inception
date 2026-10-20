#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct DecisionQuestion : global::System.IEquatable<DecisionQuestion>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionQuestionDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inception.NoulQuestion? Noul { get; init; }
#else
        public global::Inception.NoulQuestion? Noul { get; }
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
            out global::Inception.NoulQuestion? value)
        {
            value = Noul;
            return IsNoul;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inception.NoulQuestion PickNoul() => Noul is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Noul' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inception.ChoiceQuestion? Choice { get; init; }
#else
        public global::Inception.ChoiceQuestion? Choice { get; }
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
            out global::Inception.ChoiceQuestion? value)
        {
            value = Choice;
            return IsChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChoiceQuestion PickChoice() => Choice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Choice' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inception.ScoreQuestion? Score { get; init; }
#else
        public global::Inception.ScoreQuestion? Score { get; }
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
            out global::Inception.ScoreQuestion? value)
        {
            value = Score;
            return IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inception.ScoreQuestion PickScore() => Score is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Score' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionQuestion(global::Inception.NoulQuestion value) => new DecisionQuestion((global::Inception.NoulQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inception.NoulQuestion?(DecisionQuestion @this) => @this.Noul;

        /// <summary>
        ///
        /// </summary>
        public DecisionQuestion(global::Inception.NoulQuestion? value)
        {
            Noul = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionQuestion FromNoul(global::Inception.NoulQuestion? value) => new DecisionQuestion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionQuestion(global::Inception.ChoiceQuestion value) => new DecisionQuestion((global::Inception.ChoiceQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inception.ChoiceQuestion?(DecisionQuestion @this) => @this.Choice;

        /// <summary>
        ///
        /// </summary>
        public DecisionQuestion(global::Inception.ChoiceQuestion? value)
        {
            Choice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionQuestion FromChoice(global::Inception.ChoiceQuestion? value) => new DecisionQuestion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionQuestion(global::Inception.ScoreQuestion value) => new DecisionQuestion((global::Inception.ScoreQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inception.ScoreQuestion?(DecisionQuestion @this) => @this.Score;

        /// <summary>
        ///
        /// </summary>
        public DecisionQuestion(global::Inception.ScoreQuestion? value)
        {
            Score = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionQuestion FromScore(global::Inception.ScoreQuestion? value) => new DecisionQuestion(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionQuestion(
            global::Inception.DecisionQuestionDiscriminatorType? type,
            global::Inception.NoulQuestion? noul,
            global::Inception.ChoiceQuestion? choice,
            global::Inception.ScoreQuestion? score
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
            global::System.Func<global::Inception.NoulQuestion, TResult>? noul = null,
            global::System.Func<global::Inception.ChoiceQuestion, TResult>? choice = null,
            global::System.Func<global::Inception.ScoreQuestion, TResult>? score = null,
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
            global::System.Action<global::Inception.NoulQuestion>? noul = null,

            global::System.Action<global::Inception.ChoiceQuestion>? choice = null,

            global::System.Action<global::Inception.ScoreQuestion>? score = null,
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
            global::System.Action<global::Inception.NoulQuestion>? noul = null,
            global::System.Action<global::Inception.ChoiceQuestion>? choice = null,
            global::System.Action<global::Inception.ScoreQuestion>? score = null,
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
                typeof(global::Inception.NoulQuestion),
                Choice,
                typeof(global::Inception.ChoiceQuestion),
                Score,
                typeof(global::Inception.ScoreQuestion),
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
        public bool Equals(DecisionQuestion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Inception.NoulQuestion?>.Default.Equals(Noul, other.Noul) &&
                global::System.Collections.Generic.EqualityComparer<global::Inception.ChoiceQuestion?>.Default.Equals(Choice, other.Choice) &&
                global::System.Collections.Generic.EqualityComparer<global::Inception.ScoreQuestion?>.Default.Equals(Score, other.Score)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionQuestion obj1, DecisionQuestion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionQuestion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionQuestion obj1, DecisionQuestion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionQuestion o && Equals(o);
        }
    }
}
