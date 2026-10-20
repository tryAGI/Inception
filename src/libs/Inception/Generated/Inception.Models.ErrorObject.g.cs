
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ErrorObject
    {
        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Error category, e.g. `invalid_request_error`, `rate_limit_error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Offending parameter, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Machine-readable error code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorObject" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="type">
        /// Error category, e.g. `invalid_request_error`, `rate_limit_error`.
        /// </param>
        /// <param name="param">
        /// Offending parameter, if applicable.
        /// </param>
        /// <param name="code">
        /// Machine-readable error code.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorObject(
            string message,
            string type,
            string? param,
            string? code)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Param = param;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorObject" /> class.
        /// </summary>
        public ErrorObject()
        {
        }

    }
}