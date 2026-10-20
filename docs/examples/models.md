# Model catalogs

Discover models, context limits, pricing, and capabilities in every catalog.

This example assumes `using Inception;` is in scope and `apiKey` contains your Inception API key.

```csharp
using var client = new InceptionClient(apiKey);
var response = catalog switch
{
    "chat" => await client.Models.ListChatModelsAsync(),
    "fim" => await client.Models.ListFIMModelsAsync(),
    "edit" => await client.Models.ListEditModelsAsync(),
    _ => await client.Models.ListModelsAsync(),
};
foreach (var model in response.Data)
{
}
// Query filtered catalogs too: the general catalog may omit Mercury Edit 2.
```