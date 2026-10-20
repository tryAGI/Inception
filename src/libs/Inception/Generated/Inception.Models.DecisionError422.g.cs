#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Inception
{
    /// <summary>
    /// Example: {"detail":[{"loc":["body","questions"],"msg":"Field required","type":"missing"}]}
    /// </summary>
    public readonly partial struct DecisionError422 : global::System.IEquatable<DecisionError422>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inception.HTTPValidationError? HTTPValidationError { get; init; }
#else
        public global::Inception.HTTPValidationError? HTTPValidationError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HTTPValidationError))]
#endif
        public bool IsHTTPValidationError => HTTPValidationError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHTTPValidationError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inception.HTTPValidationError? value)
        {
            value = HTTPValidationError;
            return IsHTTPValidationError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inception.HTTPValidationError PickHTTPValidationError() => HTTPValidationError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HTTPValidationError' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"error":{"code":"upstream_error","type":"invalid_request_error","message":"Decision service could not complete the request."}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Inception.DecisionUpstreamValidationError? DecisionUpstreamValidationError { get; init; }
#else
        public global::Inception.DecisionUpstreamValidationError? DecisionUpstreamValidationError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DecisionUpstreamValidationError))]
#endif
        public bool IsDecisionUpstreamValidationError => DecisionUpstreamValidationError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDecisionUpstreamValidationError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Inception.DecisionUpstreamValidationError? value)
        {
            value = DecisionUpstreamValidationError;
            return IsDecisionUpstreamValidationError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionUpstreamValidationError PickDecisionUpstreamValidationError() => DecisionUpstreamValidationError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DecisionUpstreamValidationError' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionError422(global::Inception.HTTPValidationError value) => new DecisionError422((global::Inception.HTTPValidationError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inception.HTTPValidationError?(DecisionError422 @this) => @this.HTTPValidationError;

        /// <summary>
        ///
        /// </summary>
        public DecisionError422(global::Inception.HTTPValidationError? value)
        {
            HTTPValidationError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionError422 FromHTTPValidationError(global::Inception.HTTPValidationError? value) => new DecisionError422(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DecisionError422(global::Inception.DecisionUpstreamValidationError value) => new DecisionError422((global::Inception.DecisionUpstreamValidationError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Inception.DecisionUpstreamValidationError?(DecisionError422 @this) => @this.DecisionUpstreamValidationError;

        /// <summary>
        ///
        /// </summary>
        public DecisionError422(global::Inception.DecisionUpstreamValidationError? value)
        {
            DecisionUpstreamValidationError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DecisionError422 FromDecisionUpstreamValidationError(global::Inception.DecisionUpstreamValidationError? value) => new DecisionError422(value);

        /// <summary>
        ///
        /// </summary>
        public DecisionError422(
            global::Inception.HTTPValidationError? hTTPValidationError,
            global::Inception.DecisionUpstreamValidationError? decisionUpstreamValidationError
            )
        {
            HTTPValidationError = hTTPValidationError;
            DecisionUpstreamValidationError = decisionUpstreamValidationError;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DecisionUpstreamValidationError as object ??
            HTTPValidationError as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            HTTPValidationError?.ToString() ??
            DecisionUpstreamValidationError?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsHTTPValidationError || IsDecisionUpstreamValidationError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Inception.HTTPValidationError, TResult>? hTTPValidationError = null,
            global::System.Func<global::Inception.DecisionUpstreamValidationError, TResult>? decisionUpstreamValidationError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (HTTPValidationError is { } __value0 && hTTPValidationError != null)
            {
                return hTTPValidationError(__value0);
            }
            else if (DecisionUpstreamValidationError is { } __value1 && decisionUpstreamValidationError != null)
            {
                return decisionUpstreamValidationError(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Inception.HTTPValidationError>? hTTPValidationError = null,

            global::System.Action<global::Inception.DecisionUpstreamValidationError>? decisionUpstreamValidationError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (HTTPValidationError is { } __value0)
            {
                hTTPValidationError?.Invoke(__value0);
            }
            else if (DecisionUpstreamValidationError is { } __value1)
            {
                decisionUpstreamValidationError?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Inception.HTTPValidationError>? hTTPValidationError = null,
            global::System.Action<global::Inception.DecisionUpstreamValidationError>? decisionUpstreamValidationError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (HTTPValidationError is { } __value0)
            {
                hTTPValidationError?.Invoke(__value0);
            }
            else if (DecisionUpstreamValidationError is { } __value1)
            {
                decisionUpstreamValidationError?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                HTTPValidationError,
                typeof(global::Inception.HTTPValidationError),
                DecisionUpstreamValidationError,
                typeof(global::Inception.DecisionUpstreamValidationError),
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
        public bool Equals(DecisionError422 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Inception.HTTPValidationError?>.Default.Equals(HTTPValidationError, other.HTTPValidationError) &&
                global::System.Collections.Generic.EqualityComparer<global::Inception.DecisionUpstreamValidationError?>.Default.Equals(DecisionUpstreamValidationError, other.DecisionUpstreamValidationError)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DecisionError422 obj1, DecisionError422 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DecisionError422>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DecisionError422 obj1, DecisionError422 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DecisionError422 o && Equals(o);
        }
    }
}
