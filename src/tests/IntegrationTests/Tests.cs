namespace Inception.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static InceptionClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("INCEPTION_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : Environment.GetEnvironmentVariable("API_KEY") is { Length: > 0 } sharedKeyValue
                ? sharedKeyValue
                : throw new AssertInconclusiveException("INCEPTION_API_KEY environment variable is not found.");

        var client = new InceptionClient(apiKey);
        
        return client;
    }
}
