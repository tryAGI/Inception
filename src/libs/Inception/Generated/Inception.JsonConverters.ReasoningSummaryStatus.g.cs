#nullable enable

namespace Inception.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReasoningSummaryStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Inception.ReasoningSummaryStatus>
    {
        /// <inheritdoc />
        public override global::Inception.ReasoningSummaryStatus Read(
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
                        return global::Inception.ReasoningSummaryStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Inception.ReasoningSummaryStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Inception.ReasoningSummaryStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Inception.ReasoningSummaryStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Inception.ReasoningSummaryStatusExtensions.ToValueString(value));
        }
    }
}
