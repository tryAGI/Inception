/*
order: 50
title: Microsoft.Extensions.AI
slug: meai

Use Mercury chat through IChatClient with native low-latency options.
*/
using Meai = Microsoft.Extensions.AI;

namespace Inception.IntegrationTests;

public partial class Tests
{
    [TestMethod, TestCategory("Live")]
    [DataRow(false)]
    [DataRow(true)]
    public async Task Example_Meai(bool streaming)
    {
        using var native = GetAuthenticatedClient();
        Meai.IChatClient client = native;
        var options = new Meai.ChatOptions
        {
            ModelId = "mercury-3", MaxOutputTokens = 1024,
            AdditionalProperties = new() { ["reasoning_effort"] = "instant", ["realtime"] = true },
        };
        if (streaming)
        {
            var text = new System.Text.StringBuilder();
            await foreach (var update in client.GetStreamingResponseAsync([new Meai.ChatMessage(Meai.ChatRole.User, "Say hello in three words.")], options))
                text.Append(update.Text);
            text.ToString().Should().NotBeNullOrWhiteSpace();
        }
        else
        {
            var response = await client.GetResponseAsync([new Meai.ChatMessage(Meai.ChatRole.User, "Say hello in three words.")], options);
            response.Text.Should().NotBeNullOrWhiteSpace();
        }
    }
}
