# Typed decisions

Classify shared state with binary probability, named choices, and ordinal scores.

This example assumes `using Inception;` is in scope and `apiKey` contains your Inception API key.

```csharp
using var client = new InceptionClient(apiKey);
// Inception uses named dictionaries rather than OpenAI's question arrays.
var response = await client.Decisions.CreateDecisionAsync(new DecisionRequest
{
    Model = "mercury-decide", State = "Please refund the duplicate charge on my account.",
    Questions = new()
    {
        ["billing"] = new NoulQuestion { Instructions = "Is this request about billing?" },
        ["team"] = new ChoiceQuestion
        {
            Criteria = Json("""{"billing":"Payments and refunds","support":"Technical problems"}"""),
        },
        ["urgency"] = new ScoreQuestion
        {
            Instructions = "How urgent is this request?", Criteria = ["Can wait", "Needs attention", "Immediate emergency"],
        },
    },
});
```