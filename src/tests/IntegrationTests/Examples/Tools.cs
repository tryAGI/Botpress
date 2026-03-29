/*
order: 40
title: AIFunction Tools
slug: tools

Example showing how to use Botpress operations as MEAI AIFunction tools with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace Botpress.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_CreateTools()
    {
        //// Create a Botpress client and wrap operations as AIFunction tools
        using var client = GetAuthenticatedClient();
        var workspaceId = GetWorkspaceId();
        var botId = GetBotId();

        //// Create AIFunction tools for use with any IChatClient
        AIFunction listBots = client.AsListBotsTool(workspaceId);
        AIFunction getBot = client.AsGetBotTool(workspaceId);
        AIFunction listConversations = client.AsListConversationsTool(botId);
        AIFunction listMessages = client.AsListMessagesTool(botId);
        AIFunction getAnalytics = client.AsGetBotAnalyticsTool(workspaceId);

        //// Tools can be added to ChatOptions.Tools for use with any IChatClient
        listBots.Name.Should().Be("ListBotpressBots");
        getBot.Name.Should().Be("GetBotpressBot");
        listConversations.Name.Should().Be("ListBotpressConversations");
        listMessages.Name.Should().Be("ListBotpressMessages");
        getAnalytics.Name.Should().Be("GetBotpressBotAnalytics");
    }
}
