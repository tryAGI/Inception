/*
order: 10
title: Chat
slug: chat

Inception Chat example.
*/
using System.Text;
using System.Text.Json;

namespace Inception.IntegrationTests;

public partial class Tests
{
    [TestMethod, TestCategory("Live")]
    public async Task Example_Chat()
    {
        using var client = GetAuthenticatedClient();
        //// `instant` and `realtime` reduce the time to first answer text.
        var response = await client.Chat.CreateChatCompletionAsync(new ChatCompletionRequest
        {
            Model = "mercury-3",
            Messages = [new Message { Role = MessageRole.User, Content = "Say hello in three words." }],
            ReasoningEffort = ChatCompletionRequestReasoningEffort.Instant,
            Realtime = true, Temperature = 0.75, MaxCompletionTokens = 1024,
        });
        response.Choices[0].Message.Content?.Value1.Should().NotBeNullOrWhiteSpace();
        response.Usage.TotalTokens.Should().BeGreaterThan(0);
    }
}
