/*
order: 13
title: ToolCalling
slug: toolcalling

Inception ToolCalling example.
*/
using System.Text;
using System.Text.Json;

namespace Inception.IntegrationTests;

public partial class Tests
{
    [TestMethod, TestCategory("Live")]
    public async Task Example_ToolCalling()
    {
        using var client = GetAuthenticatedClient();
        var request = new ChatCompletionRequest
        {
            Model = "mercury-3",
            Messages = [new Message { Role = MessageRole.User, Content = "Say hello in three words." }],
            ReasoningEffort = ChatCompletionRequestReasoningEffort.Instant,
            Realtime = true, Temperature = 0.75, MaxCompletionTokens = 1024,
        };
        request.Messages = [new Message { Role = MessageRole.User, Content = "Get the weather in Dubai." }];
        request.Tools = [WeatherTool()];
        request.ToolChoice = new NamedToolChoice { Function = new ToolChoiceFunction { Name = "get_weather" } };
        var response = await client.Chat.CreateChatCompletionAsync(request);
        response.Choices[0].Message.ToolCalls.Should().ContainSingle();
        var call = response.Choices[0].Message.ToolCalls![0];
        call.Function.Name.Should().Be("get_weather");
        using var arguments = JsonDocument.Parse(call.Function.Arguments);
        arguments.RootElement.GetProperty("city").GetString().Should().Be("Dubai");
    }
}
