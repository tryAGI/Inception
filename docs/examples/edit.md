# Edit

Inception Edit example.

This example assumes `using Inception;` is in scope and `apiKey` contains your Inception API key.

```csharp
using var client = new InceptionClient(apiKey);
var response = await client.Edit.CreateEditCompletionAsync(new EditCompletionRequest
{
    Model = "mercury-edit-2", MaxTokens = 256,
    Messages = [new EditMessageParam
    {
        Content = "<|recently_viewed_code_snippets|>\n\n<|/recently_viewed_code_snippets|>\n<|current_file_content|>\ncurrent_file_path: add.py\n<|code_to_edit|>\ndef add(a, b):\n    return a - b<|cursor|>\n<|/code_to_edit|>\n<|/current_file_content|>\n<|edit_diff_history|>\n# Implement addition rather than subtraction.\n<|/edit_diff_history|>",
    }],
});
```