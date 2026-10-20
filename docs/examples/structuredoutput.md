# StructuredOutput

Inception StructuredOutput example.

This example assumes `using Inception;` is in scope and `apiKey` contains your Inception API key.

```csharp
using var client = new InceptionClient(apiKey);
var request = new ChatCompletionRequest
{
    Model = "mercury-3",
    Messages = [new Message { Role = MessageRole.User, Content = "Say hello in three words." }],
    ReasoningEffort = ChatCompletionRequestReasoningEffort.Instant,
    Realtime = true, Temperature = 0.75, MaxCompletionTokens = 1024,
};
request.Messages = [new Message { Role = MessageRole.User, Content = "Return the city Dubai as JSON." }];
request.ResponseFormat = new ResponseFormatJSONSchema
{
    JsonSchema = new JSONSchema
    {
        Name = "city_response", Strict = true,
        Schema = Json("""{"type":"object","properties":{"city":{"type":"string"}},"required":["city"],"additionalProperties":false}"""),
    },
};
var response = await client.Chat.CreateChatCompletionAsync(request);
using var result = JsonDocument.Parse(response.Choices[0].Message.Content!.Value.Value1!);
```