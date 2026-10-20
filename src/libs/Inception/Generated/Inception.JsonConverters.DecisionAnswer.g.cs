#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Inception.JsonConverters
{
    /// <inheritdoc />
    public class DecisionAnswerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Inception.DecisionAnswer>
    {
        /// <inheritdoc />
        public override global::Inception.DecisionAnswer Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.DecisionAnswerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.DecisionAnswerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inception.DecisionAnswerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Inception.NoulAnswer? noul = default;
            if (discriminator?.Type == global::Inception.DecisionAnswerDiscriminatorType.Noul)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.NoulAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.NoulAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inception.NoulAnswer)}");
                noul = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inception.ChoiceAnswer? choice = default;
            if (discriminator?.Type == global::Inception.DecisionAnswerDiscriminatorType.Choice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.ChoiceAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.ChoiceAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inception.ChoiceAnswer)}");
                choice = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Inception.ScoreAnswer? score = default;
            if (discriminator?.Type == global::Inception.DecisionAnswerDiscriminatorType.Score)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.ScoreAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.ScoreAnswer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Inception.ScoreAnswer)}");
                score = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Inception.DecisionAnswer(
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
            global::Inception.DecisionAnswer value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNoul)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.NoulAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.NoulAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inception.NoulAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNoul(), typeInfo);
            }
            else if (value.IsChoice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.ChoiceAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.ChoiceAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inception.ChoiceAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickChoice(), typeInfo);
            }
            else if (value.IsScore)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Inception.ScoreAnswer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Inception.ScoreAnswer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Inception.ScoreAnswer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickScore(), typeInfo);
            }
        }
    }
}