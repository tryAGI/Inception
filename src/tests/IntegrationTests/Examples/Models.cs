/*
order: 40
title: Model catalogs
slug: models

Discover models, context limits, pricing, and capabilities in every catalog.
*/
namespace Inception.IntegrationTests;

public partial class Tests
{
    [TestMethod, TestCategory("Live")]
    [DataRow("all")]
    [DataRow("chat")]
    [DataRow("fim")]
    [DataRow("edit")]
    public async Task Example_ModelCatalogs(string catalog)
    {
        using var client = GetAuthenticatedClient();
        var response = catalog switch
        {
            "chat" => await client.Models.ListChatModelsAsync(),
            "fim" => await client.Models.ListFIMModelsAsync(),
            "edit" => await client.Models.ListEditModelsAsync(),
            _ => await client.Models.ListModelsAsync(),
        };
        response.Data.Should().NotBeEmpty();
        foreach (var model in response.Data)
        {
            model.Id.Should().NotBeNullOrWhiteSpace();
            model.ContextLength.Should().BeGreaterThan(0);
            model.SupportedEndpoints.Should().NotBeEmpty();
        }
        //// Query filtered catalogs too: the general catalog may omit Mercury Edit 2.
    }
}
