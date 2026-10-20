#nullable enable

namespace Inception.JsonConverters
{
    /// <inheritdoc />
    public sealed class DecisionAnswerDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Inception.DecisionAnswerDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::Inception.DecisionAnswerDiscriminatorType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Inception.DecisionAnswerDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Inception.DecisionAnswerDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Inception.DecisionAnswerDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Inception.DecisionAnswerDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Inception.DecisionAnswerDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
