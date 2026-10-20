
#nullable enable

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    #pragma warning disable CS3016 // Converter type array in this attribute is not CLS-compliant.
    #pragma warning disable CS0618 // Converter references a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Inception.JsonConverters.ChatCompletionRequestToolChoiceJsonConverter),

            typeof(global::Inception.JsonConverters.ChatCompletionRequestToolChoiceNullableJsonConverter),

            typeof(global::Inception.JsonConverters.ChatCompletionRequestReasoningEffortJsonConverter),

            typeof(global::Inception.JsonConverters.ChatCompletionRequestReasoningEffortNullableJsonConverter),

            typeof(global::Inception.JsonConverters.ChoiceFinishReasonJsonConverter),

            typeof(global::Inception.JsonConverters.ChoiceFinishReasonNullableJsonConverter),

            typeof(global::Inception.JsonConverters.EditChoiceFinishReasonJsonConverter),

            typeof(global::Inception.JsonConverters.EditChoiceFinishReasonNullableJsonConverter),

            typeof(global::Inception.JsonConverters.ReasoningSummaryStatusJsonConverter),

            typeof(global::Inception.JsonConverters.ReasoningSummaryStatusNullableJsonConverter),

            typeof(global::Inception.JsonConverters.TextCompletionChoiceFinishReasonJsonConverter),

            typeof(global::Inception.JsonConverters.TextCompletionChoiceFinishReasonNullableJsonConverter),

            typeof(global::Inception.JsonConverters.ChunkChoiceFinishReasonJsonConverter),

            typeof(global::Inception.JsonConverters.ChunkChoiceFinishReasonNullableJsonConverter),

            typeof(global::Inception.JsonConverters.TextChunkChoiceFinishReasonJsonConverter),

            typeof(global::Inception.JsonConverters.TextChunkChoiceFinishReasonNullableJsonConverter),

            typeof(global::Inception.JsonConverters.MessageRoleJsonConverter),

            typeof(global::Inception.JsonConverters.MessageRoleNullableJsonConverter),

            typeof(global::Inception.JsonConverters.DecisionQuestionDiscriminatorTypeJsonConverter),

            typeof(global::Inception.JsonConverters.DecisionQuestionDiscriminatorTypeNullableJsonConverter),

            typeof(global::Inception.JsonConverters.DecisionAnswerDiscriminatorTypeJsonConverter),

            typeof(global::Inception.JsonConverters.DecisionAnswerDiscriminatorTypeNullableJsonConverter),

            typeof(global::Inception.JsonConverters.DecisionError422JsonConverter),

            typeof(global::Inception.JsonConverters.DecisionQuestionJsonConverter),

            typeof(global::Inception.JsonConverters.DecisionAnswerJsonConverter),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<global::Inception.ChatCompletionRequestToolChoice?, global::Inception.NamedToolChoice>),

            typeof(global::Inception.JsonConverters.OneOfJsonConverter<global::Inception.ResponseFormatText, global::Inception.ResponseFormatJSONObject, global::Inception.ResponseFormatJSONSchema>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<object>>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<object>>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Inception.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<object>>),

            typeof(global::Inception.JsonConverters.UnixTimestampJsonConverter),
        })]
    #pragma warning restore CS0618
    #pragma warning restore CS3016
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ChatCompletionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.AnyOf<global::Inception.ChatCompletionRequestToolChoice?, global::Inception.NamedToolChoice>), TypeInfoPropertyName = "AnyOfChatCompletionRequestToolChoiceNamedToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ChatCompletionRequestToolChoice), TypeInfoPropertyName = "ChatCompletionRequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.NamedToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.StreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.OneOf<global::Inception.ResponseFormatText, global::Inception.ResponseFormatJSONObject, global::Inception.ResponseFormatJSONSchema>), TypeInfoPropertyName = "OneOfResponseFormatTextResponseFormatJSONObjectResponseFormatJSONSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ResponseFormatText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ResponseFormatJSONObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ResponseFormatJSONSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ChatCompletionRequestReasoningEffort), TypeInfoPropertyName = "ChatCompletionRequestReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.Choice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ReasoningSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ChoiceFinishReason), TypeInfoPropertyName = "ChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ChoiceAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ChoiceQuestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>), TypeInfoPropertyName = "AnyOfStringObjectIListJsonValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.JsonValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.JsonValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.CompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DataCenter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Inception.DecisionQuestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionQuestion), TypeInfoPropertyName = "DecisionQuestion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Inception.DecisionAnswer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionAnswer), TypeInfoPropertyName = "DecisionAnswer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.EditChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.EditMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.EditChoiceFinishReason), TypeInfoPropertyName = "EditChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.EditCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.EditMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.EditMessageParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.EditCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.EditChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.EditUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.AnyOf<string, global::System.Collections.Generic.IList<object>>), TypeInfoPropertyName = "AnyOfStringIListObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.PromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.FIMCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.FIMCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.TextCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.TextCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.FIMUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ModelObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.PricingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.OpenRouterInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.DataCenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.ModelObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.NoulAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.NoulCriteria))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.NoulQuestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ReasoningSummaryStatus), TypeInfoPropertyName = "ReasoningSummaryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ScoreAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ScoreQuestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.TextCompletionChoiceFinishReason), TypeInfoPropertyName = "TextCompletionChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ToolCall))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.AnyOf<string, int?>>))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ChatCompletionChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.ChunkChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ChunkChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ChunkDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ChunkChoiceFinishReason), TypeInfoPropertyName = "ChunkChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.ToolCallDelta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ToolCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.FunctionCallDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.TextChunkChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.TextChunkChoiceFinishReason), TypeInfoPropertyName = "TextChunkChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.TextCompletionChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.TextChunkChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.MessageRole), TypeInfoPropertyName = "MessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Inception.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.FunctionDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.JSONSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ErrorObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionError401))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionError500))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionError402))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionError404))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionError413))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionError429))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionError502))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionError503))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionError504))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionError422), TypeInfoPropertyName = "DecisionError4222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionUpstreamValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionQuestionDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionQuestionDiscriminatorType), TypeInfoPropertyName = "DecisionQuestionDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionAnswerDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.DecisionAnswerDiscriminatorType), TypeInfoPropertyName = "DecisionAnswerDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.ChatCompletionTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.Choice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.AnyOf<string, object, global::System.Collections.Generic.List<global::Inception.JsonValue>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.JsonValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.EditMessageParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.EditChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Inception.AnyOf<string, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.TextCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.DataCenter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.ModelObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.AnyOf<string, object, global::System.Collections.Generic.List<global::Inception.JsonValue>>>))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.AnyOf<string, int?>>))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.ChunkChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.ToolCallDelta>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.TextChunkChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Inception.ToolCall>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}