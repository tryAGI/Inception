/*
order: 32
title: Edit
slug: edit

Inception Edit example.
*/
using System.Text;
using System.Text.Json;

namespace Inception.IntegrationTests;

public partial class Tests
{
    [TestMethod, TestCategory("Live")]
    public async Task Example_Edit()
    {
        using var client = GetAuthenticatedClient();
        var response = await client.Edit.CreateEditCompletionAsync(new EditCompletionRequest
        {
            Model = "mercury-edit-2", MaxTokens = 256,
            Messages = [new EditMessageParam
            {
                Content = "<|recently_viewed_code_snippets|>\n\n<|/recently_viewed_code_snippets|>\n<|current_file_content|>\ncurrent_file_path: add.py\n<|code_to_edit|>\ndef add(a, b):\n    return a - b<|cursor|>\n<|/code_to_edit|>\n<|/current_file_content|>\n<|edit_diff_history|>\n# Implement addition rather than subtraction.\n<|/edit_diff_history|>",
            }],
        });
        response.Choices[0].Message.Content?.Value1.Should().NotBeNullOrWhiteSpace();
    }
}
