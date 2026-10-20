/*
order: 20
title: Typed decisions
slug: decisions

Classify shared state with binary probability, named choices, and ordinal scores.
*/
namespace Inception.IntegrationTests;

public partial class Tests
{
    [TestMethod, TestCategory("Live")]
    public async Task Example_Decisions()
    {
        using var client = GetAuthenticatedClient();
        //// Inception uses named dictionaries rather than OpenAI's question arrays.
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
        response.Answers["billing"].IsNoul.Should().BeTrue();
        response.Answers["billing"].Noul!.Noul.Should().BeInRange(0, 1);
        response.Answers["team"].IsChoice.Should().BeTrue();
        response.Answers["team"].Choice!.Choice.Should().BeOneOf("billing", "support");
        response.Answers["urgency"].IsScore.Should().BeTrue();
        response.Usage.InputTokens.Should().BeGreaterThan(0);
    }
}
