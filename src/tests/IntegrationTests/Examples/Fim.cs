/*
order: 30
title: Fim
slug: fim

Inception Fim example.
*/
using System.Text;
using System.Text.Json;

namespace Inception.IntegrationTests;

public partial class Tests
{
    [TestMethod, TestCategory("Live")]
    public async Task Example_Fim()
    {
        using var client = GetAuthenticatedClient();
        var response = await client.Fim.CreateFimCompletionAsync(new FIMCompletionRequest
        {
            Model = "mercury-edit-2", Prompt = "def add(a, b):\n    return ",
            Suffix = "\n\nprint(add(2, 3))", MaxTokens = 64,
        });
        response.Choices[0].Text.Should().NotBeNullOrWhiteSpace();
        response.Usage.TotalTokens.Should().BeGreaterThan(0);
    }
}
