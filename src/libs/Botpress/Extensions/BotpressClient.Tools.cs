#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Botpress;

/// <summary>
/// Extensions for using BotpressClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class BotpressToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists bots in the workspace.
    /// </summary>
    /// <param name="client">The Botpress client.</param>
    /// <param name="workspaceId">The workspace ID to scope the request to.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListBotsTool(
        this BotpressClient client,
        string workspaceId)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(workspaceId);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                using var request = CreateRequest(
                    client, HttpMethod.Get, "/v1/admin/bots", workspaceId);

                using var response = await client.HttpClient.SendAsync(
                    request, cancellationToken).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync(
                    cancellationToken).ConfigureAwait(false);
            },
            name: "ListBotpressBots",
            description: "Lists all bots in the Botpress workspace. Returns bot IDs, names, creation dates, and deployment status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets details of a specific bot.
    /// </summary>
    /// <param name="client">The Botpress client.</param>
    /// <param name="workspaceId">The workspace ID to scope the request to.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetBotTool(
        this BotpressClient client,
        string workspaceId)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(workspaceId);

        return AIFunctionFactory.Create(
            async (string botId, CancellationToken cancellationToken) =>
            {
                using var request = CreateRequest(
                    client, HttpMethod.Get, $"/v1/admin/bots/{botId}", workspaceId);

                using var response = await client.HttpClient.SendAsync(
                    request, cancellationToken).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync(
                    cancellationToken).ConfigureAwait(false);
            },
            name: "GetBotpressBot",
            description: "Gets details of a specific Botpress bot by its ID. Returns the bot's name, configuration, deployment status, integrations, and metadata.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists conversations for a bot.
    /// </summary>
    /// <param name="client">The Botpress client.</param>
    /// <param name="botId">The bot ID to list conversations for.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListConversationsTool(
        this BotpressClient client,
        string botId)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(botId);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                using var request = CreateRequest(
                    client, HttpMethod.Get, "/v1/chat/conversations", botId: botId);

                using var response = await client.HttpClient.SendAsync(
                    request, cancellationToken).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync(
                    cancellationToken).ConfigureAwait(false);
            },
            name: "ListBotpressConversations",
            description: "Lists conversations for a Botpress bot. Returns conversation IDs, creation dates, tags, and participant information.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists messages in a conversation.
    /// </summary>
    /// <param name="client">The Botpress client.</param>
    /// <param name="botId">The bot ID that owns the conversations.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListMessagesTool(
        this BotpressClient client,
        string botId)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(botId);

        return AIFunctionFactory.Create(
            async (string conversationId, CancellationToken cancellationToken) =>
            {
                using var request = CreateRequest(
                    client, HttpMethod.Get, $"/v1/chat/messages?conversationId={conversationId}", botId: botId);

                using var response = await client.HttpClient.SendAsync(
                    request, cancellationToken).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync(
                    cancellationToken).ConfigureAwait(false);
            },
            name: "ListBotpressMessages",
            description: "Lists messages in a Botpress conversation by conversation ID. Returns message content, sender information, timestamps, and message types.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets bot analytics.
    /// </summary>
    /// <param name="client">The Botpress client.</param>
    /// <param name="workspaceId">The workspace ID to scope the request to.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetBotAnalyticsTool(
        this BotpressClient client,
        string workspaceId)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(workspaceId);

        return AIFunctionFactory.Create(
            async (string botId, CancellationToken cancellationToken) =>
            {
                using var request = CreateRequest(
                    client, HttpMethod.Get, $"/v1/admin/bots/{botId}/analytics", workspaceId);

                using var response = await client.HttpClient.SendAsync(
                    request, cancellationToken).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync(
                    cancellationToken).ConfigureAwait(false);
            },
            name: "GetBotpressBotAnalytics",
            description: "Gets analytics data for a specific Botpress bot. Returns usage metrics, conversation counts, message volumes, and engagement statistics.");
    }

    private static HttpRequestMessage CreateRequest(
        BotpressClient client,
        HttpMethod method,
        string path,
        string? workspaceId = null,
        string? botId = null,
        string? content = null)
    {
        var request = new HttpRequestMessage(method,
            new Uri(path, UriKind.RelativeOrAbsolute));

        // Copy authorization from client
        foreach (var auth in client.Authorizations)
        {
            if (auth.Type is "Http" or "OAuth2")
            {
                request.Headers.Authorization = new AuthenticationHeaderValue(
                    auth.Name, auth.Value);
            }
            else if (auth.Type == "ApiKey" && auth.Location == "Header")
            {
                request.Headers.Add(auth.Name, auth.Value);
            }
        }

        if (workspaceId is not null)
        {
            request.Headers.TryAddWithoutValidation("x-workspace-id", workspaceId);
        }

        if (botId is not null)
        {
            request.Headers.TryAddWithoutValidation("x-bot-id", botId);
        }

        if (content is not null)
        {
            request.Content = new StringContent(
                content, Encoding.UTF8, "application/json");
        }

        return request;
    }
}
