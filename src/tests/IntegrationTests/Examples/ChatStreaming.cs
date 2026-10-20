/*
order: 11
title: ChatStreaming
slug: chatstreaming

Inception ChatStreaming example.
*/
using System.Text;
using System.Text.Json;

namespace Inception.IntegrationTests;

public partial class Tests
{
    [TestMethod, TestCategory("Live")]
    public async Task Example_ChatStreaming()
    {
        using var client = GetAuthenticatedClient();
        var request = new ChatCompletionRequest
        {
            Model = "mercury-3",
            Messages = [new Message { Role = MessageRole.User, Content = "Say hello in three words." }],
            ReasoningEffort = ChatCompletionRequestReasoningEffort.Instant,
            Realtime = true, Temperature = 0.75, MaxCompletionTokens = 1024,
        };
        request.Stream = true;
        var text = new StringBuilder();
        await foreach (var chunk in client.Chat.CreateChatCompletionAsStreamAsync(request))
            foreach (var choice in chunk.Choices) text.Append(choice.Delta.Content);
        text.ToString().Should().NotBeNullOrWhiteSpace();
    }
}
