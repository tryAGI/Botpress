namespace Botpress.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static BotpressClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("BOTPRESS_API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            Environment.GetEnvironmentVariable("BOTPRESS_PAT") is { Length: > 0 } patValue ? patValue :
            throw new AssertInconclusiveException("BOTPRESS_API_KEY or BOTPRESS_PAT environment variable is not found.");

        var client = new BotpressClient(apiKey);

        return client;
    }

    private static string GetWorkspaceId()
    {
        return
            Environment.GetEnvironmentVariable("BOTPRESS_WORKSPACE_ID") is { Length: > 0 } value ? value :
            throw new AssertInconclusiveException("BOTPRESS_WORKSPACE_ID environment variable is not found.");
    }

    private static string GetBotId()
    {
        return
            Environment.GetEnvironmentVariable("BOTPRESS_BOT_ID") is { Length: > 0 } value ? value :
            throw new AssertInconclusiveException("BOTPRESS_BOT_ID environment variable is not found.");
    }
}
