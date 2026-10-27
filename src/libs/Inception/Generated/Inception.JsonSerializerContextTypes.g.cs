
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Inception
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChatCompletionRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.Message>? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.Message? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.ChatCompletionTool>? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChatCompletionTool? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.AnyOf<global::Inception.ChatCompletionRequestToolChoice?, global::Inception.NamedToolChoice>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChatCompletionRequestToolChoice? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.NamedToolChoice? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.StreamOptions? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.OneOf<global::Inception.ResponseFormatText, global::Inception.ResponseFormatJSONObject, global::Inception.ResponseFormatJSONSchema>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ResponseFormatText? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ResponseFormatJSONObject? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ResponseFormatJSONSchema? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChatCompletionRequestReasoningEffort? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChatCompletionResponse? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.Choice>? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.Choice? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.Usage? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ReasoningSummary? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChoiceFinishReason? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChoiceAnswer? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChoiceQuestion? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.JsonValue? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.JsonValue>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.CompletionTokensDetails? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DataCenter? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionRequest? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Inception.DecisionQuestion>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionQuestion? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionResponse? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Inception.DecisionAnswer>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionAnswer? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionUsage? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.EditChoice? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.EditMessage? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.EditChoiceFinishReason? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.EditCompletionRequest? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.EditMessageParam>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.EditMessageParam? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.EditCompletionResponse? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.EditChoice>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.EditUsage? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.AnyOf<string, global::System.Collections.Generic.IList<object>>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.PromptTokensDetails? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.FIMCompletionRequest? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.FIMCompletionResponse? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.TextCompletionChoice>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.TextCompletionChoice? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.FIMUsage? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.FunctionCall? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.HTTPValidationError? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.ValidationError>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ValidationError? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ModelObject? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTimeOffset? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.PricingInfo? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.OpenRouterInfo? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.DataCenter>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ModelsResponse? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.ModelObject>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ToolChoiceFunction? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.NoulAnswer? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.NoulCriteria? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.NoulQuestion? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ReasoningSummaryStatus? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ScoreAnswer? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ScoreQuestion? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.AnyOf<string, object, global::System.Collections.Generic.IList<global::Inception.JsonValue>>>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.TextCompletionChoiceFinishReason? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ToolCall? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.AnyOf<string, int?>>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.AnyOf<string, int?>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChatCompletionChunk? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.ChunkChoice>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChunkChoice? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChunkDelta? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ChunkChoiceFinishReason? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.ToolCallDelta>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ToolCallDelta? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.FunctionCallDelta? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.TextChunkChoice? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.TextChunkChoiceFinishReason? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.TextCompletionChunk? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.TextChunkChoice>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.MessageRole? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Inception.ToolCall>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.FunctionDefinition? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.JSONSchema? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ErrorObject? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.ErrorResponse? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionError401? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionError500? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionError402? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionError404? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionError413? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionError429? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionError502? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionError503? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionError504? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionError422? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionUpstreamValidationError? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionQuestionDiscriminator? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionQuestionDiscriminatorType? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionAnswerDiscriminator? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.DecisionAnswerDiscriminatorType? Type113 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.Message>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.ChatCompletionTool>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.Choice>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.AnyOf<string, object, global::System.Collections.Generic.List<global::Inception.JsonValue>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.JsonValue>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.EditMessageParam>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.EditChoice>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Inception.AnyOf<string, global::System.Collections.Generic.List<object>>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.TextCompletionChoice>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.ValidationError>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.DataCenter>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.ModelObject>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.AnyOf<string, object, global::System.Collections.Generic.List<global::Inception.JsonValue>>>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.AnyOf<string, int?>>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.ChunkChoice>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.ToolCallDelta>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.TextChunkChoice>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Inception.ToolCall>? ListType19 { get; set; }
    }
}