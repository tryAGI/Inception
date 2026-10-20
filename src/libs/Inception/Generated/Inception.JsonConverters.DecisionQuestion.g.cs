#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Inception.JsonConverters
{
    /// <inheritdoc />
    public class DecisionQuestionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Inception.DecisionQuestion>
    {
        /// <inheritdoc />
        public override global::Inception.DecisionQuestion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.DecisionQuestionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.DecisionQuestionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inception.DecisionQuestionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Inception.NoulQuestion? noul = default;
            if (discriminator?.Type == global::Inception.DecisionQuestionDiscriminatorType.Noul)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.NoulQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.NoulQuestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inception.NoulQuestion)}");
                noul = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inception.ChoiceQuestion? choice = default;
            if (discriminator?.Type == global::Inception.DecisionQuestionDiscriminatorType.Choice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.ChoiceQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.ChoiceQuestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inception.ChoiceQuestion)}");
                choice = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inception.ScoreQuestion? score = default;
            if (discriminator?.Type == global::Inception.DecisionQuestionDiscriminatorType.Score)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.ScoreQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.ScoreQuestion> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inception.ScoreQuestion)}");
                score = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Inception.DecisionQuestion(
                discriminator?.Type,
                noul,

                choice,

                score
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Inception.DecisionQuestion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNoul)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.NoulQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.NoulQuestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inception.NoulQuestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNoul(), typeInfo);
            }
            else if (value.IsChoice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.ChoiceQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.ChoiceQuestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inception.ChoiceQuestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickChoice(), typeInfo);
            }
            else if (value.IsScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.ScoreQuestion), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.ScoreQuestion?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inception.ScoreQuestion).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScore(), typeInfo);
            }
        }
    }
}