/*
order: 31
title: FimStreaming
slug: fimstreaming

Inception FimStreaming example.
*/
using System.Text;
using System.Text.Json;

namespace Inception.IntegrationTests;

public partial class Tests
{
    [TestMethod, TestCategory("Live")]
    public async Task Example_FimStreaming()
    {
        using var client = GetAuthenticatedClient();
        var request = new FIMCompletionRequest
        {
            Model = "mercury-edit-2", Prompt = "def add(a, b):\n    return ",
            Suffix = "\n\nprint(add(2, 3))", MaxTokens = 64,
        };
        request.Stream = true;
        var text = new StringBuilder();
        await foreach (var chunk in client.Fim.CreateFimCompletionAsStreamAsync(request))
            foreach (var choice in chunk.Choices) text.Append(choice.Text);
        text.ToString().Should().NotBeNullOrWhiteSpace();
    }
}
