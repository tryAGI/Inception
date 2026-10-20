#nullable enable

namespace Inception.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChunkChoiceFinishReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Inception.ChunkChoiceFinishReason?>
    {
        /// <inheritdoc />
        public override global::Inception.ChunkChoiceFinishReason? Read(
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
                        return global::Inception.ChunkChoiceFinishReasonExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Inception.ChunkChoiceFinishReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Inception.ChunkChoiceFinishReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Inception.ChunkChoiceFinishReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Inception.ChunkChoiceFinishReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
