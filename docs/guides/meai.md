# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Botpress SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Botpress bot management, conversation browsing, message listing, and analytics.

## Installation

```bash
dotnet add package Botpress
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListBotsTool(workspaceId)` | `ListBotpressBots` | List all bots in a workspace |
| `AsGetBotTool(workspaceId)` | `GetBotpressBot` | Get details of a specific bot by ID |
| `AsListConversationsTool(botId)` | `ListBotpressConversations` | List conversations for a bot |
| `AsListMessagesTool(botId)` | `ListBotpressMessages` | List messages in a conversation |
| `AsGetBotAnalyticsTool(workspaceId)` | `GetBotpressBotAnalytics` | Get analytics data for a bot |

## Usage

```csharp
using Botpress;
using Microsoft.Extensions.AI;

var botpressClient = new BotpressClient(
    apiKey: Environment.GetEnvironmentVariable("BOTPRESS_PAT")!);

var workspaceId = Environment.GetEnvironmentVariable("BOTPRESS_WORKSPACE_ID")!;
var botId = Environment.GetEnvironmentVariable("BOTPRESS_BOT_ID")!;

var options = new ChatOptions
{
    Tools =
    [
        botpressClient.AsListBotsTool(workspaceId),
        botpressClient.AsGetBotTool(workspaceId),
        botpressClient.AsListConversationsTool(botId),
        botpressClient.AsListMessagesTool(botId),
        botpressClient.AsGetBotAnalyticsTool(workspaceId),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "List all bots in the workspace and show analytics for the first one."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
