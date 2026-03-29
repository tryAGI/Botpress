/*
order: 30
title: Conversations
slug: conversations

Example showing how to work with conversations and messages using the Runtime API.
*/

namespace Botpress.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListConversations()
    {
        //// Create a Botpress client and list conversations for a bot
        using var client = GetAuthenticatedClient();
        var botId = GetBotId();

        //// List all conversations for the bot
        await client.Runtime.RuntimeListConversationsAsync(
            xBotId: botId);
    }

    [TestMethod]
    public async Task Example_ListMessages()
    {
        //// List messages in a conversation
        using var client = GetAuthenticatedClient();
        var botId = GetBotId();
        var conversationId =
            Environment.GetEnvironmentVariable("BOTPRESS_CONVERSATION_ID") is { Length: > 0 } value ? value :
            throw new AssertInconclusiveException("BOTPRESS_CONVERSATION_ID environment variable is not found.");

        //// Retrieve messages from a specific conversation
        await client.Runtime.RuntimeListMessagesAsync(
            xBotId: botId,
            conversationId: conversationId);
    }
}
